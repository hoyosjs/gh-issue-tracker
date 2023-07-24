# .NET Diagnostics Report Full Report - 07/24/2023 08:23:41

Total issues: 31

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 5

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#88011](https://github.com/dotnet/runtime/issues/88011) | NativeRuntimeEventSource behaving poorly in conjunction with other providers |
| [dotnet/runtime#87983](https://github.com/dotnet/runtime/issues/87983) | NativeRuntimeEventSource behaves inconsistently for LogAlways |
| [dotnet/runtime#87769](https://github.com/dotnet/runtime/issues/87769) | .net8 preview4 AOT windows service process, log component always writes to ETW |
| [dotnet/runtime#74217](https://github.com/dotnet/runtime/issues/74217) | Add a counter for gen0 budget |
| [dotnet/runtime#43390](https://github.com/dotnet/runtime/issues/43390) | Developers can employ EventSource APIs when publishing for AOT targets to be able to use .NET tracing capabilities |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 0

## v1,1-dotnet/runtime|area-System.Diagnostics.Metric

Issues in query: 4

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#88567](https://github.com/dotnet/runtime/issues/88567) | Port System.Diagnostics documentation for .NET 8.0 APIs |
| [dotnet/runtime#88515](https://github.com/dotnet/runtime/issues/88515) | [Design] .NET metrics naming standard |
| [dotnet/runtime#87150](https://github.com/dotnet/runtime/issues/87150) | Support Meter and Instrument Tags in MetricsEventSource |
| [dotnet/runtime#85684](https://github.com/dotnet/runtime/issues/85684) | [Feature]: Meter Configuration and Pipeline |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 7

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#88305](https://github.com/dotnet/runtime/issues/88305) | Test failure BasicEventSourceTests.TestsWrite.Test_Write_T_ETW |
| [dotnet/runtime#88027](https://github.com/dotnet/runtime/issues/88027) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |
| [dotnet/runtime#87064](https://github.com/dotnet/runtime/issues/87064) | Consider preserving some types for DiagnosticSource to work with dotnet-monitor in NativeAOT |
| [dotnet/runtime#86838](https://github.com/dotnet/runtime/issues/86838) | Deadlock on EventSource.EventListenersLock between EventPipeEventDispatcher.StopDispatchTask() and EventSource.Initialize() |
| [dotnet/runtime#84091](https://github.com/dotnet/runtime/issues/84091) | Process crash on simultaneous call of EventListener.DisposeOnShutdown() and EventListener.EnableEvents() |
| [dotnet/runtime#45215](https://github.com/dotnet/runtime/issues/45215) | Analyzer proposal: EventSource log argument guarding |
| [dotnet/runtime#26463](https://github.com/dotnet/runtime/issues/26463) | **\<OUT OF SLA\>** Support for tracestate collection in Activity of DiagnosticSource |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 15

| **Issue Number** | **Title** |
| :--------------: | --------- |
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
| [dotnet/runtime#75580](https://github.com/dotnet/runtime/issues/75580) | improve the gc-heap-size counter |
| [dotnet/runtime#75154](https://github.com/dotnet/runtime/issues/75154) | Update metadata when entities are deleted by an EnC edit |
| [dotnet/runtime#73183](https://github.com/dotnet/runtime/issues/73183) | NativeAOT crash dumps bucket all user exceptions as APPLICATION_FAULT |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#38736](https://github.com/dotnet/runtime/issues/38736) | **\<OUT OF SLA\>** Debugger.NotifyOfCrossThreadDependency can be slow when a debugger is attached |

