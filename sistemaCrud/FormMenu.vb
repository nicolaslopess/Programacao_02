Imports System.IO
Imports System.Diagnostics


Public Class FormMenu

    Private Sub EditarCadastro_Click(sender As Object, e As EventArgs) Handles EditarCadastroMenu.Click
        EditarCadastro.Show()
        Me.Close()
    End Sub

    Private Sub DeletarCadastroMenu_Click(sender As Object, e As EventArgs) Handles DeletarCadastroMenu.Click
        DeletarCadastro.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim caminho As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..")) & "\componentes\games\space\Mandau_Wing.exe"

        Process.Start(caminho).WaitForExit()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim caminho As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..")) & "\componentes\games\gun\Mandau_Wing_Simulation.exe"

        Process.Start(caminho).WaitForExit()

    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()
    End Sub

End Class