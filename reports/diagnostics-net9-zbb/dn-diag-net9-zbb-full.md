# .NET 9 - ZBB Diagnostics Report Full Report - 07/23/2024 21:57:47

Total issues: 25

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
| [dotnet/runtime#88011](https://github.com/dotnet/runtime/issues/88011) | NativeRuntimeEventSource behaving poorly in conjunction with other providers |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 0

## v1,1-dotnet/runtime|area-System.Diagnostics.Metric

Issues in query: 3

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#95210](https://github.com/dotnet/runtime/issues/95210) | Mono Windows x86: possible CompareExchange issue causes failures in System.Diagnostics.DiagnosticSource.Tests |
| [dotnet/runtime#91591](https://github.com/dotnet/runtime/issues/91591) | System.Diagnostics.Metrics.LastValue looks like it could experience torn reads |
| [dotnet/runtime#71563](https://github.com/dotnet/runtime/issues/71563) | [Feature Request] Faster aggregation for the MetricsEventSource under concurrency |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 7

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#103480](https://github.com/dotnet/runtime/issues/103480) | Crash when disposing an EventListener during shutdown |
| [dotnet/runtime#102197](https://github.com/dotnet/runtime/issues/102197) | EventSource event with 4 string parameters with null values behaves inconsistent in .NET 8 |
| [dotnet/runtime#96968](https://github.com/dotnet/runtime/issues/96968) | Test failure BasicEventSourceTests.TestsUserErrors.Test_BadEventSource_MismatchedIds_WithEtwListener |
| [dotnet/runtime#96219](https://github.com/dotnet/runtime/issues/96219) | Potential Deadlock When Disposing EventListeners Concurrently |
| [dotnet/runtime#94964](https://github.com/dotnet/runtime/issues/94964) | How to debug code that is being compiled in layers? I have the following problem |
| [dotnet/runtime#93175](https://github.com/dotnet/runtime/issues/93175) | Deadlock in ThreadPool.GetMaxThreads() during app start. |
| [dotnet/runtime#80666](https://github.com/dotnet/runtime/issues/80666) | tracing/eventpipe/eventsourceerror/eventsourceerror/eventsourceerror failure |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 8

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#105116](https://github.com/dotnet/runtime/issues/105116) | x86 Interop Call stack incorrect when stopped in native exception filter |
| [dotnet/runtime#104459](https://github.com/dotnet/runtime/issues/104459) | App crashes with an output "Trace/Breakpoint Trap" on Linux when a P/Invoke callback is called from a native library if the dotnet debugger is attached. |
| [dotnet/runtime#104256](https://github.com/dotnet/runtime/issues/104256) | Dump file not created when process crashes |
| [dotnet/runtime#103000](https://github.com/dotnet/runtime/issues/103000) | Environment variable DOTNET_DbgEnableMiniDump=1 doens't work when unhandled exception occurs in worker thread |
| [dotnet/runtime#98506](https://github.com/dotnet/runtime/issues/98506) | Excessive exceptions generated in StackTraceSymbols when using Portable PDB |
| [dotnet/runtime#95417](https://github.com/dotnet/runtime/issues/95417) | ExecutionEngineException on using step into while debugging |
| [dotnet/runtime#95189](https://github.com/dotnet/runtime/issues/95189) | vsdbg quits when resuming from a breakpoint if stepping over a line that throws an exception  |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | Application crash while stepping into if 'justMyCode' is disabled |

