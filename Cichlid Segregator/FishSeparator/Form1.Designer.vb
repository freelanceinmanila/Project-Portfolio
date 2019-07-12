<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainform))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnport = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lblcountf = New System.Windows.Forms.Label()
        Me.Picdisplay = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.cmbcam = New System.Windows.Forms.ComboBox()
        Me.mntr1 = New System.Windows.Forms.PictureBox()
        Me.thresh1 = New System.Windows.Forms.PictureBox()
        Me.mntr2 = New System.Windows.Forms.PictureBox()
        Me.thresh2 = New System.Windows.Forms.PictureBox()
        Me.lblclr1 = New System.Windows.Forms.Label()
        Me.lblclr2 = New System.Windows.Forms.Label()
        Me.Imgl = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblclr3 = New System.Windows.Forms.Label()
        Me.lblclr4 = New System.Windows.Forms.Label()
        Me.mntr3 = New System.Windows.Forms.PictureBox()
        Me.thresh3 = New System.Windows.Forms.PictureBox()
        Me.mntr4 = New System.Windows.Forms.PictureBox()
        Me.thresh4 = New System.Windows.Forms.PictureBox()
        Me.Lblcountm = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblname1 = New System.Windows.Forms.Label()
        Me.lblsize = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.List = New System.Windows.Forms.ListBox()
        Me.lblclr31 = New System.Windows.Forms.Label()
        Me.mntr31 = New System.Windows.Forms.PictureBox()
        Me.thresh31 = New System.Windows.Forms.PictureBox()
        CType(Me.Picdisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mntr1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thresh1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mntr2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thresh2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mntr3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thresh3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mntr4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thresh4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mntr31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thresh31, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaGreen
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Port Connection :"
        '
        'bttnport
        '
        Me.bttnport.BackColor = System.Drawing.Color.Goldenrod
        Me.bttnport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnport.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnport.Location = New System.Drawing.Point(12, 379)
        Me.bttnport.Name = "bttnport"
        Me.bttnport.Size = New System.Drawing.Size(85, 26)
        Me.bttnport.TabIndex = 1
        Me.bttnport.Text = "Connect"
        Me.bttnport.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.SeaGreen
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(103, 382)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(159, 22)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(672, 267)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(61, 39)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SeaGreen
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(402, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mbuna Counts"
        '
        'Lblcountf
        '
        Me.Lblcountf.AutoSize = True
        Me.Lblcountf.BackColor = System.Drawing.Color.SeaGreen
        Me.Lblcountf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblcountf.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcountf.ForeColor = System.Drawing.Color.Red
        Me.Lblcountf.Location = New System.Drawing.Point(465, 84)
        Me.Lblcountf.Name = "Lblcountf"
        Me.Lblcountf.Size = New System.Drawing.Size(46, 47)
        Me.Lblcountf.TabIndex = 6
        Me.Lblcountf.Text = "0"
        '
        'Picdisplay
        '
        Me.Picdisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picdisplay.Image = CType(resources.GetObject("Picdisplay.Image"), System.Drawing.Image)
        Me.Picdisplay.Location = New System.Drawing.Point(624, 73)
        Me.Picdisplay.Name = "Picdisplay"
        Me.Picdisplay.Size = New System.Drawing.Size(150, 152)
        Me.Picdisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picdisplay.TabIndex = 7
        Me.Picdisplay.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SeaGreen
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(634, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Type of Mbuna"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.SeaGreen
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(537, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Gender"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RB1
        '
        Me.RB1.BackColor = System.Drawing.Color.SeaGreen
        Me.RB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB1.ForeColor = System.Drawing.Color.Cyan
        Me.RB1.Location = New System.Drawing.Point(534, 190)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(71, 20)
        Me.RB1.TabIndex = 10
        Me.RB1.TabStop = True
        Me.RB1.Text = "Male"
        Me.RB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RB1.UseVisualStyleBackColor = False
        '
        'RB2
        '
        Me.RB2.BackColor = System.Drawing.Color.SeaGreen
        Me.RB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB2.ForeColor = System.Drawing.Color.Red
        Me.RB2.Location = New System.Drawing.Point(533, 96)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(72, 20)
        Me.RB2.TabIndex = 11
        Me.RB2.TabStop = True
        Me.RB2.Text = "Female"
        Me.RB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RB2.UseVisualStyleBackColor = False
        '
        'SerialPort1
        '
        '
        'cmbcam
        '
        Me.cmbcam.BackColor = System.Drawing.Color.SeaGreen
        Me.cmbcam.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcam.FormattingEnabled = True
        Me.cmbcam.Location = New System.Drawing.Point(17, 270)
        Me.cmbcam.Name = "cmbcam"
        Me.cmbcam.Size = New System.Drawing.Size(150, 22)
        Me.cmbcam.TabIndex = 12
        Me.cmbcam.Text = "         CAMERA"
        '
        'mntr1
        '
        Me.mntr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mntr1.Location = New System.Drawing.Point(17, 68)
        Me.mntr1.Name = "mntr1"
        Me.mntr1.Size = New System.Drawing.Size(110, 96)
        Me.mntr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mntr1.TabIndex = 13
        Me.mntr1.TabStop = False
        '
        'thresh1
        '
        Me.thresh1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.thresh1.Location = New System.Drawing.Point(130, 68)
        Me.thresh1.Name = "thresh1"
        Me.thresh1.Size = New System.Drawing.Size(110, 96)
        Me.thresh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.thresh1.TabIndex = 14
        Me.thresh1.TabStop = False
        '
        'mntr2
        '
        Me.mntr2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mntr2.Location = New System.Drawing.Point(17, 170)
        Me.mntr2.Name = "mntr2"
        Me.mntr2.Size = New System.Drawing.Size(110, 94)
        Me.mntr2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mntr2.TabIndex = 16
        Me.mntr2.TabStop = False
        '
        'thresh2
        '
        Me.thresh2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.thresh2.Location = New System.Drawing.Point(130, 170)
        Me.thresh2.Name = "thresh2"
        Me.thresh2.Size = New System.Drawing.Size(110, 94)
        Me.thresh2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.thresh2.TabIndex = 15
        Me.thresh2.TabStop = False
        '
        'lblclr1
        '
        Me.lblclr1.BackColor = System.Drawing.Color.SeaGreen
        Me.lblclr1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclr1.Location = New System.Drawing.Point(24, 46)
        Me.lblclr1.Name = "lblclr1"
        Me.lblclr1.Size = New System.Drawing.Size(94, 19)
        Me.lblclr1.TabIndex = 17
        Me.lblclr1.Text = "Yellow Lab"
        Me.lblclr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblclr1.Visible = False
        '
        'lblclr2
        '
        Me.lblclr2.BackColor = System.Drawing.Color.SeaGreen
        Me.lblclr2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclr2.Location = New System.Drawing.Point(24, 48)
        Me.lblclr2.Name = "lblclr2"
        Me.lblclr2.Size = New System.Drawing.Size(94, 17)
        Me.lblclr2.TabIndex = 18
        Me.lblclr2.Text = "Yellow Lab"
        Me.lblclr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblclr2.Visible = False
        '
        'Imgl
        '
        Me.Imgl.ImageStream = CType(resources.GetObject("Imgl.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Imgl.TransparentColor = System.Drawing.Color.Transparent
        Me.Imgl.Images.SetKeyName(0, "images.png")
        Me.Imgl.Images.SetKeyName(1, "labidochromis-caeruleus-yellow.jpg")
        Me.Imgl.Images.SetKeyName(2, "images (14).jpeg")
        Me.Imgl.Images.SetKeyName(3, "images (12).jpeg")
        Me.Imgl.Images.SetKeyName(4, "unnamed (2).jpg")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblclr3
        '
        Me.lblclr3.BackColor = System.Drawing.Color.SeaGreen
        Me.lblclr3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclr3.Location = New System.Drawing.Point(253, 177)
        Me.lblclr3.Name = "lblclr3"
        Me.lblclr3.Size = New System.Drawing.Size(94, 17)
        Me.lblclr3.TabIndex = 20
        Me.lblclr3.Text = "Trewavase"
        Me.lblclr3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblclr3.Visible = False
        '
        'lblclr4
        '
        Me.lblclr4.BackColor = System.Drawing.Color.SeaGreen
        Me.lblclr4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclr4.Location = New System.Drawing.Point(243, 129)
        Me.lblclr4.Name = "lblclr4"
        Me.lblclr4.Size = New System.Drawing.Size(94, 17)
        Me.lblclr4.TabIndex = 21
        Me.lblclr4.Text = "Trewavase"
        Me.lblclr4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblclr4.Visible = False
        '
        'mntr3
        '
        Me.mntr3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mntr3.Location = New System.Drawing.Point(17, 68)
        Me.mntr3.Name = "mntr3"
        Me.mntr3.Size = New System.Drawing.Size(110, 96)
        Me.mntr3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mntr3.TabIndex = 22
        Me.mntr3.TabStop = False
        Me.mntr3.Visible = False
        '
        'thresh3
        '
        Me.thresh3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.thresh3.Location = New System.Drawing.Point(130, 68)
        Me.thresh3.Name = "thresh3"
        Me.thresh3.Size = New System.Drawing.Size(110, 96)
        Me.thresh3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.thresh3.TabIndex = 23
        Me.thresh3.TabStop = False
        Me.thresh3.Visible = False
        '
        'mntr4
        '
        Me.mntr4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mntr4.Location = New System.Drawing.Point(237, 267)
        Me.mntr4.Name = "mntr4"
        Me.mntr4.Size = New System.Drawing.Size(110, 94)
        Me.mntr4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mntr4.TabIndex = 24
        Me.mntr4.TabStop = False
        Me.mntr4.Visible = False
        '
        'thresh4
        '
        Me.thresh4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.thresh4.Location = New System.Drawing.Point(353, 267)
        Me.thresh4.Name = "thresh4"
        Me.thresh4.Size = New System.Drawing.Size(109, 94)
        Me.thresh4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.thresh4.TabIndex = 25
        Me.thresh4.TabStop = False
        Me.thresh4.Visible = False
        '
        'Lblcountm
        '
        Me.Lblcountm.AutoSize = True
        Me.Lblcountm.BackColor = System.Drawing.Color.SeaGreen
        Me.Lblcountm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblcountm.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcountm.ForeColor = System.Drawing.Color.Aqua
        Me.Lblcountm.Location = New System.Drawing.Point(465, 177)
        Me.Lblcountm.Name = "Lblcountm"
        Me.Lblcountm.Size = New System.Drawing.Size(46, 47)
        Me.Lblcountm.TabIndex = 26
        Me.Lblcountm.Text = "0"
        '
        'lblname
        '
        Me.lblname.BackColor = System.Drawing.Color.SeaGreen
        Me.lblname.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(624, 228)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(150, 23)
        Me.lblname.TabIndex = 28
        Me.lblname.Text = "NAME"
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblname1
        '
        Me.lblname1.Font = New System.Drawing.Font("Tahoma", 3.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname1.Location = New System.Drawing.Point(624, 228)
        Me.lblname1.Name = "lblname1"
        Me.lblname1.Size = New System.Drawing.Size(40, 15)
        Me.lblname1.TabIndex = 29
        Me.lblname1.Text = "Status..."
        '
        'lblsize
        '
        Me.lblsize.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsize.Location = New System.Drawing.Point(743, 251)
        Me.lblsize.Name = "lblsize"
        Me.lblsize.Size = New System.Drawing.Size(31, 13)
        Me.lblsize.TabIndex = 31
        Me.lblsize.Text = "SIZE"
        Me.lblsize.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(530, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SeaGreen
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(530, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "View"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'List
        '
        Me.List.BackColor = System.Drawing.Color.Goldenrod
        Me.List.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List.FormattingEnabled = True
        Me.List.ItemHeight = 14
        Me.List.Location = New System.Drawing.Point(626, 312)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(148, 102)
        Me.List.TabIndex = 35
        '
        'lblclr31
        '
        Me.lblclr31.AutoSize = True
        Me.lblclr31.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclr31.Location = New System.Drawing.Point(246, 145)
        Me.lblclr31.Name = "lblclr31"
        Me.lblclr31.Size = New System.Drawing.Size(56, 16)
        Me.lblclr31.TabIndex = 36
        Me.lblclr31.Text = "Trewa2"
        Me.lblclr31.Visible = False
        '
        'mntr31
        '
        Me.mntr31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mntr31.Location = New System.Drawing.Point(246, 20)
        Me.mntr31.Name = "mntr31"
        Me.mntr31.Size = New System.Drawing.Size(110, 96)
        Me.mntr31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mntr31.TabIndex = 37
        Me.mntr31.TabStop = False
        Me.mntr31.Visible = False
        '
        'thresh31
        '
        Me.thresh31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.thresh31.Location = New System.Drawing.Point(362, 20)
        Me.thresh31.Name = "thresh31"
        Me.thresh31.Size = New System.Drawing.Size(110, 96)
        Me.thresh31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.thresh31.TabIndex = 38
        Me.thresh31.TabStop = False
        Me.thresh31.Visible = False
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(785, 429)
        Me.Controls.Add(Me.thresh31)
        Me.Controls.Add(Me.mntr31)
        Me.Controls.Add(Me.lblclr31)
        Me.Controls.Add(Me.List)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblsize)
        Me.Controls.Add(Me.lblname1)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.Lblcountm)
        Me.Controls.Add(Me.thresh4)
        Me.Controls.Add(Me.mntr4)
        Me.Controls.Add(Me.thresh3)
        Me.Controls.Add(Me.mntr3)
        Me.Controls.Add(Me.lblclr4)
        Me.Controls.Add(Me.lblclr3)
        Me.Controls.Add(Me.lblclr2)
        Me.Controls.Add(Me.lblclr1)
        Me.Controls.Add(Me.mntr2)
        Me.Controls.Add(Me.thresh2)
        Me.Controls.Add(Me.thresh1)
        Me.Controls.Add(Me.mntr1)
        Me.Controls.Add(Me.cmbcam)
        Me.Controls.Add(Me.RB2)
        Me.Controls.Add(Me.RB1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Picdisplay)
        Me.Controls.Add(Me.Lblcountf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.bttnport)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dimorphic Mbuna Cichlids"
        CType(Me.Picdisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mntr1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thresh1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mntr2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thresh2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mntr3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thresh3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mntr4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thresh4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mntr31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thresh31, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttnport As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lblcountf As System.Windows.Forms.Label
    Friend WithEvents Picdisplay As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents cmbcam As System.Windows.Forms.ComboBox
    Friend WithEvents mntr1 As System.Windows.Forms.PictureBox
    Friend WithEvents thresh1 As System.Windows.Forms.PictureBox
    Friend WithEvents mntr2 As System.Windows.Forms.PictureBox
    Friend WithEvents thresh2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblclr1 As System.Windows.Forms.Label
    Friend WithEvents lblclr2 As System.Windows.Forms.Label
    Friend WithEvents Imgl As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblclr3 As System.Windows.Forms.Label
    Friend WithEvents lblclr4 As System.Windows.Forms.Label
    Friend WithEvents mntr3 As System.Windows.Forms.PictureBox
    Friend WithEvents thresh3 As System.Windows.Forms.PictureBox
    Friend WithEvents mntr4 As System.Windows.Forms.PictureBox
    Friend WithEvents thresh4 As System.Windows.Forms.PictureBox
    Friend WithEvents Lblcountm As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblname1 As System.Windows.Forms.Label
    Friend WithEvents lblsize As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents List As System.Windows.Forms.ListBox
    Friend WithEvents lblclr31 As System.Windows.Forms.Label
    Friend WithEvents mntr31 As System.Windows.Forms.PictureBox
    Friend WithEvents thresh31 As System.Windows.Forms.PictureBox

End Class
