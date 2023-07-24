# .NET Diagnostics Report Full Report - 07/24/2023 06:13:57

Total issues: 53

## v1,1-dotnet/diagnostics

Issues in query: 22

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#4086](https://github.com/dotnet/diagnostics/issues/4086) | LLDB sos commands don't write output to SBCommandReturnObject |
| [dotnet/diagnostics#4070](https://github.com/dotnet/diagnostics/issues/4070) | SOS sets the invalid parameter handler in the CRT on Windows in an unsafe way |
| [dotnet/diagnostics#4058](https://github.com/dotnet/diagnostics/issues/4058) | dotnet-dsrouter not connecting on iOS - "Failed connecting 9191 over usbmux, wait 500 ms before retrying." |
| [dotnet/diagnostics#4002](https://github.com/dotnet/diagnostics/issues/4002) | Update docs: Linux dump analysis in a Windows environment |
| [dotnet/diagnostics#3974](https://github.com/dotnet/diagnostics/issues/3974) | Q: what does it mean when `verifyheap` reports heap errors? |
| [dotnet/diagnostics#3935](https://github.com/dotnet/diagnostics/issues/3935) | `dotnet-trace collect` hangs without completing collection on Linux |
| [dotnet/diagnostics#3917](https://github.com/dotnet/diagnostics/issues/3917) | finalizequeue can exit with exit code 139 |
| [dotnet/diagnostics#3913](https://github.com/dotnet/diagnostics/issues/3913) | gctonative requires IMemoryRegionService |
| [dotnet/diagnostics#3905](https://github.com/dotnet/diagnostics/issues/3905) | `timestamp` for `dotnet counters` in JSON Formatted Incorrectly |
| [dotnet/diagnostics#3882](https://github.com/dotnet/diagnostics/issues/3882) | Add newer Ubuntu images to testing workflows. |
| [dotnet/diagnostics#3809](https://github.com/dotnet/diagnostics/issues/3809) | DiagnosticPort docs incorrectly claim support of multiple listen ports |
| [dotnet/diagnostics#3797](https://github.com/dotnet/diagnostics/issues/3797) | Counters tool doc - specify counter |
| [dotnet/diagnostics#3774](https://github.com/dotnet/diagnostics/issues/3774) | Re-enable !gcroot source tests |
| [dotnet/diagnostics#3726](https://github.com/dotnet/diagnostics/issues/3726) | dotnet dump analyze's `gcroot -all <address>` crashes on arm64 |
| [dotnet/diagnostics#3900](https://github.com/dotnet/diagnostics/issues/3900) | Missing symbols for only dotnet code |
| [dotnet/diagnostics#3516](https://github.com/dotnet/diagnostics/issues/3516) | DumpMT disabled in SOS.OtherCommands for .NET 7.0+ |
| [dotnet/diagnostics#3506](https://github.com/dotnet/diagnostics/issues/3506) | How to debug stack overflow errors on Windows |
| [dotnet/diagnostics#3479](https://github.com/dotnet/diagnostics/issues/3479) | Timed out when dotnet-trace connects to a dotnet app |
| [dotnet/diagnostics#3331](https://github.com/dotnet/diagnostics/issues/3331) | Source-build behavior control update |
| [dotnet/diagnostics#3248](https://github.com/dotnet/diagnostics/issues/3248) | dotnet diagnostic tools benchmark tests need investigation |
| [dotnet/diagnostics#3155](https://github.com/dotnet/diagnostics/issues/3155) | **\<OUT OF SLA\>** Reenable eeversion tests in StackAndOtherTests/StackTests scripts when 7.0 dumps have version string |
| [dotnet/diagnostics#2911](https://github.com/dotnet/diagnostics/issues/2911) | **\<OUT OF SLA\>** Guidance on using PerfView/other perf visualization tools. |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#88011](https://github.com/dotnet/runtime/issues/88011) | NativeRuntimeEventSource behaving poorly in conjunction with other providers |
| [dotnet/runtime#87983](https://github.com/dotnet/runtime/issues/87983) | NativeRuntimeEventSource behaves inconsistently for LogAlways |
| [dotnet/runtime#87769](https://github.com/dotnet/runtime/issues/87769) | .net8 preview4 AOT windows service process, log component always writes to ETW |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 0

## v1,1-dotnet/runtime|area-System.Diagnostics.Metric

Issues in query: 2

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#89363](https://github.com/dotnet/runtime/issues/89363) | [API Proposal]: Support for copying Measurement<T> with same tags but different value |
| [dotnet/runtime#88567](https://github.com/dotnet/runtime/issues/88567) | Port System.Diagnostics documentation for .NET 8.0 APIs |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 4

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#88305](https://github.com/dotnet/runtime/issues/88305) | Test failure BasicEventSourceTests.TestsWrite.Test_Write_T_ETW |
| [dotnet/runtime#88027](https://github.com/dotnet/runtime/issues/88027) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |
| [dotnet/runtime#86838](https://github.com/dotnet/runtime/issues/86838) | Deadlock on EventSource.EventListenersLock between EventPipeEventDispatcher.StopDispatchTask() and EventSource.Initialize() |
| [dotnet/runtime#84091](https://github.com/dotnet/runtime/issues/84091) | Process crash on simultaneous call of EventListener.DisposeOnShutdown() and EventListener.EnableEvents() |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 22

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#89292](https://github.com/dotnet/runtime/issues/89292) | Unable to break on callback from unmanaged thread |
| [dotnet/runtime#88924](https://github.com/dotnet/runtime/issues/88924) | `RequestReJITWithInliners` can cause an access violation and crash the application |
| [dotnet/runtime#88463](https://github.com/dotnet/runtime/issues/88463) | DoStackSnapshot behaves differently on Windows x86 and x64 WRT stack unwinding |
| [dotnet/runtime#87418](https://github.com/dotnet/runtime/issues/87418) | `RequestReJITWithInliners` doesn't always trigger a rejit without `COR_PRF_MONITOR_JIT_COMPILATION` enabled |
| [dotnet/runtime#87239](https://github.com/dotnet/runtime/issues/87239) | ICorDebugGCReferenceEnum.Next fails to return stack references in .NET 8 preview 4 |
| [dotnet/runtime#85777](https://github.com/dotnet/runtime/issues/85777) | Segfault in CMiniMdTemplate<CMiniMdRW>::getSignatureOfMemberRef |
| [dotnet/runtime#84665](https://github.com/dotnet/runtime/issues/84665) | crashinfounix.cpp: unknown type name 'off64_t' on Alpine Linux |
| [dotnet/runtime#83967](https://github.com/dotnet/runtime/issues/83967) | [CoreCLR Linux arm32] `ICorDebugStackWalk` works wrong in case top frame is native. |
| [dotnet/runtime#83699](https://github.com/dotnet/runtime/issues/83699) | lldb dumpmt crashes against source-built .NET 7 on Fedora 37 |
| [dotnet/runtime#83419](https://github.com/dotnet/runtime/issues/83419) | exe file name gets truncated in .NET core mini dump name |
| [dotnet/runtime#82989](https://github.com/dotnet/runtime/issues/82989) | Concurrent exceptions might cause createdump to fail |
| [dotnet/runtime#82422](https://github.com/dotnet/runtime/issues/82422) | [Linux, amd64] ICorDebugEval::Abort are broken. |
| [dotnet/runtime#81921](https://github.com/dotnet/runtime/issues/81921) | Remotely debugging .NET 7 apps in linux-arm environments causes segmentation fault |
| [dotnet/runtime#79919](https://github.com/dotnet/runtime/issues/79919) | Unable to unwind exception on Xunit |
| [dotnet/runtime#79852](https://github.com/dotnet/runtime/issues/79852) | [macOS] cannot debug / stop at breakpoints when app sandbox is enabled |
| [dotnet/runtime#78991](https://github.com/dotnet/runtime/issues/78991) | NullReferenceException when you use the short format of string.format $"{sample}" when debugging .NET 7 on x64 macOS |
| [dotnet/runtime#76702](https://github.com/dotnet/runtime/issues/76702) | [EnC] FieldInfo.GetValue on a newly-added ValueType field crashes CoreCLR |
| [dotnet/runtime#72603](https://github.com/dotnet/runtime/issues/72603) | **\<OUT OF SLA\>** Debugger fails to attach to a specific application with CORDBG_E_MISSING_DEBUGGER_EXPORTS on macOS. |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | **\<OUT OF SLA\>** dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | **\<OUT OF SLA\>** Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | **\<OUT OF SLA\>** Application crash while stepping into if 'justMyCode' is disabled |
| [dotnet/runtime#57962](https://github.com/dotnet/runtime/issues/57962) | **\<OUT OF SLA\>** Unwind info not published in growable function tables |

