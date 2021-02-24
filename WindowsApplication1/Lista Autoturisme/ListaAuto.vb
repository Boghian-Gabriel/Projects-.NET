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

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click

    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        If chklstbox_Auto.CheckedItems.Count = 0 Then
            MessageBox.Show("Te rugam sa selectati cel putin o optiune din lista de mai sus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            '[ADD] - sterge lista si o reactualizeaza
            lstBoxAuto.Items.Clear()
            For Each item In chklstbox_Auto.CheckedItems
                lstBoxAuto.Items.Add(item)
            Next
            MessageBox.Show("Informatiile au fost adaugate cu succes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        ' Atunci cand adaug un autoturism in lista de favorite, in lista principale mi le pune ca au fost deja introduse
        ' verificare pentru a nu putea adauga de 2 ori acelasi autoturism in lista de favorite
        ' GetItemChecked - returneaza exact cate iteme au fost bifate - 
        ' Returns a value indicating whether the specified item Is checked. Return TRUE / FALSE
        ' REZOLVARE https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.checkedlistbox.getitemchecked?view=netframework-4.5.2&f1url=%3FappId%3DDev14IDEF1%26l%3DEN-US%26k%3Dk(System.Windows.Forms.CheckedListBox.GetItemChecked);k(TargetFrameworkMoniker-.NETFramework,Version%253Dv4.5.2);k(DevLang-VB)%26rd%3Dtrue


        For i As Integer = 0 To chklstbox_Auto.Items.Count - 1
            If (chklstbox_Auto.GetItemChecked(i)) Then
                chklstbox_Auto.SetItemCheckState(i, CheckState.Indeterminate)
            End If
        Next
    End Sub

    Private Sub MaterialCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox1.CheckedChanged
        If chklstbox_Auto.Items.Count <> 0 Then

            For i As Integer = 0 To chklstbox_Auto.Items.Count - 1 Step 1
                If MaterialCheckBox1.Checked = True Then
                    chklstbox_Auto.SetItemChecked(i, True)
                Else
                    chklstbox_Auto.SetItemChecked(i, False)
                End If
            Next
            'MessageBox.Show("nr total este: " & chklstbox_Auto.Items.Count)

        Else
            VerificCheckBoxDacaEsteBifatIlDebifezCuMesajDeEroare()
            'MessageBox.Show("Pentru a putea selecta toate informatiile, ar trebui ca sa afisati informatiile apasand butonul de mai jos!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

#Region "Verific daca CheckBox-ul este bifat, atunci il debifez"
    Private Sub VerificCheckBoxDacaEsteBifatIlDebifez()
        If MaterialCheckBox1.Checked = True Then
            MaterialCheckBox1.Checked = False
        End If
    End Sub

#End Region

#Region "Verific daca CheckBox-ul este bifat, atunci il debifez cu mesaj de eroare"
    Private Sub VerificCheckBoxDacaEsteBifatIlDebifezCuMesajDeEroare()
        If MaterialCheckBox1.Checked = True Then
            MaterialCheckBox1.Checked = False
        Else
            MessageBox.Show("Pentru a putea selecta toate informatiile, ar trebui ca sa afisati informatiile apasand butonul de mai jos!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

#End Region

#Region "Stergere info din textBox"
    Private Sub ClearTxtBox()
        txtMarca.Text = ""
        txtModel.Text = ""
    End Sub
#End Region
End Class