# .NET Diagnostics Report Full Report - 07/31/2023 08:23:32

Total issues: 24

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 1

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#88011](https://github.com/dotnet/runtime/issues/88011) | NativeRuntimeEventSource behaving poorly in conjunction with other providers |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 0

## v1,1-dotnet/runtime|area-System.Diagnostics.Metric

Issues in query: 4

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#88567](https://github.com/dotnet/runtime/issues/88567) | Port System.Diagnostics documentation for .NET 8.0 APIs |
| [dotnet/runtime#88515](https://github.com/dotnet/runtime/issues/88515) | [Design] .NET metrics naming standard |
| [dotnet/runtime#87150](https://github.com/dotnet/runtime/issues/87150) | Support Meter and Instrument Tags in MetricsEventSource |
| [dotnet/runtime#85684](https://github.com/dotnet/runtime/issues/85684) | [API Proposal]: Meter Configuration and Pipeline |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 4

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#88305](https://github.com/dotnet/runtime/issues/88305) | Test failure BasicEventSourceTests.TestsWrite.Test_Write_T_ETW |
| [dotnet/runtime#88027](https://github.com/dotnet/runtime/issues/88027) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |
| [dotnet/runtime#86838](https://github.com/dotnet/runtime/issues/86838) | Deadlock on EventSource.EventListenersLock between EventPipeEventDispatcher.StopDispatchTask() and EventSource.Initialize() |
| [dotnet/runtime#84091](https://github.com/dotnet/runtime/issues/84091) | Process crash on simultaneous call of EventListener.DisposeOnShutdown() and EventListener.EnableEvents() |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 15

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#89617](https://github.com/dotnet/runtime/issues/89617) | ICorProfiler ELT hooks need tested with UnmanagedCallersOnly methods |
| [dotnet/runtime#89592](https://github.com/dotnet/runtime/issues/89592) | Debugger assert during register mapping |
| [dotnet/runtime#89475](https://github.com/dotnet/runtime/issues/89475) | HasNativeCodeReJitAware |
| [dotnet/runtime#89474](https://github.com/dotnet/runtime/issues/89474) | Have AreOptimizationsDisabled to go through DAC |
| [dotnet/runtime#88904](https://github.com/dotnet/runtime/issues/88904) | Ensure createdump works with NativeAOT applications |
| [dotnet/runtime#88463](https://github.com/dotnet/runtime/issues/88463) | DoStackSnapshot behaves differently on Windows x86 and x64 WRT stack unwinding |
| [dotnet/runtime#87418](https://github.com/dotnet/runtime/issues/87418) | `RequestReJITWithInliners` doesn't always trigger a rejit without `COR_PRF_MONITOR_JIT_COMPILATION` enabled |
| [dotnet/runtime#87239](https://github.com/dotnet/runtime/issues/87239) | ICorDebugGCReferenceEnum.Next fails to return stack references in .NET 8 preview 4 |
| [dotnet/runtime#82989](https://github.com/dotnet/runtime/issues/82989) | Concurrent exceptions might cause createdump to fail |
| [dotnet/runtime#82422](https://github.com/dotnet/runtime/issues/82422) | [Linux, amd64] ICorDebugEval::Abort are broken. |
| [dotnet/runtime#81921](https://github.com/dotnet/runtime/issues/81921) | Remotely debugging .NET 7 apps in linux-arm environments causes segmentation fault |
| [dotnet/runtime#78991](https://github.com/dotnet/runtime/issues/78991) | NullReferenceException when you use the short format of string.format $"{sample}" when debugging .NET 7 on x64 macOS |
| [dotnet/runtime#77530](https://github.com/dotnet/runtime/issues/77530) | Discussion: Reducing confusion around the System.Runtime gc-heap-size EventCounter |
| [dotnet/runtime#76702](https://github.com/dotnet/runtime/issues/76702) | [EnC] FieldInfo.GetValue on a newly-added ValueType field crashes CoreCLR |
| [dotnet/runtime#38736](https://github.com/dotnet/runtime/issues/38736) | **\<OUT OF SLA\>** Debugger.NotifyOfCrossThreadDependency can be slow when a debugger is attached |

