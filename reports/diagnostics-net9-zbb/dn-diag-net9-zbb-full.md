# .NET 9 - ZBB Diagnostics Report Full Report - 07/22/2024 17:35:13

Total issues: 65

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 14

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#104670](https://github.com/dotnet/runtime/issues/104670) | BinderTracingTest.ResolutionFlow times out |
| [dotnet/runtime#102572](https://github.com/dotnet/runtime/issues/102572) | It is not possible to pass the ID of the garbage collection when the .NET provider is enabled with the GCHeapCollect(0x800000) keyword |
| [dotnet/runtime#102004](https://github.com/dotnet/runtime/issues/102004) | MemoryAllocatedForJitCode ETW Event missing in trace, but CLRStackWalk still fires |
| [dotnet/runtime#101764](https://github.com/dotnet/runtime/issues/101764) | Malformed EventPipe request can crash the runtime |
| [dotnet/runtime#99497](https://github.com/dotnet/runtime/issues/99497) | Assert in CounterGroup.OnEventSourceCommand after trying to run BDN x86 |
| [dotnet/runtime#96365](https://github.com/dotnet/runtime/issues/96365) | Incomplete rundown event metadata |
| [dotnet/runtime#92734](https://github.com/dotnet/runtime/issues/92734) | SampleProfiler EventPipe provider support for .net 8 Native AOT  |
| [dotnet/runtime#91687](https://github.com/dotnet/runtime/issues/91687) | CoreCLR clretwallmain.h contains DotNETRuntimeMonoProfiler events |
| [dotnet/runtime#90052](https://github.com/dotnet/runtime/issues/90052) | Adding a new listener to EventPipeEventDispatcher temporarily stops emitting events for existing sessions |
| [dotnet/runtime#88938](https://github.com/dotnet/runtime/issues/88938) | [Runtime] Jump stubs appear as `?!?` in ETL traces |
| [dotnet/runtime#88011](https://github.com/dotnet/runtime/issues/88011) | NativeRuntimeEventSource behaving poorly in conjunction with other providers |
| [dotnet/runtime#87257](https://github.com/dotnet/runtime/issues/87257) | When firing rundown events we do not distinguish between generic overloads for jitted methods |
| [dotnet/runtime#71644](https://github.com/dotnet/runtime/issues/71644) | Request: Add PDB checksum (type 19) to ModuleDCStart/ModuleDCStop events |
| [dotnet/runtime#43390](https://github.com/dotnet/runtime/issues/43390) | **\<OUT OF SLA\>** Developers can employ EventSource APIs when publishing for AOT targets to be able to use .NET tracing capabilities |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#81574](https://github.com/dotnet/runtime/issues/81574) | Dotnet-counter and other tools for specifying meter and ActivitySource names should support namespace wildcards  |
| [dotnet/runtime#79372](https://github.com/dotnet/runtime/issues/79372) | How do I discover what counters are available for dotnet-counters? |
| [dotnet/runtime#79371](https://github.com/dotnet/runtime/issues/79371) | Implement/Convert existing EventCounters to Metrics |

## v1,1-dotnet/runtime|area-System.Diagnostics.Metric

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#95210](https://github.com/dotnet/runtime/issues/95210) | Mono Windows x86: possible CompareExchange issue causes failures in System.Diagnostics.DiagnosticSource.Tests |
| [dotnet/runtime#91591](https://github.com/dotnet/runtime/issues/91591) | System.Diagnostics.Metrics.LastValue looks like it could experience torn reads |
| [dotnet/runtime#71563](https://github.com/dotnet/runtime/issues/71563) | [Feature Request] Faster aggregation for the MetricsEventSource under concurrency |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 11

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#103480](https://github.com/dotnet/runtime/issues/103480) | Crash when disposing an EventListener during shutdown |
| [dotnet/runtime#102197](https://github.com/dotnet/runtime/issues/102197) | EventSource event with 4 string parameters with null values behaves inconsistent in .NET 8 |
| [dotnet/runtime#99274](https://github.com/dotnet/runtime/issues/99274) | EventAttribute Message not showing in ETW events |
| [dotnet/runtime#96968](https://github.com/dotnet/runtime/issues/96968) | Test failure BasicEventSourceTests.TestsUserErrors.Test_BadEventSource_MismatchedIds_WithEtwListener |
| [dotnet/runtime#96219](https://github.com/dotnet/runtime/issues/96219) | Potential Deadlock When Disposing EventListeners Concurrently |
| [dotnet/runtime#94964](https://github.com/dotnet/runtime/issues/94964) | How to debug code that is being compiled in layers? I have the following problem |
| [dotnet/runtime#93175](https://github.com/dotnet/runtime/issues/93175) | Deadlock in ThreadPool.GetMaxThreads() during app start. |
| [dotnet/runtime#80666](https://github.com/dotnet/runtime/issues/80666) | tracing/eventpipe/eventsourceerror/eventsourceerror/eventsourceerror failure |
| [dotnet/runtime#77572](https://github.com/dotnet/runtime/issues/77572) | dotnet-trace: Make it easier to get a dump of what EventSources and Events are actually used by a process |
| [dotnet/runtime#77520](https://github.com/dotnet/runtime/issues/77520) | Enable sample based tracing to track issues in high performance/load scenarios |
| [dotnet/runtime#49659](https://github.com/dotnet/runtime/issues/49659) | **\<OUT OF SLA\>** Use source generator to assist EventSource initialization for SPCL EventSources |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 34

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#105116](https://github.com/dotnet/runtime/issues/105116) | x86 Interop Call stack incorrect when stopped in native exception filter |
| [dotnet/runtime#104459](https://github.com/dotnet/runtime/issues/104459) | App crashes with an output "Trace/Breakpoint Trap" on Linux when a P/Invoke callback is called from a native library if the dotnet debugger is attached. |
| [dotnet/runtime#104256](https://github.com/dotnet/runtime/issues/104256) | Dump file not created when process crashes |
| [dotnet/runtime#103955](https://github.com/dotnet/runtime/issues/103955) | Debugger Crashes when using breakpoints with a compiled runtime in debug mode _CrtlsValidHeapPointer(block) |
| [dotnet/runtime#103872](https://github.com/dotnet/runtime/issues/103872) | WER handler is broken |
| [dotnet/runtime#103421](https://github.com/dotnet/runtime/issues/103421) | R2RGetEntryPoint ETW / eventpipe event missing a size |
| [dotnet/runtime#103000](https://github.com/dotnet/runtime/issues/103000) | Environment variable DOTNET_DbgEnableMiniDump=1 doens't work when unhandled exception occurs in worker thread |
| [dotnet/runtime#102767](https://github.com/dotnet/runtime/issues/102767) | Patch skipping crashing in functions marked with [UnmanagedCallersOnly] |
| [dotnet/runtime#102080](https://github.com/dotnet/runtime/issues/102080) | [hot reload] Validate / Implement support for adding `static extern` methods |
| [dotnet/runtime#101310](https://github.com/dotnet/runtime/issues/101310) | coreclr + vsdbg failure to get stack trace from remote Kubernetes pod |
| [dotnet/runtime#101257](https://github.com/dotnet/runtime/issues/101257) | [cdac-build-tool] Take baseline as a command line argument |
| [dotnet/runtime#100162](https://github.com/dotnet/runtime/issues/100162) | [cdac] data contract spec follow up items and open questions |
| [dotnet/runtime#99487](https://github.com/dotnet/runtime/issues/99487) | CLR_GCHEAPCOLLECT_KEYWORD triggers a GC twice |
| [dotnet/runtime#99302](https://github.com/dotnet/runtime/issues/99302) | [cdac] Implement `!PrintException` |
| [dotnet/runtime#98506](https://github.com/dotnet/runtime/issues/98506) | Excessive exceptions generated in StackTraceSymbols when using Portable PDB |
| [dotnet/runtime#97229](https://github.com/dotnet/runtime/issues/97229) | Add missing GC and Threads performance counters in Net-6 |
| [dotnet/runtime#96473](https://github.com/dotnet/runtime/issues/96473) | Adjustment to RichDebug format and standardizing it for external profiler use |
| [dotnet/runtime#95417](https://github.com/dotnet/runtime/issues/95417) | ExecutionEngineException on using step into while debugging |
| [dotnet/runtime#95189](https://github.com/dotnet/runtime/issues/95189) | vsdbg quits when resuming from a breakpoint if stepping over a line that throws an exception  |
| [dotnet/runtime#92615](https://github.com/dotnet/runtime/issues/92615) | EE skips static field initialization when scope references collection literals |
| [dotnet/runtime#90079](https://github.com/dotnet/runtime/issues/90079) | Avalonia calling into the runtime after shut down |
| [dotnet/runtime#88286](https://github.com/dotnet/runtime/issues/88286) | Distribute macOS symbols as dSYM, not .dwarf |
| [dotnet/runtime#84087](https://github.com/dotnet/runtime/issues/84087) | Ensure XMM16-XMM31 and K0-K7 are handled where appropriate |
| [dotnet/runtime#77530](https://github.com/dotnet/runtime/issues/77530) | Discussion: Reducing confusion around the System.Runtime gc-heap-size EventCounter |
| [dotnet/runtime#75580](https://github.com/dotnet/runtime/issues/75580) | improve the gc-heap-size counter |
| [dotnet/runtime#75154](https://github.com/dotnet/runtime/issues/75154) | Update metadata when entities are deleted by an EnC edit |
| [dotnet/runtime#74271](https://github.com/dotnet/runtime/issues/74271) | [CET Debugging] User mode APC's on Windows x64 with CET enabled can cause a debug session to crash  |
| [dotnet/runtime#73826](https://github.com/dotnet/runtime/issues/73826) | Add an ICorProfiler callback for when an exception goes unhandled |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#68446](https://github.com/dotnet/runtime/issues/68446) | Improve event pipe thread time analysis by detecting blocking methods |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | Application crash while stepping into if 'justMyCode' is disabled |
| [dotnet/runtime#47617](https://github.com/dotnet/runtime/issues/47617) | **\<OUT OF SLA\>** Exception throw/catch impactfully slower when debugger attached |
| [dotnet/runtime#11466](https://github.com/dotnet/runtime/issues/11466) | **\<OUT OF SLA\>** Poorly performing hash used in the DBI/EE |

