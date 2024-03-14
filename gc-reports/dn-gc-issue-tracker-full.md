# .NET GC Report Full Report - 03/14/2024 22:25:03

Total issues: 143

## v1,1-dotnet/runtime|area-GC-coreclr

Issues in query: 143

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#99487](https://github.com/dotnet/runtime/issues/99487) | CLR_GCHEAPCOLLECT_KEYWORD triggers a GC twice |
| [dotnet/runtime#99304](https://github.com/dotnet/runtime/issues/99304) | Possible memory leak in .Net 8.0.2 |
| [dotnet/runtime#99164](https://github.com/dotnet/runtime/issues/99164) | [API Proposal]: Add Garbage collector metrics |
| [dotnet/runtime#97600](https://github.com/dotnet/runtime/issues/97600) | NoGCRegion decommits memory in an inconsistent way |
| [dotnet/runtime#97467](https://github.com/dotnet/runtime/issues/97467) | Segmentation fault on .NET 6 - Linux Ubuntu 18.04 |
| [dotnet/runtime#97434](https://github.com/dotnet/runtime/issues/97434) | [API Proposal]: GC level ObjectPooling APIs and more |
| [dotnet/runtime#97186](https://github.com/dotnet/runtime/issues/97186) | Runtime crashes on OSX running compiler unit tests |
| [dotnet/runtime#96592](https://github.com/dotnet/runtime/issues/96592) | AOT built binary for aarch64 android fails to run on Nvidia Shield TV |
| [dotnet/runtime#97126](https://github.com/dotnet/runtime/issues/97126) | High Memory Usage on AMD EPYC 7282 Compared to Intel Xeon E5-2630 v4 with .NET 8.0 |
| [dotnet/runtime#96213](https://github.com/dotnet/runtime/issues/96213) | Pauseless Garbage Collector (Question) |
| [dotnet/runtime#96179](https://github.com/dotnet/runtime/issues/96179) | Memory footprint decreases when application is launched as a console, but does not when launched through a Windows service |
| [dotnet/runtime#96091](https://github.com/dotnet/runtime/issues/96091) | High memory consumption of .Net 6 app on Linux |
| [dotnet/runtime#95944](https://github.com/dotnet/runtime/issues/95944) | Web project does not release memory |
| [dotnet/runtime#95922](https://github.com/dotnet/runtime/issues/95922) | Large unmanaged memory growth (leak?) when upgrading from .NET 6 to 8 |
| [dotnet/runtime#95191](https://github.com/dotnet/runtime/issues/95191) | .Net 7 + 8 Garbage Collection Regression Issue |
| [dotnet/runtime#95257](https://github.com/dotnet/runtime/issues/95257) | .net8 AOT compiled library targeting arm64 crashes when invoked using DllImport from .net8 code |
| [dotnet/runtime#94565](https://github.com/dotnet/runtime/issues/94565) | GCMemoryInfo.MemoryLoadBytes does not reflect whats inside MEMORYSTATUS  |
| [dotnet/runtime#94476](https://github.com/dotnet/runtime/issues/94476) | [Perf] Linux/x64: 2 Regressions on 11/4/2023 4:52:33 AM |
| [dotnet/runtime#94175](https://github.com/dotnet/runtime/issues/94175) | Unexpected OOM with GCHeapLimit |
| [dotnet/runtime#94157](https://github.com/dotnet/runtime/issues/94157) | Test failure GC/Scenarios/muldimjagary/muldimjagary/muldimjagary.sh |
| [dotnet/runtime#94076](https://github.com/dotnet/runtime/issues/94076) | [GC] DATAS Startup time significantly worse than with workstation GC |
| [dotnet/runtime#93905](https://github.com/dotnet/runtime/issues/93905) | Test failure GC\\API\\GC\\CollectionCountTest\\CollectionCountTest.cmd |
| [dotnet/runtime#93891](https://github.com/dotnet/runtime/issues/93891) | [GC] DATAS Tuning to improve pauses and heap volatility |
| [dotnet/runtime#93682](https://github.com/dotnet/runtime/issues/93682) | Fatal runtime errors do not always generate crashes/Watson reports |
| [dotnet/runtime#93162](https://github.com/dotnet/runtime/issues/93162) | Test failure GC\\Features\\HeapExpansion\\plug\\plug.cmd |
| [dotnet/runtime#93059](https://github.com/dotnet/runtime/issues/93059) | App stops responding - ExceptionCode: 80000003 (Break instruction exception) |
| [dotnet/runtime#92490](https://github.com/dotnet/runtime/issues/92490) | Workingset constantly growing, possible unmanaged memory leak |
| [dotnet/runtime#91914](https://github.com/dotnet/runtime/issues/91914) | Microbenchmark Regressions from .NET 8 |
| [dotnet/runtime#91642](https://github.com/dotnet/runtime/issues/91642) | GCPerfSim .NET 8 vs. .NET 6 Performance Regressions |
| [dotnet/runtime#90675](https://github.com/dotnet/runtime/issues/90675) | Move dynamic heap sample inside GC pause |
| [dotnet/runtime#90674](https://github.com/dotnet/runtime/issues/90674) | Support infinite size, commit-on-demand, NoGCRegion |
| [dotnet/runtime#90672](https://github.com/dotnet/runtime/issues/90672) | Avoid wasted commit in NoGCRegions |
| [dotnet/runtime#90640](https://github.com/dotnet/runtime/issues/90640) | GC runs but working set remains the same? |
| [dotnet/runtime#90555](https://github.com/dotnet/runtime/issues/90555) | Workstation GC Performance |
| [dotnet/runtime#90442](https://github.com/dotnet/runtime/issues/90442) | Assert failure: g_heaps[h]->committed_by_oh_per_heap[oh] == g_heaps[h]->committed_by_oh_per_heap_refresh[oh] |
| [dotnet/runtime#89272](https://github.com/dotnet/runtime/issues/89272) | GC deadlock on spawning new process on OSX under Rosetta |
| [dotnet/runtime#87826](https://github.com/dotnet/runtime/issues/87826) | Regressions in System.Threading.Tests.Perf_Timer |
| [dotnet/runtime#87626](https://github.com/dotnet/runtime/issues/87626) | [Perf] Windows/arm64: 4 Regressions on 6/12/2023 7:14:25 PM |
| [dotnet/runtime#87027](https://github.com/dotnet/runtime/issues/87027) | coreclr.dll threw access violation exception |
| [dotnet/runtime#86775](https://github.com/dotnet/runtime/issues/86775) | Fatal error. Internal CLR error. (0x80131506) in .NET 6 |
| [dotnet/runtime#86183](https://github.com/dotnet/runtime/issues/86183) | May  9 21:11:41 server883 kernel: [218937.760135] .NET Server GC[1427719]: segfault at 8 ip 00007f7440ae835c sp 00007f74395bfdf0 error 6 |
| [dotnet/runtime#85556](https://github.com/dotnet/runtime/issues/85556) | crash with 0x8007000E error on .NET 7.0 |
| [dotnet/runtime#85483](https://github.com/dotnet/runtime/issues/85483) | GC Performance OS and Hardware Comparison Differences: Windows Intel vs. Ubuntu Intel and Windows Intel vs. Ubuntu ARM |
| [dotnet/runtime#84393](https://github.com/dotnet/runtime/issues/84393) | [6.0, 7.0] Assert failed in coreclr linux arm: GCHeapUtilities::GetGCHeap()->IsInFrozenSegment(obj) |
| [dotnet/runtime#84035](https://github.com/dotnet/runtime/issues/84035) | Process memory and the memory snapshot are not equal |
| [dotnet/runtime#83964](https://github.com/dotnet/runtime/issues/83964) | [GC] GetLogicalProcessorCacheSizeFromOS should fallback per cache level |
| [dotnet/runtime#81425](https://github.com/dotnet/runtime/issues/81425) | **\<OUT OF SLA\>** Memory Leak in Complex Software with Net 7 |
| [dotnet/runtime#81383](https://github.com/dotnet/runtime/issues/81383) | **\<OUT OF SLA\>** [6.0] GC test failures: Handle collector count overflows or underflows |
| [dotnet/runtime#81056](https://github.com/dotnet/runtime/issues/81056) | **\<OUT OF SLA\>** In .NET 7 large number of concurrent requests will memory leak |
| [dotnet/runtime#80351](https://github.com/dotnet/runtime/issues/80351) | **\<OUT OF SLA\>** Memory not being collected back |
| [dotnet/runtime#79308](https://github.com/dotnet/runtime/issues/79308) | **\<OUT OF SLA\>** Assert ((size_t)g_gc_lowest_address - ps) >= OS_PAGE_SIZE |
| [dotnet/runtime#79063](https://github.com/dotnet/runtime/issues/79063) | **\<OUT OF SLA\>** CGroup/Docker memory reservation model isn't honored by GC |
| [dotnet/runtime#79062](https://github.com/dotnet/runtime/issues/79062) | **\<OUT OF SLA\>** Consider aging dependent handles the same way as the other kinds of handles. |
| [dotnet/runtime#78962](https://github.com/dotnet/runtime/issues/78962) | **\<OUT OF SLA\>** High netcore memory usage compared to windows (From an VS Template starter app) |
| [dotnet/runtime#78899](https://github.com/dotnet/runtime/issues/78899) | **\<OUT OF SLA\>** Test failure GC\\Regressions\\Github\\Runtime_76219\\Runtime_76219\\Runtime_76219.cmd |
| [dotnet/runtime#77128](https://github.com/dotnet/runtime/issues/77128) | **\<OUT OF SLA\>** Many Gen1 GCs doing nothing with high fragmentation |
| [dotnet/runtime#76921](https://github.com/dotnet/runtime/issues/76921) | **\<OUT OF SLA\>** #SIGSEGV in linux docker since upgrade to 6.0.10 |
| [dotnet/runtime#76290](https://github.com/dotnet/runtime/issues/76290) | **\<OUT OF SLA\>** GC picks wrong L3 cache size on Linux |
| [dotnet/runtime#76249](https://github.com/dotnet/runtime/issues/76249) | **\<OUT OF SLA\>** How to tell how much memory a .NET 6 application is really using? |
| [dotnet/runtime#75865](https://github.com/dotnet/runtime/issues/75865) | **\<OUT OF SLA\>** Make GC stack walking robust in the presence of unmanaged byrefs with extended lifetime |
| [dotnet/runtime#75034](https://github.com/dotnet/runtime/issues/75034) | **\<OUT OF SLA\>** ubsan detects null this when calling a member function in the GC |
| [dotnet/runtime#74388](https://github.com/dotnet/runtime/issues/74388) | **\<OUT OF SLA\>** System.Tests.GCExtendedTests.GetAllocatedBytesForCurrentThread - Allocated too much |
| [dotnet/runtime#74333](https://github.com/dotnet/runtime/issues/74333) | **\<OUT OF SLA\>** How to run `GC/Stress/Framework/ReliabilityFramework/ReliabilityFramework.sh` on linux ? |
| [dotnet/runtime#73557](https://github.com/dotnet/runtime/issues/73557) | **\<OUT OF SLA\>** Tracking allocations in async methods |
| [dotnet/runtime#73417](https://github.com/dotnet/runtime/issues/73417) | **\<OUT OF SLA\>** keep total_committed_so_far and total_decommitted_so_far counters |
| [dotnet/runtime#73415](https://github.com/dotnet/runtime/issues/73415) | **\<OUT OF SLA\>** Induced aggressive GC needs to be added to trace event. |
| [dotnet/runtime#73414](https://github.com/dotnet/runtime/issues/73414) | **\<OUT OF SLA\>** SIP region alloc isn't accounted for in any ETW events |
| [dotnet/runtime#73413](https://github.com/dotnet/runtime/issues/73413) | **\<OUT OF SLA\>** Consider putting the AllocTick event on a different keyword so we can get the join events |
| [dotnet/runtime#73412](https://github.com/dotnet/runtime/issues/73412) | **\<OUT OF SLA\>** Should add Working Set accounting in our tooling |
| [dotnet/runtime#73411](https://github.com/dotnet/runtime/issues/73411) | **\<OUT OF SLA\>** Fixing ETW event emission from revisit_written_pages |
| [dotnet/runtime#72247](https://github.com/dotnet/runtime/issues/72247) | **\<OUT OF SLA\>** How to check GC Collection information that does not affect performance. |
| [dotnet/runtime#67653](https://github.com/dotnet/runtime/issues/67653) | **\<OUT OF SLA\>** Allow Background GC Thread Affinization |
| [dotnet/runtime#67268](https://github.com/dotnet/runtime/issues/67268) | **\<OUT OF SLA\>** .NET 6 RAM consumption on Windows Server 2019 |
| [dotnet/runtime#66699](https://github.com/dotnet/runtime/issues/66699) | **\<OUT OF SLA\>** GC crash in background_sweep() and other methods |
| [dotnet/runtime#65850](https://github.com/dotnet/runtime/issues/65850) | **\<OUT OF SLA\>** [Question] GC pause time is too large for 60 fps |
| [dotnet/runtime#65198](https://github.com/dotnet/runtime/issues/65198) | **\<OUT OF SLA\>** GC.AllocateUninitializedArray has regressed on macOS |
| [dotnet/runtime#64934](https://github.com/dotnet/runtime/issues/64934) | **\<OUT OF SLA\>** GCSimulator_63 test failed in outerloop on linux-arm64 |
| [dotnet/runtime#64831](https://github.com/dotnet/runtime/issues/64831) | **\<OUT OF SLA\>** OutOfMemoryException caused by user-code in ASP.NET Core runtime |
| [dotnet/runtime#64393](https://github.com/dotnet/runtime/issues/64393) | **\<OUT OF SLA\>** [API Proposal]: inconsistent case on GC environment variable names  |
| [dotnet/runtime#64164](https://github.com/dotnet/runtime/issues/64164) | **\<OUT OF SLA\>** GC's VXSort question |
| [dotnet/runtime#63113](https://github.com/dotnet/runtime/issues/63113) | **\<OUT OF SLA\>** [API Proposal]: Soft References |
| [dotnet/runtime#62498](https://github.com/dotnet/runtime/issues/62498) | **\<OUT OF SLA\>** Feature Request: New performance counter for total bytes allocated |
| [dotnet/runtime#61628](https://github.com/dotnet/runtime/issues/61628) | **\<OUT OF SLA\>** GC slowdown from .NET Core 3.1 |
| [dotnet/runtime#61416](https://github.com/dotnet/runtime/issues/61416) | **\<OUT OF SLA\>** Garbage Collection Causes Crash |
| [dotnet/runtime#60542](https://github.com/dotnet/runtime/issues/60542) | **\<OUT OF SLA\>** Non-concurrent GC is run rather than Background GC, in container with memory limit |
| [dotnet/runtime#60169](https://github.com/dotnet/runtime/issues/60169) | **\<OUT OF SLA\>** .net core application get out of memory exception in App Service environment(windows machine) when the machine memory is still available |
| [dotnet/runtime#59405](https://github.com/dotnet/runtime/issues/59405) | **\<OUT OF SLA\>** Paging, MemoryMappedFile and GC fun |
| [dotnet/runtime#59003](https://github.com/dotnet/runtime/issues/59003) | **\<OUT OF SLA\>** Resident Set Size high despite not using the backing pages |
| [dotnet/runtime#58974](https://github.com/dotnet/runtime/issues/58974) | **\<OUT OF SLA\>**  .NET 6 container throws OutOfMemoryException |
| [dotnet/runtime#57309](https://github.com/dotnet/runtime/issues/57309) | **\<OUT OF SLA\>** Consider modifying tests / timeouts of  coreclr-gc-simulator pipeline or not using public CI machines |
| [dotnet/runtime#57157](https://github.com/dotnet/runtime/issues/57157) | **\<OUT OF SLA\>** Consistent test failure in the 8192/8182 test case for NoGC.dll |
| [dotnet/runtime#57151](https://github.com/dotnet/runtime/issues/57151) | **\<OUT OF SLA\>** Consider pausing the induced GC caused by OS low memory notification during NoGC |
| [dotnet/runtime#54542](https://github.com/dotnet/runtime/issues/54542) | **\<OUT OF SLA\>** Consider making GC.KeepAlive() unnecessary |
| [dotnet/runtime#53895](https://github.com/dotnet/runtime/issues/53895) | **\<OUT OF SLA\>** Proposal: GC.RegisterMemoryPressureCallback |
| [dotnet/runtime#52623](https://github.com/dotnet/runtime/issues/52623) | **\<OUT OF SLA\>** Min 0 Budget changes between 2.2 -> 3.x+ leads to P99 regressions |
| [dotnet/runtime#52230](https://github.com/dotnet/runtime/issues/52230) | **\<OUT OF SLA\>** help analyze a gcroot! |
| [dotnet/runtime#50902](https://github.com/dotnet/runtime/issues/50902) | **\<OUT OF SLA\>** Add an API to reduce GC memory usage |
| [dotnet/runtime#50134](https://github.com/dotnet/runtime/issues/50134) | **\<OUT OF SLA\>** Why does .net core app working set memory keep increasing in linux docker? |
| [dotnet/runtime#49059](https://github.com/dotnet/runtime/issues/49059) | **\<OUT OF SLA\>** Please introduce pauseless GC in c# |
| [dotnet/runtime#48937](https://github.com/dotnet/runtime/issues/48937) | **\<OUT OF SLA\>** High gen0 collect overhead with (suppressed) finalizer objects |
| [dotnet/runtime#46147](https://github.com/dotnet/runtime/issues/46147) | **\<OUT OF SLA\>** net5.0 console apps on linux don't show OutOfMemoryExceptions before being OOM-killed |
| [dotnet/runtime#44683](https://github.com/dotnet/runtime/issues/44683) | **\<OUT OF SLA\>** Excessive GC time caused by ConditionalWeakTable entries |
| [dotnet/runtime#43885](https://github.com/dotnet/runtime/issues/43885) | **\<OUT OF SLA\>** Windows .NET process hang in GC |
| [dotnet/runtime#43654](https://github.com/dotnet/runtime/issues/43654) | **\<OUT OF SLA\>** Epic: Pinned Object Heap tuning |
| [dotnet/runtime#42743](https://github.com/dotnet/runtime/issues/42743) | **\<OUT OF SLA\>** Access Violation Error in GC DiagTraceGCSegments |
| [dotnet/runtime#41708](https://github.com/dotnet/runtime/issues/41708) | **\<OUT OF SLA\>** Create a unit test for PAL_GetLogicalProcessorCacheSizeFromOS |
| [dotnet/runtime#41675](https://github.com/dotnet/runtime/issues/41675) | **\<OUT OF SLA\>** GC memory commit issue with currently not supported OS (Nintendo Switch) |
| [dotnet/runtime#39820](https://github.com/dotnet/runtime/issues/39820) | **\<OUT OF SLA\>** Add hot reloading cpu/memory cgroup settings support during running |
| [dotnet/runtime#38221](https://github.com/dotnet/runtime/issues/38221) | **\<OUT OF SLA\>** [Pinned Object Heap] POH perf tuning |
| [dotnet/runtime#37693](https://github.com/dotnet/runtime/issues/37693) | **\<OUT OF SLA\>** Add API for reading the LOH size threshold |
| [dotnet/runtime#37205](https://github.com/dotnet/runtime/issues/37205) | **\<OUT OF SLA\>** Pinned object problems |
| [dotnet/runtime#36796](https://github.com/dotnet/runtime/issues/36796) | **\<OUT OF SLA\>** Add triggering test for GC.AddMemoryPressure/GC.RemoveMemoryPressure |
| [dotnet/runtime#2407](https://github.com/dotnet/runtime/issues/2407) | **\<OUT OF SLA\>** [Pinned Object Heap] Need to generalize GC notification API |
| [dotnet/runtime#13737](https://github.com/dotnet/runtime/issues/13737) | **\<OUT OF SLA\>** [Pinned Object Heap] Need to generalize NoGC regions or explicitly not support. |
| [dotnet/runtime#13238](https://github.com/dotnet/runtime/issues/13238) | **\<OUT OF SLA\>** Concurrent GC fails to run concurrently |
| [dotnet/runtime#12809](https://github.com/dotnet/runtime/issues/12809) | **\<OUT OF SLA\>** Local GC API to support object scanning |
| [dotnet/runtime#12628](https://github.com/dotnet/runtime/issues/12628) | **\<OUT OF SLA\>** Add a managed API to enumerate and mutate the heap |
| [dotnet/runtime#11775](https://github.com/dotnet/runtime/issues/11775) | **\<OUT OF SLA\>** New GCLowVolume keyword for ETW/EventPipe events when verbose events are enabled for other keywords |
| [dotnet/runtime#11733](https://github.com/dotnet/runtime/issues/11733) | **\<OUT OF SLA\>** Proposal: Add delegate to TryStartNoGCRegion to be invoked when user allocates more than totalSize bytes |
| [dotnet/runtime#11533](https://github.com/dotnet/runtime/issues/11533) | **\<OUT OF SLA\>** Potential bus contention on many core machines in the handle table code |
| [dotnet/runtime#11250](https://github.com/dotnet/runtime/issues/11250) | **\<OUT OF SLA\>** can't found GCSimulator.sh in x64_release_ubuntu_gcsimulator_tst  |
| [dotnet/runtime#10547](https://github.com/dotnet/runtime/issues/10547) | **\<OUT OF SLA\>** GC.GetAllocatedBytesForCurrentThread always returns 0 when processor affinity is set to single proc |
| [dotnet/runtime#10529](https://github.com/dotnet/runtime/issues/10529) | **\<OUT OF SLA\>** Add an aggressively-clear GC mode |
| [dotnet/runtime#10480](https://github.com/dotnet/runtime/issues/10480) | **\<OUT OF SLA\>** GC Heap Compaction should clear the source data |
| [dotnet/runtime#9022](https://github.com/dotnet/runtime/issues/9022) | **\<OUT OF SLA\>** Improve Density of GC heap by String Interning  (de-duping)  on Gen2 GC  |
| [dotnet/runtime#8718](https://github.com/dotnet/runtime/issues/8718) | **\<OUT OF SLA\>** Reduce CoreCLR memory footprint |
| [dotnet/runtime#8666](https://github.com/dotnet/runtime/issues/8666) | **\<OUT OF SLA\>** NoGC region improvements |
| [dotnet/runtime#12255](https://github.com/dotnet/runtime/issues/12255) | **\<OUT OF SLA\>** ConditionalWeakTable causes a memory leak if one of their values references the table |
| [dotnet/runtime#8061](https://github.com/dotnet/runtime/issues/8061) | **\<OUT OF SLA\>** [Local GC] Local GC Feature Meta-Issue |
| [dotnet/runtime#7780](https://github.com/dotnet/runtime/issues/7780) | **\<OUT OF SLA\>** Null (allocate-only) GC proposal |
| [dotnet/runtime#7670](https://github.com/dotnet/runtime/issues/7670) | **\<OUT OF SLA\>** GCStress is not safe when not using per-thread allocation contexts |
| [dotnet/runtime#7175](https://github.com/dotnet/runtime/issues/7175) | **\<OUT OF SLA\>** Custom Allocator to lower GC frequency and improve cache locality |
| [dotnet/runtime#6919](https://github.com/dotnet/runtime/issues/6919) | **\<OUT OF SLA\>** Low memory handling? |
| [dotnet/runtime#77618](https://github.com/dotnet/runtime/issues/77618) | **\<OUT OF SLA\>** Low memory handling? |
| [dotnet/runtime#6061](https://github.com/dotnet/runtime/issues/6061) | **\<OUT OF SLA\>** PROPOSAL: AppDomain.MonitoringAllocatedMemorySizeSinceCollection |
| [dotnet/runtime#6051](https://github.com/dotnet/runtime/issues/6051) | **\<OUT OF SLA\>** Low memory notifications for GC on Unix |
| [dotnet/runtime#5933](https://github.com/dotnet/runtime/issues/5933) | **\<OUT OF SLA\>** Port UpdatePublishedVersions.ps1 from corefx to coreclr |
| [dotnet/runtime#5931](https://github.com/dotnet/runtime/issues/5931) | **\<OUT OF SLA\>** Add support for memory alignment |
| [dotnet/runtime#5638](https://github.com/dotnet/runtime/issues/5638) | **\<OUT OF SLA\>** Profiling: How to get GC Metrics in-process |
| [dotnet/runtime#5633](https://github.com/dotnet/runtime/issues/5633) | **\<OUT OF SLA\>** Heap objects with custom allocator and explicit delete |
| [dotnet/runtime#4076](https://github.com/dotnet/runtime/issues/4076) | **\<OUT OF SLA\>** An effective way to compress Large Object Heap |
| [dotnet/runtime#4024](https://github.com/dotnet/runtime/issues/4024) | **\<OUT OF SLA\>** Discussion on reorganizing gc.cpp |
| [dotnet/runtime#3975](https://github.com/dotnet/runtime/issues/3975) | **\<OUT OF SLA\>** C++ include guards under src\gc need cleanup for portability |

