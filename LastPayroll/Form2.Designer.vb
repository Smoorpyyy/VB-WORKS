<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Button1 = New Button()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.BackColor = Color.RoyalBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(417, 348)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 0
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.InactiveBorder
        Label2.Location = New Point(396, 265)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 28)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.BackColor = SystemColors.ButtonHighlight
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(396, 223)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(184, 31)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.BackColor = SystemColors.ButtonHighlight
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(396, 293)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(184, 31)
        TextBox2.TabIndex = 4
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources._9815472
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(334, 205)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(56, 49)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources._14605836
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(334, 275)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(56, 49)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.InactiveBorder
        Label1.Location = New Point(396, 195)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 28)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Courier New", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(206, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(511, 110)
        Label3.TabIndex = 7
        Label3.Text = "WELCOME!"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(434, 385)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 25)
        Label4.TabIndex = 8
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.images__1_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(938, 537)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
