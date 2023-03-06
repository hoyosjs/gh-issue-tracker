# .NET Diagnostics Report Full Report - 03/06/2023 23:07:15

Total issues: 50

## v1,1-dotnet/diagnostics

Issues in query: 22

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#3714](https://github.com/dotnet/diagnostics/issues/3714) | dotnet-trace report Missing Symbol for .Net 6 application in container even when pdb files are available |
| [dotnet/diagnostics#3699](https://github.com/dotnet/diagnostics/issues/3699) | DiagnosticsClient.GetPublishedProcesses returns dead processes PIDs on Linux and macOS |
| [dotnet/diagnostics#3682](https://github.com/dotnet/diagnostics/issues/3682) | dotnet tools do not work on mac when running dll directly |
| [dotnet/diagnostics#3665](https://github.com/dotnet/diagnostics/issues/3665) | dotnet-counters formatting broken in 8.0 |
| [dotnet/diagnostics#3581](https://github.com/dotnet/diagnostics/issues/3581) | eeversion prints wrong mode |
| [dotnet/diagnostics#3566](https://github.com/dotnet/diagnostics/issues/3566) | `listnearobj` can't confirm heap consistency with .NET 7 |
| [dotnet/diagnostics#3516](https://github.com/dotnet/diagnostics/issues/3516) | DumpMT disabled in SOS.OtherCommands for .NET 7.0+ |
| [dotnet/diagnostics#3506](https://github.com/dotnet/diagnostics/issues/3506) | How to debug stack overflow errors on Windows |
| [dotnet/diagnostics#3482](https://github.com/dotnet/diagnostics/issues/3482) | !eeheap is reporting slightly inaccurate committed bytes. |
| [dotnet/diagnostics#3479](https://github.com/dotnet/diagnostics/issues/3479) | Timed out when dotnet-trace connects to a dotnet app |
| [dotnet/diagnostics#3341](https://github.com/dotnet/diagnostics/issues/3341) | TFM trimming, and elimination of net4* targeting in Linux source-build |
| [dotnet/diagnostics#3331](https://github.com/dotnet/diagnostics/issues/3331) | Source-build behavior control update |
| [dotnet/diagnostics#3326](https://github.com/dotnet/diagnostics/issues/3326) | Specify all source-built dependencies and ensure they are regularly updated |
| [dotnet/diagnostics#3248](https://github.com/dotnet/diagnostics/issues/3248) | dotnet diagnostic tools benchmark tests need investigation |
| [dotnet/diagnostics#3155](https://github.com/dotnet/diagnostics/issues/3155) | Reenable eeversion tests in StackAndOtherTests/StackTests scripts when 7.0 dumps have version string |
| [dotnet/diagnostics#3137](https://github.com/dotnet/diagnostics/issues/3137) | dumpasync --methodtable result in error when parameter are not prefix with the 0x (hex) sign  |
| [dotnet/diagnostics#3131](https://github.com/dotnet/diagnostics/issues/3131) | dotnet-gcdump doesnt work with kubectl debug |
| [dotnet/diagnostics#3111](https://github.com/dotnet/diagnostics/issues/3111) | Reenable TestDbgEng tests in M.D.DebugServices.UnitTests |
| [dotnet/diagnostics#2911](https://github.com/dotnet/diagnostics/issues/2911) | **\<OUT OF SLA\>** Guidance on using PerfView/other perf visualization tools. |
| [dotnet/diagnostics#2905](https://github.com/dotnet/diagnostics/issues/2905) | **\<OUT OF SLA\>** Diagnosing managed memory leaks with dotnet-gcdump. |
| [dotnet/diagnostics#2903](https://github.com/dotnet/diagnostics/issues/2903) | **\<OUT OF SLA\>** E2E guide how to collect a dump and debug it with VS or LLDB |
| [dotnet/diagnostics#82423]() |  |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 6

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#82423](https://github.com/dotnet/runtime/issues/82423) | WriteEvent(Int32, Byte[]) not supported by EventPipe? |
| [dotnet/runtime#81323](https://github.com/dotnet/runtime/issues/81323) | Test failure tracing/eventpipe/rundownvalidation/rundownvalidation/rundownvalidation.sh |
| [dotnet/runtime#80767](https://github.com/dotnet/runtime/issues/80767) | Test failure tracing/runtimeeventsource/nativeruntimeeventsource/nativeruntimeeventsource.sh |
| [dotnet/runtime#78006](https://github.com/dotnet/runtime/issues/78006) | NRE in System.Diagnostics.Tracing.EventPipePayloadDecoder if Threading event keywords are enabled. |
| [dotnet/runtime#75581](https://github.com/dotnet/runtime/issues/75581) | Diagnostic port suspension message doesn't report expected port name |
| [dotnet/runtime#61353](https://github.com/dotnet/runtime/issues/61353) | **\<OUT OF SLA\>** EventCounters unexpectedly stop reporting data when first of two listeners disconnects |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#82871](https://github.com/dotnet/runtime/issues/82871) | [API Proposal]: Add an overload of the StackTrace constructor to take in an array of frames |
| [dotnet/runtime#77945](https://github.com/dotnet/runtime/issues/77945) | Stopwatch.GetTimestamp() doesn't take into account sleep time on Unix |
| [dotnet/runtime#66734](https://github.com/dotnet/runtime/issues/66734) | Stopwatch is inconsistent when guarding against negative Elapsed durations |

## v1,1-dotnet/runtime|area-System.Diagnostics.Metric

Issues in query: 0

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#83015](https://github.com/dotnet/runtime/issues/83015) | Test failure BasicEventSourceTests.TestsWriteEvent.Test_WriteEvent_ByteArray_SelfDescribing_ETW |
| [dotnet/runtime#80666](https://github.com/dotnet/runtime/issues/80666) | tracing/eventpipe/eventsourceerror/eventsourceerror/eventsourceerror failure |
| [dotnet/runtime#80064](https://github.com/dotnet/runtime/issues/80064) | PublishSingleFile=true + EventListener causes EventPipeEventDispatcher.DispatchEventsToEventListeners() to fully occupy a CPU core |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 18

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#82989](https://github.com/dotnet/runtime/issues/82989) | Concurrent exceptions might cause createdump to fail |
| [dotnet/runtime#82690](https://github.com/dotnet/runtime/issues/82690) | Test failure profiler\\multiple\\multiple\\multiple.cmd |
| [dotnet/runtime#82422](https://github.com/dotnet/runtime/issues/82422) | [Linux, amd64] ICorDebugEval::Abort are broken. |
| [dotnet/runtime#81921](https://github.com/dotnet/runtime/issues/81921) | Remotely debugging .NET 7 apps in linux-arm environments causes segmentation fault |
| [dotnet/runtime#81324](https://github.com/dotnet/runtime/issues/81324) | Test failure profiler/multiple/multiple/multiple.sh |
| [dotnet/runtime#79919](https://github.com/dotnet/runtime/issues/79919) | Unable to unwind exception on Xunit |
| [dotnet/runtime#79852](https://github.com/dotnet/runtime/issues/79852) | [macOS] cannot debug / stop at breakpoints when app sandbox is enabled |
| [dotnet/runtime#78991](https://github.com/dotnet/runtime/issues/78991) | NullReferenceException when you use the short format of string.format $"{sample}" |
| [dotnet/runtime#78940](https://github.com/dotnet/runtime/issues/78940) | Debugging execution code in vs is slow, but the program is compiled and runs fine |
| [dotnet/runtime#77574](https://github.com/dotnet/runtime/issues/77574) | .NET Debugging services don't issue thread create callbacks for single file apps |
| [dotnet/runtime#75821](https://github.com/dotnet/runtime/issues/75821) | Test failure profiler\\gc\\gcbasic\\gcbasic.cmd |
| [dotnet/runtime#72603](https://github.com/dotnet/runtime/issues/72603) | Debugger fails to attach to a specific application with CORDBG_E_MISSING_DEBUGGER_EXPORTS on macOS. |
| [dotnet/runtime#71786](https://github.com/dotnet/runtime/issues/71786) | Linux perf support regressed on W^X enabled runs |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | Application crash while stepping into if 'justMyCode' is disabled |
| [dotnet/runtime#40958](https://github.com/dotnet/runtime/issues/40958) | **\<OUT OF SLA\>** Add NT_SIGINFO NOTE for each thread to createdump dumps |
| [dotnet/runtime#75581](https://github.com/dotnet/runtime/issues/75581) | Diagnostic port suspension message doesn't report expected port name |

