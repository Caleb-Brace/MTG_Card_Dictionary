Imports System.Text.RegularExpressions
Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim uiSetup As String
        Dim uiOutput() As String

        tbName.Text = Form1.tempName

        btnSubmit.Show()

        PictureBox1.Show()
        PictureBox2.Hide()

        cbCmc.Items.Add(0)
        cbCmc.Items.Add(1)
        cbCmc.Items.Add(2)
        cbCmc.Items.Add(3)
        cbCmc.Items.Add(4)
        cbCmc.Items.Add(5)
        cbCmc.Items.Add(6)
        cbCmc.Items.Add(7)
        cbCmc.Items.Add(8)
        cbCmc.Items.Add(9)
        cbCmc.Items.Add(10)
        cbCmc.Items.Add(11)
        cbCmc.Items.Add(12)
        cbCmc.Items.Add(13)
        cbCmc.Items.Add(14)
        cbCmc.Items.Add(15)

        cbRarity.Items.Add("Common")
        cbRarity.Items.Add("Uncommon")
        cbRarity.Items.Add("Rare")
        cbRarity.Items.Add("Mythic")

        cbSuper.Items.Add(" ")
        cbSuper.Items.Add("Basic")              '' Adding items to the various combo boxes used on the form
        cbSuper.Items.Add("Legendary")
        cbSuper.Items.Add("Elite")
        cbSuper.Items.Add("Host")
        cbSuper.Items.Add("Ongoing")
        cbSuper.Items.Add("Snow")
        cbSuper.Items.Add("World")

        cbType.Items.Add("Land")
        cbType.Items.Add("Creature")
        cbType.Items.Add("Artifact")
        cbType.Items.Add("Enchantment")
        cbType.Items.Add("Planeswalker")
        cbType.Items.Add("Instant")
        cbType.Items.Add("Sorcery")

        cbColor.Items.Add("White")
        cbColor.Items.Add("Blue")
        cbColor.Items.Add("Black")
        cbColor.Items.Add("Red")
        cbColor.Items.Add("Green")
        cbColor.Items.Add("Colorless")
        cbColor.Items.Add("Multicolor")

        cbType.SelectedIndex = 1
        cbSuper.SelectedIndex = 0
        cbRarity.SelectedIndex = 3
        cbCmc.SelectedIndex = 4
        cbColor.SelectedIndex = 3

        Try
            uiSetup = Form1.cardListOut(Form1.lbDictionary.SelectedIndex)   ''Utilizes the attributes tied to the selection on first form. If there has yet to be an
            uiOutput = Split(uiSetup, ",")                                  '' class made from card, skips these changed ui presets.

            tbName.Text = uiOutput(1)
            tbSub.Text = uiOutput(5)
            cbType.SelectedIndex = uiOutput(4)
            cbSuper.SelectedIndex = uiOutput(3)
            cbRarity.SelectedIndex = uiOutput(6)
            cbCmc.SelectedIndex = uiOutput(2)
            cbColor.SelectedIndex = uiOutput(7)

            PictureBox1.Hide()          ''Hides demo card and shows blank card
            PictureBox2.Show()

            btnSubmit.Hide() ''Hides submit button to prevent a duplicant entry

        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim newCard As New CardInfo(Form1.tempId, Form1.tempName, cbCmc.SelectedItem, cbSuper.SelectedIndex, cbType.SelectedIndex, tbSub.Text, cbRarity.SelectedIndex, cbColor.SelectedIndex)
        Dim outFile As IO.StreamWriter

        If IO.File.Exists("Mtg.txt") Then

            outFile = IO.File.AppendText("Mtg.txt") ''Set streamwriter to open Mtg.txt using Append Text to add

            outFile.WriteLine(newCard.OutputCard) ''Writes the contents of this class to the next line of the text file.

            outFile.Close()

        End If

        Me.Close()

        Form1.Show()


    End Sub

    Private Sub tbSub_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbSub.MouseClick
        tbSub.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click


        Me.Close()
        Form1.Show()
    End Sub

End Class
