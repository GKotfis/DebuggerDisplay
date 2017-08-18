using System;
using System.Collections.Generic;
using System.Diagnostics;
using DebbugerDisplayProject;
using ExternalSdk;

// Output folder: C:\Users\{UserName}\Documents\Visual Studio 2017\Visualizers

[assembly: DebuggerTypeProxy(typeof(AddressDebug), Target = typeof(Address))]
