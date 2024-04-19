# .NET GC Report Comparative Report - 04/19/2024 22:10:44

## Overall Stats

**Current total**: 154
**New**: 13
**Closed**: 1
**Moved In**: 0
**Moved Out** 1

## New Issues

| **Issue Number** | **Title** | **Last Updated Time (UTC)** | **Milestone** |
| :--------------: | --------- | --------------------- | ------------- |
| [dotnet/runtime#100149](100149) | Failure in GC\API\NoGCRegion\Callback_Svr\Callback_Svr.cmd | 04/19/2024 22:02:47 | 9.0.0 |
| [dotnet/runtime#100035](100035) | Assert failure(PID 13812 [0x000035f4], Thread: 14128 [0x3730]): promoted_bytes (heap_number) == promoted | 04/19/2024 22:02:43 | N/A |
| [dotnet/runtime#101080](101080) | Support loading standalone GC from an absolute path using a new config named `DOTNET_GCPath` | 04/19/2024 18:01:38 | N/A |
| [dotnet/runtime#100382](100382) | Test failure: GC/LargeMemory/Regressions/largearraytest/largearraytest.sh | 04/19/2024 01:28:05 | N/A |
| [dotnet/runtime#101183](101183) | Behaviour of GC HeapHardLimit | 04/17/2024 23:00:21 | N/A |
| [dotnet/runtime#101013](101013) | Linux huge memory consumption in .NET 8 | 04/14/2024 18:58:42 | N/A |
| [dotnet/runtime#101006](101006) | DATAS is slower than Workstation GC on binary tree benchmarks | 04/13/2024 13:50:50 | N/A |
| [dotnet/runtime#100804](100804) | DOTNET_GCHeapHardLimitPercent being ignored without warnings | 04/09/2024 13:09:00 | N/A |
| [dotnet/runtime#100594](100594) | GC sometimes reports survival rates above 100% | 04/05/2024 23:12:53 | 9.0.0 |
| [dotnet/runtime#100521](100521) | Running multiple .net core containers on a single node | 04/05/2024 14:42:32 | N/A |
| [dotnet/runtime#100567](100567) | Test failure: GC/Features/SustainedLowLatency/scenario/scenario.sh | 04/03/2024 03:25:19 | N/A |
| [dotnet/runtime#100217](100217) | Test failure: baseservices/RuntimeConfiguration/TestConfigTester/TestConfigTester.dll | 03/26/2024 21:01:00 | N/A |
| [dotnet/runtime#99804](99804) | High memory usages on "AMD EPYC 7R13 Processor" | 03/15/2024 10:56:53 | N/A |

## Closed Issues

| **Issue Number** | **Title** | **Last Updated Time (UTC)** | **Milestone** |
| :--------------: | --------- | --------------------- | ------------- |
| [dotnet/runtime#8666](8666) | NoGC region improvements | 04/14/2024 09:58:54 | No MilestoneTitle Specified |

## Moved In Issues

| **Issue Number** | **Title** | **Last Updated Time (UTC)** | **Milestone** |
| :--------------: | --------- | --------------------- | ------------- |

## Removed Issues

| **Issue Number** | **Title** | **Last Updated Time (UTC)** | **Milestone** |
| :--------------: | --------- | --------------------- | ------------- |
| [dotnet/runtime#99487](99487) | CLR_GCHEAPCOLLECT_KEYWORD triggers a GC twice | 03/19/2024 20:48:22 | 9.0.0 |

## Issues Out of Time SLA (12 months)

| **Issue Number** | **Title** | **Last Updated Time (UTC)** | **Milestone** |
| :--------------: | --------- | --------------------- | ------------- |
| [dotnet/runtime#84393](84393) | [6.0, 7.0] Assert failed in coreclr linux arm: GCHeapUtilities::GetGCHeap()->IsInFrozenSegment(obj) | 04/19/2024 22:00:31 | 6.0.x |
| [dotnet/runtime#81383](81383) | [6.0] GC test failures: Handle collector count overflows or underflows | 04/19/2024 22:00:25 | Future |
| [dotnet/runtime#65850](65850) | [Question] GC pause time is too large for 60 fps | 03/18/2024 06:26:49 | Future |
| [dotnet/runtime#49059](49059) | Please introduce pauseless GC in c# | 02/23/2024 19:00:41 | Future |
| [dotnet/runtime#12809](12809) | Local GC API to support object scanning | 12/14/2023 14:55:03 | Future |
| [dotnet/runtime#5933](5933) | Port UpdatePublishedVersions.ps1 from corefx to coreclr | 11/24/2023 12:33:21 | Future |
| [dotnet/runtime#10529](10529) | Add an aggressively-clear GC mode | 11/02/2023 06:03:46 | Future |
| [dotnet/runtime#58974](58974) |  .NET 6 container throws OutOfMemoryException | 10/20/2023 20:03:56 | Future |
| [dotnet/runtime#76921](76921) | #SIGSEGV in linux docker since upgrade to 6.0.10 | 10/18/2023 11:49:15 | Future |
| [dotnet/runtime#74333](74333) | How to run `GC/Stress/Framework/ReliabilityFramework/ReliabilityFramework.sh` on linux ? | 10/05/2023 18:05:46 | Future |
| [dotnet/runtime#42743](42743) | Access Violation Error in GC DiagTraceGCSegments | 09/26/2023 09:44:56 | Future |
| [dotnet/runtime#65198](65198) | GC.AllocateUninitializedArray has regressed on macOS | 08/30/2023 04:58:33 | Future |
| [dotnet/runtime#79063](79063) | CGroup/Docker memory reservation model isn't honored by GC | 08/14/2023 15:49:16 | 9.0.0 |
| [dotnet/runtime#9022](9022) | Improve Density of GC heap by String Interning  (de-duping)  on Gen2 GC  | 08/12/2023 04:54:05 | Future |
| [dotnet/runtime#76249](76249) | How to tell how much memory a .NET 6 application is really using? | 08/10/2023 13:27:01 | Future |
| [dotnet/runtime#81056](81056) | In .NET 7 large number of concurrent requests will memory leak | 08/06/2023 00:10:58 | Future |
| [dotnet/runtime#83964](83964) | [GC] GetLogicalProcessorCacheSizeFromOS should fallback per cache level | 08/03/2023 20:13:37 | 9.0.0 |
| [dotnet/runtime#78899](78899) | Test failure GC\\Regressions\\Github\\Runtime_76219\\Runtime_76219\\Runtime_76219.cmd | 08/03/2023 20:10:30 | 9.0.0 |
| [dotnet/runtime#77128](77128) | Many Gen1 GCs doing nothing with high fragmentation | 08/03/2023 20:09:25 | 9.0.0 |
| [dotnet/runtime#73414](73414) | SIP region alloc isn't accounted for in any ETW events | 08/03/2023 20:06:23 | 9.0.0 |
| [dotnet/runtime#76290](76290) | GC picks wrong L3 cache size on Linux | 08/03/2023 18:37:57 | 9.0.0 |
| [dotnet/runtime#79308](79308) | Assert ((size_t)g_gc_lowest_address - ps) >= OS_PAGE_SIZE | 08/03/2023 03:09:56 | Future |
| [dotnet/runtime#78962](78962) | High netcore memory usage compared to windows (From an VS Template starter app) | 08/02/2023 23:18:17 | Future |
| [dotnet/runtime#73411](73411) | Fixing ETW event emission from revisit_written_pages | 08/02/2023 23:17:34 | Future |
| [dotnet/runtime#75034](75034) | ubsan detects null this when calling a member function in the GC | 08/02/2023 23:15:54 | Future |
| [dotnet/runtime#75865](75865) | Make GC stack walking robust in the presence of unmanaged byrefs with extended lifetime | 08/02/2023 23:12:05 | Future |
| [dotnet/runtime#74388](74388) | System.Tests.GCExtendedTests.GetAllocatedBytesForCurrentThread - Allocated too much | 08/02/2023 23:07:22 | Future |
| [dotnet/runtime#73417](73417) | keep total_committed_so_far and total_decommitted_so_far counters | 08/02/2023 23:05:43 | Future |
| [dotnet/runtime#64934](64934) | GCSimulator_63 test failed in outerloop on linux-arm64 | 08/02/2023 23:04:26 | Future |
| [dotnet/runtime#41708](41708) | Create a unit test for PAL_GetLogicalProcessorCacheSizeFromOS | 08/02/2023 23:03:23 | Future |
| [dotnet/runtime#10480](10480) | GC Heap Compaction should clear the source data | 08/02/2023 23:03:13 | Future |
| [dotnet/runtime#80351](80351) | Memory not being collected back | 07/31/2023 14:29:50 | Future |
| [dotnet/runtime#8061](8061) | [Local GC] Local GC Feature Meta-Issue | 07/18/2023 22:18:56 | Future |
| [dotnet/runtime#38221](38221) | [Pinned Object Heap] POH perf tuning | 07/03/2023 16:38:38 | Future |
| [dotnet/runtime#11533](11533) | Potential bus contention on many core machines in the handle table code | 06/23/2023 20:23:45 | Future |
| [dotnet/runtime#67653](67653) | Allow Background GC Thread Affinization | 06/23/2023 20:20:44 | Future |
| [dotnet/runtime#63113](63113) | [API Proposal]: Soft References | 06/16/2023 18:31:00 | Future |
| [dotnet/runtime#66699](66699) | GC crash in background_sweep() and other methods | 04/27/2023 08:47:24 | Future |
| [dotnet/runtime#64831](64831) | OutOfMemoryException caused by user-code in ASP.NET Core runtime | 04/27/2023 08:38:58 | Future |
| [dotnet/runtime#84035](84035) | Process memory and the memory snapshot are not equal | 04/13/2023 02:04:59 | Future |
| [dotnet/runtime#4076](4076) | An effective way to compress Large Object Heap | 04/04/2023 10:03:31 | Future |
| [dotnet/runtime#77618](77618) | Low memory handling? | 03/22/2023 15:45:33 | Future |
| [dotnet/runtime#81425](81425) | Memory Leak in Complex Software with Net 7 | 03/13/2023 16:59:49 | Future |
| [dotnet/runtime#59003](59003) | Resident Set Size high despite not using the backing pages | 02/20/2023 15:23:00 | Future |
| [dotnet/runtime#10547](10547) | GC.GetAllocatedBytesForCurrentThread always returns 0 when processor affinity is set to single proc | 01/31/2023 07:55:56 | Future |
| [dotnet/runtime#5931](5931) | Add support for memory alignment | 01/24/2023 00:13:49 | Future |
| [dotnet/runtime#5633](5633) | Heap objects with custom allocator and explicit delete | 12/28/2022 20:58:07 | Future |
| [dotnet/runtime#13238](13238) | Concurrent GC fails to run concurrently | 12/13/2022 15:35:49 | Future |
| [dotnet/runtime#79062](79062) | Consider aging dependent handles the same way as the other kinds of handles. | 12/01/2022 00:50:52 | Future |
| [dotnet/runtime#73413](73413) | Consider putting the AllocTick event on a different keyword so we can get the join events | 08/08/2022 16:51:03 | Future |
| [dotnet/runtime#73415](73415) | Induced aggressive GC needs to be added to trace event. | 08/08/2022 16:50:33 | Future |
| [dotnet/runtime#73412](73412) | Should add Working Set accounting in our tooling | 08/08/2022 16:44:37 | Future |
| [dotnet/runtime#73557](73557) | Tracking allocations in async methods | 08/08/2022 16:44:08 | Future |
| [dotnet/runtime#2407](2407) | [Pinned Object Heap] Need to generalize GC notification API | 07/27/2022 15:44:57 | Future |
| [dotnet/runtime#57309](57309) | Consider modifying tests / timeouts of  coreclr-gc-simulator pipeline or not using public CI machines | 07/19/2022 16:25:24 | Future |
| [dotnet/runtime#36796](36796) | Add triggering test for GC.AddMemoryPressure/GC.RemoveMemoryPressure | 07/19/2022 16:23:53 | Future |
| [dotnet/runtime#43654](43654) | Epic: Pinned Object Heap tuning | 07/19/2022 16:23:14 | Future |
| [dotnet/runtime#60169](60169) | .net core application get out of memory exception in App Service environment(windows machine) when the machine memory is still available | 07/19/2022 15:49:04 | Future |
| [dotnet/runtime#13737](13737) | [Pinned Object Heap] Need to generalize NoGC regions or explicitly not support. | 07/19/2022 15:28:42 | Future |
| [dotnet/runtime#41675](41675) | GC memory commit issue with currently not supported OS (Nintendo Switch) | 07/19/2022 15:24:34 | Future |
| [dotnet/runtime#72247](72247) | How to check GC Collection information that does not affect performance. | 07/18/2022 21:54:49 | Future |
| [dotnet/runtime#62498](62498) | Feature Request: New performance counter for total bytes allocated | 07/07/2022 23:46:27 | Future |
| [dotnet/runtime#64164](64164) | GC's VXSort question | 07/07/2022 23:43:34 | Future |
| [dotnet/runtime#67268](67268) | .NET 6 RAM consumption on Windows Server 2019 | 07/06/2022 17:52:03 | Future |
| [dotnet/runtime#8718](8718) | Reduce CoreCLR memory footprint | 06/29/2022 23:31:03 | Future |
| [dotnet/runtime#37693](37693) | Add API for reading the LOH size threshold | 04/24/2022 02:23:34 | Future |
| [dotnet/runtime#7780](7780) | Null (allocate-only) GC proposal | 04/09/2022 07:52:51 | Future |
| [dotnet/runtime#50902](50902) | Add an API to reduce GC memory usage | 03/20/2022 14:04:14 | Future |
| [dotnet/runtime#64393](64393) | [API Proposal]: inconsistent case on GC environment variable names  | 03/14/2022 16:52:04 | Future |
| [dotnet/runtime#11733](11733) | Proposal: Add delegate to TryStartNoGCRegion to be invoked when user allocates more than totalSize bytes | 03/03/2022 07:55:50 | Future |
| [dotnet/runtime#4024](4024) | Discussion on reorganizing gc.cpp | 02/22/2022 18:34:22 | Future |
| [dotnet/runtime#6919](6919) | Low memory handling? | 01/09/2022 09:27:42 | Future |
| [dotnet/runtime#60542](60542) | Non-concurrent GC is run rather than Background GC, in container with memory limit | 12/16/2021 20:40:06 | Future |
| [dotnet/runtime#61628](61628) | GC slowdown from .NET Core 3.1 | 11/22/2021 07:56:24 | 6.0.x |
| [dotnet/runtime#61416](61416) | Garbage Collection Causes Crash | 11/11/2021 20:47:03 | Future |
| [dotnet/runtime#53895](53895) | Proposal: GC.RegisterMemoryPressureCallback | 11/11/2021 18:26:47 | Future |
| [dotnet/runtime#44683](44683) | Excessive GC time caused by ConditionalWeakTable entries | 10/28/2021 12:57:11 | Future |
| [dotnet/runtime#59405](59405) | Paging, MemoryMappedFile and GC fun | 09/21/2021 22:32:11 | Future |
| [dotnet/runtime#12255](12255) | ConditionalWeakTable causes a memory leak if one of their values references the table | 09/03/2021 15:33:24 | Future |
| [dotnet/runtime#48937](48937) | High gen0 collect overhead with (suppressed) finalizer objects | 08/25/2021 12:00:15 | Future |
| [dotnet/runtime#57151](57151) | Consider pausing the induced GC caused by OS low memory notification during NoGC | 08/12/2021 17:28:52 | Future |
| [dotnet/runtime#57157](57157) | Consistent test failure in the 8192/8182 test case for NoGC.dll | 08/12/2021 17:28:47 | Future |
| [dotnet/runtime#6051](6051) | Low memory notifications for GC on Unix | 07/09/2021 23:21:01 | Future |
| [dotnet/runtime#52623](52623) | Min 0 Budget changes between 2.2 -> 3.x+ leads to P99 regressions | 07/06/2021 06:03:12 | Future |
| [dotnet/runtime#54542](54542) | Consider making GC.KeepAlive() unnecessary | 06/25/2021 15:13:49 | Future |
| [dotnet/runtime#52230](52230) | help analyze a gcroot! | 05/07/2021 07:39:32 | Future |
| [dotnet/runtime#11775](11775) | New GCLowVolume keyword for ETW/EventPipe events when verbose events are enabled for other keywords | 05/04/2021 22:40:49 | Future |
| [dotnet/runtime#50134](50134) | Why does .net core app working set memory keep increasing in linux docker? | 03/24/2021 04:21:45 | Future |
| [dotnet/runtime#43885](43885) | Windows .NET process hang in GC | 01/21/2021 06:30:49 | Future |
| [dotnet/runtime#5638](5638) | Profiling: How to get GC Metrics in-process | 01/04/2021 04:47:17 | Future |
| [dotnet/runtime#46147](46147) | net5.0 console apps on linux don't show OutOfMemoryExceptions before being OOM-killed | 12/17/2020 14:28:54 | Future |
| [dotnet/runtime#11250](11250) | can't found GCSimulator.sh in x64_release_ubuntu_gcsimulator_tst  | 12/03/2020 21:40:29 | Future |
| [dotnet/runtime#3975](3975) | C++ include guards under src\gc need cleanup for portability | 09/22/2020 16:32:39 | Future |
| [dotnet/runtime#6061](6061) | PROPOSAL: AppDomain.MonitoringAllocatedMemorySizeSinceCollection | 09/22/2020 15:55:30 | Future |
| [dotnet/runtime#37205](37205) | Pinned object problems | 08/06/2020 18:23:47 | Future |
| [dotnet/runtime#39820](39820) | Add hot reloading cpu/memory cgroup settings support during running | 07/23/2020 17:15:30 | Future |
| [dotnet/runtime#12628](12628) | Add a managed API to enumerate and mutate the heap | 02/08/2020 05:20:02 | Future |
| [dotnet/runtime#7175](7175) | Custom Allocator to lower GC frequency and improve cache locality | 01/31/2020 00:55:53 | Future |
| [dotnet/runtime#7670](7670) | GCStress is not safe when not using per-thread allocation contexts | 11/12/2019 17:13:24 | Future |

