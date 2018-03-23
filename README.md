# Blob Storage Backup using Azure Functions

Demo project and benchmark of different approaches to backup blobs to another [Blob Storage](https://azure.microsoft.com/en-us/services/storage/blobs/) based on [Azure Function App](https://docs.microsoft.com/en-us/azure/azure-functions/) trigger.

## Description

When new object is added to initial container Function App triggers function which copies the object to container in another storage account.

There are two approches [Asynchronous approach](func_async.csx) and [Synchronous approach](func.csx)

How it works:
* Funtion app monitors container in the 1st storage account for new objects
* When new object is added to container in the 1st storage account Function app code is triggered
* Object is copied to target container in 2nd storage account

## Benchmark

Please see the [log](log.md) for detailed results.

### 1 GB File & [Async](func_async.csx)

| Run number     | Time          |
| -------------  |:-------------:|
| 1              | 00:02:50      |
| 2              | 00:02:18      |
| 3              | 00:02:17      |
| 4              | 00:02:09      |

### 1 GB File & [Sync](func.csx)

| Run number     | Time          |
| -------------  |:-------------:|
| 1              | 00:01:31      |
| 2              | 00:02:14      |
| 3              | 00:02:00      |
| 4              | 00:02:22      |


### 1000 Files of size 20 MB & [Async](func_async.csx)


| Run number     | Time \*       |
| -------------  |:-------------:|
| 1              | 00:22:35      |
| 2              | 00:22:37      |
| 3              | 00:23:48      |


### 1000 Files of size 20 MB & [Sync](func.csx)


| Run number     | Time \*       |
| -------------  |:-------------:|
| 1              | 00:22:52      |
| 2              | 00:20:09      |


\* Time between first file copied to target backup container and last file copied to target container.
