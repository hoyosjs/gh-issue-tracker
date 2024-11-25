# .NET Diagnostics Report Full Report - 11/25/2024 06:20:25

Total issues: 58

## v1,1-dotnet/diagnostics

Issues in query: 16

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#5054](https://github.com/dotnet/diagnostics/issues/5054) | Dotnet-dump gcroot <reference> Segmentation fault (arm64) |
| [dotnet/diagnostics#5020](https://github.com/dotnet/diagnostics/issues/5020) | Diagnostics client fails to create dump when path has spaces |
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
| [dotnet/diagnostics#4375](https://github.com/dotnet/diagnostics/issues/4375) | **\<OUT OF SLA\>** dotnet-dump not working when process run as user |
| [dotnet/diagnostics#4314](https://github.com/dotnet/diagnostics/issues/4314) | **\<OUT OF SLA\>** !clrstack reports incorrect method names when <> is encountered |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 1

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#102004](https://github.com/dotnet/runtime/issues/102004) | MemoryAllocatedForJitCode ETW Event missing in trace, but CLRStackWalk still fires |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 0

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 5

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#109712](https://github.com/dotnet/runtime/issues/109712) | Diagnostics eventcommand argument error when run generic host on netframework |
| [dotnet/runtime#106087](https://github.com/dotnet/runtime/issues/106087) | [Tracing] EventProvider Disposal hangs within a callback |
| [dotnet/runtime#99274](https://github.com/dotnet/runtime/issues/99274) | EventAttribute Message not showing in ETW events |
| [dotnet/runtime#96968](https://github.com/dotnet/runtime/issues/96968) | Test failure BasicEventSourceTests.TestsUserErrors.Test_BadEventSource_MismatchedIds_WithEtwListener |
| [dotnet/runtime#96219](https://github.com/dotnet/runtime/issues/96219) | Potential Deadlock When Disposing EventListeners Concurrently |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 26

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#110062](https://github.com/dotnet/runtime/issues/110062) | Deadlock in GC when attached profiler calls ICorProfilerInfo4::EnumThreads using .NET9 runtime |
| [dotnet/runtime#109967](https://github.com/dotnet/runtime/issues/109967) | [Perf] Windows/x64: Multiple (13) Regressions on 11/14/2024 12:52:44 AM |
| [dotnet/runtime#109885](https://github.com/dotnet/runtime/issues/109885) | Step Over sometimes executes a lot more than one statement |
| [dotnet/runtime#109877](https://github.com/dotnet/runtime/issues/109877) | [DAC] ISOSDacInterface:GetMethodDescData reads from nullptr |
| [dotnet/runtime#109812](https://github.com/dotnet/runtime/issues/109812) | `foreach` will jump to other code in `dotnet9` |
| [dotnet/runtime#109785](https://github.com/dotnet/runtime/issues/109785) | Step becomes a "go" in .NET 9 |
| [dotnet/runtime#109779](https://github.com/dotnet/runtime/issues/109779) | App hangs after taking crashdump in official .NET 9 x64 glibc docker images |
| [dotnet/runtime#109296](https://github.com/dotnet/runtime/issues/109296) | Mysterious `NullReferenceException` when initializing a `List<int>` |
| [dotnet/runtime#109103](https://github.com/dotnet/runtime/issues/109103) | Running console application that creates and joins with short-lived threads leaks handles when debugger is attached |
| [dotnet/runtime#108912](https://github.com/dotnet/runtime/issues/108912) | Runtime System.Private.CoreLib patches pdbs |
| [dotnet/runtime#108893](https://github.com/dotnet/runtime/issues/108893) | [Perf] Windows/x64: 2 Regressions on 10/9/2024 1:12:38 AM |
| [dotnet/runtime#108273](https://github.com/dotnet/runtime/issues/108273) | [Profiler] Duplicate `GarbageCollectionFinished` notification |
| [dotnet/runtime#107344](https://github.com/dotnet/runtime/issues/107344) | Issues with memory dumps and Single File App |
| [dotnet/runtime#106243](https://github.com/dotnet/runtime/issues/106243) | Test failure: profiler/transitions/transitions/transitions.sh |
| [dotnet/runtime#106148](https://github.com/dotnet/runtime/issues/106148) | [DAC][ReJIT] ReJitManager::IsReJITEnabled checked DOTNET_ProfAPI_RejitOnAttach in the wrong environment |
| [dotnet/runtime#106104](https://github.com/dotnet/runtime/issues/106104) | Process silently exits after patching self-contained app with Debug bits when specific breakpoints are set |
| [dotnet/runtime#105690](https://github.com/dotnet/runtime/issues/105690) | Quality of native perf profiling on x64 |
| [dotnet/runtime#104459](https://github.com/dotnet/runtime/issues/104459) | App crashes with an output "Trace/Breakpoint Trap" on Linux when a P/Invoke callback is called from a native library if the dotnet debugger is attached. |
| [dotnet/runtime#102767](https://github.com/dotnet/runtime/issues/102767) | Patch skipping crashing in functions marked with [UnmanagedCallersOnly] |
| [dotnet/runtime#101310](https://github.com/dotnet/runtime/issues/101310) | coreclr + vsdbg failure to get stack trace from remote Kubernetes pod |
| [dotnet/runtime#95417](https://github.com/dotnet/runtime/issues/95417) | ExecutionEngineException on using step into while debugging |
| [dotnet/runtime#90563](https://github.com/dotnet/runtime/issues/90563) | **\<OUT OF SLA\>** Lock contention in StackTrace/Exception.ToString() |
| [dotnet/runtime#90079](https://github.com/dotnet/runtime/issues/90079) | **\<OUT OF SLA\>** Avalonia calling into the runtime after shut down |
| [dotnet/runtime#87574](https://github.com/dotnet/runtime/issues/87574) | **\<OUT OF SLA\>** [EnC] CoreCLR assertion in System.Reflection.Metadata.ApplyUpdateTest.TestGenericAddStaticField |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | **\<OUT OF SLA\>** dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | **\<OUT OF SLA\>** Application crash while stepping into if 'justMyCode' is disabled |

## v1,1-dotnet/runtime|area-Debugger-mono

Issues in query: 6

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#110016](https://github.com/dotnet/runtime/issues/110016) | Assertion when stepping over breakpoint |
| [dotnet/runtime#109980](https://github.com/dotnet/runtime/issues/109980) | .NET 9 mono debugger much slower |
| [dotnet/runtime#109067](https://github.com/dotnet/runtime/issues/109067) | Issues with the new .NET 9+ Mono Debugger |
| [dotnet/runtime#108078](https://github.com/dotnet/runtime/issues/108078) | `chrome-DebuggerTests` timing out |
| [dotnet/runtime#108072](https://github.com/dotnet/runtime/issues/108072) | [wasm] DebuggerTests.Inspector.OpenSessionAsync |
| [dotnet/runtime#101554](https://github.com/dotnet/runtime/issues/101554) | Blazor client side web debugging fails to function when run within IIS |

## v1,1-dotnet/runtime|area-Diagnostics-mono

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#108211](https://github.com/dotnet/runtime/issues/108211) | Cross-VM Exception Unwinding |
| [dotnet/runtime#108078](https://github.com/dotnet/runtime/issues/108078) | `chrome-DebuggerTests` timing out |
| [dotnet/runtime#108071](https://github.com/dotnet/runtime/issues/108071) | [wasm] DebuggerTests.WasmHostProvider.LaunchHostAsync |

## v1,1-dotnet/runtime|area-System.Diagnostics-mono

Issues in query: 0

## v1,1-dotnet/runtime|area-Tracing-mono

Issues in query: 0

## v1,1-dotnet/runtime|area-enc-mono

Issues in query: 1

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#108097](https://github.com/dotnet/runtime/issues/108097) | EnC: Mono throws when member accessibility is changed |

