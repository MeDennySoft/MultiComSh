<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encriptador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Encriptador))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(777, 256)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Entrada: Texto a transformar o revertir + La clave"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 43)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(684, 208)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(696, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Strong"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(483, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "<<<<------ Clave necesaria para encriptación-----<<<"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Clave"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(89, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(334, 20)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 313)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(777, 242)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultado"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 13)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(684, 229)
        Me.TextBox3.TabIndex = 10
        Me.TextBox3.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Button13)
        Me.GroupBox4.Controls.Add(Me.Button12)
        Me.GroupBox4.Controls.Add(Me.Button11)
        Me.GroupBox4.Controls.Add(Me.Button10)
        Me.GroupBox4.Controls.Add(Me.Button9)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Location = New System.Drawing.Point(314, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(463, 45)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Funciones"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button13
        '
        Me.Button13.Image = Global.MultiCom.My.Resources.Resources.page_white_font
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.Location = New System.Drawing.Point(328, 14)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(26, 25)
        Me.Button13.TabIndex = 15
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Image = Global.MultiCom.My.Resources.Resources.application_osx_lightning
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.Location = New System.Drawing.Point(371, 14)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(26, 25)
        Me.Button12.TabIndex = 14
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Image = Global.MultiCom.My.Resources.Resources.world_connect
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(418, 14)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(26, 25)
        Me.Button11.TabIndex = 13
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Image = Global.MultiCom.My.Resources.Resources.disk_magnify
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(287, 14)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(26, 25)
        Me.Button10.TabIndex = 12
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Image = Global.MultiCom.My.Resources.Resources.box_picture
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(191, 15)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 24)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "Abrir"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.MultiCom.My.Resources.Resources.play_blue
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(18, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 22)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Encriptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.MultiCom.My.Resources.Resources.reload
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(106, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Reverse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = Global.MultiCom.My.Resources.Resources.arrow_sw_ne
        Me.Button7.Location = New System.Drawing.Point(694, 116)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 24)
        Me.Button7.TabIndex = 11
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.MultiCom.My.Resources.Resources.disk_black
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(694, 54)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 25)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "   Guardar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.MultiCom.My.Resources.Resources.database_copy
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(694, 85)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 25)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Copiar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Image = Global.MultiCom.My.Resources.Resources.page_white_break
        Me.Button8.Location = New System.Drawing.Point(694, 141)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 22)
        Me.Button8.TabIndex = 11
        Me.Button8.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackgroundImage = Global.MultiCom.My.Resources.Resources.application_osx_key
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CheckBox1.Location = New System.Drawing.Point(429, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Auto"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.MultiCom.My.Resources.Resources.disk_black
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(694, 79)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 25)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "   Guardar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.MultiCom.My.Resources.Resources.database_copy
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(694, 110)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 25)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Copiar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(9, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(88, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "AES Base 64"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(119, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(82, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Numerico64"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(226, 19)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Base 64"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algoritmo de Cifrado"
        '
        'Encriptador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 558)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Encriptador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":::::...CRYPTOSHAURUS...:::::"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
