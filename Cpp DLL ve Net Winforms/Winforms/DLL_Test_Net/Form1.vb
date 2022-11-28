Imports System.Runtime.InteropServices

Public Class Form1
    Const Dosyayolu As String = "E:\TestDLL\x64\Debug\TestDLL.dll"
    <DllImport(Dosyayolu)> Public Shared Function Test(ByVal Deger As Integer) As Integer
    End Function

    <DllImport(Dosyayolu)> Public Shared Function Fonks() As Integer
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Fonks_Buton_Click(sender As Object, e As EventArgs) Handles Fonks_Buton.Click
        MsgBox(Fonks)
    End Sub

    Private Sub Test_Buton_Click(sender As Object, e As EventArgs) Handles Test_Buton.Click
        MsgBox(Test(CInt(TextBox1.Text)))
    End Sub
End Class
