# .NET Diagnostics Report Full Report - 10/21/2024 06:19:41

Total issues: 56

## v1,1-dotnet/diagnostics

Issues in query: 15

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#4814](https://github.com/dotnet/diagnostics/issues/4814) | DumpStackObjects doesn't seem to work if the thread is on the alternate signal stack |
| [dotnet/diagnostics#4795](https://github.com/dotnet/diagnostics/issues/4795) | Update GCInfo deserializer once https://github.com/dotnet/runtime/pull/104336 merges |
| [dotnet/diagnostics#4782](https://github.com/dotnet/diagnostics/issues/4782) | [Test] Microsoft.Diagnostics.Monitoring.EventPipe.UnitTests.EventCounterTriggerWithEventPipePipelineTest fails intermittently  |
| [dotnet/diagnostics#4779](https://github.com/dotnet/diagnostics/issues/4779) |  dotnet-dump analyze does not work on M3 macOS |
| [dotnet/diagnostics#4757](https://github.com/dotnet/diagnostics/issues/4757) | [test failure] TestCounterMonitorSystemRuntimeMetricsCSV intermittently fails: System.IO.EndOfStreamException : Attempted to read past the end of the stream. |
| [dotnet/diagnostics#4769](https://github.com/dotnet/diagnostics/issues/4769) | Crash when debugging with lldb on MacOS |
| [dotnet/diagnostics#4717](https://github.com/dotnet/diagnostics/issues/4717) | [Test] StartEventPipeSessionWithoutStackwalkTestAsync fails with ServerNotAvailableException |
| [dotnet/diagnostics#4655](https://github.com/dotnet/diagnostics/issues/4655) | [test] Method not found Xunit.Sdk.XunitException..ctor |
| [dotnet/diagnostics#4654](https://github.com/dotnet/diagnostics/issues/4654) | [SOS][tests] OtherCommands(config: projectk.sdk.prebuilt*) VerifyOutput: no last command output or debugger exited unexpectedly |
| [dotnet/diagnostics#4557](https://github.com/dotnet/diagnostics/issues/4557) | Timeout while executing StartEventPipeSession |
| [dotnet/diagnostics#4524](https://github.com/dotnet/diagnostics/issues/4524) | dotnet-dsrouter and dotnet-gcdump doc needed when default port is occupied |
| [dotnet/diagnostics#4484](https://github.com/dotnet/diagnostics/issues/4484) | CLRMD floods logs with `EnumerateStackRoots found an entry with Object == 0, addr:73664ff040 srcType:0` while enumerating root paths for core dump created under linux |
| [dotnet/diagnostics#4375](https://github.com/dotnet/diagnostics/issues/4375) | dotnet-dump not working when process run as user |
| [dotnet/diagnostics#4314](https://github.com/dotnet/diagnostics/issues/4314) | **\<OUT OF SLA\>** !clrstack reports incorrect method names when <> is encountered |
| [dotnet/diagnostics#4825](https://github.com/dotnet/diagnostics/issues/4825) | **\<OUT OF SLA\>** NativeRuntimeEventSource behaving poorly in conjunction with other providers |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#104670](https://github.com/dotnet/runtime/issues/104670) | BinderTracingTest.ResolutionFlow times out |
| [dotnet/runtime#102572](https://github.com/dotnet/runtime/issues/102572) | It is not possible to pass the ID of the garbage collection when the .NET provider is enabled with the GCHeapCollect(0x800000) keyword |
| [dotnet/runtime#102004](https://github.com/dotnet/runtime/issues/102004) | MemoryAllocatedForJitCode ETW Event missing in trace, but CLRStackWalk still fires |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 0

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 6

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#108919](https://github.com/dotnet/runtime/issues/108919) | Type initializer for CDSCollectionETWBCLProvider threw exception - NullReferenceException in InvokeStub_EventSourceAttribute.set_Guid |
| [dotnet/runtime#106890](https://github.com/dotnet/runtime/issues/106890) | Timeout in runtimeeventsource/nativeruntimeeventsource/nativeruntimeeventsource.cmd |
| [dotnet/runtime#106087](https://github.com/dotnet/runtime/issues/106087) | [Tracing] EventProvider Disposal hangs within a callback |
| [dotnet/runtime#99274](https://github.com/dotnet/runtime/issues/99274) | EventAttribute Message not showing in ETW events |
| [dotnet/runtime#96968](https://github.com/dotnet/runtime/issues/96968) | Test failure BasicEventSourceTests.TestsUserErrors.Test_BadEventSource_MismatchedIds_WithEtwListener |
| [dotnet/runtime#96219](https://github.com/dotnet/runtime/issues/96219) | Potential Deadlock When Disposing EventListeners Concurrently |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 20

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#108912](https://github.com/dotnet/runtime/issues/108912) | Runtime System.Private.CoreLib patches pdbs |
| [dotnet/runtime#108893](https://github.com/dotnet/runtime/issues/108893) | [Perf] Windows/x64: 2 Regressions on 10/9/2024 1:12:38 AM |
| [dotnet/runtime#108273](https://github.com/dotnet/runtime/issues/108273) | [Profiler] Duplicate `GarbageCollectionFinished` notification |
| [dotnet/runtime#107344](https://github.com/dotnet/runtime/issues/107344) | Issues with memory dumps and Single File App |
| [dotnet/runtime#106946](https://github.com/dotnet/runtime/issues/106946) | Test failure: profiler\\elt\\slowpatheltleave\\slowpatheltleave.cmd |
| [dotnet/runtime#106243](https://github.com/dotnet/runtime/issues/106243) | Test failure: profiler/transitions/transitions/transitions.sh |
| [dotnet/runtime#106241](https://github.com/dotnet/runtime/issues/106241) | Test failure: profiler\\assembly\\ALCTest\\ALCTest.cmd |
| [dotnet/runtime#106148](https://github.com/dotnet/runtime/issues/106148) | [DAC][ReJIT] ReJitManager::IsReJITEnabled checked DOTNET_ProfAPI_RejitOnAttach in the wrong environment |
| [dotnet/runtime#106104](https://github.com/dotnet/runtime/issues/106104) | Process silently exits after patching self-contained app with Debug bits when specific breakpoints are set |
| [dotnet/runtime#105690](https://github.com/dotnet/runtime/issues/105690) | Quality of native perf profiling on x64 |
| [dotnet/runtime#104459](https://github.com/dotnet/runtime/issues/104459) | App crashes with an output "Trace/Breakpoint Trap" on Linux when a P/Invoke callback is called from a native library if the dotnet debugger is attached. |
| [dotnet/runtime#102767](https://github.com/dotnet/runtime/issues/102767) | Patch skipping crashing in functions marked with [UnmanagedCallersOnly] |
| [dotnet/runtime#101310](https://github.com/dotnet/runtime/issues/101310) | coreclr + vsdbg failure to get stack trace from remote Kubernetes pod |
| [dotnet/runtime#99487](https://github.com/dotnet/runtime/issues/99487) | CLR_GCHEAPCOLLECT_KEYWORD triggers a GC twice |
| [dotnet/runtime#95417](https://github.com/dotnet/runtime/issues/95417) | ExecutionEngineException on using step into while debugging |
| [dotnet/runtime#90563](https://github.com/dotnet/runtime/issues/90563) | **\<OUT OF SLA\>** Lock contention in StackTrace/Exception.ToString() |
| [dotnet/runtime#90079](https://github.com/dotnet/runtime/issues/90079) | **\<OUT OF SLA\>** Avalonia calling into the runtime after shut down |
| [dotnet/runtime#87574](https://github.com/dotnet/runtime/issues/87574) | **\<OUT OF SLA\>** [EnC] CoreCLR assertion in System.Reflection.Metadata.ApplyUpdateTest.TestGenericAddStaticField |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | **\<OUT OF SLA\>** dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | **\<OUT OF SLA\>** Application crash while stepping into if 'justMyCode' is disabled |

## v1,1-dotnet/runtime|area-Debugger-mono

Issues in query: 5

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#109025](https://github.com/dotnet/runtime/issues/109025) | [debugger] Inspector exceptions in debugger tests |
| [dotnet/runtime#108078](https://github.com/dotnet/runtime/issues/108078) | `chrome-DebuggerTests` timing out |
| [dotnet/runtime#108072](https://github.com/dotnet/runtime/issues/108072) | [wasm] DebuggerTests.Inspector.OpenSessionAsync |
| [dotnet/runtime#106376](https://github.com/dotnet/runtime/issues/106376) | 'chrome-DebuggerTests.ExceptionTests' timing out |
| [dotnet/runtime#101554](https://github.com/dotnet/runtime/issues/101554) | Blazor client side web debugging fails to function when run within IIS |

## v1,1-dotnet/runtime|area-Diagnostics-mono

Issues in query: 6

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#108211](https://github.com/dotnet/runtime/issues/108211) | Cross-VM Exception Unwinding |
| [dotnet/runtime#108078](https://github.com/dotnet/runtime/issues/108078) | `chrome-DebuggerTests` timing out |
| [dotnet/runtime#108071](https://github.com/dotnet/runtime/issues/108071) | [wasm] DebuggerTests.WasmHostProvider.LaunchHostAsync |
| [dotnet/runtime#106064](https://github.com/dotnet/runtime/issues/106064) | [mono][ios] Mono prevents crash logs from being generated in case `SIGSEGV` is raised from native code |
| [dotnet/runtime#97209](https://github.com/dotnet/runtime/issues/97209) | [Android] Application crashes when an exception is thrown after running a System.Diagnostics.Process |
| [dotnet/runtime#93551](https://github.com/dotnet/runtime/issues/93551) | **\<OUT OF SLA\>** [wasm] run browser-bench sample with https connection |

## v1,1-dotnet/runtime|area-System.Diagnostics-mono

Issues in query: 0

## v1,1-dotnet/runtime|area-Tracing-mono

Issues in query: 1

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#107315](https://github.com/dotnet/runtime/issues/107315) | [Mono] NetTrace Collected mismatches expected CLR Instance name |

