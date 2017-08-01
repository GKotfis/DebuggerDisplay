using System.Diagnostics;
using ExternalSdk;

// Output folder: C:\Users\{UserName}\Documents\Visual Studio 2017\Visualizers

[assembly: DebuggerDisplay(@"[Visualizer] Id = {Id,nq}, Name = {Name,nq}, WithAddress = {Address != null}}", Target = typeof(Person))]
[assembly: DebuggerDisplay(@"Address = {City,nq} : {Street,nq}", Target = typeof(Address))]