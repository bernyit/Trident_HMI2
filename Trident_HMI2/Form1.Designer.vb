<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmrUpdateScreen = New System.Windows.Forms.Timer(Me.components)
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ph12 = New System.Windows.Forms.Panel()
        Me.ph10 = New System.Windows.Forms.Panel()
        Me.ph07 = New System.Windows.Forms.Panel()
        Me.ph05 = New System.Windows.Forms.Panel()
        Me.ph04 = New System.Windows.Forms.Panel()
        Me.ph03 = New System.Windows.Forms.Panel()
        Me.ph02 = New System.Windows.Forms.Panel()
        Me.ph01 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1155, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 81)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tmrUpdateScreen
        '
        Me.tmrUpdateScreen.Enabled = True
        Me.tmrUpdateScreen.Interval = 250
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Location = New System.Drawing.Point(202, 73)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(39, 13)
        Me.lblDateTime.TabIndex = 1
        Me.lblDateTime.Text = "Label1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1094, 705)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ph12)
        Me.TabPage1.Controls.Add(Me.ph10)
        Me.TabPage1.Controls.Add(Me.ph07)
        Me.TabPage1.Controls.Add(Me.ph05)
        Me.TabPage1.Controls.Add(Me.ph04)
        Me.TabPage1.Controls.Add(Me.ph03)
        Me.TabPage1.Controls.Add(Me.ph02)
        Me.TabPage1.Controls.Add(Me.ph01)
        Me.TabPage1.Controls.Add(Me.lblDateTime)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1086, 679)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(862, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'ph12
        '
        Me.ph12.BackColor = System.Drawing.Color.Lime
        Me.ph12.Location = New System.Drawing.Point(926, 119)
        Me.ph12.Name = "ph12"
        Me.ph12.Size = New System.Drawing.Size(10, 137)
        Me.ph12.TabIndex = 9
        '
        'ph10
        '
        Me.ph10.BackColor = System.Drawing.Color.Lime
        Me.ph10.Location = New System.Drawing.Point(926, 433)
        Me.ph10.Name = "ph10"
        Me.ph10.Size = New System.Drawing.Size(10, 137)
        Me.ph10.TabIndex = 8
        '
        'ph07
        '
        Me.ph07.BackColor = System.Drawing.Color.Lime
        Me.ph07.Location = New System.Drawing.Point(580, 275)
        Me.ph07.Name = "ph07"
        Me.ph07.Size = New System.Drawing.Size(10, 137)
        Me.ph07.TabIndex = 7
        '
        'ph05
        '
        Me.ph05.BackColor = System.Drawing.Color.Lime
        Me.ph05.Location = New System.Drawing.Point(458, 275)
        Me.ph05.Name = "ph05"
        Me.ph05.Size = New System.Drawing.Size(10, 137)
        Me.ph05.TabIndex = 6
        '
        'ph04
        '
        Me.ph04.BackColor = System.Drawing.Color.Lime
        Me.ph04.Location = New System.Drawing.Point(372, 275)
        Me.ph04.Name = "ph04"
        Me.ph04.Size = New System.Drawing.Size(10, 137)
        Me.ph04.TabIndex = 5
        '
        'ph03
        '
        Me.ph03.BackColor = System.Drawing.Color.Lime
        Me.ph03.Location = New System.Drawing.Point(285, 275)
        Me.ph03.Name = "ph03"
        Me.ph03.Size = New System.Drawing.Size(10, 137)
        Me.ph03.TabIndex = 4
        '
        'ph02
        '
        Me.ph02.BackColor = System.Drawing.Color.Lime
        Me.ph02.Location = New System.Drawing.Point(196, 275)
        Me.ph02.Name = "ph02"
        Me.ph02.Size = New System.Drawing.Size(10, 137)
        Me.ph02.TabIndex = 3
        '
        'ph01
        '
        Me.ph01.BackColor = System.Drawing.Color.Lime
        Me.ph01.Location = New System.Drawing.Point(98, 275)
        Me.ph01.Name = "ph01"
        Me.ph01.Size = New System.Drawing.Size(10, 137)
        Me.ph01.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Trident_HMI2.My.Resources.Resources.LAYOUT
        Me.PictureBox1.Location = New System.Drawing.Point(57, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1008, 618)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1086, 679)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1155, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 81)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents tmrUpdateScreen As Timer
    Friend WithEvents lblDateTime As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ph12 As Panel
    Friend WithEvents ph10 As Panel
    Friend WithEvents ph07 As Panel
    Friend WithEvents ph05 As Panel
    Friend WithEvents ph04 As Panel
    Friend WithEvents ph03 As Panel
    Friend WithEvents ph02 As Panel
    Friend WithEvents ph01 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
