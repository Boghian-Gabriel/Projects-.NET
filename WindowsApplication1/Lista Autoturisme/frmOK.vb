Imports MaterialSkin

Public Class Informatii
    Inherits MaterialSkin.Controls.MaterialForm

    Public Property Message As String
        Get
            Return mlblInfoFrmOK.Text
        End Get
        Set(value As String)
            mlblInfoFrmOK.Text = value
        End Set
    End Property


#Region "FrmOK"
    Private Sub Informatii_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        'skinManager.AddFormToManage(Me)
        'skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'skinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen700, TextShade.WHITE)
    End Sub
#End Region

End Class