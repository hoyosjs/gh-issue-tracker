# .NET Diagnostics Report Full Report - 01/15/2024 06:14:54

Total issues: 61

## v1,1-dotnet/diagnostics

Issues in query: 23

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/diagnostics#4446](https://github.com/dotnet/diagnostics/issues/4446) | Crashing attempting to call `dumplog` |
| [dotnet/diagnostics#4438](https://github.com/dotnet/diagnostics/issues/4438) | .net core 8 can not find System.Private.Xml.ni.pdb in windbg, and VS2022 load  System.Private.Xml.pdb not  System.Private.Xml.ni.pdb |
| [dotnet/diagnostics#4430](https://github.com/dotnet/diagnostics/issues/4430) | Can't analyze dump of arm64ec process |
| [dotnet/diagnostics#4415](https://github.com/dotnet/diagnostics/issues/4415) | dotnet-counters long value rendered format |
| [dotnet/diagnostics#4390](https://github.com/dotnet/diagnostics/issues/4390) | gcdump/dump: Process not running compatible .NET runtime |
| [dotnet/diagnostics#4375](https://github.com/dotnet/diagnostics/issues/4375) | dotnet-dump not working when process run as user |
| [dotnet/diagnostics#4370](https://github.com/dotnet/diagnostics/issues/4370) | Linux arm32 lldb dump debugging commands not working |
| [dotnet/diagnostics#4369](https://github.com/dotnet/diagnostics/issues/4369) | Seg Fault with dotnet-dump on specific arm32 Linux device |
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
| [dotnet/diagnostics#3882](https://github.com/dotnet/diagnostics/issues/3882) | Add newer Ubuntu images to testing workflows. |
| [dotnet/diagnostics#3774](https://github.com/dotnet/diagnostics/issues/3774) | Re-enable !gcroot source tests |
| [dotnet/diagnostics#3506](https://github.com/dotnet/diagnostics/issues/3506) | **\<OUT OF SLA\>** How to debug stack overflow errors on Windows |

## v1,1-dotnet/runtime|area-Tracing-coreclr

Issues in query: 2

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#91687](https://github.com/dotnet/runtime/issues/91687) | CoreCLR clretwallmain.h contains DotNETRuntimeMonoProfiler events |
| [dotnet/runtime#88011](https://github.com/dotnet/runtime/issues/88011) | NativeRuntimeEventSource behaving poorly in conjunction with other providers |

## v1,1-dotnet/runtime|area-System.Diagnostics

Issues in query: 2

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#91191](https://github.com/dotnet/runtime/issues/91191) | [API Proposal]: An attribute to indicate boxed value type is not expected for certain API |
| [dotnet/runtime#80783](https://github.com/dotnet/runtime/issues/80783) | Would for some tests system wide profiling be a good thing?  |

## v1,1-dotnet/runtime|area-System.Diagnostics.Tracing

Issues in query: 9

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#96968](https://github.com/dotnet/runtime/issues/96968) | Test failure BasicEventSourceTests.TestsUserErrors.Test_BadEventSource_MismatchedIds_WithEtwListener |
| [dotnet/runtime#96904](https://github.com/dotnet/runtime/issues/96904) | BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGeneration intermittent test failures |
| [dotnet/runtime#96324](https://github.com/dotnet/runtime/issues/96324) | Debug.Assert exception I encountered when using Debug version System.Private.CoreLib.dll with mono runtime |
| [dotnet/runtime#96219](https://github.com/dotnet/runtime/issues/96219) | Potential Deadlock When Disposing EventListeners Concurrently |
| [dotnet/runtime#94964](https://github.com/dotnet/runtime/issues/94964) | How to debug code that is being compiled in layers? I have the following problem |
| [dotnet/runtime#91304](https://github.com/dotnet/runtime/issues/91304) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |
| [dotnet/runtime#88567](https://github.com/dotnet/runtime/issues/88567) | Port System.Diagnostics documentation for .NET 8.0 APIs |
| [dotnet/runtime#88305](https://github.com/dotnet/runtime/issues/88305) | Test failure BasicEventSourceTests.TestsWrite.Test_Write_T_ETW |
| [dotnet/runtime#88027](https://github.com/dotnet/runtime/issues/88027) | Test failure BasicEventSourceTests.TestsManifestGeneration.Test_EventSource_EtwManifestGenerationRollover |

## v1,1-dotnet/runtime|area-Diagnostics-coreclr

Issues in query: 25

| **Issue Number** | **Title** |
| :--------------: | --------- |
| [dotnet/runtime#96818](https://github.com/dotnet/runtime/issues/96818) | XUnitLogChecker: Unable to find dumps in Linux |
| [dotnet/runtime#96747](https://github.com/dotnet/runtime/issues/96747) | [NETSDKE2E][Regression] With VSCode on Linux, debugging a .NET 9 project is failed with Unknown Error 0x80131c3c Unable to attach to CoreCLR. |
| [dotnet/runtime#96485](https://github.com/dotnet/runtime/issues/96485) | Is there a way to Request the "Profiler" if one is attached to the CLR to request a "Flush" or harvest from Managed code? |
| [dotnet/runtime#95417](https://github.com/dotnet/runtime/issues/95417) | ExecutionEngineException on using step into while debugging |
| [dotnet/runtime#95189](https://github.com/dotnet/runtime/issues/95189) | vsdbg quits when resuming from a breakpoint if stepping over a line that throws an exception  |
| [dotnet/runtime#95167](https://github.com/dotnet/runtime/issues/95167) | Crash in DoStackSnapshot. |
| [dotnet/runtime#91631](https://github.com/dotnet/runtime/issues/91631) | No compatiable code running on the thread |
| [dotnet/runtime#90563](https://github.com/dotnet/runtime/issues/90563) | Lock contention in StackTrace/Exception.ToString() |
| [dotnet/runtime#90547](https://github.com/dotnet/runtime/issues/90547) | Createdump will incorrectly try to classify memfd entries as files |
| [dotnet/runtime#90359](https://github.com/dotnet/runtime/issues/90359) | [External] Libunwind has suppressed warnings  |
| [dotnet/runtime#90079](https://github.com/dotnet/runtime/issues/90079) | Deadlock between debugger and class loading in PGO |
| [dotnet/runtime#89592](https://github.com/dotnet/runtime/issues/89592) | Debugger assert during register mapping |
| [dotnet/runtime#88463](https://github.com/dotnet/runtime/issues/88463) | DoStackSnapshot behaves differently on Windows x86 and x64 WRT stack unwinding |
| [dotnet/runtime#87418](https://github.com/dotnet/runtime/issues/87418) | `RequestReJITWithInliners` doesn't always trigger a rejit without `COR_PRF_MONITOR_JIT_COMPILATION` enabled |
| [dotnet/runtime#85777](https://github.com/dotnet/runtime/issues/85777) | Segfault in CMiniMdTemplate<CMiniMdRW>::getSignatureOfMemberRef |
| [dotnet/runtime#84665](https://github.com/dotnet/runtime/issues/84665) | crashinfounix.cpp: unknown type name 'off64_t' on Alpine Linux |
| [dotnet/runtime#83967](https://github.com/dotnet/runtime/issues/83967) | [CoreCLR Linux arm32] `ICorDebugStackWalk` works wrong in case top frame is native. |
| [dotnet/runtime#83699](https://github.com/dotnet/runtime/issues/83699) | lldb dumpmt crashes against source-built .NET 7 on Fedora 37 |
| [dotnet/runtime#83419](https://github.com/dotnet/runtime/issues/83419) | exe file name gets truncated in .NET core mini dump name |
| [dotnet/runtime#82422](https://github.com/dotnet/runtime/issues/82422) | [Linux, amd64] ICorDebugEval::Abort are broken. |
| [dotnet/runtime#79852](https://github.com/dotnet/runtime/issues/79852) | **\<OUT OF SLA\>** [macOS] cannot debug / stop at breakpoints when app sandbox is enabled |
| [dotnet/runtime#78991](https://github.com/dotnet/runtime/issues/78991) | **\<OUT OF SLA\>** NullReferenceException when you use the short format of string.format $"{sample}" when debugging .NET 7 on x64 macOS |
| [dotnet/runtime#71472](https://github.com/dotnet/runtime/issues/71472) | **\<OUT OF SLA\>** dotnet-dump makes process to double its used memory and fails |
| [dotnet/runtime#70755](https://github.com/dotnet/runtime/issues/70755) | **\<OUT OF SLA\>** Crash in coreclr.dll!Debugger::SendException while processing stack overflow in x64 Windows |
| [dotnet/runtime#68018](https://github.com/dotnet/runtime/issues/68018) | **\<OUT OF SLA\>** Application crash while stepping into if 'justMyCode' is disabled |

