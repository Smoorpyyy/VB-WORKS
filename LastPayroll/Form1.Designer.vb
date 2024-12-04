<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Panel1 = New Panel()
        Label9 = New Label()
        TextBox7 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        TextBox6 = New TextBox()
        Panel2 = New Panel()
        Button5 = New Button()
        Label11 = New Label()
        PictureBox1 = New PictureBox()
        Label10 = New Label()
        LinkLabel1 = New LinkLabel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackgroundImage = My.Resources.Resources.istockphoto_1473121061_612x612
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(319, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1001, 614)
        Panel1.TabIndex = 13
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Courier New", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(57, 216)
        Label9.Name = "Label9"
        Label9.Size = New Size(233, 25)
        Label9.TabIndex = 42
        Label9.Text = "EMPLOYEE DETAILS:"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(435, 118)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(196, 28)
        TextBox7.TabIndex = 40
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Location = New Point(435, 43)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 20)
        Label7.TabIndex = 39
        Label7.Text = "Position"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(435, 97)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 20)
        Label6.TabIndex = 37
        Label6.Text = "Contact No."
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(435, 170)
        TextBox5.Margin = New Padding(3, 2, 3, 2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(96, 28)
        TextBox5.TabIndex = 36
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(571, 149)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 20)
        Label5.TabIndex = 35
        Label5.Text = "Sex"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        ComboBox1.Location = New Point(570, 171)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(102, 28)
        ComboBox1.TabIndex = 34
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(435, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 20)
        Label4.TabIndex = 33
        Label4.Text = "Age"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(435, 66)
        TextBox4.Margin = New Padding(3, 2, 3, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(237, 28)
        TextBox4.TabIndex = 32
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridView1.Location = New Point(57, 241)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(928, 358)
        DataGridView1.TabIndex = 31
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 75
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "LastName"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "FirstName"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "MiddleName"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Position"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 175
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Age"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 75
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Sex"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.Width = 150
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(46, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 20)
        Label3.TabIndex = 30
        Label3.Text = "Middle Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(46, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 20)
        Label2.TabIndex = 29
        Label2.Text = "First Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(46, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 20)
        Label1.TabIndex = 28
        Label1.Text = "Last Name"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(46, 171)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(287, 28)
        TextBox3.TabIndex = 27
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(46, 117)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(287, 28)
        TextBox2.TabIndex = 26
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(46, 65)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(287, 28)
        TextBox1.TabIndex = 25
        ' 
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Location = New Point(54, 67)
        TextBox6.Margin = New Padding(3, 2, 3, 2)
        TextBox6.Name = "TextBox6"
        TextBox6.ReadOnly = True
        TextBox6.Size = New Size(49, 28)
        TextBox6.TabIndex = 38
        TextBox6.TextAlign = HorizontalAlignment.Center
        TextBox6.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel2.BackgroundImage = My.Resources.Resources.istockphoto_1473121061_612x6121
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(28, 48)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(273, 571)
        Panel2.TabIndex = 14
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.LightSkyBlue
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(29, 428)
        Button5.Name = "Button5"
        Button5.Size = New Size(212, 54)
        Button5.TabIndex = 21
        Button5.Text = "COMPUTE EMPLOYEE SALARY"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Blue
        Label11.Location = New Point(130, 106)
        Label11.Name = "Label11"
        Label11.Size = New Size(82, 27)
        Label11.TabIndex = 20
        Label11.Text = "Admin"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources._9815472
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(20, 64)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 69)
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(106, 67)
        Label10.Name = "Label10"
        Label10.Size = New Size(106, 23)
        Label10.TabIndex = 18
        Label10.Text = "Welcome!"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.LinkColor = Color.Red
        LinkLabel1.Location = New Point(87, 515)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(86, 20)
        LinkLabel1.TabIndex = 17
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Log out"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.LightSkyBlue
        Button4.Location = New Point(141, 306)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(123, 27)
        Button4.TabIndex = 16
        Button4.Text = "CLEAR"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightSkyBlue
        Button3.Location = New Point(11, 306)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(123, 27)
        Button3.TabIndex = 15
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSkyBlue
        Button2.Location = New Point(141, 274)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(123, 27)
        Button2.TabIndex = 14
        Button2.Text = "UPDATE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightSkyBlue
        Button1.Location = New Point(11, 274)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(123, 27)
        Button1.TabIndex = 13
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1322, 631)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(TextBox6)
        Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = " Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button5 As Button

End Class
