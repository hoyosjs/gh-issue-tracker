# .NET Diagnostics Report Full Report - 05/06/2024 06:15:00

Total issues: 84

## v1,1-dotnet/diagnostics

Issues in query: 35

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#4647](https://github.com/dotnet/diagnostics/issues/4647) | dotnet-gcdump seem not reflect the memory usage of my dump |
| [dotnet/diagnostics#4646](https://github.com/dotnet/diagnostics/issues/4646) | dotnet-counters not showing metric names |
| [dotnet/diagnostics#4648](https://github.com/dotnet/diagnostics/issues/4648) | Error: Fail to create host ldelegate 80070002 |
| [dotnet/diagnostics#4637](https://github.com/dotnet/diagnostics/issues/4637) | `clrstack -f` shows no managed names with lldb in .NET 9 |
| [dotnet/diagnostics#4632](https://github.com/dotnet/diagnostics/issues/4632) | dotnet-dump :  "Can not load or initialize libmscordaccore.so" |
| [dotnet/diagnostics#4597](https://github.com/dotnet/diagnostics/issues/4597) | Clarify whether dotnet-counters can monitor .NET Framework app |
| [dotnet/diagnostics#4590](https://github.com/dotnet/diagnostics/issues/4590) | dotnet-sos for .NET 9 |
| [dotnet/diagnostics#4564](https://github.com/dotnet/diagnostics/issues/4564) | dotnet-counters does not report values from multiple Metrics Meters with distinct tags |
| [dotnet/diagnostics#4563](https://github.com/dotnet/diagnostics/issues/4563) | Error: No CLR runtime found (dump collected with 8.0.0) |
| [dotnet/diagnostics#4557](https://github.com/dotnet/diagnostics/issues/4557) | Timeout while executing StartEventPipeSession |
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
| [dotnet/diagnostics#3506](https://github.com/dotnet/diagnostics/issues/3506) | **\<OUT OF SLA\>** How to debug stack overflow errors on Windows |
| [dotnet/diagnostics#2921](https://github.com/dotnet/diagnostics/issues/2921) | **\<OUT OF SLA\>** SDL signoff requirements - please enable additional C/C++ compiler warnings |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 5

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#101764](https://github.com/dotnet/runtime/issues/101764) | Malformed EventPipe request can crash the runtime |
| [dotnet/runtime#101759](https://github.com/dotnet/runtime/issues/101759) | tracing/eventpipe/providervalidation/providervalidation/providervalidation.cmd test failure |
| [dotnet/runtime#99497](https://github.com/dotnet/runtime/issues/99497) | Assert in CounterGroup.OnEventSourceCommand after trying to run BDN x86 |
| [dotnet/runtime#91687](https://github.com/dotnet/runtime/issues/91687) | CoreCLR clretwallmain.h contains DotNETRuntimeMonoProfiler events |
| [dotnet/runtime#88011](https://github.com/dotnet/runtime/issues/88011) | NativeRuntimeEventSource behaving poorly in conjunction with other providers |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 1

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#91191](https://github.com/dotnet/runtime/issues/91191) | [API Proposal]: An attribute to indicate boxed value type is not expected for certain API |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 8

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#99816](https://github.com/dotnet/runtime/issues/99816) | Higher Memory Usage for the EventSource Class |
| [dotnet/runtime#99274](https://github.com/dotnet/runtime/issues/99274) | EventAttribute Message not showing in ETW events |
| [dotnet/runtime#96968](https://github.com/dotnet/runtime/issues/96968) | Test failure BasicEventSourceTests.TestsUserErrors.Test_BadEventSource_MismatchedIds_WithEtwListener |
| [dotnet/runtime#96219](https://github.com/dotnet/runtime/issues/96219) | Potential Deadlock When Disposing EventListeners Concurrently |
| [dotnet/runtime#94964](https://github.com/dotnet/runtime/issues/94964) | How to debug code that is being compiled in layers? I have the following problem |
| [dotnet/runtime#91304](https://github.com/dotnet/runtime/issues/91304) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |
| [dotnet/runtime#88567](https://github.com/dotnet/runtime/issues/88567) | Port System.Diagnostics documentation for .NET 8.0 APIs |
| [dotnet/runtime#88027](https://github.com/dotnet/runtime/issues/88027) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 26

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#101729](https://github.com/dotnet/runtime/issues/101729) | .NET 9: Unhandled exceptions in background threads reported with empty managed frames |
| [dotnet/runtime#101310](https://github.com/dotnet/runtime/issues/101310) | coreclr + vsdbg failure to get stack trace from remote Kubernetes pod |
| [dotnet/runtime#101035](https://github.com/dotnet/runtime/issues/101035) | Using Visual Studio for Managed Code |
| [dotnet/runtime#100826](https://github.com/dotnet/runtime/issues/100826) | Hot reload fails to flow generic constraints to the inherited class |
| [dotnet/runtime#100114](https://github.com/dotnet/runtime/issues/100114) | profiler\multiple test failed |
| [dotnet/runtime#100098](https://github.com/dotnet/runtime/issues/100098) | Assertion on rsthread.cpp:5902 taAmbient != NULL |
| [dotnet/runtime#99487](https://github.com/dotnet/runtime/issues/99487) | CLR_GCHEAPCOLLECT_KEYWORD triggers a GC twice |
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
| [dotnet/runtime#85777](https://github.com/dotnet/runtime/issues/85777) | **\<OUT OF SLA\>** Segfault in CMiniMdTemplate<CMiniMdRW>::getSignatureOfMemberRef |
| [dotnet/runtime#82422](https://github.com/dotnet/runtime/issues/82422) | **\<OUT OF SLA\>** [Linux, amd64] ICorDebugEval::Abort are broken. |
| [dotnet/runtime#79852](https://github.com/dotnet/runtime/issues/79852) | **\<OUT OF SLA\>** [macOS] cannot debug / stop at breakpoints when app sandbox is enabled |
| [dotnet/runtime#78991](https://github.com/dotnet/runtime/issues/78991) | **\<OUT OF SLA\>** NullReferenceException when you use the short format of string.format $"{sample}" when debugging .NET 7 on x64 macOS |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | **\<OUT OF SLA\>** dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | **\<OUT OF SLA\>** Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | **\<OUT OF SLA\>** Application crash while stepping into if 'justMyCode' is disabled |

## v1,1-dotnet/runtime|area-Debugger-mono

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#101554](https://github.com/dotnet/runtime/issues/101554) | Blazor client side web debugging fails to function when run within IIS |
| [dotnet/runtime#99007](https://github.com/dotnet/runtime/issues/99007) | [.NET 8] [android] case where Mono debugger doesn't "break" correctly on unhandled exceptions |
| [dotnet/runtime#91197](https://github.com/dotnet/runtime/issues/91197) | Blazor Standalone WASM - Debugging Breaks after OIDC Authentication |

## v1,1-dotnet/runtime|area-Diagnostics-mono

Issues in query: 5

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#97209](https://github.com/dotnet/runtime/issues/97209) | [Android] Application crashes when an exception is thrown after running a System.Diagnostics.Process |
| [dotnet/runtime#94114](https://github.com/dotnet/runtime/issues/94114) | EventPipe Doesn't Work On OSX With Sandbox Enabled |
| [dotnet/runtime#93551](https://github.com/dotnet/runtime/issues/93551) | [wasm] run browser-bench sample with https connection |
| [dotnet/runtime#91197](https://github.com/dotnet/runtime/issues/91197) | Blazor Standalone WASM - Debugging Breaks after OIDC Authentication |
| [dotnet/runtime#85960](https://github.com/dotnet/runtime/issues/85960) | Intermittend failures in ThreadPoolTests on Mono Linux ARM64 |

## v1,1-dotnet/runtime|area-System.Diagnostics-mono

Issues in query: 0

## v1,1-dotnet/runtime|area-Tracing-mono

Issues in query: 1

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#89621](https://github.com/dotnet/runtime/issues/89621) | EventPipe shutdown race condition in .net7/.net6 |

