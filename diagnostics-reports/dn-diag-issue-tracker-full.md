# .NET Diagnostics Report Full Report - 02/19/2024 06:14:19

Total issues: 57

## v1,1-dotnet/diagnostics

Issues in query: 21

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#4491](https://github.com/dotnet/diagnostics/issues/4491) | Better document the difference between `DumpType.Normal` and `DumpType.Triage` |
| [dotnet/diagnostics#4484](https://github.com/dotnet/diagnostics/issues/4484) | CLRMD floods logs with `EnumerateStackRoots found an entry with Object == 0, addr:73664ff040 srcType:0` while enumerating root paths for core dump created under linux |
| [dotnet/diagnostics#4464](https://github.com/dotnet/diagnostics/issues/4464) | Access Denied (5) |
| [dotnet/diagnostics#4446](https://github.com/dotnet/diagnostics/issues/4446) | Crashing attempting to call `dumplog` |
| [dotnet/diagnostics#4430](https://github.com/dotnet/diagnostics/issues/4430) | Can't analyze dump of arm64ec process |
| [dotnet/diagnostics#4415](https://github.com/dotnet/diagnostics/issues/4415) | dotnet-counters long value rendered format |
| [dotnet/diagnostics#4375](https://github.com/dotnet/diagnostics/issues/4375) | dotnet-dump not working when process run as user |
| [dotnet/diagnostics#4314](https://github.com/dotnet/diagnostics/issues/4314) | !clrstack reports incorrect method names when <> is encountered |
| [dotnet/diagnostics#4506](https://github.com/dotnet/diagnostics/issues/4506) | dotnet trace convert causes a crash on s390x |
| [dotnet/diagnostics#4259](https://github.com/dotnet/diagnostics/issues/4259) | libsosplugin cannot be loaded into lldb (macos arm64) |
| [dotnet/diagnostics#4191](https://github.com/dotnet/diagnostics/issues/4191) | Fix Microsoft.Diagnostics.NETCore.Client.PerMapTests.GenerateAllTest and GeneratePerfMapTest for 8.0 |
| [dotnet/diagnostics#4171](https://github.com/dotnet/diagnostics/issues/4171) | Please document CorGCReferenceType::CorHandleWeakWinRT |
| [dotnet/diagnostics#4150](https://github.com/dotnet/diagnostics/issues/4150) | Document how to use createdump on native AOT apps |
| [dotnet/diagnostics#4139](https://github.com/dotnet/diagnostics/issues/4139) | How to debug memory leak that is not clear on dotnet-dump? |
| [dotnet/diagnostics#4086](https://github.com/dotnet/diagnostics/issues/4086) | LLDB sos commands don't write output to SBCommandReturnObject |
| [dotnet/diagnostics#4002](https://github.com/dotnet/diagnostics/issues/4002) | Update docs: Linux dump analysis in a Windows environment |
| [dotnet/diagnostics#3974](https://github.com/dotnet/diagnostics/issues/3974) | Q: what does it mean when `verifyheap` reports heap errors? |
| [dotnet/diagnostics#3935](https://github.com/dotnet/diagnostics/issues/3935) | `dotnet-trace collect` hangs without completing collection on Linux |
| [dotnet/diagnostics#3882](https://github.com/dotnet/diagnostics/issues/3882) | Add newer Ubuntu images to testing workflows. |
| [dotnet/diagnostics#3774](https://github.com/dotnet/diagnostics/issues/3774) | Re-enable !gcroot source tests |
| [dotnet/diagnostics#3506](https://github.com/dotnet/diagnostics/issues/3506) | **\<OUT OF SLA\>** How to debug stack overflow errors on Windows |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#98270](https://github.com/dotnet/runtime/issues/98270) | dotnet command hangs on two out of three Linux systems (possible deadlock in LTTNG) |
| [dotnet/runtime#91687](https://github.com/dotnet/runtime/issues/91687) | CoreCLR clretwallmain.h contains DotNETRuntimeMonoProfiler events |
| [dotnet/runtime#88011](https://github.com/dotnet/runtime/issues/88011) | NativeRuntimeEventSource behaving poorly in conjunction with other providers |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 2

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#98499](https://github.com/dotnet/runtime/issues/98499) | `DiagnosticSource` Filtering Behaviour |
| [dotnet/runtime#91191](https://github.com/dotnet/runtime/issues/91191) | [API Proposal]: An attribute to indicate boxed value type is not expected for certain API |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 8

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#96968](https://github.com/dotnet/runtime/issues/96968) | Test failure BasicEventSourceTests.TestsUserErrors.Test_BadEventSource_MismatchedIds_WithEtwListener |
| [dotnet/runtime#96324](https://github.com/dotnet/runtime/issues/96324) | Debug.Assert exception I encountered when using Debug version System.Private.CoreLib.dll with mono runtime |
| [dotnet/runtime#96219](https://github.com/dotnet/runtime/issues/96219) | Potential Deadlock When Disposing EventListeners Concurrently |
| [dotnet/runtime#94964](https://github.com/dotnet/runtime/issues/94964) | How to debug code that is being compiled in layers? I have the following problem |
| [dotnet/runtime#91304](https://github.com/dotnet/runtime/issues/91304) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |
| [dotnet/runtime#88567](https://github.com/dotnet/runtime/issues/88567) | Port System.Diagnostics documentation for .NET 8.0 APIs |
| [dotnet/runtime#88305](https://github.com/dotnet/runtime/issues/88305) | Test failure BasicEventSourceTests.TestsWrite.Test_Write_T_ETW |
| [dotnet/runtime#88027](https://github.com/dotnet/runtime/issues/88027) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 23

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#98506](https://github.com/dotnet/runtime/issues/98506) | Excessive exceptions generated in StackTraceSymbols when using Portable PDB |
| [dotnet/runtime#98500](https://github.com/dotnet/runtime/issues/98500) | Unhandled exception. System.Exception: Profilee returned exit code 139 instead of expected exit code 100 |
| [dotnet/runtime#98359](https://github.com/dotnet/runtime/issues/98359) | Debugging With Primary Constructor |
| [dotnet/runtime#97765](https://github.com/dotnet/runtime/issues/97765) | WriteXorExecute is not working in combination with PerfMaps |
| [dotnet/runtime#97175](https://github.com/dotnet/runtime/issues/97175) | C# program stops at wrong line after IndexOutOfRangeException |
| [dotnet/runtime#95417](https://github.com/dotnet/runtime/issues/95417) | ExecutionEngineException on using step into while debugging |
| [dotnet/runtime#95189](https://github.com/dotnet/runtime/issues/95189) | vsdbg quits when resuming from a breakpoint if stepping over a line that throws an exception  |
| [dotnet/runtime#95167](https://github.com/dotnet/runtime/issues/95167) | Crash in DoStackSnapshot. |
| [dotnet/runtime#91631](https://github.com/dotnet/runtime/issues/91631) | No compatiable code running on the thread |
| [dotnet/runtime#90563](https://github.com/dotnet/runtime/issues/90563) | Lock contention in StackTrace/Exception.ToString() |
| [dotnet/runtime#90359](https://github.com/dotnet/runtime/issues/90359) | [External] Libunwind has suppressed warnings  |
| [dotnet/runtime#90079](https://github.com/dotnet/runtime/issues/90079) | Deadlock between debugger and class loading in PGO |
| [dotnet/runtime#89592](https://github.com/dotnet/runtime/issues/89592) | Debugger assert during register mapping |
| [dotnet/runtime#88463](https://github.com/dotnet/runtime/issues/88463) | DoStackSnapshot behaves differently on Windows x86 and x64 WRT stack unwinding |
| [dotnet/runtime#87418](https://github.com/dotnet/runtime/issues/87418) | `RequestReJITWithInliners` doesn't always trigger a rejit without `COR_PRF_MONITOR_JIT_COMPILATION` enabled |
| [dotnet/runtime#85777](https://github.com/dotnet/runtime/issues/85777) | Segfault in CMiniMdTemplate<CMiniMdRW>::getSignatureOfMemberRef |
| [dotnet/runtime#83967](https://github.com/dotnet/runtime/issues/83967) | [CoreCLR Linux arm32] `ICorDebugStackWalk` works wrong in case top frame is native. |
| [dotnet/runtime#82422](https://github.com/dotnet/runtime/issues/82422) | [Linux, amd64] ICorDebugEval::Abort are broken. |
| [dotnet/runtime#79852](https://github.com/dotnet/runtime/issues/79852) | **\<OUT OF SLA\>** [macOS] cannot debug / stop at breakpoints when app sandbox is enabled |
| [dotnet/runtime#78991](https://github.com/dotnet/runtime/issues/78991) | **\<OUT OF SLA\>** NullReferenceException when you use the short format of string.format $"{sample}" when debugging .NET 7 on x64 macOS |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | **\<OUT OF SLA\>** dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | **\<OUT OF SLA\>** Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | **\<OUT OF SLA\>** Application crash while stepping into if 'justMyCode' is disabled |

