Imports MaterialSkin

#Region "Forma Principala"
Public Class Chose

#Region "Design Forma Principala"
    Private Sub Chose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
        skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        skinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub
#End Region

#Region "Apasare buton ce afiseaza forma cu prima aplicatie"
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Dim frmListaAuto As New ListaAuto
        frmListaAuto.Show()
        Me.Visible = False
    End Sub
#End Region
End Class
#End Region
