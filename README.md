# RavenDB tests fail in Resharper Continuous Testing Session

### Success in normal test session
![Success in normal test session screenshot](/images/test-success-in-resharper-runner.png?raw=true)

### Fail in continuous testing session
![Fail in continuous testing session screenshot](/images/test-fail-in-continuous-testing-session.png?raw=true)

Full error message:

```
Test method raven_continuous_testing_fail.RavenDbTest.FailsWhenRunningInResharperContinuousTestingSession threw exception: 
Raven.Abstractions.Exceptions.IndexCompilationException: Can't figure out how to find the relevant clause for this query
    at Raven.Client.Connection.Implementation.HttpJsonRequest.<CheckForErrorsAndReturnCachedResultIfAnyAsync>d__20.MoveNext() in c:\Builds\RavenDB-Stable-3.0\Raven.Client.Lightweight\Connection\Implementation\HttpJsonRequest.cs:line 438
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd(Task task)
   at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1.ConfiguredTaskAwaiter.GetResult()
   at Raven.Client.Connection.Implementation.HttpJsonRequest.<>c__DisplayClasse.<<SendRequestInternal>b__d>d__10.MoveNext() in c:\Builds\RavenDB-Stable-3.0\Raven.Client.Lightweight\Connection\Implementation\HttpJsonRequest.cs:line 238
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd(Task task)
   at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1.ConfiguredTaskAwaiter.GetResult()
   at Raven.Client.Connection.Implementation.HttpJsonRequest.<RunWithAuthRetry>d__15`1.MoveNext() in c:\Builds\RavenDB-Stable-3.0\Raven.Client.Lightweight\Connection\Implementation\HttpJsonRequest.cs:line 287
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd(Task task)
   at System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.GetResult()
   at Raven.Client.Connection.Async.AsyncServerClient.<DirectPutIndexAsyncWithOperation>d__5d.MoveNext() in c:\Builds\RavenDB-Stable-3.0\Raven.Client.Lightweight\Connection\Async\AsyncServerClient.cs:line 312
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd(Task task)
   at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1.ConfiguredTaskAwaiter.GetResult()
   at Raven.Client.Connection.Async.AsyncServerClient.<DirectPutIndexAsync>d__59.MoveNext() in c:\Builds\RavenDB-Stable-3.0\Raven.Client.Lightweight\Connection\Async\AsyncServerClient.cs:line 282
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd(Task task)
   at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1.ConfiguredTaskAwaiter.GetResult()
   at Raven.Client.Connection.ReplicationInformerBase`1.<TryOperationAsync>d__29`1.MoveNext() in c:\Builds\RavenDB-Stable-3.0\Raven.Client.Lightweight\Connection\ReplicationInformerBase.cs:line 446
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd(Task task)
   at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1.ConfiguredTaskAwaiter.GetResult()
   at Raven.Client.Connection.ReplicationInformerBase`1.<ExecuteWithReplicationAsync>d__19`1.MoveNext() in c:\Builds\RavenDB-Stable-3.0\Raven.Client.Lightweight\Connection\ReplicationInformerBase.cs:line 338
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd(Task task)
   at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1.ConfiguredTaskAwaiter.GetResult()
   at Raven.Client.Connection.Async.AsyncServerClient.<ExecuteWithReplication>d__2d1`1.MoveNext() in c:\Builds\RavenDB-Stable-3.0\Raven.Client.Lightweight\Connection\Async\AsyncServerClient.cs:line 2439
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter`1.GetResult()
   at Raven.Abstractions.Util.AsyncHelpers.<>c__DisplayClassb`1.<<RunSync>b__8>d__d.MoveNext() in c:\Builds\RavenDB-Stable-3.0\Raven.Abstractions\Util\AsyncHelpers.cs:line 75
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at Raven.Abstractions.Util.AsyncHelpers.RunSync[T](Func`1 task) in c:\Builds\RavenDB-Stable-3.0\Raven.Abstractions\Util\AsyncHelpers.cs:line 90
   at Raven.Client.Connection.ServerClient.PutIndex(String name, IndexDefinition definition, Boolean overwrite) in c:\Builds\RavenDB-Stable-3.0\Raven.Client.Lightweight\Connection\ServerClient.cs:line 260
   at Raven.Client.Indexes.AbstractIndexCreationTask.Execute(IDatabaseCommands databaseCommands, DocumentConvention documentConvention) in c:\Builds\RavenDB-Stable-3.0\Raven.Client.Lightweight\Indexes\AbstractIndexCreationTask.cs:line 305
   at Raven.Tests.Helpers.RavenTestBase.CreateDefaultIndexes(IDocumentStore documentStore) in c:\Builds\RavenDB-Stable-3.0\Raven.Tests.Helpers\RavenTestBase.cs:line 529
   at Raven.Tests.Helpers.RavenTestBase.NewDocumentStore(Boolean runInMemory, String requestedStorage, ComposablePartCatalog catalog, String dataDir, Boolean enableAuthentication, String activeBundles, Nullable`1 port, AnonymousUserAccessMode anonymousUserAccessMode, Action`1 configureStore, String databaseName, IEnumerable`1 indexes, IEnumerable`1 transformers, IEnumerable`1 seedData, Boolean noStaleQueries, DocumentConvention conventions) in c:\Builds\RavenDB-Stable-3.0\Raven.Tests.Helpers\RavenTestBase.cs:line 259
   at raven_continuous_testing_fail.RavenDbTest.FailsWhenRunningInResharperContinuousTestingSession() in C:\dev\test\raven-continuous-testing-fail\RavenDbTest.cs:line 22
```
