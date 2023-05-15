# .NET Diagnostics Report Full Report - 5/15/2023 11:10:59 AM

Total issues: 50

## v1,1-dotnet/diagnostics

Issues in query: 16

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#3842](https://github.com/dotnet/diagnostics/issues/3842) | `dumpgen gen0` makes analyze exit with an exit code of 139 on Linux |
| [dotnet/diagnostics#3828](https://github.com/dotnet/diagnostics/issues/3828) | Failed to profile .NET iOS app (`dotnet trace`: Unable to read beyond the end of the stream) |
| [dotnet/diagnostics#3809](https://github.com/dotnet/diagnostics/issues/3809) | DiagnosticPort docs incorrectly claim support of multiple listen ports |
| [dotnet/diagnostics#3797](https://github.com/dotnet/diagnostics/issues/3797) | Counters tool doc - specify counter |
| [dotnet/diagnostics#3774](https://github.com/dotnet/diagnostics/issues/3774) | Re-enable !gcroot source tests |
| [dotnet/diagnostics#3726](https://github.com/dotnet/diagnostics/issues/3726) | dotnet dump analyze's `gcroot -all <address>` crashes on arm64 |
| [dotnet/diagnostics#3516](https://github.com/dotnet/diagnostics/issues/3516) | DumpMT disabled in SOS.OtherCommands for .NET 7.0+ |
| [dotnet/diagnostics#3506](https://github.com/dotnet/diagnostics/issues/3506) | How to debug stack overflow errors on Windows |
| [dotnet/diagnostics#3479](https://github.com/dotnet/diagnostics/issues/3479) | Timed out when dotnet-trace connects to a dotnet app |
| [dotnet/diagnostics#3331](https://github.com/dotnet/diagnostics/issues/3331) | Source-build behavior control update |
| [dotnet/diagnostics#3326](https://github.com/dotnet/diagnostics/issues/3326) | Specify all source-built dependencies and ensure they are regularly updated |
| [dotnet/diagnostics#3248](https://github.com/dotnet/diagnostics/issues/3248) | dotnet diagnostic tools benchmark tests need investigation |
| [dotnet/diagnostics#3155](https://github.com/dotnet/diagnostics/issues/3155) | Reenable eeversion tests in StackAndOtherTests/StackTests scripts when 7.0 dumps have version string |
| [dotnet/diagnostics#3137](https://github.com/dotnet/diagnostics/issues/3137) | dumpasync --methodtable result in error when parameter are not prefix with the 0x (hex) sign  |
| [dotnet/diagnostics#3111](https://github.com/dotnet/diagnostics/issues/3111) | Reenable TestDbgEng tests in M.D.DebugServices.UnitTests |
| [dotnet/diagnostics#2911](https://github.com/dotnet/diagnostics/issues/2911) | **\<OUT OF SLA\>** Guidance on using PerfView/other perf visualization tools. |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 9

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#86086](https://github.com/dotnet/runtime/issues/86086) | EventPipe/ETW/PerfMap rundown can report wrong optimization tier |
| [dotnet/runtime#85261](https://github.com/dotnet/runtime/issues/85261) | jitstress: BinderTracingTest.ResolutionFlow.cmd failing |
| [dotnet/runtime#85213](https://github.com/dotnet/runtime/issues/85213) | Test failure tracing\\eventpipe\\bigevent\\bigevent\\bigevent.cmd |
| [dotnet/runtime#84813](https://github.com/dotnet/runtime/issues/84813) | Test failure Loader\\binding\\tracing\\BinderTracingTest.ResolutionFlow\\BinderTracingTest.ResolutionFlow.cmd |
| [dotnet/runtime#84586](https://github.com/dotnet/runtime/issues/84586) | [Breaking change] Changing EventSource OnEventCommand to be consistent |
| [dotnet/runtime#83575](https://github.com/dotnet/runtime/issues/83575) | Test failure JIT\\Directed\\debugging\\debuginfo\\tester\\tester.cmd |
| [dotnet/runtime#83127](https://github.com/dotnet/runtime/issues/83127) | NativeRuntimeEventSource generates a large manifest that is never used |
| [dotnet/runtime#82423](https://github.com/dotnet/runtime/issues/82423) | WriteEvent(Int32, Byte[]) not supported by EventPipe? |
| [dotnet/runtime#78006](https://github.com/dotnet/runtime/issues/78006) | NRE in System.Diagnostics.Tracing.EventPipePayloadDecoder if Threading event keywords are enabled. |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 0

## v1,1-dotnet/runtime|area-System.Diagnostics.Metric

Issues in query: 1

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#85290](https://github.com/dotnet/runtime/issues/85290) | [TestFailure] System.Diagnostics.Metrics.Tests.MetricEventSourceTests.EventSourcePublishesAllDataTypes |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 4

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#86134](https://github.com/dotnet/runtime/issues/86134) | Test failure BasicEventSourceTests.TestsWrite.Test_Write_T_ETW |
| [dotnet/runtime#85274](https://github.com/dotnet/runtime/issues/85274) | [Documentation] Request update on the documentation of IL2026 |
| [dotnet/runtime#84091](https://github.com/dotnet/runtime/issues/84091) | Process crash on simultaneous call of EventListener.DisposeOnShutdown() and EventListener.EnableEvents() |
| [dotnet/runtime#80666](https://github.com/dotnet/runtime/issues/80666) | tracing/eventpipe/eventsourceerror/eventsourceerror/eventsourceerror failure |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 20

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#86178](https://github.com/dotnet/runtime/issues/86178) | ICorProfilerCallback.AssemblyUnloadStarted is never called |
| [dotnet/runtime#85948](https://github.com/dotnet/runtime/issues/85948) | Memory usage reported by the process greatly mismatches the dump |
| [dotnet/runtime#85777](https://github.com/dotnet/runtime/issues/85777) | Segfault in CMiniMdTemplate<CMiniMdRW>::getSignatureOfMemberRef |
| [dotnet/runtime#85339](https://github.com/dotnet/runtime/issues/85339) | Native->Managed (.net core) step-in not working in Visual Studio |
| [dotnet/runtime#84665](https://github.com/dotnet/runtime/issues/84665) | crashinfounix.cpp: unknown type name 'off64_t' on Alpine Linux |
| [dotnet/runtime#83985](https://github.com/dotnet/runtime/issues/83985) | Windbg Can't Unwind Stacks for Single-File Dumps Captured with procdump |
| [dotnet/runtime#83967](https://github.com/dotnet/runtime/issues/83967) | [CoreCLR Linux arm32] `ICorDebugStackWalk` works wrong in case top frame is native. |
| [dotnet/runtime#83699](https://github.com/dotnet/runtime/issues/83699) | lldb dumpmt crashes against source-built .NET 7 on Fedora 37 |
| [dotnet/runtime#83419](https://github.com/dotnet/runtime/issues/83419) | exe file name gets truncated in .NET core mini dump name |
| [dotnet/runtime#82989](https://github.com/dotnet/runtime/issues/82989) | Concurrent exceptions might cause createdump to fail |
| [dotnet/runtime#82422](https://github.com/dotnet/runtime/issues/82422) | [Linux, amd64] ICorDebugEval::Abort are broken. |
| [dotnet/runtime#81921](https://github.com/dotnet/runtime/issues/81921) | Remotely debugging .NET 7 apps in linux-arm environments causes segmentation fault |
| [dotnet/runtime#79919](https://github.com/dotnet/runtime/issues/79919) | Unable to unwind exception on Xunit |
| [dotnet/runtime#79852](https://github.com/dotnet/runtime/issues/79852) | [macOS] cannot debug / stop at breakpoints when app sandbox is enabled |
| [dotnet/runtime#78991](https://github.com/dotnet/runtime/issues/78991) | NullReferenceException when you use the short format of string.format $"{sample}" when debugging .NET 7 on x64 macOS |
| [dotnet/runtime#78940](https://github.com/dotnet/runtime/issues/78940) | Debugging execution code in vs is slow, but the program is compiled and runs fine |
| [dotnet/runtime#72603](https://github.com/dotnet/runtime/issues/72603) | Debugger fails to attach to a specific application with CORDBG_E_MISSING_DEBUGGER_EXPORTS on macOS. |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | **\<OUT OF SLA\>** Application crash while stepping into if 'justMyCode' is disabled |

