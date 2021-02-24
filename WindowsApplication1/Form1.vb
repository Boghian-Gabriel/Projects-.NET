﻿Imports MaterialSkin
Public Class Chose
    Private Sub Chose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
        skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        skinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Dim frmListaAuto As New ListaAuto
        frmListaAuto.Show()
        Me.Visible = False
    End Sub

End Class
