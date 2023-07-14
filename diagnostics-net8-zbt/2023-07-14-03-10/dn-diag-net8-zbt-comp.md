# .NET Diagnostics Report Comparative Report - 7/14/2023 3:10:41 AM

## Overall Stats

**Current total**: 46
**New**: 46
**Closed**: 0
**Moved In**: 0
**Moved Out** 0

## New Issues

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#88011](https://github.com/dotnet/runtime/issues/88011) | NativeRuntimeEventSource behaving poorly in conjunction with other providers |
| [dotnet/runtime#87983](https://github.com/dotnet/runtime/issues/87983) | NativeRuntimeEventSource behaves inconsistently for LogAlways |
| [dotnet/runtime#86086](https://github.com/dotnet/runtime/issues/86086) | EventPipe/ETW/PerfMap rundown can report wrong optimization tier |
| [dotnet/runtime#74217](https://github.com/dotnet/runtime/issues/74217) | Add a counter for gen0 budget |
| [dotnet/runtime#79463](https://github.com/dotnet/runtime/issues/79463) | [API Proposal]: new System.Diagnostics.StackTrace(System.Threading.Thread) |
| [dotnet/runtime#79371](https://github.com/dotnet/runtime/issues/79371) | Implement/Convert existing EventCounters to Metrics |
| [dotnet/runtime#78125](https://github.com/dotnet/runtime/issues/78125) | [API Proposal]: DiagnosticListener support for testing |
| [dotnet/runtime#88567](https://github.com/dotnet/runtime/issues/88567) | Port System.Diagnostics documentation for .NET 8.0 APIs |
| [dotnet/runtime#88515](https://github.com/dotnet/runtime/issues/88515) | [Design] .NET metrics naming standard |
| [dotnet/runtime#87150](https://github.com/dotnet/runtime/issues/87150) | Support Meter and Instrument Tags in MetricsEventSource |
| [dotnet/runtime#85684](https://github.com/dotnet/runtime/issues/85684) | [Feature]: Meter Configuration and Pipeline |
| [dotnet/runtime#84412](https://github.com/dotnet/runtime/issues/84412) | Feature Request: Support handling more histograms in MetricsEventSource |
| [dotnet/runtime#81574](https://github.com/dotnet/runtime/issues/81574) | Dotnet-counter and other tools for specifying meter and ActivitySource names should support namespace wildcards  |
| [dotnet/runtime#81534](https://github.com/dotnet/runtime/issues/81534) | Advancing Metrics in .NET |
| [dotnet/runtime#79372](https://github.com/dotnet/runtime/issues/79372) | How do I discover what counters are available for dotnet-counters? |
| [dotnet/runtime#88305](https://github.com/dotnet/runtime/issues/88305) | Test failure BasicEventSourceTests.TestsWrite.Test_Write_T_ETW |
| [dotnet/runtime#88027](https://github.com/dotnet/runtime/issues/88027) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |
| [dotnet/runtime#87064](https://github.com/dotnet/runtime/issues/87064) | Consider preserving some types for DiagnosticSource to work with dotnet-monitor in NativeAOT |
| [dotnet/runtime#86838](https://github.com/dotnet/runtime/issues/86838) | Deadlock on EventSource.EventListenersLock between EventPipeEventDispatcher.StopDispatchTask() and EventSource.Initialize() |
| [dotnet/runtime#84091](https://github.com/dotnet/runtime/issues/84091) | Process crash on simultaneous call of EventListener.DisposeOnShutdown() and EventListener.EnableEvents() |
| [dotnet/runtime#77572](https://github.com/dotnet/runtime/issues/77572) | dotnet-trace: Make it easier to get a dump of what EventSources and Events are actually used by a process |
| [dotnet/runtime#77520](https://github.com/dotnet/runtime/issues/77520) | Enable sample based tracing to track issues in high performance/load scenarios |
| [dotnet/runtime#88463](https://github.com/dotnet/runtime/issues/88463) | DoStackSnapshot behaves differently on Windows x86 and x64 WRT stack unwinding |
| [dotnet/runtime#87574](https://github.com/dotnet/runtime/issues/87574) | [EnC] CoreCLR assertion in System.Reflection.Metadata.ApplyUpdateTest.TestGenericAddStaticField |
| [dotnet/runtime#87418](https://github.com/dotnet/runtime/issues/87418) | `RequestReJITWithInliners` doesn't always trigger a rejit without `COR_PRF_MONITOR_JIT_COMPILATION` enabled |
| [dotnet/runtime#87300](https://github.com/dotnet/runtime/issues/87300) | Rejit test failures in outerloop - unexpected counts |
| [dotnet/runtime#87239](https://github.com/dotnet/runtime/issues/87239) | ICorDebugGCReferenceEnum.Next fails to return stack references in .NET 8 preview 4 |
| [dotnet/runtime#86259](https://github.com/dotnet/runtime/issues/86259) | .net7 HRESULT: 0x8007000E on linux with read-only fs |
| [dotnet/runtime#86178](https://github.com/dotnet/runtime/issues/86178) | ICorProfilerCallback.AssemblyUnloadStarted is never called |
| [dotnet/runtime#85777](https://github.com/dotnet/runtime/issues/85777) | Segfault in CMiniMdTemplate<CMiniMdRW>::getSignatureOfMemberRef |
| [dotnet/runtime#84087](https://github.com/dotnet/runtime/issues/84087) | Ensure XMM16-XMM31 and K0-K7 are handled where appropriate |
| [dotnet/runtime#82989](https://github.com/dotnet/runtime/issues/82989) | Concurrent exceptions might cause createdump to fail |
| [dotnet/runtime#82422](https://github.com/dotnet/runtime/issues/82422) | [Linux, amd64] ICorDebugEval::Abort are broken. |
| [dotnet/runtime#81921](https://github.com/dotnet/runtime/issues/81921) | Remotely debugging .NET 7 apps in linux-arm environments causes segmentation fault |
| [dotnet/runtime#79919](https://github.com/dotnet/runtime/issues/79919) | Unable to unwind exception on Xunit |
| [dotnet/runtime#79852](https://github.com/dotnet/runtime/issues/79852) | [macOS] cannot debug / stop at breakpoints when app sandbox is enabled |
| [dotnet/runtime#78991](https://github.com/dotnet/runtime/issues/78991) | NullReferenceException when you use the short format of string.format $"{sample}" when debugging .NET 7 on x64 macOS |
| [dotnet/runtime#78940](https://github.com/dotnet/runtime/issues/78940) | Debugging execution code in vs is slow, but the program is compiled and runs fine |
| [dotnet/runtime#77530](https://github.com/dotnet/runtime/issues/77530) | Discussion: Reducing confusion around the System.Runtime gc-heap-size EventCounter |
| [dotnet/runtime#76702](https://github.com/dotnet/runtime/issues/76702) | [EnC] FieldInfo.GetValue on a newly-added ValueType field crashes CoreCLR |
| [dotnet/runtime#75580](https://github.com/dotnet/runtime/issues/75580) | improve the gc-heap-size counter |
| [dotnet/runtime#73826](https://github.com/dotnet/runtime/issues/73826) | Add an ICorProfiler callback for when an exception goes unhandled |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#69324](https://github.com/dotnet/runtime/issues/69324) | should expose the accumulative GC pause duration as a counter |
| [dotnet/runtime#38736](https://github.com/dotnet/runtime/issues/38736) | Debugger.NotifyOfCrossThreadDependency can be slow when a debugger is attached |

## Closed Issues

| **Issue Number** | **Title** |
| :--------------: | --------- |

## Moved In Issues

| **Issue Number** | **Title** |
| :--------------: | --------- |

## Removed Issues

| **Issue Number** | **Title** |
| :--------------: | --------- |

## Issues Out of Time SLA (36 months)

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#38736](https://github.com/dotnet/runtime/issues/38736) | Debugger.NotifyOfCrossThreadDependency can be slow when a debugger is attached |

