using System;
using System.IO;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

public static void Run(CloudBlockBlob myBlob, TraceWriter log)
{
    CopyBlob(myBlob, log);
}

private static void CopyBlob(CloudBlockBlob myBlob, TraceWriter log)
{
    var connectionString = $"<connectionString>";
    CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);

    // Create the destination blob client
    CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
    CloudBlobContainer container = blobClient.GetContainerReference("backup");
    // Create the container if it doesn't already exist.
    try
    {
        container.CreateIfNotExists();
    }
    catch(Exception e)
    {
        log.Error(e.Message);
    }

    // Get hold of the destination blob
    CloudBlockBlob destinationBlob = container.GetBlockBlobReference(myBlob.Name);
    log.Info($"BlockBlob destination name: {destinationBlob.Name}");

    log.Info("Starting Copy");
    try{
        destinationBlob.StartCopy(myBlob);

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
