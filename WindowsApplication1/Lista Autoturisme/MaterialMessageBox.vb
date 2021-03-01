Imports System.Windows.Forms

Public Class MaterialMessageBox
    'Static in C# = Shared in 
    Public Function Show(ByVal message As String, ByVal caption As String, ByVal button As MessageBoxButtons) As DialogResult

        Dim result As DialogResult = DialogResult.None

        Select Case button
            Case MessageBoxButtons.OK
                Using info As Informatii = New Informatii
                    info.Text = caption
                    info.Message = message
                    result = info.ShowDialog()
                End Using

        End Select

    End Function

End Class
