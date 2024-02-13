<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Object_Demo
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
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        GroupBox3 = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        GroupBox4 = New GroupBox()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox1.BackColor = SystemColors.ButtonHighlight
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.ForeColor = SystemColors.ActiveCaptionText
        GroupBox1.Location = New Point(100, 153)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(393, 355)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Display Text"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Window
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(27, 88)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(294, 40)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Sample Text"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(CheckBox3)
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.Location = New Point(687, 566)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(328, 386)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = " Font Style"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox3.Location = New Point(49, 264)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(199, 45)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Bold Italic"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox2.Location = New Point(49, 170)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(121, 45)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Bold"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = SystemColors.Window
        CheckBox1.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(49, 92)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(119, 45)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Italic"
        CheckBox1.TextAlign = ContentAlignment.TopRight
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton3)
        GroupBox3.Controls.Add(RadioButton2)
        GroupBox3.Controls.Add(RadioButton1)
        GroupBox3.Location = New Point(1090, 566)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(375, 386)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = " Font Color"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(65, 317)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(106, 45)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Red"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(65, 63)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(135, 45)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Green"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(65, 191)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(112, 45)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Blue"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(RadioButton6)
        GroupBox4.Controls.Add(RadioButton5)
        GroupBox4.Controls.Add(RadioButton4)
        GroupBox4.Location = New Point(536, 153)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(891, 355)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Font"
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(578, 120)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(159, 45)
        RadioButton6.TabIndex = 2
        RadioButton6.TabStop = True
        RadioButton6.Text = "Tahoma"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(294, 120)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(176, 45)
        RadioButton5.TabIndex = 1
        RadioButton5.TabStop = True
        RadioButton5.Text = "Magneto"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(39, 120)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(195, 45)
        RadioButton4.TabIndex = 0
        RadioButton4.TabStop = True
        RadioButton4.Text = "Garamond"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(100, 542)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(489, 410)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ImageAlign = ContentAlignment.TopLeft
        Button1.Location = New Point(217, 983)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(10)
        Button1.Size = New Size(374, 128)
        Button1.TabIndex = 5
        Button1.Text = "Load Picture"
        Button1.TextAlign = ContentAlignment.TopLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderColor = Color.Black
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(1178, 997)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(10, 0, 0, 0)
        Button2.Size = New Size(174, 101)
        Button2.TabIndex = 6
        Button2.Text = "Exit"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Object_Demo
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(2164, 1215)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Object_Demo"
        Padding = New Padding(3)
        Text = "Object Demonstrations"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
