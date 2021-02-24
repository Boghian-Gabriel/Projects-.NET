Imports MaterialSkin

Public Class ListaAuto
    Private Sub ListaAuto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
        skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        skinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub ListaAuto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form1 As New Chose
        Chose.Show()
    End Sub
End Class