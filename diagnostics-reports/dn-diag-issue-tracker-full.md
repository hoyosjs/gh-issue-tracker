# .NET Diagnostics Report Full Report - 1/24/2023 7:31:28 AM

Total issues: 56

## v1,1-dotnet/diagnostics

Issues in query: 26

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#3607](https://github.com/dotnet/diagnostics/issues/3607) | Dotnet convert to chromium format produces invalid JSON |
| [dotnet/diagnostics#3581](https://github.com/dotnet/diagnostics/issues/3581) | eeversion prints wrong mode |
| [dotnet/diagnostics#3566](https://github.com/dotnet/diagnostics/issues/3566) | `listnearobj` can't confirm heap consistency with .NET 7 |
| [dotnet/diagnostics#3516](https://github.com/dotnet/diagnostics/issues/3516) | DumpMT disabled in SOS.OtherCommands for .NET 7.0+ |
| [dotnet/diagnostics#3506](https://github.com/dotnet/diagnostics/issues/3506) | How to debug stack overflow errors on Windows |
| [dotnet/diagnostics#3482](https://github.com/dotnet/diagnostics/issues/3482) | !eeheap is reporting slightly inaccurate committed bytes. |
| [dotnet/diagnostics#3479](https://github.com/dotnet/diagnostics/issues/3479) | Timed out when dotnet-trace connects to a dotnet app |
| [dotnet/diagnostics#3395](https://github.com/dotnet/diagnostics/issues/3395) | Update SOS command docs with newly supported Linux/MacOS commands |
| [dotnet/diagnostics#3341](https://github.com/dotnet/diagnostics/issues/3341) | TFM trimming, and elimination of net4* targeting in Linux source-build |
| [dotnet/diagnostics#3331](https://github.com/dotnet/diagnostics/issues/3331) | Source-build behavior control update |
| [dotnet/diagnostics#3326](https://github.com/dotnet/diagnostics/issues/3326) | Specify all source-built dependencies and ensure they are regularly updated |
| [dotnet/diagnostics#3265](https://github.com/dotnet/diagnostics/issues/3265) | A few SOS commands fail on a Linux single-file app under lldb at process launch |
| [dotnet/diagnostics#3248](https://github.com/dotnet/diagnostics/issues/3248) | dotnet diagnostic tools benchmark tests need investigation |
| [dotnet/diagnostics#3155](https://github.com/dotnet/diagnostics/issues/3155) | Reenable eeversion tests in StackAndOtherTests/StackTests scripts when 7.0 dumps have version string |
| [dotnet/diagnostics#3137](https://github.com/dotnet/diagnostics/issues/3137) | dumpasync --methodtable result in error when parameter are not prefix with the 0x (hex) sign  |
| [dotnet/diagnostics#3131](https://github.com/dotnet/diagnostics/issues/3131) | dotnet-gcdump doesnt work with kubectl debug |
| [dotnet/diagnostics#3111](https://github.com/dotnet/diagnostics/issues/3111) | Reenable TestDbgEng tests in M.D.DebugServices.UnitTests |
| [dotnet/diagnostics#3078](https://github.com/dotnet/diagnostics/issues/3078) | Update docs: make required version of LLDB clear |
| [dotnet/diagnostics#2973](https://github.com/dotnet/diagnostics/issues/2973) | Dotnet-dump analyze shows "unknown" function name for my application symbols - public symbols resolve  |
| [dotnet/diagnostics#2947](https://github.com/dotnet/diagnostics/issues/2947) | sos commands `eestack` & `dumpstack` crashed with .net 7.0 |
| [dotnet/diagnostics#2911](https://github.com/dotnet/diagnostics/issues/2911) | Guidance on using PerfView/other perf visualization tools. |
| [dotnet/diagnostics#2905](https://github.com/dotnet/diagnostics/issues/2905) | Diagnosing managed memory leaks with dotnet-gcdump. |
| [dotnet/diagnostics#2903](https://github.com/dotnet/diagnostics/issues/2903) | E2E guide how to collect a dump and debug it with VS or LLDB |
| [dotnet/diagnostics#2841](https://github.com/dotnet/diagnostics/issues/2841) | dotnet-gcdump collect: System.Exception: Read past end of stream |
| [dotnet/diagnostics#2323](https://github.com/dotnet/diagnostics/issues/2323) | **\<OUT OF SLA\>** dotnet-counters in Azure Kudu/Console. |
| [dotnet/diagnostics#1942](https://github.com/dotnet/diagnostics/issues/1942) | **\<OUT OF SLA\>** [macos] Shipping dotnet-* tools unsigned  |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#80767](https://github.com/dotnet/runtime/issues/80767) | Test failure tracing/runtimeeventsource/nativeruntimeeventsource/nativeruntimeeventsource.sh |
| [dotnet/runtime#78006](https://github.com/dotnet/runtime/issues/78006) | NRE in System.Diagnostics.Tracing.EventPipePayloadDecoder if Threading event keywords are enabled. |
| [dotnet/runtime#61353](https://github.com/dotnet/runtime/issues/61353) | **\<OUT OF SLA\>** EventCounters unexpectedly stop reporting data when first of two listeners disconnects |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#80555](https://github.com/dotnet/runtime/issues/80555) | Obsolete constructor public StackTrace(Thread targetThread, bool needFileInfo) |
| [dotnet/runtime#77945](https://github.com/dotnet/runtime/issues/77945) | Stopwatch.GetTimestamp() doesn't take into account sleep time on Unix |
| [dotnet/runtime#66734](https://github.com/dotnet/runtime/issues/66734) | Stopwatch is inconsistent when guarding against negative Elapsed durations |

## v1,1-dotnet/runtime|area-System.Diagnostics.Metric

Issues in query: 1

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#79916](https://github.com/dotnet/runtime/issues/79916) | `MetricsEventSource` Not Publishing `UpDownCounter` For `dotnet-counters`/`dotnet-monitor`? |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#80684](https://github.com/dotnet/runtime/issues/80684) | No-op EventListener + idle Web app = 190 MB/h native memory leak |
| [dotnet/runtime#80666](https://github.com/dotnet/runtime/issues/80666) | tracing/eventpipe/eventsourceerror/eventsourceerror/eventsourceerror failure |
| [dotnet/runtime#80064](https://github.com/dotnet/runtime/issues/80064) | PublishSingleFile=true + EventListener causes EventPipeEventDispatcher.DispatchEventsToEventListeners() to fully occupy a CPU core |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 20

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#80550](https://github.com/dotnet/runtime/issues/80550) | NET7 macOS: Missing dSYM files for libcoreclr (and others) |
| [dotnet/runtime#80280](https://github.com/dotnet/runtime/issues/80280) | Build breaks in profiling samples |
| [dotnet/runtime#79919](https://github.com/dotnet/runtime/issues/79919) | Unable to unwind exception on Xunit |
| [dotnet/runtime#79852](https://github.com/dotnet/runtime/issues/79852) | [macOS] cannot debug / stop at breakpoints when app sandbox is enabled |
| [dotnet/runtime#78991](https://github.com/dotnet/runtime/issues/78991) | NullReferenceException when you use the short format of string.format $"{sample}" |
| [dotnet/runtime#78940](https://github.com/dotnet/runtime/issues/78940) | Debugging execution code in vs is slow, but the program is compiled and runs fine |
| [dotnet/runtime#78421](https://github.com/dotnet/runtime/issues/78421) | VSMac Crash Reports Missing Frames |
| [dotnet/runtime#78282](https://github.com/dotnet/runtime/issues/78282) | Cross architecture CLRDEBUGINFO<host_os><host_arch> resource missing on windows coreclr |
| [dotnet/runtime#77574](https://github.com/dotnet/runtime/issues/77574) | .NET Debugging services don't issue thread create callbacks for single file apps |
| [dotnet/runtime#76702](https://github.com/dotnet/runtime/issues/76702) | [EnC] FieldInfo.GetValue on a newly-added ValueType field crashes CoreCLR |
| [dotnet/runtime#75821](https://github.com/dotnet/runtime/issues/75821) | Test failure profiler\\gc\\gcbasic\\gcbasic.cmd |
| [dotnet/runtime#75581](https://github.com/dotnet/runtime/issues/75581) | Diagnostic port suspension message doesn't report expected port name |
| [dotnet/runtime#72603](https://github.com/dotnet/runtime/issues/72603) | Debugger fails to attach to a specific application with CORDBG_E_MISSING_DEBUGGER_EXPORTS on macOS. |
| [dotnet/runtime#72202](https://github.com/dotnet/runtime/issues/72202) | Null dereferencing makes AccessViolationException under certain condition. |
| [dotnet/runtime#71786](https://github.com/dotnet/runtime/issues/71786) | Linux perf support regressed on W^X enabled runs |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#69380](https://github.com/dotnet/runtime/issues/69380) | createdump on AKS + Linux doesn't work correctly unless running in a shell |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | Application crash while stepping into if 'justMyCode' is disabled |
| [dotnet/runtime#64765](https://github.com/dotnet/runtime/issues/64765) | profiler.multiple failing on MacOS 12.0 |
