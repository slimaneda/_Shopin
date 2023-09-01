Imports System.IO
Public Class Main



    Private Sub InsertData()

    End Sub

    Private Sub PopulateComboBoxFromFile(filePath As String)
        If File.Exists(filePath) Then
            Dim items As String() = File.ReadAllLines(filePath)
            ComboBox1.Items.Clear()

            For Each item As String In items
                ComboBox1.Items.Add(item)
            Next
        Else
            MessageBox.Show("The items file does not exist.")
        End If
    End Sub
    Private Sub ShowDatagridview()


        Dim dt As New DataTable()
        dt.Columns.Add("Item")
        dt.Columns.Add("Code bare")
        dt.Columns.Add("Unite")
        dt.Columns.Add("Date")
        dt.Columns.Add("Quantity in")
        dt.Columns.Add("Price In")
        dt.Columns.Add("Quantity Out ")
        dt.Columns.Add("Price Out")

        Using reader As New StreamReader("db/Produit.txt")
            Do While reader.Peek() <> -1
                Dim line As String = reader.ReadLine()
                Dim parts As String() = line.Split("|"c)
                If parts.Length = 8 Then
                    dt.Rows.Add(parts)
                End If
            Loop
        End Using

        DataGridView1.DataSource = dt

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ShowDatagridview()
        PopulateComboBoxFromFile("db/Category.txt")
        If ComboBox1.Items.Count > 0 Then
            ComboBox1.Text = ComboBox1.Items(0).ToString()
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If Text_item.Text = "" Then

            ErrorProvider1.SetError(Text_item, "يرجى ادخال اسم الزبون")
            Text_item.Select()
            Exit Sub
        Else
            ErrorProvider1.SetError(Text_item, "")
            Text_item.Select()

            If Text_code.Text = "" Then

                ErrorProvider1.SetError(Text_code, "يرجى ادخال اسم الزبون")
                Text_code.Select()
                Exit Sub
            Else
                ErrorProvider1.SetError(Text_code, "")
                Text_code.Select()
                '=========================== add==================
                Dim extralin As String = $"{Text_item.Text}|{Text_code.Text}|{ComboBox1.Text}|{text_date.Text}|{Text_qtyin.Text}|{Text_pricin.Text}|{Text_qtyout.Text}|{Text_priceout.Text}"

                File.AppendAllText("db/Produit.txt", extralin & Environment.NewLine)

                '====================================================================



                ShowDatagridview()
            End If
        End If
    End Sub

    Private Sub btn_addunite_Click(sender As Object, e As EventArgs) Handles btn_addunite.Click
        File.AppendAllText("db/Category.txt", ComboBox1.Text & Environment.NewLine)
        PopulateComboBoxFromFile("db/Category.txt")
    End Sub

    Private Sub btn_deleteunite_Click(sender As Object, e As EventArgs) Handles btn_deleteunite.Click

        Dim selectedItem As String = ComboBox1.Text
        Dim filePath As String = "db/Category.txt"

        If ComboBox1.Items.Contains(selectedItem) Then
            ' Remove item from ComboBox
            ComboBox1.Items.Remove(selectedItem)

            ' Remove item from Category.txt file
            Dim lines As List(Of String) = File.ReadAllLines(filePath).ToList()
            lines.Remove(selectedItem)
            File.WriteAllLines(filePath, lines.ToArray())

            ' Clear ComboBox text
            ComboBox1.Text = ""

            MessageBox.Show("Item deleted successfully.")
        Else
            MessageBox.Show("Selected item not found.")
        End If
    End Sub







    '================== btn searche ==========================================================

    Private Sub btn_search_itm_Click(sender As Object, e As EventArgs) Handles btn_search_itm.Click
        Dim searchitm As String = search_itm.Text.ToLower()

        ' Get the search term and convert to lowercase for case-insensitive comparison
        Dim dt As New DataTable() ' Create a new DataTable to store filtered data
        dt.Columns.Add("Item")
        dt.Columns.Add("Code bare")
        dt.Columns.Add("Unite")
        dt.Columns.Add("Date")
        dt.Columns.Add("Quantity in")
        dt.Columns.Add("Price In")
        dt.Columns.Add("Quantity Out ")
        dt.Columns.Add("Price Out")



        Using reader As New StreamReader("db/Produit.txt")
            Do While reader.Peek() <> -1
                Dim line As String = reader.ReadLine()
                Dim parts As String() = line.Split("|"c)

                If parts.Length = 8 AndAlso parts(0).ToLower().Contains(searchitm) Then
                    dt.Rows.Add(parts)

                End If
            Loop
        End Using

        DataGridView1.DataSource = dt ' Set the DataGridView's data source to the filtered DataTable

    End Sub

    Private Sub btn_search_code_Click(sender As Object, e As EventArgs) Handles btn_search_code.Click
        Dim searchcode As String = search_code.Text.ToLower()

        ' Get the search term and convert to lowercase for case-insensitive comparison
        Dim dt As New DataTable() ' Create a new DataTable to store filtered data
        dt.Columns.Add("Item")
        dt.Columns.Add("Code bare")
        dt.Columns.Add("Unite")
        dt.Columns.Add("Date")
        dt.Columns.Add("Quantity in")
        dt.Columns.Add("Price In")
        dt.Columns.Add("Quantity Out ")
        dt.Columns.Add("Price Out")


        Using reader As New StreamReader("db/Produit.txt")
            Do While reader.Peek() <> -1
                Dim line As String = reader.ReadLine()
                Dim parts As String() = line.Split("|"c)


                If parts.Length = 8 AndAlso parts(1).ToLower().Contains(searchcode) Then
                    dt.Rows.Add(parts)

                End If
            Loop
        End Using

        DataGridView1.DataSource = dt ' Set the DataGridView's data source to the filtered DataTable
        ' Your code for searching by code
    End Sub

    Private Sub btn_search_date_Click(sender As Object, e As EventArgs) Handles btn_search_date.Click

        Dim searchdate As String = search_date.Text.ToLower()
        ' Get the search term and convert to lowercase for case-insensitive comparison
        Dim dt As New DataTable() ' Create a new DataTable to store filtered data
        dt.Columns.Add("Item")
        dt.Columns.Add("Code bare")
        dt.Columns.Add("Unite")
        dt.Columns.Add("Date")
        dt.Columns.Add("Quantity in")
        dt.Columns.Add("Price In")
        dt.Columns.Add("Quantity Out ")
        dt.Columns.Add("Price Out")




        Using reader As New StreamReader("db/Produit.txt")
            Do While reader.Peek() <> -1
                Dim line As String = reader.ReadLine()
                Dim parts As String() = line.Split("|"c)

                If parts.Length = 8 AndAlso parts(3).ToLower().Contains(searchdate) Then
                    dt.Rows.Add(parts)
                End If
            Loop
        End Using

        DataGridView1.DataSource = dt ' Set the DataGridView's data source to the filtered DataTable
        ' Your code for searching by date
    End Sub

    '============================================================================================


    Private Sub btn_edte_Click(sender As Object, e As EventArgs) Handles btn_edte.Click

        Try
            Dim lines As New List(Of String)

            ' Iterate through DataGridView rows
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then ' Skip the new row, if present
                    ' Extract data from each row and format it as a line in the text file
                    Dim line As String = $"{row.Cells(0).Value}|{row.Cells(1).Value}|{row.Cells(2).Value}|{row.Cells(3).Value}|{row.Cells(4).Value}|{row.Cells(5).Value}|{row.Cells(6).Value}|{row.Cells(7).Value}"
                    lines.Add(line)
                End If
            Next

            ' Write the lines to the text file
            File.WriteAllLines("db/produit.txt", lines)

            MessageBox.Show("Data saved successfully ")
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
    End Sub



    Private Sub Text_qtyin_TextChanged(sender As Object, e As EventArgs) Handles Text_qtyin.TextChanged
        Text_totalqtyin.Text = Val(Text_qtyin.Text)
        Text_qtyin_qtyout.Text = Val(Text_qtyin.Text) - Val(Text_qtyout.Text)
    End Sub

    Private Sub Text_pricin_TextChanged(sender As Object, e As EventArgs) Handles Text_pricin.TextChanged
        Text_totalpricin.Text = Val(Text_pricin.Text)
        Texttotalin.Text = Val(Text_qtyin.Text) * Val(Text_pricin.Text)
    End Sub

    Private Sub Text_qtyout_TextChanged(sender As Object, e As EventArgs) Handles Text_qtyout.TextChanged
        Text_totalqtyout.Text = Val(Text_qtyout.Text)
        Text_qtyin_qtyout.Text = Val(Text_qtyin.Text) - Val(Text_qtyout.Text)
    End Sub

    Private Sub Text_priceout_TextChanged(sender As Object, e As EventArgs) Handles Text_priceout.TextChanged
        Text_totalpriceout.Text = Val(Text_priceout.Text)
        Text_totalout.Text = Val(Text_qtyout.Text) * Val(Text_priceout.Text)
        If Text_pricin.Text = Text_priceout.Text Then
            Text_profil.Text = Val(Text_qtyin_qtyout.Text) * Val(Text_pricin.Text)
        Else
            Text_profil.Text = Val(Text_qtyin_qtyout.Text) * (Val(Text_pricin.Text) - Val(Text_priceout.Text))
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        ' Check if any rows are selected
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Prompt the user for confirmation
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Remove selected rows from the DataGridView
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    If Not row.IsNewRow Then
                        DataGridView1.Rows.Remove(row)
                        btn_edte_Click(sender, e)
                    End If
                Next
            End If
        Else
            MessageBox.Show("No rows are selected to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        ' Vérifiez si la cellule sélectionnée est valide (non l'en-tête de colonne)
        If e.RowIndex >= 0 Then
            ' Obtenez la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Obtenez les valeurs des cellules de la ligne sélectionnée
            Dim itemValue As String = selectedRow.Cells("Item").Value.ToString()
            Dim codeValue As String = selectedRow.Cells("Code bare").Value.ToString()
            Dim comboBoxValue As String = selectedRow.Cells("Unite").Value.ToString()
            Dim dateValue As String = selectedRow.Cells("Date").Value.ToString()
            Dim qtyInValue As String = selectedRow.Cells("Quantity in").Value.ToString()
            Dim priceInValue As String = selectedRow.Cells("Price In").Value.ToString()
            Dim qtyOutValue As String = selectedRow.Cells("Quantity Out ").Value.ToString()
            Dim priceOutValue As String = selectedRow.Cells("Price Out").Value.ToString()

            ' Ajustez les noms des colonnes ("ColumnNameForItem", etc.) selon votre structure de DataGridView

            ' Affichez les valeurs dans les TextBox correspondants
            Text_item.Text = itemValue
            Text_code.Text = codeValue
            ComboBox1.Text = comboBoxValue
            text_date.Text = dateValue
            Text_qtyin.Text = qtyInValue
            Text_pricin.Text = priceInValue
            Text_qtyout.Text = qtyOutValue
            Text_priceout.Text = priceOutValue

            ' Vous pouvez également mettre à jour d'autres TextBox ici en fonction de votre modèle
        End If
    End Sub

    Private Sub btn_cleare_Click(sender As Object, e As EventArgs) Handles btn_cleare.Click
        Text_item.Text = ""
        Text_code.Text = ""
        ComboBox1.SelectedIndex = -1
        text_date.Text = ""
        Text_qtyin.Text = ""
        Text_pricin.Text = ""
        Text_qtyout.Text = ""
        Text_priceout.Text = ""
    End Sub
End Class