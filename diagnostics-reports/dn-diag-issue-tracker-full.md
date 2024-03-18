# .NET Diagnostics Report Full Report - 03/18/2024 06:14:15

Total issues: 98

## v1,1-dotnet/diagnostics

Issues in query: 27

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#4555](https://github.com/dotnet/diagnostics/issues/4555) | "No CLR runtime found" analyzing Linux .NET 6.0.26 crash dump |
| [dotnet/diagnostics#4551](https://github.com/dotnet/diagnostics/issues/4551) | libsosplugin.dylib: CoreCLR host crash on macOS Sonoma 14.4 on arm64 |
| [dotnet/diagnostics#4542](https://github.com/dotnet/diagnostics/issues/4542) | dotnet trace not working for MAUI application using EF Core |
| [dotnet/diagnostics#4524](https://github.com/dotnet/diagnostics/issues/4524) | dotnet-dsrouter and dotnet-gcdump doc needed when default port is occupied |
| [dotnet/diagnostics#4522](https://github.com/dotnet/diagnostics/issues/4522) | Unexpected error in .NET Core 3.1 when running "Collect metrics" sample from MS documentation |
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
| [dotnet/diagnostics#2921](https://github.com/dotnet/diagnostics/issues/2921) | **\<OUT OF SLA\>** SDL signoff requirements - please enable additional C/C++ compiler warnings |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 4

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#99497](https://github.com/dotnet/runtime/issues/99497) | Assert in CounterGroup.OnEventSourceCommand after trying to run BDN x86 |
| [dotnet/runtime#94390](https://github.com/dotnet/runtime/issues/94390) | Test failure Loader/binding/tracing/BinderTracingTest.ResolutionFlow/BinderTracingTest.ResolutionFlow.cmd |
| [dotnet/runtime#91687](https://github.com/dotnet/runtime/issues/91687) | CoreCLR clretwallmain.h contains DotNETRuntimeMonoProfiler events |
| [dotnet/runtime#88011](https://github.com/dotnet/runtime/issues/88011) | NativeRuntimeEventSource behaving poorly in conjunction with other providers |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 1

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#91191](https://github.com/dotnet/runtime/issues/91191) | [API Proposal]: An attribute to indicate boxed value type is not expected for certain API |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 9

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#99816](https://github.com/dotnet/runtime/issues/99816) | Higher Memory Usage for the EventSource Class |
| [dotnet/runtime#99274](https://github.com/dotnet/runtime/issues/99274) | EventAttribute Message not showing in ETW events |
| [dotnet/runtime#96968](https://github.com/dotnet/runtime/issues/96968) | Test failure BasicEventSourceTests.TestsUserErrors.Test_BadEventSource_MismatchedIds_WithEtwListener |
| [dotnet/runtime#96324](https://github.com/dotnet/runtime/issues/96324) | Debug.Assert exception I encountered when using Debug version System.Private.CoreLib.dll with mono runtime |
| [dotnet/runtime#96219](https://github.com/dotnet/runtime/issues/96219) | Potential Deadlock When Disposing EventListeners Concurrently |
| [dotnet/runtime#94964](https://github.com/dotnet/runtime/issues/94964) | How to debug code that is being compiled in layers? I have the following problem |
| [dotnet/runtime#91304](https://github.com/dotnet/runtime/issues/91304) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |
| [dotnet/runtime#88567](https://github.com/dotnet/runtime/issues/88567) | Port System.Diagnostics documentation for .NET 8.0 APIs |
| [dotnet/runtime#88027](https://github.com/dotnet/runtime/issues/88027) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 22

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#99487](https://github.com/dotnet/runtime/issues/99487) | CLR_GCHEAPCOLLECT_KEYWORD triggers a GC twice |
| [dotnet/runtime#99471](https://github.com/dotnet/runtime/issues/99471) | SDL signoff requirements - enable MSVC warnings C4242 and C4244 (libunwind) |
| [dotnet/runtime#98654](https://github.com/dotnet/runtime/issues/98654) | System.IO.IOException: ' Received an unexpected EOF or 0 bytes from the transport stream.' |
| [dotnet/runtime#98506](https://github.com/dotnet/runtime/issues/98506) | Excessive exceptions generated in StackTraceSymbols when using Portable PDB |
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
| [dotnet/runtime#82422](https://github.com/dotnet/runtime/issues/82422) | **\<OUT OF SLA\>** [Linux, amd64] ICorDebugEval::Abort are broken. |
| [dotnet/runtime#79852](https://github.com/dotnet/runtime/issues/79852) | **\<OUT OF SLA\>** [macOS] cannot debug / stop at breakpoints when app sandbox is enabled |
| [dotnet/runtime#78991](https://github.com/dotnet/runtime/issues/78991) | **\<OUT OF SLA\>** NullReferenceException when you use the short format of string.format $"{sample}" when debugging .NET 7 on x64 macOS |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | **\<OUT OF SLA\>** dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | **\<OUT OF SLA\>** Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | **\<OUT OF SLA\>** Application crash while stepping into if 'justMyCode' is disabled |

## v1,1-dotnet/runtime|area-Debugger-mono

Issues in query: 24

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#99686](https://github.com/dotnet/runtime/issues/99686) | [wasm] CreateGoodBreakpointAndHit failure |
| [dotnet/runtime#99007](https://github.com/dotnet/runtime/issues/99007) | [.NET 8] [android] case where Mono debugger doesn't "break" correctly on unhandled exceptions |
| [dotnet/runtime#98771](https://github.com/dotnet/runtime/issues/98771) | [browser][MT] Debugger timeout with deputy thread |
| [dotnet/runtime#98215](https://github.com/dotnet/runtime/issues/98215) | [wasm][debugger] Chrome test failure `DebuggerTests.SteppingTests.SteppingIntoLibrarySymbolsLoadedFromSymbolServerRemoveSymbolServerAndStepAgain` |
| [dotnet/runtime#98208](https://github.com/dotnet/runtime/issues/98208) | Blazor WASM "Debug Adapter" fail to handle breakpoints when a Web Worker is present |
| [dotnet/runtime#98086](https://github.com/dotnet/runtime/issues/98086) | [browser][debugger] Firefox EvaluateOnCallFrame2Tests |
| [dotnet/runtime#97652](https://github.com/dotnet/runtime/issues/97652) | [wasm][mt] Debugger test is using blocking calls in JS interop thread |
| [dotnet/runtime#97198](https://github.com/dotnet/runtime/issues/97198) | [blazor][debugger] Unable to debug in lazy loaded assemblies with remote authentication failed |
| [dotnet/runtime#96734](https://github.com/dotnet/runtime/issues/96734) | [browser][debugger] Cannot set breakpoint in partial class defined in separate files |
| [dotnet/runtime#96137](https://github.com/dotnet/runtime/issues/96137) | Debugging With InteractiveAuto When Changes To Webassembly |
| [dotnet/runtime#95943](https://github.com/dotnet/runtime/issues/95943) | [wasm] `DebuggerTests.ExceptionTests.ExceptionTestAllWithReload` failing with `Expected to only pause because of an exception.` |
| [dotnet/runtime#95401](https://github.com/dotnet/runtime/issues/95401) | [browser][nodejs] Start app with debugging for console template  |
| [dotnet/runtime#95209](https://github.com/dotnet/runtime/issues/95209) | Debugging Blazor application freezes Chrome (and Edge) |
| [dotnet/runtime#93973](https://github.com/dotnet/runtime/issues/93973) | [debugger][mono][codespaces] Debug Blazor app from Codespaces |
| [dotnet/runtime#93971](https://github.com/dotnet/runtime/issues/93971) | [wasm][debugger] Show correct datatypes for int, long, double |
| [dotnet/runtime#93615](https://github.com/dotnet/runtime/issues/93615) | [Mono] [Debug] VS Code debugger for Mono does not attach  |
| [dotnet/runtime#91773](https://github.com/dotnet/runtime/issues/91773) | [wasm][debugger] Timeout waiting for CheckInspectLocalsAtBreakpointSite  |
| [dotnet/runtime#91197](https://github.com/dotnet/runtime/issues/91197) | Blazor Standalone WASM - Debugging Breaks after OIDC Authentication |
| [dotnet/runtime#89909](https://github.com/dotnet/runtime/issues/89909) | [wasm] `DebuggerTests.MiscTests.DebuggerTests.MiscTests.TestDebugUsingMultiThreadedRuntime` failing |
| [dotnet/runtime#89700](https://github.com/dotnet/runtime/issues/89700) | [wasm][debugger] NRE seen in proxy when loading symbols from symbol server |
| [dotnet/runtime#89409](https://github.com/dotnet/runtime/issues/89409) | [wasm][debugger] Debugger tests getting randomly aborted on CI |
| [dotnet/runtime#86496](https://github.com/dotnet/runtime/issues/86496) | [debugger][mono] Multithreading debugger failures |
| [dotnet/runtime#84086](https://github.com/dotnet/runtime/issues/84086) | Blazor WASM project will not debug if index.html file  includes some scripts with crossorigin |
| [dotnet/runtime#75013](https://github.com/dotnet/runtime/issues/75013) | **\<OUT OF SLA\>** WASM CI failure in `DebuggerTests.EvaluateOnCallFrameTests.InheritedAndPrivateMembersInAClass` |

## v1,1-dotnet/runtime|area-Diagnostics-mono

Issues in query: 9

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#99609](https://github.com/dotnet/runtime/issues/99609) | mono_os_mutex_destroy: pthread_mutex_destroy failed with "Device or resource busy" |
| [dotnet/runtime#97209](https://github.com/dotnet/runtime/issues/97209) | [Android] Application crashes when an exception is thrown after running a System.Diagnostics.Process |
| [dotnet/runtime#97097](https://github.com/dotnet/runtime/issues/97097) | [.NET8 + WebAssembly] Debugging experience still is far from being 'OK' |
| [dotnet/runtime#94114](https://github.com/dotnet/runtime/issues/94114) | EventPipe Doesn't Work On OSX With Sandbox Enabled |
| [dotnet/runtime#93551](https://github.com/dotnet/runtime/issues/93551) | [wasm] run browser-bench sample with https connection |
| [dotnet/runtime#91197](https://github.com/dotnet/runtime/issues/91197) | Blazor Standalone WASM - Debugging Breaks after OIDC Authentication |
| [dotnet/runtime#85960](https://github.com/dotnet/runtime/issues/85960) | Intermittend failures in ThreadPoolTests on Mono Linux ARM64 |
| [dotnet/runtime#82492](https://github.com/dotnet/runtime/issues/82492) | **\<OUT OF SLA\>** Stop using select in the Mono profiler |
| [dotnet/runtime#48849](https://github.com/dotnet/runtime/issues/48849) | **\<OUT OF SLA\>** Investigate why StackFrameHelperTest Trimming test fails on mono |

## v1,1-dotnet/runtime|area-System.Diagnostics-mono

Issues in query: 0

## v1,1-dotnet/runtime|area-Tracing-mono

Issues in query: 2

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#89621](https://github.com/dotnet/runtime/issues/89621) | EventPipe shutdown race condition in .net7/.net6 |
| [dotnet/runtime#82396](https://github.com/dotnet/runtime/issues/82396) | **\<OUT OF SLA\>** Run low level EventPipe and container type native tests on CI. |

