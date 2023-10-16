# .NET Diagnostics Report Full Report - 10/16/2023 06:14:29

Total issues: 66

## v1,1-dotnet/diagnostics

Issues in query: 22

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#4315](https://github.com/dotnet/diagnostics/issues/4315) | When initializing SOS, `coreclr_initialize` sometimes fails with HR `0x80131022`, leading to "Unrecognized command" error for managed commands |
| [dotnet/diagnostics#4314](https://github.com/dotnet/diagnostics/issues/4314) | !clrstack reports incorrect method names when <> is encountered |
| [dotnet/diagnostics#4259](https://github.com/dotnet/diagnostics/issues/4259) | libsosplugin cannot be loaded into lldb (macos arm64) |
| [dotnet/diagnostics#4191](https://github.com/dotnet/diagnostics/issues/4191) | Fix Microsoft.Diagnostics.NETCore.Client.PerMapTests.GenerateAllTest and GeneratePerfMapTest for 8.0 |
| [dotnet/diagnostics#4171](https://github.com/dotnet/diagnostics/issues/4171) | Please document CorGCReferenceType::CorHandleWeakWinRT |
| [dotnet/diagnostics#4150](https://github.com/dotnet/diagnostics/issues/4150) | Document how to use createdump on native AOT apps |
| [dotnet/diagnostics#4139](https://github.com/dotnet/diagnostics/issues/4139) | How to debug memory leak that is not clear on dotnet-dump? |
| [dotnet/diagnostics#4086](https://github.com/dotnet/diagnostics/issues/4086) | LLDB sos commands don't write output to SBCommandReturnObject |
| [dotnet/diagnostics#4058](https://github.com/dotnet/diagnostics/issues/4058) | dotnet-dsrouter not connecting on iOS - "Failed connecting 9191 over usbmux, wait 500 ms before retrying." |
| [dotnet/diagnostics#4002](https://github.com/dotnet/diagnostics/issues/4002) | Update docs: Linux dump analysis in a Windows environment |
| [dotnet/diagnostics#3974](https://github.com/dotnet/diagnostics/issues/3974) | Q: what does it mean when `verifyheap` reports heap errors? |
| [dotnet/diagnostics#3935](https://github.com/dotnet/diagnostics/issues/3935) | `dotnet-trace collect` hangs without completing collection on Linux |
| [dotnet/diagnostics#3905](https://github.com/dotnet/diagnostics/issues/3905) | `timestamp` for `dotnet counters` in JSON Formatted Incorrectly |
| [dotnet/diagnostics#3882](https://github.com/dotnet/diagnostics/issues/3882) | Add newer Ubuntu images to testing workflows. |
| [dotnet/diagnostics#3809](https://github.com/dotnet/diagnostics/issues/3809) | DiagnosticPort docs incorrectly claim support of multiple listen ports |
| [dotnet/diagnostics#3797](https://github.com/dotnet/diagnostics/issues/3797) | Counters tool doc - specify counter |
| [dotnet/diagnostics#3774](https://github.com/dotnet/diagnostics/issues/3774) | Re-enable !gcroot source tests |
| [dotnet/diagnostics#3900](https://github.com/dotnet/diagnostics/issues/3900) | Missing symbols for only dotnet code |
| [dotnet/diagnostics#3506](https://github.com/dotnet/diagnostics/issues/3506) | How to debug stack overflow errors on Windows |
| [dotnet/diagnostics#3479](https://github.com/dotnet/diagnostics/issues/3479) | Timed out when dotnet-trace connects to a dotnet app |
| [dotnet/diagnostics#3331](https://github.com/dotnet/diagnostics/issues/3331) | **\<OUT OF SLA\>** Source-build behavior control update |
| [dotnet/diagnostics#4099](https://github.com/dotnet/diagnostics/issues/4099) | **\<OUT OF SLA\>** NativeAOT crash dumps bucket all user exceptions as APPLICATION_FAULT |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 4

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#92734](https://github.com/dotnet/runtime/issues/92734) | SampleProfiler EventPipe provider support for .net 8 Native AOT  |
| [dotnet/runtime#91687](https://github.com/dotnet/runtime/issues/91687) | CoreCLR clretwallmain.h contains DotNETRuntimeMonoProfiler events |
| [dotnet/runtime#90052](https://github.com/dotnet/runtime/issues/90052) | Adding a new listener to EventPipeEventDispatcher temporarily stops emitting events for existing sessions |
| [dotnet/runtime#88011](https://github.com/dotnet/runtime/issues/88011) | NativeRuntimeEventSource behaving poorly in conjunction with other providers |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 2

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#91191](https://github.com/dotnet/runtime/issues/91191) | [API Proposal]: An attribute to indicate boxed value type is not expected for certain API |
| [dotnet/runtime#80783](https://github.com/dotnet/runtime/issues/80783) | Would for some tests system wide profiling be a good thing?  |

## v1,1-dotnet/runtime|area-System.Diagnostics.Metric

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#93097](https://github.com/dotnet/runtime/issues/93097) | MetricEventSource value published events don't resolve which scope they are refering to |
| [dotnet/runtime#91591](https://github.com/dotnet/runtime/issues/91591) | System.Diagnostics.Metrics.LastValue looks like it could experience torn reads |
| [dotnet/runtime#88567](https://github.com/dotnet/runtime/issues/88567) | Port System.Diagnostics documentation for .NET 8.0 APIs |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 8

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#93019](https://github.com/dotnet/runtime/issues/93019) | `.NET 9.0` Native Trace Instrumentation Support for HttpClient as per OTel specification |
| [dotnet/runtime#92519](https://github.com/dotnet/runtime/issues/92519) | Sometimes `testhost/CoreRun` crashes with `System.Diagnostics.Tracing`-related assertion failure |
| [dotnet/runtime#91769](https://github.com/dotnet/runtime/issues/91769) | Test failure BasicEventSourceTests.TestsWrite.Test_Write_T_ETW |
| [dotnet/runtime#91304](https://github.com/dotnet/runtime/issues/91304) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |
| [dotnet/runtime#90433](https://github.com/dotnet/runtime/issues/90433) | Clean up ifdefs in EventSource |
| [dotnet/runtime#88305](https://github.com/dotnet/runtime/issues/88305) | Test failure BasicEventSourceTests.TestsWrite.Test_Write_T_ETW |
| [dotnet/runtime#88027](https://github.com/dotnet/runtime/issues/88027) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |
| [dotnet/runtime#84091](https://github.com/dotnet/runtime/issues/84091) | Process crash on simultaneous call of EventListener.DisposeOnShutdown() and EventListener.EnableEvents() |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 27

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#92615](https://github.com/dotnet/runtime/issues/92615) | EE skips static field initialization when scope references collection literals |
| [dotnet/runtime#91963](https://github.com/dotnet/runtime/issues/91963) | `RequestReJITWithInliners` silently fails for debug modules if `COMPLUS_ForceEnc` is enabled |
| [dotnet/runtime#91631](https://github.com/dotnet/runtime/issues/91631) | No compatiable code running on the thread |
| [dotnet/runtime#90563](https://github.com/dotnet/runtime/issues/90563) | Lock contention in StackTrace/Exception.ToString() |
| [dotnet/runtime#90547](https://github.com/dotnet/runtime/issues/90547) | Createdump will incorrectly try to classify memfd entries as files |
| [dotnet/runtime#90500](https://github.com/dotnet/runtime/issues/90500) | ARM64 unwinder missing support for pac_sign_lr |
| [dotnet/runtime#90359](https://github.com/dotnet/runtime/issues/90359) | [External] Libunwind has suppressed warnings  |
| [dotnet/runtime#90079](https://github.com/dotnet/runtime/issues/90079) | Deadlock between debugger and class loading in PGO |
| [dotnet/runtime#89592](https://github.com/dotnet/runtime/issues/89592) | Debugger assert during register mapping |
| [dotnet/runtime#89292](https://github.com/dotnet/runtime/issues/89292) | Unable to break on callback from unmanaged thread |
| [dotnet/runtime#88924](https://github.com/dotnet/runtime/issues/88924) | `RequestReJITWithInliners` can cause an access violation and crash the application |
| [dotnet/runtime#88463](https://github.com/dotnet/runtime/issues/88463) | DoStackSnapshot behaves differently on Windows x86 and x64 WRT stack unwinding |
| [dotnet/runtime#87418](https://github.com/dotnet/runtime/issues/87418) | `RequestReJITWithInliners` doesn't always trigger a rejit without `COR_PRF_MONITOR_JIT_COMPILATION` enabled |
| [dotnet/runtime#85777](https://github.com/dotnet/runtime/issues/85777) | Segfault in CMiniMdTemplate<CMiniMdRW>::getSignatureOfMemberRef |
| [dotnet/runtime#84665](https://github.com/dotnet/runtime/issues/84665) | crashinfounix.cpp: unknown type name 'off64_t' on Alpine Linux |
| [dotnet/runtime#83967](https://github.com/dotnet/runtime/issues/83967) | [CoreCLR Linux arm32] `ICorDebugStackWalk` works wrong in case top frame is native. |
| [dotnet/runtime#83699](https://github.com/dotnet/runtime/issues/83699) | lldb dumpmt crashes against source-built .NET 7 on Fedora 37 |
| [dotnet/runtime#83419](https://github.com/dotnet/runtime/issues/83419) | exe file name gets truncated in .NET core mini dump name |
| [dotnet/runtime#82422](https://github.com/dotnet/runtime/issues/82422) | [Linux, amd64] ICorDebugEval::Abort are broken. |
| [dotnet/runtime#79852](https://github.com/dotnet/runtime/issues/79852) | [macOS] cannot debug / stop at breakpoints when app sandbox is enabled |
| [dotnet/runtime#79546](https://github.com/dotnet/runtime/issues/79546) | Last PInvoke error in LibraryImport may not be preserved after runtime internal calls |
| [dotnet/runtime#78991](https://github.com/dotnet/runtime/issues/78991) | NullReferenceException when you use the short format of string.format $"{sample}" when debugging .NET 7 on x64 macOS |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | **\<OUT OF SLA\>** dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | **\<OUT OF SLA\>** Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | **\<OUT OF SLA\>** Application crash while stepping into if 'justMyCode' is disabled |
| [dotnet/runtime#57962](https://github.com/dotnet/runtime/issues/57962) | **\<OUT OF SLA\>** Unwind info not published in growable function tables |
| [dotnet/runtime#11466](https://github.com/dotnet/runtime/issues/11466) | **\<OUT OF SLA\>** Poorly performing hash used in the DBI |

