# .NET Diagnostics Report Comparative Report - 07/29/2024 06:17:27

## Overall Stats

**Current total**: 74
**New**: 7
**Closed**: 12
**Moved In**: 0
**Moved Out** 2

## New Issues

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#4814](https://github.com/dotnet/diagnostics/issues/4814) | DumpStackObjects doesn't seem to work if the thread is on the alternate signal stack |
| [dotnet/diagnostics#4806](https://github.com/dotnet/diagnostics/issues/4806) | Docs/test updates/migration guidance for new runtime metrics in dotnet-counters |
| [dotnet/diagnostics#4803](https://github.com/dotnet/diagnostics/issues/4803) | dotnet dump analyze threadpool fails to obtain threadpool data  |
| [dotnet/runtime#105603](https://github.com/dotnet/runtime/issues/105603) | The `ICorProfilerInfo::GetModuleMetaData` function returns `CORPROF_E_UNSUPPORTED_CALL_SEQUENCE`, while another approach with `IMetaDataDispenserEx` works |
| [dotnet/runtime#105594](https://github.com/dotnet/runtime/issues/105594) | Hot Reload with a specific code structure throws `System.BadImageFormatException: An attempt was made to load a program with an incorrect format.` |
| [dotnet/runtime#105463](https://github.com/dotnet/runtime/issues/105463) | App is experiencing a freeze, probably due to GC suspending threads |
| [dotnet/runtime#105374](https://github.com/dotnet/runtime/issues/105374) | Debugger hits SIGSEGV in ShimStackWalk::StackWalkInfo::GetCurrentInternalFrame when .NET app throws exception |

## Closed Issues

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#4771](https://github.com/dotnet/diagnostics/issues/4771) | Write dump failed - HRESULT: 0x00000000 with nothing in service stdout |
| [dotnet/diagnostics#4718](https://github.com/dotnet/diagnostics/issues/4718) | [Test] TestLogsUseAppFiltersAndFilterSpecs fails with `Assert.Equal() Failure` |
| [dotnet/runtime#99497](https://github.com/dotnet/runtime/issues/99497) | Assert in CounterGroup.OnEventSourceCommand after trying to run BDN x86 |
| [dotnet/runtime#105213](https://github.com/dotnet/runtime/issues/105213) | Test failure: GC\\API\\WeakReference\\multipleWRs_1\\multipleWRs_1.cmd |
| [dotnet/runtime#94964](https://github.com/dotnet/runtime/issues/94964) | How to debug code that is being compiled in layers? I have the following problem |
| [dotnet/runtime#105225](https://github.com/dotnet/runtime/issues/105225) | Test failure: profiler\\assembly\\ALCTest\\ALCTest.cmd |
| [dotnet/runtime#105222](https://github.com/dotnet/runtime/issues/105222) | Test failure: Loader/classloader/TypeInitialization/Inlining/GenMethInlined/GenMethInlined.cmd |
| [dotnet/runtime#105116](https://github.com/dotnet/runtime/issues/105116) | x86 Interop Call stack incorrect when stopped in native exception filter |
| [dotnet/runtime#98506](https://github.com/dotnet/runtime/issues/98506) | Excessive exceptions generated in StackTraceSymbols when using Portable PDB |
| [dotnet/runtime#104231](https://github.com/dotnet/runtime/issues/104231) | Blazor webassembly does not hit breakpoints on <select> bindings |
| [dotnet/runtime#99007](https://github.com/dotnet/runtime/issues/99007) | [.NET 8] [android] case where Mono debugger doesn't "break" correctly on unhandled exceptions |
| [dotnet/runtime#91631](https://github.com/dotnet/runtime/issues/91631) | No compatiable code running on the thread |

## Moved In Issues

| **Issue Number** | **Title** |
| :--------------: | --------- |

## Removed Issues

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#4086](https://github.com/dotnet/diagnostics/issues/4086) | LLDB sos commands don't write output to SBCommandReturnObject |
| [dotnet/runtime#101764](https://github.com/dotnet/runtime/issues/101764) | Malformed EventPipe request can crash the runtime |

## Issues Out of Time SLA (12 months)

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#3506](https://github.com/dotnet/diagnostics/issues/3506) | How to debug stack overflow errors on Windows |
| [dotnet/diagnostics#2541](https://github.com/dotnet/diagnostics/issues/2541) | TestLogsAllCategoriesDefaultLevelFallback fails frequently |
| [dotnet/runtime#88011](https://github.com/dotnet/runtime/issues/88011) | NativeRuntimeEventSource behaving poorly in conjunction with other providers |
| [dotnet/runtime#80666](https://github.com/dotnet/runtime/issues/80666) | tracing/eventpipe/eventsourceerror/eventsourceerror/eventsourceerror failure |
| [dotnet/runtime#74271](https://github.com/dotnet/runtime/issues/74271) | [CET Debugging] User mode APC's on Windows x64 with CET enabled can cause a debug session to crash  |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | Application crash while stepping into if 'justMyCode' is disabled |

