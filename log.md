# Benchmark

## 1 GB File & Async

### Run1

```
2018-03-22 09:21:25.744 INFO - blobxfer start time: 2018-03-22 09:21:25.744518+00:00
2018-03-22 09:21:25.744 DEBUG - spawning 4 disk threads
2018-03-22 09:21:25.761 DEBUG - spawning 8 transfer threads
2018-03-22 09:21:26.311 DEBUG - 0 files 0.0000 MiB filesize and/or lmt_ge skipped
2018-03-22 09:21:26.311 DEBUG - 1 local/remote files processed, waiting for upload completion of approx. 1024.0000 MiB
2018-03-22 09:21:45.440 INFO - elapsed upload + verify time and throughput of 1.0000 GiB: 19.129 sec, 428.2516 Mbps (53.531 MiB/s)
2018-03-22 09:21:45.440 INFO - blobxfer end time: 2018-03-22 09:21:45.440592+00:00 (elapsed: 19.696 sec)
```

```
2018-03-22T09:21:55.123 [Info] Function started (Id=f1fe8b41-e29e-43e8-99cd-bcd4867d5806)
2018-03-22T09:21:55.717 [Info] Function completed (Success, Id=f1fe8b41-e29e-43e8-99cd-bcd4867d5806, Duration=596ms)
2018-03-22T09:21:55.748 [Info] Starting Copy
2018-03-22T09:24:35.159 [Info] Copy completed
2018-03-22T09:24:35.159 [Info] Elapsed time: 159475 ms
```

### Run2


2018-03-22 10:06:46.591 INFO - blobxfer start time: 2018-03-22 10:06:46.591064+00:00
2018-03-22 10:06:46.591 DEBUG - spawning 4 disk threads
2018-03-22 10:06:46.604 DEBUG - spawning 8 transfer threads
2018-03-22 10:06:47.164 DEBUG - 0 files 0.0000 MiB filesize and/or lmt_ge skipped
2018-03-22 10:06:47.165 DEBUG - 1 local/remote files processed, waiting for upload completion of approx. 1024.0000 MiB
2018-03-22 10:07:06.041 INFO - elapsed upload + verify time and throughput of 1.0000 GiB: 18.877 sec, 433.9782 Mbps (54.247 MiB/s)
2018-03-22 10:07:06.041 INFO - blobxfer end time: 2018-03-22 10:07:06.041515+00:00 (elapsed: 19.450 sec)



2018-03-22T10:07:14.864 [Info] Function started (Id=dceffcbc-dadc-4bb8-bb48-ae5011b76675)
2018-03-22T10:07:15.427 [Info] Function completed (Success, Id=dceffcbc-dadc-4bb8-bb48-ae5011b76675, Duration=565ms)
2018-03-22T10:07:15.459 [Info] Starting Copy
2018-03-22T10:09:24.112 [Info] Copy completed
2018-03-22T10:09:24.112 [Info] Elapsed time: 128737 ms


### Run3


2018-03-22 10:11:49.826 INFO - blobxfer start time: 2018-03-22 10:11:49.825934+00:00
2018-03-22 10:11:49.826 DEBUG - spawning 4 disk threads
2018-03-22 10:11:49.837 DEBUG - spawning 8 transfer threads
2018-03-22 10:11:50.375 DEBUG - 0 files 0.0000 MiB filesize and/or lmt_ge skipped
2018-03-22 10:11:50.375 DEBUG - 1 local/remote files processed, waiting for upload completion of approx. 1024.0000 MiB
2018-03-22 10:12:06.882 INFO - elapsed upload + verify time and throughput of 1.0000 GiB: 16.507 sec, 496.2614 Mbps (62.033 MiB/s)
2018-03-22 10:12:06.883 INFO - blobxfer end time: 2018-03-22 10:12:06.883021+00:00 (elapsed: 17.057 sec)



2018-03-22T10:12:15.989 [Info] Function started (Id=aa7a5947-cc63-4974-a54f-849b48f7ac72)
2018-03-22T10:12:16.005 [Info] Function completed (Success, Id=aa7a5947-cc63-4974-a54f-849b48f7ac72, Duration=12ms)
2018-03-22T10:12:16.036 [Info] Starting Copy
2018-03-22T10:14:23.311 [Info] Copy completed
2018-03-22T10:14:23.311 [Info] Elapsed time: 127305


### Run4


2018-03-22 10:32:27.746 INFO - blobxfer start time: 2018-03-22 10:32:27.746778+00:00
2018-03-22 10:32:27.747 DEBUG - spawning 4 disk threads
2018-03-22 10:32:27.794 DEBUG - spawning 8 transfer threads
2018-03-22 10:32:28.328 DEBUG - 0 files 0.0000 MiB filesize and/or lmt_ge skipped
2018-03-22 10:32:28.328 DEBUG - 1 local/remote files processed, waiting for upload completion of approx. 1024.0000 MiB
2018-03-22 10:32:45.613 INFO - elapsed upload + verify time and throughput of 1.0000 GiB: 17.285 sec, 473.9253 Mbps (59.241 MiB/s)
2018-03-22 10:32:45.614 INFO - blobxfer end time: 2018-03-22 10:32:45.613974+00:00 (elapsed: 17.867 sec)



2018-03-22T10:32:49.624 [Info] Function started (Id=b4de81fc-9a82-470c-a562-d80683608508)
2018-03-22T10:32:49.643 [Info] Function completed (Success, Id=b4de81fc-9a82-470c-a562-d80683608508, Duration=10ms)
2018-03-22T10:32:49.671 [Info] Starting Copy
2018-03-22T10:34:54.339 [Info] Copy completed
2018-03-22T10:34:54.339 [Info] Elapsed time: 124703


## 1 GB File & Sync

### Run1


2018-03-22 10:45:07.410 INFO - blobxfer start time: 2018-03-22 10:45:07.410651+00:00
2018-03-22 10:45:07.410 DEBUG - spawning 4 disk threads
2018-03-22 10:45:07.454 DEBUG - spawning 8 transfer threads
2018-03-22 10:45:07.990 DEBUG - 0 files 0.0000 MiB filesize and/or lmt_ge skipped
2018-03-22 10:45:07.991 DEBUG - 1 local/remote files processed, waiting for upload completion of approx. 1024.0000 MiB
2018-03-22 10:45:28.325 INFO - elapsed upload + verify time and throughput of 1.0000 GiB: 20.334 sec, 402.8653 Mbps (50.358 MiB/s)
2018-03-22 10:45:28.325 INFO - blobxfer end time: 2018-03-22 10:45:28.325382+00:00 (elapsed: 20.915 sec)



Copy completed at 2018-03-22 10:46:59


### Run2


2018-03-22 10:50:06.498 INFO - blobxfer start time: 2018-03-22 10:50:06.498422+00:00
2018-03-22 10:50:06.498 DEBUG - spawning 4 disk threads
2018-03-22 10:50:06.513 DEBUG - spawning 8 transfer threads
2018-03-22 10:50:07.063 DEBUG - 0 files 0.0000 MiB filesize and/or lmt_ge skipped
2018-03-22 10:50:07.063 DEBUG - 1 local/remote files processed, waiting for upload completion of approx. 1024.0000 MiB
2018-03-22 10:50:26.627 INFO - elapsed upload + verify time and throughput of 1.0000 GiB: 19.564 sec, 418.7268 Mbps (52.341 MiB/s)
2018-03-22 10:50:26.627 INFO - blobxfer end time: 2018-03-22 10:50:26.627727+00:00 (elapsed: 20.129 sec)



Copy completed at 2018-03-22 10:52:40


### Run3


2018-03-22 10:53:37.165 INFO - blobxfer start time: 2018-03-22 10:53:37.164918+00:00
2018-03-22 10:53:37.165 DEBUG - spawning 4 disk threads
2018-03-22 10:53:37.186 DEBUG - spawning 8 transfer threads
2018-03-22 10:53:37.730 DEBUG - 0 files 0.0000 MiB filesize and/or lmt_ge skipped
2018-03-22 10:53:37.730 DEBUG - 1 local/remote files processed, waiting for upload completion of approx. 1024.0000 MiB
2018-03-22 10:53:55.221 INFO - elapsed upload + verify time and throughput of 1.0000 GiB: 17.490 sec, 468.3791 Mbps (58.547 MiB/s)
2018-03-22 10:53:55.221 INFO - blobxfer end time: 2018-03-22 10:53:55.221145+00:00 (elapsed: 18.056 sec)



Copy completed at 2018-03-22 10:55:55


## 1000 Files of size 20 MB & Async

### Run1


2018-03-22 12:37:41.696 INFO - blobxfer start time: 2018-03-22 12:37:41.696729+00:00
2018-03-22 12:37:41.697 DEBUG - spawning 4 disk threads
2018-03-22 12:37:41.713 DEBUG - spawning 8 transfer threads
2018-03-22 12:39:53.284 DEBUG - 0 files 0.0000 MiB filesize and/or lmt_ge skipped
2018-03-22 12:39:53.284 DEBUG - 1001 local/remote files processed, waiting for upload completion of approx. 20000.0002 MiB
2018-03-22 12:54:56.927 INFO - elapsed upload + verify time and throughput of 19.5313 GiB: 1034.484 sec, 154.6665 Mbps (19.333 MiB/s)
2018-03-22 12:54:56.927 INFO - blobxfer end time: 2018-03-22 12:54:56.927733+00:00 (elapsed: 1035.231 sec)



Finished at 2018-03-22 13:02:28.692


### Run2


2018-03-22 13:12:38.327 INFO - blobxfer start time: 2018-03-22 13:12:38.326888+00:00
2018-03-22 13:12:38.327 DEBUG - spawning 4 disk threads
2018-03-22 13:12:38.341 DEBUG - spawning 8 transfer threads
2018-03-22 13:14:53.430 DEBUG - 0 files 0.0000 MiB filesize and/or lmt_ge skipped
2018-03-22 13:14:53.430 DEBUG - 1001 local/remote files processed, waiting for upload completion of approx. 20000.0002 MiB
2018-03-22 13:30:54.258 INFO - elapsed upload + verify time and throughput of 19.5313 GiB: 1095.372 sec, 146.0690 Mbps (18.259 MiB/s)
2018-03-22 13:30:54.259 INFO - blobxfer end time: 2018-03-22 13:30:54.259149+00:00 (elapsed: 1095.932 sec)



2018-03-22T13:14:50.258 [Info] Function started (Id=db590cad-12ec-47b6-8d64-13afe664d504)
2018-03-22T13:14:51.155 [Info] Function completed (Success, Id=db590cad-12ec-47b6-8d64-13afe664d504, Duration=899ms)
2018-03-22T13:14:51.185 [Info] Starting Copy



Finished at 2018-03-22 13:37:30


### Run3


2018-03-22 15:00:07.289 INFO - blobxfer start time: 2018-03-22 15:00:07.289239+00:00
2018-03-22 15:00:07.289 DEBUG - spawning 4 disk threads
2018-03-22 15:00:07.311 DEBUG - spawning 8 transfer threads
2018-03-22 15:02:20.786 DEBUG - 0 files 0.0000 MiB filesize and/or lmt_ge skipped
2018-03-22 15:02:20.786 DEBUG - 1000 local/remote files processed, waiting for upload completion of approx. 20000.0000 MiB
2018-03-22 15:18:25.100 INFO - elapsed upload + verify time and throughput of 19.5312 GiB: 1097.245 sec, 145.8198 Mbps (18.227 MiB/s)
2018-03-22 15:18:25.100 INFO - blobxfer end time: 2018-03-22 15:18:25.100752+00:00 (elapsed: 1097.812 sec)



First File in Backup: 15:02:26



Finished at 2018-03-22 15:26:14


## 1000 Files of size 20 MB & Sync

### Run1


2018-03-22 13:52:05.645 INFO - blobxfer start time: 2018-03-22 13:52:05.645161+00:00
2018-03-22 13:52:05.645 DEBUG - spawning 4 disk threads
2018-03-22 13:52:05.664 DEBUG - spawning 8 transfer threads
2018-03-22 13:54:18.177 DEBUG - 0 files 0.0000 MiB filesize and/or lmt_ge skipped
2018-03-22 13:54:18.177 DEBUG - 1000 local/remote files processed, waiting for upload completion of approx. 20000.0000 MiB
2018-03-22 14:10:19.375 INFO - elapsed upload + verify time and throughput of 19.5312 GiB: 1093.171 sec, 146.3632 Mbps (18.295 MiB/s)
2018-03-22 14:10:19.376 INFO - blobxfer end time: 2018-03-22 14:10:19.376239+00:00 (elapsed: 1093.731 sec)



2018-03-22T13:54:15.218 [Info] Function started (Id=002e4b45-4f87-48eb-8404-b3389379f51c)
2018-03-22T13:54:16.086 [Info] Starting Copy



First File in Backup: 13:54:20



Finished at: 2018-03-22 14:17:12


### Run2


2018-03-22 14:28:41.550 INFO - blobxfer start time: 2018-03-22 14:28:41.549994+00:00
2018-03-22 14:28:41.550 DEBUG - spawning 4 disk threads
2018-03-22 14:28:41.562 DEBUG - spawning 8 transfer threads
2018-03-22 14:30:53.816 DEBUG - 0 files 0.0000 MiB filesize and/or lmt_ge skipped
2018-03-22 14:30:53.816 DEBUG - 1000 local/remote files processed, waiting for upload completion of approx. 20000.0000 MiB
2018-03-22 14:46:55.042 INFO - elapsed upload + verify time and throughput of 19.5312 GiB: 1092.900 sec, 146.3994 Mbps (18.300 MiB/s)
2018-03-22 14:46:55.042 INFO - blobxfer end time: 2018-03-22 14:46:55.042535+00:00 (elapsed: 1093.493 sec)



First File in Backup: 14:31:21



Finished at: 2018-03-22 14:51:30


