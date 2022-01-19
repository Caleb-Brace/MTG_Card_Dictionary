<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.cbSuper = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.cbCmc = New System.Windows.Forms.ComboBox()
        Me.cbRarity = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSub = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cbColor = New System.Windows.Forms.ComboBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbSuper
        '
        Me.cbSuper.FormattingEnabled = True
        Me.cbSuper.Location = New System.Drawing.Point(101, 258)
        Me.cbSuper.Name = "cbSuper"
        Me.cbSuper.Size = New System.Drawing.Size(105, 21)
        Me.cbSuper.TabIndex = 10
        Me.cbSuper.Text = "Super-Type"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(238, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(321, 388)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'cbType
        '
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(101, 285)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(105, 21)
        Me.cbType.TabIndex = 12
        Me.cbType.Text = "Type"
        '
        'cbCmc
        '
        Me.cbCmc.FormattingEnabled = True
        Me.cbCmc.Location = New System.Drawing.Point(524, 69)
        Me.cbCmc.Name = "cbCmc"
        Me.cbCmc.Size = New System.Drawing.Size(105, 21)
        Me.cbCmc.TabIndex = 13
        Me.cbCmc.Text = "CMC"
        '
        'cbRarity
        '
        Me.cbRarity.FormattingEnabled = True
        Me.cbRarity.Location = New System.Drawing.Point(524, 258)
        Me.cbRarity.Name = "cbRarity"
        Me.cbRarity.Size = New System.Drawing.Size(105, 21)
        Me.cbRarity.TabIndex = 14
        Me.cbRarity.Text = "Rarity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(562, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "This form requires you to set each field to return back to the original menu. All" &
    " values applicable to this sample are set. "
        '
        'tbSub
        '
        Me.tbSub.Location = New System.Drawing.Point(101, 312)
        Me.tbSub.Name = "tbSub"
        Me.tbSub.Size = New System.Drawing.Size(105, 20)
        Me.tbSub.TabIndex = 17
        Me.tbSub.Text = "Dragon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Left to right typing: Super, type, and finally sub."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(521, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "CMC is calculated by adding number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(521, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "to quantity of emblems. In this example, it is 4."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(521, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "From common to mythic rarity, color codes are:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(521, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = " White, Silver, Gold, Red"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(604, 370)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(184, 31)
        Me.btnSubmit.TabIndex = 24
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'cbColor
        '
        Me.cbColor.FormattingEnabled = True
        Me.cbColor.Location = New System.Drawing.Point(101, 117)
        Me.cbColor.Name = "cbColor"
        Me.cbColor.Size = New System.Drawing.Size(105, 21)
        Me.cbColor.TabIndex = 26
        Me.cbColor.Text = "Color Identity"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(101, 69)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(105, 20)
        Me.tbName.TabIndex = 27
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(604, 407)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(184, 31)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.cbColor)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbSub)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbRarity)
        Me.Controls.Add(Me.cbCmc)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbSuper)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbSuper As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbType As ComboBox
    Friend WithEvents cbCmc As ComboBox
    Friend WithEvents cbRarity As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSub As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cbColor As ComboBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents btnClose As Button
End Class
