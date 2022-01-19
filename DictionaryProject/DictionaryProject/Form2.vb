Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbName.Text = Form1.tempName

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
        cbSuper.Items.Add("Basic")
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

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim newCard = New CardInfo(Form1.tempId, Form1.tempName, cbCmc.SelectedItem, cbSuper.SelectedIndex, cbType.SelectedIndex, tbSub.ToString, cbRarity.SelectedIndex, cbRarity.SelectedIndex)

        Me.Close()
        Form1.Show()

    End Sub

    Private Sub tbSub_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbSub.MouseClick
        tbSub.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
