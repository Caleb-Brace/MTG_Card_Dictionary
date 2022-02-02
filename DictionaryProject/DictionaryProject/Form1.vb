Imports System.Text.RegularExpressions
Public Class Form1

    Public removalSuite As New ArrayList
    Public cardListIn As New ArrayList
    Public cardListOut As New ArrayList
    Public tempId As Integer
    Public tempName As String
    Dim inFile As IO.StreamReader

    Public dictionary As New Dictionary(Of Integer, String)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try

            dictionary.Add(txtId.Text, txtCname.Text)       ''Attempts to add dictionary entry from Id and card name provided by user

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


        lbDictionary.Items.Clear()
        txtId.Clear()
        txtCname.Clear()                    ''Clears box and adds every entry from dictionary seperated with -

        For Each pair As KeyValuePair(Of Integer, String) In dictionary

            lbDictionary.Items.Add(pair.Key & " - " & pair.Value)

        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim outFile As IO.StreamWriter

        Try

            dictionary.Remove(removalSuite(lbDictionary.SelectedIndex))     ''Utilizes the selectedindex of the listbox to find the corresponding entry available in the suite

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        lbDictionary.Items.Clear()
        txtId.Clear()
        txtCname.Clear()

        For Each pair As KeyValuePair(Of Integer, String) In dictionary

            lbDictionary.Items.Add(pair.Key & " - " & pair.Value)   ''rebuilds the listbox after removing an entry from it

        Next

        Try

            cardListIn.RemoveAt(lbDictionary.SelectedIndex) '' this section is supposed to permanently delete an entry from the text file.
            '' for some reason when i declare the element to be chosen as based on index of selection it doesn't work.
            '' This does work if any hard number is added instead.

            If IO.File.Exists("Mtg.txt") Then

                outFile = IO.File.CreateText("Mtg.txt")     ''Set streamwriter to open NeedToVisit.txt using creattext to overwrite

                For count As Integer = 0 To cardListIn.Count - 1

                    outFile.WriteLine(cardListIn(count))  ''Writes each line from within the array list to the text file

                Next

                outFile.Close()

            End If

        Catch
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim tempSelect As String
        Dim capTemplate() As String

        Try

            tempSelect = lbDictionary.SelectedItem  ''Create placeholders to split the content of the selected listbox entry. Brings name to form 2
            capTemplate = Split(tempSelect, " - ")

            tempId = capTemplate(0)
            tempName = capTemplate(1)

            Hide()
            Form2.Show()

        Catch ex As Exception

            MessageBox.Show("Please select an entry to edit.") ''handles clicking edit without a target

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("This program is a trading card collection manager. You will start by entering the name and id number of your card. (ID found on the bottem left
of your card). You will then have the option to edit this card to add its other various traits. These traits will be saved to when the program exits.")

        Dim counter As Integer = 0
        Dim cardBox As String
        Dim cleanCard As String
        Dim splitString() As String



        If IO.File.Exists("Mtg.txt") Then

            inFile = IO.File.OpenText("Mtg.txt")

            Do Until inFile.Peek = -1

                cardListIn.Add(inFile.ReadLine) ''Reads each line of the text file and adds it to an array
                cardBox = cardListIn(counter)
                cleanCard = Regex.Replace(cardBox, "[()]", "")
                cardListOut.Add(cleanCard)          ''Takes the format entered into the text box, removing the parenthesis and then splitting to use the first two entries to make a 
                splitString = Split(cleanCard, ",") ''dictionary entry for later use.

                removalSuite.Add(splitString(0))
                dictionary.Add(splitString(0), splitString(1))
                counter += 1
            Loop

            inFile.Close()

            For Each pair As KeyValuePair(Of Integer, String) In dictionary

                lbDictionary.Items.Add(pair.Key & " - " & pair.Value)   ''Populate table again.

            Next


        End If
    End Sub
End Class
