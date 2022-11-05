# .NET Diagnostics Report - 11/05/2022 01:48:57

## Overall Stats

**Current total**: 50
**New**: 50
**Closed**: 0
**Moved In**: 0
**Moved Out** 0

## New Issues

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#3494](https://github.com/dotnet/diagnostics/issues/3494) | Please offer native version for macOS Arm64 |
| [dotnet/diagnostics#3482](https://github.com/dotnet/diagnostics/issues/3482) | !eeheap is reporting slightly inaccurate committed bytes. |
| [dotnet/diagnostics#3479](https://github.com/dotnet/diagnostics/issues/3479) | Timed out when dotnet-trace connects to a dotnet app |
| [dotnet/diagnostics#3451](https://github.com/dotnet/diagnostics/issues/3451) | Improve distributed tracing doc |
| [dotnet/diagnostics#3401](https://github.com/dotnet/diagnostics/issues/3401) | dotnet-dump collect process crash. Unable to read beyond the end of the stream. |
| [dotnet/diagnostics#3395](https://github.com/dotnet/diagnostics/issues/3395) | Update SOS command docs with newly supported Linux/MacOS commands |
| [dotnet/diagnostics#3341](https://github.com/dotnet/diagnostics/issues/3341) | TFM trimming, and elimination of net4* targeting in Linux source-build |
| [dotnet/diagnostics#3331](https://github.com/dotnet/diagnostics/issues/3331) | Source-build behavior control update |
| [dotnet/diagnostics#3326](https://github.com/dotnet/diagnostics/issues/3326) | Specify all source-built dependencies and ensure they are regularly updated |
| [dotnet/diagnostics#3265](https://github.com/dotnet/diagnostics/issues/3265) | A few SOS commands fail on a Linux single-file app under lldb at process launch |
| [dotnet/diagnostics#3248](https://github.com/dotnet/diagnostics/issues/3248) | dotnet diagnostic tools benchmark tests need investigation |
| [dotnet/diagnostics#3155](https://github.com/dotnet/diagnostics/issues/3155) | Reenable eeversion tests in StackAndOtherTests/StackTests scripts when 7.0 dumps have version string |
| [dotnet/diagnostics#3137](https://github.com/dotnet/diagnostics/issues/3137) | dumpasync --methodtable result in error when parameter are not prefix with the 0x (hex) sign  |
| [dotnet/diagnostics#3131](https://github.com/dotnet/diagnostics/issues/3131) | dotnet-gcdump doesnt work with kubectl debug |
| [dotnet/diagnostics#3126](https://github.com/dotnet/diagnostics/issues/3126) | Reenable SOS "bpmd" on 7.0 once the windbg breakpoint issue on W^X is fixed |
| [dotnet/diagnostics#3111](https://github.com/dotnet/diagnostics/issues/3111) | Reenable TestDbgEng tests in M.D.DebugServices.UnitTests |
| [dotnet/diagnostics#3078](https://github.com/dotnet/diagnostics/issues/3078) | Update docs: make required version of LLDB clear |
| [dotnet/diagnostics#3065](https://github.com/dotnet/diagnostics/issues/3065) | dotnet-dump "mini" dumps do not include enough data to debug single file dumps |
| [dotnet/diagnostics#3059](https://github.com/dotnet/diagnostics/issues/3059) | Cleanup Module.GetPEInfo() functions |
| [dotnet/diagnostics#2973](https://github.com/dotnet/diagnostics/issues/2973) | Dotnet-dump analyze shows "unknown" function name for my application symbols - public symbols resolve  |
| [dotnet/diagnostics#2947](https://github.com/dotnet/diagnostics/issues/2947) | sos commands `eestack` & `dumpstack` crashed with .net 7.0 |
| [dotnet/diagnostics#2922](https://github.com/dotnet/diagnostics/issues/2922) | LLDB expression causes MacOS app to crash (only when LLDB was attached) |
| [dotnet/diagnostics#2905](https://github.com/dotnet/diagnostics/issues/2905) | Diagnosing managed memory leaks with dotnet-gcdump. |
| [dotnet/diagnostics#2903](https://github.com/dotnet/diagnostics/issues/2903) | E2E guide how to collect a dump and debug it with VS or LLDB |
| [dotnet/diagnostics#2841](https://github.com/dotnet/diagnostics/issues/2841) | dotnet-gcdump collect: System.Exception: Read past end of stream |
| [dotnet/diagnostics#2323](https://github.com/dotnet/diagnostics/issues/2323) | dotnet-counters in Azure Kudu/Console. |
| [dotnet/runtime#76430](https://github.com/dotnet/runtime/issues/76430) | EventPipe sessions can leak the EventPipeThreadSessionState* associated with them |
| [dotnet/runtime#61353](https://github.com/dotnet/runtime/issues/61353) | EventCounters unexpectedly stop reporting data when first of two listeners disconnects |
| [dotnet/runtime#66734](https://github.com/dotnet/runtime/issues/66734) | Stopwatch is inconsistent when guarding against negative Elapsed durations |
| [dotnet/runtime#44986](https://github.com/dotnet/runtime/issues/44986) | StackTrace reports incorrect line number from catch and finally blocks when running on X64 |
| [dotnet/runtime#77922](https://github.com/dotnet/runtime/issues/77922) | Enable logging for the DAC build |
| [dotnet/runtime#77574](https://github.com/dotnet/runtime/issues/77574) | .NET Debugging services don't issue thread create callbacks for single file apps |
| [dotnet/runtime#77523](https://github.com/dotnet/runtime/issues/77523) | Launch Without Debugging Doesn't Block BackgroundService and Whole App but Debug Does |
| [dotnet/runtime#76702](https://github.com/dotnet/runtime/issues/76702) | [EnC] FieldInfo.GetValue on a newly-added ValueType field crashes CoreCLR |
| [dotnet/runtime#75821](https://github.com/dotnet/runtime/issues/75821) | Test failure profiler\\gc\\gcbasic\\gcbasic.cmd |
| [dotnet/runtime#75641](https://github.com/dotnet/runtime/issues/75641) | !CREATE_CHECK_STRING(!"Detected use of a corrupted OB   JECTREF. Possible GC hole.") running tests under VS debugger |
| [dotnet/runtime#75581](https://github.com/dotnet/runtime/issues/75581) | Diagnostic port suspension message doesn't report expected port name |
| [dotnet/runtime#74271](https://github.com/dotnet/runtime/issues/74271) | [CET Debugging] User mode APC's on Windows x64 with CET enabled can cause a debug session to crash  |
| [dotnet/runtime#73718](https://github.com/dotnet/runtime/issues/73718) | illegal read of byte preceding an automatic (stack allocate) variable |
| [dotnet/runtime#72603](https://github.com/dotnet/runtime/issues/72603) | Debugger fails to attach to a specific application with CORDBG_E_MISSING_DEBUGGER_EXPORTS on macOS. |
| [dotnet/runtime#72202](https://github.com/dotnet/runtime/issues/72202) | Null dereferencing makes AccessViolationException under certain condition. |
| [dotnet/runtime#71786](https://github.com/dotnet/runtime/issues/71786) | Linux perf support regressed on W^X enabled runs |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#70541](https://github.com/dotnet/runtime/issues/70541) | SIGSEGV Coredump From Interop Debugging In VSCode |
| [dotnet/runtime#69380](https://github.com/dotnet/runtime/issues/69380) | createdump on AKS + Linux doesn't work correctly unless running in a shell |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | Application crash while stepping into if 'justMyCode' is disabled |
| [dotnet/runtime#67605](https://github.com/dotnet/runtime/issues/67605) | [release/6.0] Test failure: profiler/multiple/multiple/multiple.sh |
| [dotnet/runtime#57962](https://github.com/dotnet/runtime/issues/57962) | RuntimeIdentifiers stack trace issue |
| [dotnet/runtime#46093](https://github.com/dotnet/runtime/issues/46093) | Failed To Create CoreCLR |
| [dotnet/runtime#42296](https://github.com/dotnet/runtime/issues/42296) | createdump doesn't always add the special version string to coredumps |

## Closed Issues

| **Issue Number** | **Title** |
| :--------------: | --------- |

## Moved Issues

| **Issue Number** | **Title** |
| :--------------: | --------- |

## Removed Issues

| **Issue Number** | **Title** |
| :--------------: | --------- |

