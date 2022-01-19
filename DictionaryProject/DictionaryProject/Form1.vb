Public Class Form1


    Public tempId As Integer
    Public tempName As String

    Public dictionary As New Dictionary(Of Integer, String)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try

            dictionary.Add(txtId.Text, txtCname.Text)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


        lbDictionary.Items.Clear()
        txtId.Clear()
        txtCname.Clear()

        For Each pair As KeyValuePair(Of Integer, String) In dictionary

            lbDictionary.Items.Add(pair.Key & " - " & pair.Value)

        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Try

            dictionary.Remove(txtId.Text)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        lbDictionary.Items.Clear()
        txtId.Clear()
        txtCname.Clear()

        For Each pair As KeyValuePair(Of Integer, String) In dictionary

            lbDictionary.Items.Add(pair.Key & " - " & pair.Value)

        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim tempSelect As String
        Dim capTemplate() As String

        Try

            tempSelect = lbDictionary.SelectedItem
            capTemplate = Split(tempSelect, " - ")

            tempId = capTemplate(0)
            tempName = capTemplate(1)

            Hide()
            Form2.Show()

        Catch ex As Exception

            MessageBox.Show("Please select a value to edit.")

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("This program is a trading card collection manager. You will start by entering the name and id number of your card. (ID found on the bottem left
of your card). You will then have the option to edit this card to add its other various traits. These traits will be saved to be accessed whenever this program is launched.")

    End Sub
End Class
