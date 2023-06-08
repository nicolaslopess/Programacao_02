Imports System.IO
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class DeletarCadastro
    Dim caminho As String
    Dim dt As New DataTable()
    Private Sub DeletarCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        caminho = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..")) & "\componentes\Dados\Usuarios.csv"
        carregarDataGrid()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete the user?", "", MessageBoxButtons.YesNo)

        Dim lines As List(Of String) = File.ReadAllLines(caminho).ToList()

        Dim dadosDeletar As String = DeletarDado.Text

        If confirmResult = DialogResult.Yes Then
            Dim index As Integer = -1
            For i As Integer = 0 To lines.Count - 1
                If lines(i).StartsWith(dadosDeletar) Then
                    index = i
                    Exit For
                End If
            Next

            File.WriteAllText(caminho, String.Empty)

            If index > -1 Then
                lines.RemoveAt(index)
                Dim novaLista As New List(Of String)
                For Each line As String In lines
                    novaLista.Add(line)
                Next

                File.WriteAllLines(caminho, novaLista)

                carregarDataGrid()
            End If
        End If

    End Sub
    Private Function carregarDataGrid()
        Dim lines As List(Of String) = File.ReadAllLines(caminho).ToList()
        dt.Clear()
        For Each line As String In File.ReadLines(caminho)
            Dim dados As String() = line.Split(","c)

            For i As Integer = 0 To dados.Length - 1
                dados(i) = dados(i).Replace("""", "")
            Next

            If dt.Columns.Count = 0 Then

                For i As Integer = 0 To dados.Length - 1
                    If i = 1 Then
                        dt.Columns.Add("User Name")
                    ElseIf i = 2 Then
                        dt.Columns.Add("Password")
                    Else
                        dt.Columns.Add("Index")
                    End If


                Next
            End If
            dt.Rows.Add(dados)
        Next

        DataGridDel.DataSource = dt

        DataGridDel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Function

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
        FormMenu.Show()
    End Sub
End Class