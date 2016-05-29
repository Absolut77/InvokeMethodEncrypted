# InvokeMethodEncrypted

This is a method to call another method into a .NET Framework Application.

The strings encrypted are (in order):
{"GetILGenerator", _
 "Load", _
 "GetType", _
 "CreateInstance", _
 "GetObjectValue", _
 "CallByName", _
 "Emit", _
 "EmitCall", _
 "Invoke"}
{"Ldarg_0", _
 "Call", _
 "Ldarg_1", _
 "Callvirt", _
 "Ldarg_2", _
 "Ldc_I4_1", _
 "Ldarg_3", _
 "Ret"}
{"System.Reflection.Assembly", _
 "System.Activator", _
 "System.Runtime.CompilerServices.RuntimeHelpers", _
 "Microsoft.VisualBasic.CompilerServices.Versioned"}
 
 To use this method: 
 
 Argument 1: The file you want to load (Need to be a .NET File)
 Argument 2: Namespace.Class
 Argument 3: Method (shared and public)
 Argument 4: Argument if needed (New Object() {}..)
 
 EncryptedCall._Call(Argument 1 ,Argument 2 , Argument 3 , Argument 4)
