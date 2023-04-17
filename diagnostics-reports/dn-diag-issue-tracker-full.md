# .NET Diagnostics Report Full Report - 04/17/2023 21:54:57

Total issues: 56

## v1,1-dotnet/diagnostics

Issues in query: 21

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#3828](https://github.com/dotnet/diagnostics/issues/3828) | Failed to profile .NET iOS app (`dotnet trace`: Unable to read beyond the end of the stream) |
| [dotnet/diagnostics#3809](https://github.com/dotnet/diagnostics/issues/3809) | DiagnosticPort docs incorrectly claim support of multiple listen ports |
| [dotnet/diagnostics#3797](https://github.com/dotnet/diagnostics/issues/3797) | Counters tool doc - specify counter |
| [dotnet/diagnostics#3774](https://github.com/dotnet/diagnostics/issues/3774) | Re-enable !gcroot source tests |
| [dotnet/diagnostics#3742](https://github.com/dotnet/diagnostics/issues/3742) | dotnet-counter doesn't display UpDownCounter |
| [dotnet/diagnostics#3726](https://github.com/dotnet/diagnostics/issues/3726) | dotnet dump analyze's `gcroot -all <address>` crashes on arm64 |
| [dotnet/diagnostics#3665](https://github.com/dotnet/diagnostics/issues/3665) | dotnet-counters formatting broken in 8.0 |
| [dotnet/diagnostics#3581](https://github.com/dotnet/diagnostics/issues/3581) | eeversion prints wrong mode |
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
| [dotnet/diagnostics#2208](https://github.com/dotnet/diagnostics/issues/2208) | **\<OUT OF SLA\>** should_check_bgc_mark and fgc_should_consider_object need to be updated for regions |
| [dotnet/diagnostics#83699]() |  |
| [dotnet/diagnostics#82423]() |  |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 9

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#84813](https://github.com/dotnet/runtime/issues/84813) | Test failure Loader\\binding\\tracing\\BinderTracingTest.ResolutionFlow\\BinderTracingTest.ResolutionFlow.cmd |
| [dotnet/runtime#84586](https://github.com/dotnet/runtime/issues/84586) | [Breaking change] Changing EventSource OnEventCommand to be consistent |
| [dotnet/runtime#84555](https://github.com/dotnet/runtime/issues/84555) | Test failure tracing\\eventpipe\\bigevent\\bigevent\\bigevent.cmd |
| [dotnet/runtime#83575](https://github.com/dotnet/runtime/issues/83575) | Test failure JIT\\Directed\\debugging\\debuginfo\\tester\\tester.cmd |
| [dotnet/runtime#83127](https://github.com/dotnet/runtime/issues/83127) | NativeRuntimeEventSource generates a large manifest that is never used |
| [dotnet/runtime#82423](https://github.com/dotnet/runtime/issues/82423) | WriteEvent(Int32, Byte[]) not supported by EventPipe? |
| [dotnet/runtime#80767](https://github.com/dotnet/runtime/issues/80767) | Test failure tracing/runtimeeventsource/nativeruntimeeventsource/nativeruntimeeventsource.sh |
| [dotnet/runtime#78006](https://github.com/dotnet/runtime/issues/78006) | NRE in System.Diagnostics.Tracing.EventPipePayloadDecoder if Threading event keywords are enabled. |
| [dotnet/runtime#75581](https://github.com/dotnet/runtime/issues/75581) | Diagnostic port suspension message doesn't report expected port name |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 2

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#77945](https://github.com/dotnet/runtime/issues/77945) | Stopwatch.GetTimestamp() doesn't take into account sleep time on Unix |
| [dotnet/runtime#66734](https://github.com/dotnet/runtime/issues/66734) | **\<OUT OF SLA\>** Stopwatch is inconsistent when guarding against negative Elapsed durations |

## v1,1-dotnet/runtime|area-System.Diagnostics.Metric

Issues in query: 2

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#84903](https://github.com/dotnet/runtime/issues/84903) | Metrics Enrichment support |
| [dotnet/runtime#84713](https://github.com/dotnet/runtime/issues/84713) | Degraded performance in metering when creating a lot of instruments |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 4

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#84091](https://github.com/dotnet/runtime/issues/84091) | Process crash on simultaneous call of EventListener.DisposeOnShutdown() and EventListener.EnableEvents() |
| [dotnet/runtime#83015](https://github.com/dotnet/runtime/issues/83015) | Test failure BasicEventSourceTests.TestsWriteEvent.Test_WriteEvent_ByteArray_SelfDescribing_ETW |
| [dotnet/runtime#80666](https://github.com/dotnet/runtime/issues/80666) | tracing/eventpipe/eventsourceerror/eventsourceerror/eventsourceerror failure |
| [dotnet/runtime#80064](https://github.com/dotnet/runtime/issues/80064) | PublishSingleFile=true + EventListener causes EventPipeEventDispatcher.DispatchEventsToEventListeners() to fully occupy a CPU core |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 22

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#84665](https://github.com/dotnet/runtime/issues/84665) | crashinfounix.cpp: unknown type name 'off64_t' on Alpine Linux |
| [dotnet/runtime#83985](https://github.com/dotnet/runtime/issues/83985) | Windbg Can't Unwind Stacks for Single-File Dumps Captured with procdump |
| [dotnet/runtime#83967](https://github.com/dotnet/runtime/issues/83967) | [CoreCLR Linux arm32] `ICorDebugStackWalk` works wrong in case top frame is native. |
| [dotnet/runtime#83613](https://github.com/dotnet/runtime/issues/83613) | createdump is added to Mac app bundles |
| [dotnet/runtime#83699](https://github.com/dotnet/runtime/issues/83699) | lldb dumpmt crashes against source-built .NET 7 on Fedora 37 |
| [dotnet/runtime#83419](https://github.com/dotnet/runtime/issues/83419) | exe file name gets truncated in .NET core mini dump name |
| [dotnet/runtime#82989](https://github.com/dotnet/runtime/issues/82989) | Concurrent exceptions might cause createdump to fail |
| [dotnet/runtime#82690](https://github.com/dotnet/runtime/issues/82690) | Test failure profiler\\multiple\\multiple\\multiple.cmd |
| [dotnet/runtime#82422](https://github.com/dotnet/runtime/issues/82422) | [Linux, amd64] ICorDebugEval::Abort are broken. |
| [dotnet/runtime#81921](https://github.com/dotnet/runtime/issues/81921) | Remotely debugging .NET 7 apps in linux-arm environments causes segmentation fault |
| [dotnet/runtime#79919](https://github.com/dotnet/runtime/issues/79919) | Unable to unwind exception on Xunit |
| [dotnet/runtime#79852](https://github.com/dotnet/runtime/issues/79852) | [macOS] cannot debug / stop at breakpoints when app sandbox is enabled |
| [dotnet/runtime#78991](https://github.com/dotnet/runtime/issues/78991) | NullReferenceException when you use the short format of string.format $"{sample}" |
| [dotnet/runtime#78940](https://github.com/dotnet/runtime/issues/78940) | Debugging execution code in vs is slow, but the program is compiled and runs fine |
| [dotnet/runtime#77574](https://github.com/dotnet/runtime/issues/77574) | .NET Debugging services don't issue thread create callbacks for single file apps |
| [dotnet/runtime#72603](https://github.com/dotnet/runtime/issues/72603) | Debugger fails to attach to a specific application with CORDBG_E_MISSING_DEBUGGER_EXPORTS on macOS. |
| [dotnet/runtime#71786](https://github.com/dotnet/runtime/issues/71786) | Linux perf support regressed on W^X enabled runs |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | **\<OUT OF SLA\>** Application crash while stepping into if 'justMyCode' is disabled |
| [dotnet/runtime#83575](https://github.com/dotnet/runtime/issues/83575) | Test failure JIT\\Directed\\debugging\\debuginfo\\tester\\tester.cmd |
| [dotnet/runtime#75581](https://github.com/dotnet/runtime/issues/75581) | Diagnostic port suspension message doesn't report expected port name |

