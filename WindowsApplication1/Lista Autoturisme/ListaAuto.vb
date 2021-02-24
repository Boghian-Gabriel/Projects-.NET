Imports MaterialSkin

Public Class ListaAuto

#Region "Instantiere Clase si declarare liste"

    Dim autoo As New Autoturisme
    Dim lstAuto As New List(Of Autoturisme)
    Dim auto As List(Of Autoturisme) = CreateListAuto()

#End Region
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

#Region "Functie ce Afiseaza autoturismele folosind LINQ"
    Private Sub Afisare_Auto()
        'Using LINQ get a list of auto
        Dim linqAuto = From theAuto In auto
                       Order By theAuto.Marca
                       Select theAuto.Marca, theAuto.Model

        If chklstbox_Auto.Items.Count = 0 Then
            chklstbox_Auto.Items.Clear()
            For Each theAuto In linqAuto
                chklstbox_Auto.Items.Add(theAuto.Marca & " - " & theAuto.Model).ToString()
                'lstBoxAuto.Items.Add(theAuto.Marca.ToString())
            Next
        Else
            MessageBox.Show("Informatiile au fost afisate!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        'nr total de informatii din CheckListBox
        lblNrTotalInfo.Text = chklstbox_Auto.Items.Count
    End Sub
#End Region

#Region "crete a list Auto and populated it"
    Private Function CreateListAuto() As List(Of Autoturisme)
        Return New List(Of Autoturisme) From
            {
                {New Autoturisme With {.Marca = "Volkswagen", .Model = "Passat"}},
                {New Autoturisme With {.Marca = "Audi", .Model = "A4"}},
                {New Autoturisme With {.Marca = "Nissan", .Model = "Qashqai"}},
                {New Autoturisme With {.Marca = "Volvo", .Model = "CX60"}},
                {New Autoturisme With {.Marca = "Skoda", .Model = "Superb"}},
                {New Autoturisme With {.Marca = "Skoda", .Model = "Superb V2.02"}}
            }
    End Function
#End Region
#Region "Afiseaza lista cu autoturisme"
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Afisare_Auto()
    End Sub
#End Region
End Class