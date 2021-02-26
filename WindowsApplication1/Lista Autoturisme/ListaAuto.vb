Imports MaterialSkin

#Region "Project List Auto"
Public Class ListaAuto

#Region "Instantiere Clase si declarare liste"
    Dim message As New MaterialMessageBox
    Dim autoo As New Autoturisme
    Dim lstAuto As New List(Of Autoturisme)
    Dim auto As List(Of Autoturisme) = CreateListAuto()

#End Region

#Region "Design Forma"
    Private Sub ListaAuto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
        skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        skinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub
#End Region

#Region "Cand inchid fereastra, apare forma principala de undeselectez alte proiecte"
    Private Sub ListaAuto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form1 As New Chose
        Chose.Show()
    End Sub
#End Region

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
        If chklstbox_Auto.Items.Count <> 0 Then
            chklstbox_Auto.Items.Clear()
        Else
            Afisare_Auto()
        End If

    End Sub
#End Region

#Region "Adaugare Autoturisme in lista principala CheckBoxList"
    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        If txtMarca.Text = String.Empty Or txtModel.Text = String.Empty Then
            MessageBox.Show("Trebuie sa completati toate campurile corespunzator", " Information ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMarca.BackColor = Color.Gray
            txtModel.BackColor = Color.Gray

        ElseIf chklstbox_Auto.Items.Count = 0 Then
            MessageBox.Show("Inainte de a adauga un nou autoturism, trebuie sa afisati lista!", " Information ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            txtMarca.BackColor = Color.White
            txtModel.BackColor = Color.White
            autoo.Marca = txtMarca.Text
            autoo.Model = txtModel.Text

            '[ADD] - iteme in lista de Autoturisme
            lstAuto.Add(New Autoturisme(autoo.Marca, autoo.Model))

            '[ADD] - iteme in ListChekedBox
            chklstbox_Auto.Items.Add(autoo.ToString())
            '[INFO] - mesaj care ne specifica ce inregistrare a fost adaugata
            MessageBox.Show($"Autoturismul [MARCA] : {autoo.Marca} - [MODELUL] : {autoo.Model} a fost adaugat cu succes in lista!", " Information ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            '[INFO] - Dupa ce obiectul a fost adaugat cu succes, se sterg toate informatiile din respectivele textBox-uri.
            ClearTxtBox()
            Actualizez_Info()

        End If
    End Sub
#End Region

#Region "Adauga Informatii in lista favorita"
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

#End Region

#Region "Informatii despre ChekBoxList - Auto "
    Private Sub chklstbox_Auto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chklstbox_Auto.SelectedIndexChanged
        'nr de iteme selectate din CheckListBox
        Dim itemsCheked = chklstbox_Auto.CheckedItems.Count

        'nr total de iteme din CheckListBox
        Dim nrTotalItemInCheckBoxList = chklstbox_Auto.Items.Count

        'nr total de iteme din CheckedListBox neselectate
        Dim itemsUnCheked = nrTotalItemInCheckBoxList - itemsCheked

        'label cu toate itemele din Lista
        lblInfoSelectate.Text = itemsCheked

        'label cu iteme neselectate (din nr total de iteme, scadem itemele selectate)
        lblInfoNeselectate.Text = chklstbox_Auto.Items.Count - chklstbox_Auto.CheckedItems.Count

    End Sub
#End Region

#Region "Verific daca check box-ul este bifat, atunci bifez toate informatiile din checkedListBox"
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
            Actualizez_Info()
        Else
            VerificCheckBoxDacaEsteBifatIlDebifezCuMesajDeEroare()
            'MessageBox.Show("Pentru a putea selecta toate informatiile, ar trebui ca sa afisati informatiile apasand butonul de mai jos!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub
#End Region

#Region "Actualizez informatiile din group-box-ul desre CheckedBoxLixt"
    Private Sub Actualizez_Info()

        lblNrTotalInfo.Text = chklstbox_Auto.Items.Count

        If MaterialCheckBox1.Checked = True Then
            lblInfoSelectate.Text = chklstbox_Auto.CheckedItems.Count
            lblInfoNeselectate.Text = chklstbox_Auto.Items.Count - chklstbox_Auto.CheckedItems.Count
        Else
            lblInfoNeselectate.Text = chklstbox_Auto.Items.Count - chklstbox_Auto.CheckedItems.Count
            lblInfoSelectate.Text = chklstbox_Auto.CheckedItems.Count
        End If
    End Sub
#End Region

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

#Region "Sterge toate informatiile"
    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click

        If lstBoxAuto.Items.Count > 0 Then
            lstBoxAuto.Items.Clear()
            For i As Integer = 0 To chklstbox_Auto.Items.Count - 1
                If (chklstbox_Auto.GetItemChecked(i)) Then
                    chklstbox_Auto.SetItemCheckState(i, CheckState.Unchecked)
                End If
            Next
        Else
            MessageBox.Show("Momentan lista dumneavoastra cu autoturisme favorite nu  este populata! Selectati si adaugati din lista de mai sus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        VerificCheckBoxDacaEsteBifatIlDebifez()
        Actualizez_Info()
    End Sub
#End Region

#Region "Sterge doar informatiile pe care le-ai selectat"
    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton5.Click
        If lstBoxAuto.SelectedItems.Count <> 0 Then
            Dim selectedItemCount = lstBoxAuto.SelectedItems.Count
            Dim i As Integer
            ' https://stackoverflow.com/questions/24939046/deleting-multiple-or-single-items-from-list-box
            ' Parcurs de la coada la cap pentru a nu genera erori
            ' Daca parcurg asa, oricum de la itemele selectate merge pana la 0 si daca sterg mai multe informatii functioneaza
            ' Pentru  a parcurge de la inceput la sfarsit cu for si sterg mai multe informatii, prima info se sterge iar cealalta da eroare deoarece
            ' nu mai sunt atatea iteme cum erau la inceput si trebuie sa scap si indexul dar nu e tocmai ok
            For i = selectedItemCount - 1 To 0 Step -1
                'MessageBox.Show(selectedItemCount)
                'lstStudent.SelectedItems(0).Remove()
                ' lstBoxAuto.Items.RemoveAt(selectedIndex)
                lstBoxAuto.Items.Remove(lstBoxAuto.SelectedItems(i))

                'If (chklstbox_Auto.GetItemChecked(i)) Then
                '    chklstbox_Auto.SetItemCheckState(i, CheckState.Unchecked)
                'End If
            Next
            MessageBox.Show("Inregistrarea/Inregistrarile a fost stearse cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Trebuie sa selectezi o inregistrare!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
#End Region

#Region "Stergere info din textBox"
    Private Sub ClearTxtBox()
        txtMarca.Text = ""
        txtModel.Text = ""
    End Sub
#End Region

#Region "Adaugare culoare la panel-ul din stanga"
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        Panel1.BackColor = Color.FromArgb(38, 50, 56)
    End Sub
#End Region

#Region "Adaugare GroupBox ce cauta un autoturism in lista"
    Private Sub btnCauta_Click(sender As Object, e As EventArgs) Handles btnCauta.Click

        If txtCauta.Text = String.Empty Then
            message.Show("Trebuie sa completezi campul de mai sus!", "Informatii", MessageBoxButtons.OK)
        ElseIf chklstbox_Auto.Items.Count = 0 Then
            MessageBox.Show("Pentru a cauta o informatie in lista, trebuie sa o afisati si apoi sa cautati!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'chklstbox_Auto.Items.Clear()
            CautaAutov2(txtCauta.Text)
            'CautaAuto(txtCauta.Text)
        End If
    End Sub
#End Region

#Region "Function SearchAutoInList"
    Private Sub CautaAuto(ByVal searchItem As String)
        ' Loop items
        For Each lbItem As Object In chklstbox_Auto.Items
            ' Case-sensitive match
            If lbItem.ToString = searchItem Then
                ' Match found: set as selected item and exit procedure
                chklstbox_Auto.SelectedItem = lbItem
                chklstbox_Auto.Items.Clear()
                chklstbox_Auto.Items.Add(lbItem)
                Return
            Else

            End If
        Next
        MessageBox.Show("Autoturismul nu a fost gasit!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub
#End Region

#Region "Function SearchAutoInList V2"
    Private Sub CautaAutov2(ByVal searchItem As String)

        Dim nrItemInChekedBoxLis = chklstbox_Auto.Items.Count - 1
        Dim i As Integer
        For i = 0 To nrItemInChekedBoxLis
            If chklstbox_Auto.Items(i).ToString().ToLower().Contains(searchItem.ToLower()) Then
                chklstbox_Auto.SetItemChecked(i, True)
            End If
        Next
        mlblInfoGasite.Text = $"Au fost gasite: {chklstbox_Auto.CheckedItems.Count.ToString()} informatii!"
    End Sub
#End Region
End Class


#End Region