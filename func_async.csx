#r "Microsoft.WindowsAzure.Storage"

using System;
using System.IO;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

public async static void Run(CloudBlockBlob myBlob, TraceWriter log)
{
    await CopyBlob(myBlob, log);
}

private async static Task CopyBlob(CloudBlockBlob myBlob, TraceWriter log)
{
    var connectionString = $"<connectionString>";
    CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);

    // Create the destination blob client
    CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
    CloudBlobContainer container = blobClient.GetContainerReference("backup");

    // Create the container if it doesn't already exist.
    try
    {
        await container.CreateIfNotExistsAsync();
    }
    catch(Exception e)
    {
        log.Error(e.Message);
    }

    //Get SAS token
    SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();
    sasConstraints.SharedAccessStartTime = DateTimeOffset.UtcNow.AddHours(-24);
    sasConstraints.SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24);
    sasConstraints.Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.List;

    //Generate the shared access signature on the blob, setting the constraints directly on the signature.
    string sasBlobToken = myBlob.GetSharedAccessSignature(sasConstraints);

    log.Info(myBlob.Uri + sasBlobToken);

    // Get hold of the destination blob
    CloudBlockBlob destinationBlob = container.GetBlockBlobReference(myBlob.Name);
    log.Info($"BlockBlob destination name: {destinationBlob.Name}");

    log.Info("Starting Copy");
    try{
        await destinationBlob.StartCopyAsync(new System.Uri(myBlob.Uri + sasBlobToken));

        while (destinationBlob.CopyState.Status == CopyStatus.Pending)
        {
            System.Threading.Thread.Sleep(500);
            destinationBlob.FetchAttributes();
        }

        if (destinationBlob.CopyState.Status != CopyStatus.Success)
        {
            throw new Exception("Copy failed: " + destinationBlob.CopyState.Status);
        }

        // this tunnels the data via your program,
        // so it reuploads the blob instead of copying it on service side
        /*
        using (var stream = await myBlob.OpenReadAsync())
        {
          await destinationBlob.UploadFromStreamAsync(stream);
        }*/

        log.Info("Copy completed");
    }
    catch(Exception ex){
        log.Error(ex.Message);
        log.Info("Copy failed");
    }
    finally{
        log.Info("Operation completed");
    }
}
