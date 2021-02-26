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
        Dim skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub
#End Region

End Class