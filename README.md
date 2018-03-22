# Blob Storage Backup using Function Apps

Demo project and benchmark of different approaches to backup blobs to another Blob Storage based on Function Apps trigger.

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


\* Time between first file upload to origin container and last file backup to target container.
