# InvokeMethodEncrypted

This is a method to call another method into a .NET Framework Application.
 
 Update:
 Hide the initilization of the dynamicmethod
 Hide "GetMethod" Function
 Hide Call
 Hide IL Generation
 
 To use this method: 
 
 Argument 1: The file you want to load (Need to be a .NET File)
 Argument 2: Namespace.Class
 Argument 3: Method (shared and public)
 Argument 4: Argument if needed (New Object() {}..)
 
 EncryptedCall._Call(Argument 1 ,Argument 2 , Argument 3 , Argument 4)
