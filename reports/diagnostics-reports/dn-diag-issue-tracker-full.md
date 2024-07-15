# .NET Diagnostics Report Full Report - 07/15/2024 06:18:28

Total issues: 83

## v1,1-dotnet/diagnostics

Issues in query: 32

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#4782](https://github.com/dotnet/diagnostics/issues/4782) | [Test] Microsoft.Diagnostics.Monitoring.EventPipe.UnitTests.EventCounterTriggerWithEventPipePipelineTest fails intermittently  |
| [dotnet/diagnostics#4779](https://github.com/dotnet/diagnostics/issues/4779) |  dotnet-dump analyze does not work on M3 macOS |
| [dotnet/diagnostics#4771](https://github.com/dotnet/diagnostics/issues/4771) | Write dump failed - HRESULT: 0x00000000 with nothing in service stdout |
| [dotnet/diagnostics#4757](https://github.com/dotnet/diagnostics/issues/4757) | [test failure] TestCounterMonitorSystemRuntimeMetricsCSV intermittently fails: System.IO.EndOfStreamException : Attempted to read past the end of the stream. |
| [dotnet/diagnostics#4769](https://github.com/dotnet/diagnostics/issues/4769) | Crash when debugging with lldb on MacOS |
| [dotnet/diagnostics#4718](https://github.com/dotnet/diagnostics/issues/4718) | [Test] TestLogsUseAppFiltersAndFilterSpecs fails with `Assert.Equal() Failure` |
| [dotnet/diagnostics#4717](https://github.com/dotnet/diagnostics/issues/4717) | [Test] StartEventPipeSessionWithoutStackwalkTestAsync fails with ServerNotAvailableException |
| [dotnet/diagnostics#4655](https://github.com/dotnet/diagnostics/issues/4655) | [test] Method not found Xunit.Sdk.XunitException..ctor |
| [dotnet/diagnostics#4654](https://github.com/dotnet/diagnostics/issues/4654) | [SOS][tests] OtherCommands(config: projectk.sdk.prebuilt*) VerifyOutput: no last command output or debugger exited unexpectedly |
| [dotnet/diagnostics#4646](https://github.com/dotnet/diagnostics/issues/4646) | dotnet-counters not showing metric names |
| [dotnet/diagnostics#4564](https://github.com/dotnet/diagnostics/issues/4564) | dotnet-counters does not report values from multiple Metrics Meters with distinct tags |
| [dotnet/diagnostics#4563](https://github.com/dotnet/diagnostics/issues/4563) | Error: No CLR runtime found (dump collected with 8.0.0) |
| [dotnet/diagnostics#4557](https://github.com/dotnet/diagnostics/issues/4557) | Timeout while executing StartEventPipeSession |
| [dotnet/diagnostics#4524](https://github.com/dotnet/diagnostics/issues/4524) | dotnet-dsrouter and dotnet-gcdump doc needed when default port is occupied |
| [dotnet/diagnostics#4522](https://github.com/dotnet/diagnostics/issues/4522) | Unexpected error in .NET Core 3.1 when running "Collect metrics" sample from MS documentation |
| [dotnet/diagnostics#4491](https://github.com/dotnet/diagnostics/issues/4491) | Better document the difference between `DumpType.Normal` and `DumpType.Triage` |
| [dotnet/diagnostics#4484](https://github.com/dotnet/diagnostics/issues/4484) | CLRMD floods logs with `EnumerateStackRoots found an entry with Object == 0, addr:73664ff040 srcType:0` while enumerating root paths for core dump created under linux |
| [dotnet/diagnostics#4446](https://github.com/dotnet/diagnostics/issues/4446) | Crashing attempting to call `dumplog` |
| [dotnet/diagnostics#4430](https://github.com/dotnet/diagnostics/issues/4430) | Can't analyze dump of arm64ec process |
| [dotnet/diagnostics#4415](https://github.com/dotnet/diagnostics/issues/4415) | dotnet-counters long value rendered format |
| [dotnet/diagnostics#4375](https://github.com/dotnet/diagnostics/issues/4375) | dotnet-dump not working when process run as user |
| [dotnet/diagnostics#4314](https://github.com/dotnet/diagnostics/issues/4314) | !clrstack reports incorrect method names when <> is encountered |
| [dotnet/diagnostics#4259](https://github.com/dotnet/diagnostics/issues/4259) | libsosplugin cannot be loaded into lldb (macos arm64) |
| [dotnet/diagnostics#4191](https://github.com/dotnet/diagnostics/issues/4191) | Fix Microsoft.Diagnostics.NETCore.Client.PerMapTests.GenerateAllTest and GeneratePerfMapTest for 8.0 |
| [dotnet/diagnostics#4171](https://github.com/dotnet/diagnostics/issues/4171) | Please document CorGCReferenceType::CorHandleWeakWinRT |
| [dotnet/diagnostics#4150](https://github.com/dotnet/diagnostics/issues/4150) | Document how to use createdump on native AOT apps |
| [dotnet/diagnostics#4139](https://github.com/dotnet/diagnostics/issues/4139) | How to debug memory leak that is not clear on dotnet-dump? |
| [dotnet/diagnostics#4086](https://github.com/dotnet/diagnostics/issues/4086) | LLDB sos commands don't write output to SBCommandReturnObject |
| [dotnet/diagnostics#4002](https://github.com/dotnet/diagnostics/issues/4002) | **\<OUT OF SLA\>** Update docs: Linux dump analysis in a Windows environment |
| [dotnet/diagnostics#3935](https://github.com/dotnet/diagnostics/issues/3935) | **\<OUT OF SLA\>** `dotnet-trace collect` hangs without completing collection on Linux |
| [dotnet/diagnostics#3506](https://github.com/dotnet/diagnostics/issues/3506) | **\<OUT OF SLA\>** How to debug stack overflow errors on Windows |
| [dotnet/diagnostics#2541](https://github.com/dotnet/diagnostics/issues/2541) | **\<OUT OF SLA\>** TestLogsAllCategoriesDefaultLevelFallback fails frequently |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 7

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#104670](https://github.com/dotnet/runtime/issues/104670) | BinderTracingTest.ResolutionFlow times out |
| [dotnet/runtime#102572](https://github.com/dotnet/runtime/issues/102572) | It is not possible to pass the ID of the garbage collection when the .NET provider is enabled with the GCHeapCollect(0x800000) keyword |
| [dotnet/runtime#102004](https://github.com/dotnet/runtime/issues/102004) | MemoryAllocatedForJitCode ETW Event missing in trace, but CLRStackWalk still fires |
| [dotnet/runtime#101764](https://github.com/dotnet/runtime/issues/101764) | Malformed EventPipe request can crash the runtime |
| [dotnet/runtime#99497](https://github.com/dotnet/runtime/issues/99497) | Assert in CounterGroup.OnEventSourceCommand after trying to run BDN x86 |
| [dotnet/runtime#91687](https://github.com/dotnet/runtime/issues/91687) | CoreCLR clretwallmain.h contains DotNETRuntimeMonoProfiler events |
| [dotnet/runtime#88011](https://github.com/dotnet/runtime/issues/88011) | **\<OUT OF SLA\>** NativeRuntimeEventSource behaving poorly in conjunction with other providers |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 1

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#91191](https://github.com/dotnet/runtime/issues/91191) | [API Proposal]: An attribute to indicate boxed value type is not expected for certain API |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 10

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#103480](https://github.com/dotnet/runtime/issues/103480) | Crash when disposing an EventListener during shutdown |
| [dotnet/runtime#102197](https://github.com/dotnet/runtime/issues/102197) | EventSource event with 4 string parameters with null values behaves inconsistent in .NET 8 |
| [dotnet/runtime#99816](https://github.com/dotnet/runtime/issues/99816) | Higher Memory Usage for the EventSource Class |
| [dotnet/runtime#99274](https://github.com/dotnet/runtime/issues/99274) | EventAttribute Message not showing in ETW events |
| [dotnet/runtime#96968](https://github.com/dotnet/runtime/issues/96968) | Test failure BasicEventSourceTests.TestsUserErrors.Test_BadEventSource_MismatchedIds_WithEtwListener |
| [dotnet/runtime#96219](https://github.com/dotnet/runtime/issues/96219) | Potential Deadlock When Disposing EventListeners Concurrently |
| [dotnet/runtime#94964](https://github.com/dotnet/runtime/issues/94964) | How to debug code that is being compiled in layers? I have the following problem |
| [dotnet/runtime#93175](https://github.com/dotnet/runtime/issues/93175) | Deadlock in ThreadPool.GetMaxThreads() during app start. |
| [dotnet/runtime#88027](https://github.com/dotnet/runtime/issues/88027) | **\<OUT OF SLA\>** Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |
| [dotnet/runtime#80666](https://github.com/dotnet/runtime/issues/80666) | **\<OUT OF SLA\>** tracing/eventpipe/eventsourceerror/eventsourceerror/eventsourceerror failure |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 22

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#104459](https://github.com/dotnet/runtime/issues/104459) | App crashes with an output "Trace/Breakpoint Trap" on Linux when a P/Invoke callback is called from a native library if the dotnet debugger is attached. |
| [dotnet/runtime#104256](https://github.com/dotnet/runtime/issues/104256) | Dump file not created when process crashes |
| [dotnet/runtime#103955](https://github.com/dotnet/runtime/issues/103955) | Debugger Crashes when using breakpoints with a compiled runtime in debug mode _CrtlsValidHeapPointer(block) |
| [dotnet/runtime#103872](https://github.com/dotnet/runtime/issues/103872) | WER handler is broken |
| [dotnet/runtime#103000](https://github.com/dotnet/runtime/issues/103000) | Environment variable DOTNET_DbgEnableMiniDump=1 doens't work when unhandled exception occurs in worker thread |
| [dotnet/runtime#102767](https://github.com/dotnet/runtime/issues/102767) | Patch skipping crashing in functions marked with [UnmanagedCallersOnly] |
| [dotnet/runtime#101310](https://github.com/dotnet/runtime/issues/101310) | coreclr + vsdbg failure to get stack trace from remote Kubernetes pod |
| [dotnet/runtime#99487](https://github.com/dotnet/runtime/issues/99487) | CLR_GCHEAPCOLLECT_KEYWORD triggers a GC twice |
| [dotnet/runtime#98654](https://github.com/dotnet/runtime/issues/98654) | System.IO.IOException: ' Received an unexpected EOF or 0 bytes from the transport stream.' |
| [dotnet/runtime#98506](https://github.com/dotnet/runtime/issues/98506) | Excessive exceptions generated in StackTraceSymbols when using Portable PDB |
| [dotnet/runtime#95417](https://github.com/dotnet/runtime/issues/95417) | ExecutionEngineException on using step into while debugging |
| [dotnet/runtime#95189](https://github.com/dotnet/runtime/issues/95189) | vsdbg quits when resuming from a breakpoint if stepping over a line that throws an exception  |
| [dotnet/runtime#90563](https://github.com/dotnet/runtime/issues/90563) | Lock contention in StackTrace/Exception.ToString() |
| [dotnet/runtime#90359](https://github.com/dotnet/runtime/issues/90359) | [External] Libunwind has suppressed warnings  |
| [dotnet/runtime#90079](https://github.com/dotnet/runtime/issues/90079) | Deadlock between debugger and class loading in PGO |
| [dotnet/runtime#88463](https://github.com/dotnet/runtime/issues/88463) | **\<OUT OF SLA\>** DoStackSnapshot behaves differently on Windows x86 and x64 WRT stack unwinding |
| [dotnet/runtime#87418](https://github.com/dotnet/runtime/issues/87418) | **\<OUT OF SLA\>** `RequestReJITWithInliners` doesn't always trigger a rejit without `COR_PRF_MONITOR_JIT_COMPILATION` enabled |
| [dotnet/runtime#79852](https://github.com/dotnet/runtime/issues/79852) | **\<OUT OF SLA\>** [macOS] cannot debug / stop at breakpoints when app sandbox is enabled |
| [dotnet/runtime#74271](https://github.com/dotnet/runtime/issues/74271) | **\<OUT OF SLA\>** [CET Debugging] User mode APC's on Windows x64 with CET enabled can cause a debug session to crash  |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | **\<OUT OF SLA\>** dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | **\<OUT OF SLA\>** Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | **\<OUT OF SLA\>** Application crash while stepping into if 'justMyCode' is disabled |

## v1,1-dotnet/runtime|area-Debugger-mono

Issues in query: 6

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#104234](https://github.com/dotnet/runtime/issues/104234) | DEBUGGING IS NOT ENABLED when trying to debug .NET 8 Blazor Web project simulating iOS device on edge |
| [dotnet/runtime#104231](https://github.com/dotnet/runtime/issues/104231) | Blazor webassembly does not hit breakpoints on <select> bindings |
| [dotnet/runtime#101554](https://github.com/dotnet/runtime/issues/101554) | Blazor client side web debugging fails to function when run within IIS |
| [dotnet/runtime#99007](https://github.com/dotnet/runtime/issues/99007) | [.NET 8] [android] case where Mono debugger doesn't "break" correctly on unhandled exceptions |
| [dotnet/runtime#91631](https://github.com/dotnet/runtime/issues/91631) | No compatiable code running on the thread |
| [dotnet/runtime#91197](https://github.com/dotnet/runtime/issues/91197) | Blazor Standalone WASM - Debugging Breaks after OIDC Authentication |

## v1,1-dotnet/runtime|area-Diagnostics-mono

Issues in query: 4

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#97209](https://github.com/dotnet/runtime/issues/97209) | [Android] Application crashes when an exception is thrown after running a System.Diagnostics.Process |
| [dotnet/runtime#94114](https://github.com/dotnet/runtime/issues/94114) | EventPipe Doesn't Work On OSX With Sandbox Enabled |
| [dotnet/runtime#93551](https://github.com/dotnet/runtime/issues/93551) | [wasm] run browser-bench sample with https connection |
| [dotnet/runtime#91197](https://github.com/dotnet/runtime/issues/91197) | Blazor Standalone WASM - Debugging Breaks after OIDC Authentication |

## v1,1-dotnet/runtime|area-System.Diagnostics-mono

Issues in query: 0

## v1,1-dotnet/runtime|area-Tracing-mono

Issues in query: 1

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#89621](https://github.com/dotnet/runtime/issues/89621) | EventPipe shutdown race condition in .net7/.net6 |

