# .NET Diagnostics Report Full Report - 08/19/2024 06:18:31

Total issues: 79

## v1,1-dotnet/diagnostics

Issues in query: 36

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#4856](https://github.com/dotnet/diagnostics/issues/4856) | GCDump requires client-side symbol lookup for native AOT |
| [dotnet/diagnostics#4850](https://github.com/dotnet/diagnostics/issues/4850) | DumpIL SOS command does not properly handle DynamicMethods in .NET Core |
| [dotnet/diagnostics#4847](https://github.com/dotnet/diagnostics/issues/4847) | Latest NET 9 runtime causes EventCounterPipelineUnitTests.TestCounterEventPipeline test to fail |
| [dotnet/diagnostics#4843](https://github.com/dotnet/diagnostics/issues/4843) | CreateCounter can create corruptable counter |
| [dotnet/diagnostics#4826](https://github.com/dotnet/diagnostics/issues/4826) | dotnet stack hangup on trying to get the stackframes of a stuck process |
| [dotnet/diagnostics#4814](https://github.com/dotnet/diagnostics/issues/4814) | DumpStackObjects doesn't seem to work if the thread is on the alternate signal stack |
| [dotnet/diagnostics#4806](https://github.com/dotnet/diagnostics/issues/4806) | Docs/test updates/migration guidance for new runtime metrics in dotnet-counters |
| [dotnet/diagnostics#4803](https://github.com/dotnet/diagnostics/issues/4803) | dotnet dump analyze threadpool fails to obtain threadpool data  |
| [dotnet/diagnostics#4795](https://github.com/dotnet/diagnostics/issues/4795) | Update GCInfo deserializer once https://github.com/dotnet/runtime/pull/104336 merges |
| [dotnet/diagnostics#4782](https://github.com/dotnet/diagnostics/issues/4782) | [Test] Microsoft.Diagnostics.Monitoring.EventPipe.UnitTests.EventCounterTriggerWithEventPipePipelineTest fails intermittently  |
| [dotnet/diagnostics#4779](https://github.com/dotnet/diagnostics/issues/4779) |  dotnet-dump analyze does not work on M3 macOS |
| [dotnet/diagnostics#4757](https://github.com/dotnet/diagnostics/issues/4757) | [test failure] TestCounterMonitorSystemRuntimeMetricsCSV intermittently fails: System.IO.EndOfStreamException : Attempted to read past the end of the stream. |
| [dotnet/diagnostics#4769](https://github.com/dotnet/diagnostics/issues/4769) | Crash when debugging with lldb on MacOS |
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
| [dotnet/diagnostics#4150](https://github.com/dotnet/diagnostics/issues/4150) | **\<OUT OF SLA\>** Document how to use createdump on native AOT apps |
| [dotnet/diagnostics#4825](https://github.com/dotnet/diagnostics/issues/4825) | **\<OUT OF SLA\>** NativeRuntimeEventSource behaving poorly in conjunction with other providers |
| [dotnet/diagnostics#3506](https://github.com/dotnet/diagnostics/issues/3506) | **\<OUT OF SLA\>** How to debug stack overflow errors on Windows |
| [dotnet/diagnostics#2541](https://github.com/dotnet/diagnostics/issues/2541) | **\<OUT OF SLA\>** TestLogsAllCategoriesDefaultLevelFallback fails frequently |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 5

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#105682](https://github.com/dotnet/runtime/issues/105682) | Deadlock in System.Diagnostics.Tracing.FrameworkEventSource on application startup |
| [dotnet/runtime#104670](https://github.com/dotnet/runtime/issues/104670) | BinderTracingTest.ResolutionFlow times out |
| [dotnet/runtime#102572](https://github.com/dotnet/runtime/issues/102572) | It is not possible to pass the ID of the garbage collection when the .NET provider is enabled with the GCHeapCollect(0x800000) keyword |
| [dotnet/runtime#102004](https://github.com/dotnet/runtime/issues/102004) | MemoryAllocatedForJitCode ETW Event missing in trace, but CLRStackWalk still fires |
| [dotnet/runtime#91687](https://github.com/dotnet/runtime/issues/91687) | CoreCLR clretwallmain.h contains DotNETRuntimeMonoProfiler events |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 2

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#105808](https://github.com/dotnet/runtime/issues/105808) | [Help] [RISC-V] GC crash on System.Diagnostics.Tests.DiagnosticSourceTest.AllSubscriberStress |
| [dotnet/runtime#91191](https://github.com/dotnet/runtime/issues/91191) | [API Proposal]: An attribute to indicate boxed value type is not expected for certain API |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 6

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#106087](https://github.com/dotnet/runtime/issues/106087) | [Tracing] EventProvider Disposal hangs within a callback |
| [dotnet/runtime#106462](https://github.com/dotnet/runtime/issues/106462) | [mono][Perf] `Microsoft.Extensions.Logging.EventSourceLogger.NestedScopes_TwoMessages` regressions on 3/5/2024 8:17:11 PM |
| [dotnet/runtime#99274](https://github.com/dotnet/runtime/issues/99274) | EventAttribute Message not showing in ETW events |
| [dotnet/runtime#96968](https://github.com/dotnet/runtime/issues/96968) | Test failure BasicEventSourceTests.TestsUserErrors.Test_BadEventSource_MismatchedIds_WithEtwListener |
| [dotnet/runtime#96219](https://github.com/dotnet/runtime/issues/96219) | Potential Deadlock When Disposing EventListeners Concurrently |
| [dotnet/runtime#93175](https://github.com/dotnet/runtime/issues/93175) | Deadlock in ThreadPool.GetMaxThreads() during app start. |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 21

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#106543](https://github.com/dotnet/runtime/issues/106543) | ICorProfilerCallback GC related behavior changed in CoreCLR 8.0? |
| [dotnet/runtime#106243](https://github.com/dotnet/runtime/issues/106243) | Test failure: profiler/transitions/transitions/transitions.sh |
| [dotnet/runtime#106241](https://github.com/dotnet/runtime/issues/106241) | Test failure: profiler\\assembly\\ALCTest\\ALCTest.cmd |
| [dotnet/runtime#106194](https://github.com/dotnet/runtime/issues/106194) | PosixSignalRegistration.Create hangs debugger on MacOS (Rider & VSCode) |
| [dotnet/runtime#106148](https://github.com/dotnet/runtime/issues/106148) | [DAC][ReJIT] ReJitManager::IsReJITEnabled checked DOTNET_ProfAPI_RejitOnAttach in the wrong environment |
| [dotnet/runtime#106104](https://github.com/dotnet/runtime/issues/106104) | Process silently exits after patching self-contained app with Debug bits when specific breakpoints are set |
| [dotnet/runtime#105712](https://github.com/dotnet/runtime/issues/105712) | Identification of JIT generated functions by their address |
| [dotnet/runtime#105690](https://github.com/dotnet/runtime/issues/105690) | Quality of native perf profiling on x64 |
| [dotnet/runtime#105132](https://github.com/dotnet/runtime/issues/105132) | Unmanaged memory growth with DiagnosticsClient |
| [dotnet/runtime#104459](https://github.com/dotnet/runtime/issues/104459) | App crashes with an output "Trace/Breakpoint Trap" on Linux when a P/Invoke callback is called from a native library if the dotnet debugger is attached. |
| [dotnet/runtime#103955](https://github.com/dotnet/runtime/issues/103955) | Debugger Crashes when using breakpoints with a compiled runtime in debug mode _CrtlsValidHeapPointer(block) |
| [dotnet/runtime#102767](https://github.com/dotnet/runtime/issues/102767) | Patch skipping crashing in functions marked with [UnmanagedCallersOnly] |
| [dotnet/runtime#101310](https://github.com/dotnet/runtime/issues/101310) | coreclr + vsdbg failure to get stack trace from remote Kubernetes pod |
| [dotnet/runtime#99487](https://github.com/dotnet/runtime/issues/99487) | CLR_GCHEAPCOLLECT_KEYWORD triggers a GC twice |
| [dotnet/runtime#95417](https://github.com/dotnet/runtime/issues/95417) | ExecutionEngineException on using step into while debugging |
| [dotnet/runtime#90563](https://github.com/dotnet/runtime/issues/90563) | **\<OUT OF SLA\>** Lock contention in StackTrace/Exception.ToString() |
| [dotnet/runtime#90079](https://github.com/dotnet/runtime/issues/90079) | **\<OUT OF SLA\>** Avalonia calling into the runtime after shut down |
| [dotnet/runtime#74271](https://github.com/dotnet/runtime/issues/74271) | **\<OUT OF SLA\>** [CET Debugging] User mode APC's on Windows x64 with CET enabled can cause a debug session to crash  |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | **\<OUT OF SLA\>** dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | **\<OUT OF SLA\>** Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | **\<OUT OF SLA\>** Application crash while stepping into if 'justMyCode' is disabled |

## v1,1-dotnet/runtime|area-Debugger-mono

Issues in query: 4

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#106470](https://github.com/dotnet/runtime/issues/106470) | Problem with hitting breakpoints while using Firefox or Firefox Developer Edition in InteractiveWebAssembly render mode, but no issues when using Microsoft Edge or Google Chrome. |
| [dotnet/runtime#106376](https://github.com/dotnet/runtime/issues/106376) | 'chrome-DebuggerTests.ExceptionTests' timing out |
| [dotnet/runtime#101554](https://github.com/dotnet/runtime/issues/101554) | Blazor client side web debugging fails to function when run within IIS |
| [dotnet/runtime#91197](https://github.com/dotnet/runtime/issues/91197) | Blazor Standalone WASM - Debugging Breaks after OIDC Authentication |

## v1,1-dotnet/runtime|area-Diagnostics-mono

Issues in query: 5

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#106064](https://github.com/dotnet/runtime/issues/106064) | [mono][ios] Mono prevents crash logs from being generated in case `SIGSEGV` is raised from native code |
| [dotnet/runtime#97209](https://github.com/dotnet/runtime/issues/97209) | [Android] Application crashes when an exception is thrown after running a System.Diagnostics.Process |
| [dotnet/runtime#93551](https://github.com/dotnet/runtime/issues/93551) | [wasm] run browser-bench sample with https connection |
| [dotnet/runtime#91197](https://github.com/dotnet/runtime/issues/91197) | Blazor Standalone WASM - Debugging Breaks after OIDC Authentication |
| [dotnet/runtime#91049](https://github.com/dotnet/runtime/issues/91049) | Blazor - WebAssembly `build_id` section |

## v1,1-dotnet/runtime|area-System.Diagnostics-mono

Issues in query: 0

## v1,1-dotnet/runtime|area-Tracing-mono

Issues in query: 0

