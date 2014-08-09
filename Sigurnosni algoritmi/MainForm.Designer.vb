<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InformationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CryptographyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TripleDESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AESRijndaelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HashingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHA1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHA256ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Encryption_Box = New System.Windows.Forms.GroupBox()
        Me.rbAES = New System.Windows.Forms.RadioButton()
        Me.rbTripleDES = New System.Windows.Forms.RadioButton()
        Me.rbDES = New System.Windows.Forms.RadioButton()
        Me.Hash_Box = New System.Windows.Forms.GroupBox()
        Me.rbSHA256 = New System.Windows.Forms.RadioButton()
        Me.rbSHA1 = New System.Windows.Forms.RadioButton()
        Me.rbMD5 = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Encryption_Box.SuspendLayout()
        Me.Hash_Box.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(444, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(473, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformationsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(560, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InformationsToolStripMenuItem
        '
        Me.InformationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CryptographyToolStripMenuItem, Me.ToolStripSeparator1, Me.HashingToolStripMenuItem})
        Me.InformationsToolStripMenuItem.Name = "InformationsToolStripMenuItem"
        Me.InformationsToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.InformationsToolStripMenuItem.Text = "Information"
        '
        'CryptographyToolStripMenuItem
        '
        Me.CryptographyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AESToolStripMenuItem, Me.TripleDESToolStripMenuItem, Me.AESRijndaelToolStripMenuItem})
        Me.CryptographyToolStripMenuItem.Name = "CryptographyToolStripMenuItem"
        Me.CryptographyToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CryptographyToolStripMenuItem.Text = "Cryptographic functions"
        '
        'AESToolStripMenuItem
        '
        Me.AESToolStripMenuItem.Name = "AESToolStripMenuItem"
        Me.AESToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AESToolStripMenuItem.Text = "DES"
        '
        'TripleDESToolStripMenuItem
        '
        Me.TripleDESToolStripMenuItem.Name = "TripleDESToolStripMenuItem"
        Me.TripleDESToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TripleDESToolStripMenuItem.Text = "TripleDES"
        '
        'AESRijndaelToolStripMenuItem
        '
        Me.AESRijndaelToolStripMenuItem.Name = "AESRijndaelToolStripMenuItem"
        Me.AESRijndaelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AESRijndaelToolStripMenuItem.Text = "AES (Rijndael)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(200, 6)
        '
        'HashingToolStripMenuItem
        '
        Me.HashingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MD5ToolStripMenuItem, Me.SHA1ToolStripMenuItem, Me.SHA256ToolStripMenuItem})
        Me.HashingToolStripMenuItem.Name = "HashingToolStripMenuItem"
        Me.HashingToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.HashingToolStripMenuItem.Text = "Hash functions"
        '
        'MD5ToolStripMenuItem
        '
        Me.MD5ToolStripMenuItem.Name = "MD5ToolStripMenuItem"
        Me.MD5ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MD5ToolStripMenuItem.Text = "MD5"
        '
        'SHA1ToolStripMenuItem
        '
        Me.SHA1ToolStripMenuItem.Name = "SHA1ToolStripMenuItem"
        Me.SHA1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SHA1ToolStripMenuItem.Text = "SHA-1"
        '
        'SHA256ToolStripMenuItem
        '
        Me.SHA256ToolStripMenuItem.Name = "SHA256ToolStripMenuItem"
        Me.SHA256ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SHA256ToolStripMenuItem.Text = "SHA-256"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Insert the string you wish to encrypt/hash here:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 309)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(560, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.IT_Security_Algorithms.My.Resources.Resources.it_security
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(560, 331)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 83)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Encryption"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(15, 106)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Hashing"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Encryption_Box
        '
        Me.Encryption_Box.BackColor = System.Drawing.SystemColors.Control
        Me.Encryption_Box.Controls.Add(Me.rbAES)
        Me.Encryption_Box.Controls.Add(Me.rbTripleDES)
        Me.Encryption_Box.Controls.Add(Me.rbDES)
        Me.Encryption_Box.Enabled = False
        Me.Encryption_Box.Location = New System.Drawing.Point(141, 83)
        Me.Encryption_Box.Name = "Encryption_Box"
        Me.Encryption_Box.Size = New System.Drawing.Size(200, 93)
        Me.Encryption_Box.TabIndex = 9
        Me.Encryption_Box.TabStop = False
        Me.Encryption_Box.Text = "List of encryption algorithms"
        '
        'rbAES
        '
        Me.rbAES.AutoSize = True
        Me.rbAES.Location = New System.Drawing.Point(7, 68)
        Me.rbAES.Name = "rbAES"
        Me.rbAES.Size = New System.Drawing.Size(46, 17)
        Me.rbAES.TabIndex = 2
        Me.rbAES.TabStop = True
        Me.rbAES.Text = "AES"
        Me.rbAES.UseVisualStyleBackColor = True
        '
        'rbTripleDES
        '
        Me.rbTripleDES.AutoSize = True
        Me.rbTripleDES.Location = New System.Drawing.Point(7, 44)
        Me.rbTripleDES.Name = "rbTripleDES"
        Me.rbTripleDES.Size = New System.Drawing.Size(73, 17)
        Me.rbTripleDES.TabIndex = 1
        Me.rbTripleDES.TabStop = True
        Me.rbTripleDES.Text = "TripleDES"
        Me.rbTripleDES.UseVisualStyleBackColor = True
        '
        'rbDES
        '
        Me.rbDES.AutoSize = True
        Me.rbDES.Location = New System.Drawing.Point(7, 20)
        Me.rbDES.Name = "rbDES"
        Me.rbDES.Size = New System.Drawing.Size(47, 17)
        Me.rbDES.TabIndex = 0
        Me.rbDES.TabStop = True
        Me.rbDES.Text = "DES"
        Me.rbDES.UseVisualStyleBackColor = True
        '
        'Hash_Box
        '
        Me.Hash_Box.Controls.Add(Me.rbSHA256)
        Me.Hash_Box.Controls.Add(Me.rbSHA1)
        Me.Hash_Box.Controls.Add(Me.rbMD5)
        Me.Hash_Box.Enabled = False
        Me.Hash_Box.Location = New System.Drawing.Point(348, 83)
        Me.Hash_Box.Name = "Hash_Box"
        Me.Hash_Box.Size = New System.Drawing.Size(200, 93)
        Me.Hash_Box.TabIndex = 10
        Me.Hash_Box.TabStop = False
        Me.Hash_Box.Text = "List of hash algorithms"
        '
        'rbSHA256
        '
        Me.rbSHA256.AutoSize = True
        Me.rbSHA256.Location = New System.Drawing.Point(6, 67)
        Me.rbSHA256.Name = "rbSHA256"
        Me.rbSHA256.Size = New System.Drawing.Size(68, 17)
        Me.rbSHA256.TabIndex = 2
        Me.rbSHA256.TabStop = True
        Me.rbSHA256.Text = "SHA-256"
        Me.rbSHA256.UseVisualStyleBackColor = True
        '
        'rbSHA1
        '
        Me.rbSHA1.AutoSize = True
        Me.rbSHA1.Location = New System.Drawing.Point(7, 44)
        Me.rbSHA1.Name = "rbSHA1"
        Me.rbSHA1.Size = New System.Drawing.Size(56, 17)
        Me.rbSHA1.TabIndex = 1
        Me.rbSHA1.TabStop = True
        Me.rbSHA1.Text = "SHA-1"
        Me.rbSHA1.UseVisualStyleBackColor = True
        '
        'rbMD5
        '
        Me.rbMD5.AutoSize = True
        Me.rbMD5.Location = New System.Drawing.Point(7, 20)
        Me.rbMD5.Name = "rbMD5"
        Me.rbMD5.Size = New System.Drawing.Size(48, 17)
        Me.rbMD5.TabIndex = 0
        Me.rbMD5.TabStop = True
        Me.rbMD5.Text = "MD5"
        Me.rbMD5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbMD5.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 331)
        Me.Controls.Add(Me.Hash_Box)
        Me.Controls.Add(Me.Encryption_Box)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Implementacija sigurnosnih algoritama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Encryption_Box.ResumeLayout(False)
        Me.Encryption_Box.PerformLayout()
        Me.Hash_Box.ResumeLayout(False)
        Me.Hash_Box.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InformationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CryptographyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TripleDESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AESRijndaelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HashingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MD5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Encryption_Box As System.Windows.Forms.GroupBox
    Friend WithEvents rbAES As System.Windows.Forms.RadioButton
    Friend WithEvents rbTripleDES As System.Windows.Forms.RadioButton
    Friend WithEvents rbDES As System.Windows.Forms.RadioButton
    Friend WithEvents Hash_Box As System.Windows.Forms.GroupBox
    Friend WithEvents rbSHA1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbMD5 As System.Windows.Forms.RadioButton
    Friend WithEvents rbSHA256 As System.Windows.Forms.RadioButton
    Friend WithEvents SHA1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SHA256ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
