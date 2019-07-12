Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge.Imaging.Filters
Imports AForge.Imaging
Public Class mainform
    Dim FUENTES As FilterInfoCollection
    Dim FUENTE As VideoCaptureDevice

    Delegate Sub AddText(ByVal Text As String)
    Dim Countf As Integer
    Dim Countm As Integer
    Private Sub Video_NewFrame(sender As Object, eventArgs As AForge.Video.NewFrameEventArgs)

        Try

            If lblclr1.Text = "Yellow" And lblclr2.Text = "" And lblclr1.Visible = True And lblclr2.Visible = False Then
                Picdisplay.Image = Imgl.Images(2)
                lblname.Text = "Kenyi"
                RB1.Checked = True
                RB2.Checked = False
                lblname1.Text = ""
                ' SerialPort1.WriteLine("e")

            End If
            If lblclr1.Text = "Yellow" And lblclr2.Text = "Black" And lblclr1.Visible = True And lblclr2.Visible = True Then
                Picdisplay.Image = Imgl.Images(1)
                lblname.Text = "Kenyi"
                RB1.Checked = False
                RB2.Checked = True
                lblname1.Text = ""
                ' SerialPort1.WriteLine("E")
            Else
                'Picdisplay.Image = Imgl.Images(0)
                lblname1.Text = "Identifying..."

            End If

            Dim ORIGINAL As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            Dim FILTRADO As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)

            Dim FILTRO As New ColorFiltering
            FILTRO.Red = New IntRange(91, 191)
            FILTRO.Green = New IntRange(175, 175) 'ming 195 up against orange
            FILTRO.Blue = New IntRange(111, 113)
            FILTRO.ApplyInPlace(FILTRADO)
            Dim GRIS As Grayscale = Grayscale.CommonAlgorithms.BT709
            Dim IMAGENG As Bitmap = GRIS.Apply(FILTRADO)


            Dim BLOBS As New BlobCounter()
            BLOBS.MinHeight = 10
            BLOBS.MinWidth = 10
            BLOBS.ObjectsOrder = ObjectsOrder.Size
            BLOBS.ProcessImage(IMAGENG)

            Dim RECTANGULOS As Rectangle() = BLOBS.GetObjectsRectangles()
            If RECTANGULOS.Count > 0 Then
                lblclr1.Visible = True
                lblclr1.Text = "Yellow"
                mntr1.Visible = True
                thresh1.Visible = True
                Dim RECTANGULO As Rectangle = RECTANGULOS(0)
                Dim DIBUJO As Graphics = Graphics.FromImage(ORIGINAL)
                Dim TRAZO As New Pen(Color.Lime, 5)

                DIBUJO.DrawRectangle(TRAZO, RECTANGULO)
                DIBUJO.Dispose()
                lblsize.Text = RECTANGULOS.Length.ToString()
            Else
                lblclr1.Text = ""
                lblclr1.Visible = False
                mntr1.Visible = False
                thresh1.Visible = False
            End If

            mntr1.Image = ORIGINAL
            thresh1.Image = FILTRADO

            Dim ORIGINAL1 As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            Dim FILTRADO1 As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)

            Dim FILTRO1 As New ColorFiltering
            FILTRO1.Red = New IntRange(0, 69)
            FILTRO1.Green = New IntRange(14, 213)
            FILTRO1.Blue = New IntRange(53, 63)
            FILTRO1.ApplyInPlace(FILTRADO1)
            Dim GRIS1 As Grayscale = Grayscale.CommonAlgorithms.BT709
            Dim IMAGENG1 As Bitmap = GRIS1.Apply(FILTRADO1)


            Dim BLOBS1 As New BlobCounter()
            BLOBS1.MinHeight = 10
            BLOBS1.MinWidth = 10
            BLOBS1.ObjectsOrder = ObjectsOrder.Size
            BLOBS1.ProcessImage(IMAGENG1)

            Dim RECTANGULOS1 As Rectangle() = BLOBS1.GetObjectsRectangles()
            If RECTANGULOS1.Count > 0 Then
                lblclr2.Text = "Black"
                lblclr2.Visible = True
                mntr2.Visible = True
                thresh2.Visible = True
                Dim RECTANGULO1 As Rectangle = RECTANGULOS1(0)
                Dim DIBUJO1 As Graphics = Graphics.FromImage(ORIGINAL1)
                Dim TRAZO1 As New Pen(Color.Lime, 5)
                DIBUJO1.DrawRectangle(TRAZO1, RECTANGULO1)
                DIBUJO1.Dispose()

            Else
                lblclr2.Text = ""
                lblclr2.Visible = False
                mntr2.Visible = False
                thresh2.Visible = False
            End If
            mntr2.Image = ORIGINAL1
            thresh2.Image = FILTRADO1



            If lblclr3.Text = "Orange" And lblclr4.Text = "Blue" And lblclr3.Visible = True And lblclr4.Visible = True Then
                Picdisplay.Image = Imgl.Images(3)
                lblname.Text = "Trewavase"
                RB1.Checked = True
                RB2.Checked = False
                lblname1.Text = ""
            End If
            If lblclr31.Text = "Orange2" And lblclr4.Text = "" And lblclr31.Visible = True And lblclr4.Visible = False Then
                Picdisplay.Image = Imgl.Images(4)
                lblname.Text = "Trewavase"
                RB1.Checked = False
                RB2.Checked = True
                lblname1.Text = ""
            Else
                ' Picdisplay.Image = Imgl.Images(0)
                lblname1.Text = "Identifying..."
            End If

            Dim ORIGINAL2 As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            Dim FILTRADO2 As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)

            Dim FILTRO2 As New ColorFiltering
            FILTRO2.Red = New IntRange(59, 60)
            FILTRO2.Green = New IntRange(20, 34)
            FILTRO2.Blue = New IntRange(45, 53)
            FILTRO2.ApplyInPlace(FILTRADO2)
            Dim GRIS2 As Grayscale = Grayscale.CommonAlgorithms.BT709
            Dim IMAGENG2 As Bitmap = GRIS2.Apply(FILTRADO2)


            Dim BLOBS2 As New BlobCounter()
            BLOBS2.MinHeight = 10
            BLOBS2.MinWidth = 10
            BLOBS2.ObjectsOrder = ObjectsOrder.Size
            BLOBS2.ProcessImage(IMAGENG2)

            Dim RECTANGULOS2 As Rectangle() = BLOBS2.GetObjectsRectangles()
            If RECTANGULOS2.Count > 0 Then
                lblclr3.Visible = True
                lblclr3.Text = "Orange"
                mntr3.Visible = True
                thresh3.Visible = True
                Dim RECTANGULO2 As Rectangle = RECTANGULOS2(0)
                Dim DIBUJO2 As Graphics = Graphics.FromImage(ORIGINAL2)
                Dim TRAZO2 As New Pen(Color.Lime, 5)

                DIBUJO2.DrawRectangle(TRAZO2, RECTANGULO2)
                DIBUJO2.Dispose()
                lblsize.Text = RECTANGULOS2.Length.ToString()
            Else
                lblclr3.Text = ""
                lblclr3.Visible = False
                mntr3.Visible = False
                thresh3.Visible = False
            End If

            mntr3.Image = ORIGINAL2
            thresh3.Image = FILTRADO2

            Dim ORIGINAL21 As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            Dim FILTRADO21 As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)

            Dim FILTRO21 As New ColorFiltering
            FILTRO21.Red = New IntRange(153, 153)
            FILTRO21.Green = New IntRange(32, 87)
            FILTRO21.Blue = New IntRange(42, 57)
            FILTRO21.ApplyInPlace(FILTRADO21)
            Dim GRIS21 As Grayscale = Grayscale.CommonAlgorithms.BT709
            Dim IMAGENG21 As Bitmap = GRIS21.Apply(FILTRADO21)


            Dim BLOBS21 As New BlobCounter()
            BLOBS21.MinHeight = 10
            BLOBS21.MinWidth = 10
            BLOBS21.ObjectsOrder = ObjectsOrder.Size
            BLOBS21.ProcessImage(IMAGENG21)

            Dim RECTANGULOS21 As Rectangle() = BLOBS21.GetObjectsRectangles()
            If RECTANGULOS21.Count > 0 Then
                lblclr31.Visible = True
                lblclr31.Text = "Orange2"
                mntr31.Visible = True
                thresh31.Visible = True
                Dim RECTANGULO21 As Rectangle = RECTANGULOS21(0)
                Dim DIBUJO21 As Graphics = Graphics.FromImage(ORIGINAL21)
                Dim TRAZO21 As New Pen(Color.Lime, 5)

                DIBUJO21.DrawRectangle(TRAZO21, RECTANGULO21)
                DIBUJO21.Dispose()
                lblsize.Text = RECTANGULOS21.Length.ToString()
            Else
                lblclr31.Text = ""
                lblclr31.Visible = False
                mntr31.Visible = False
                thresh31.Visible = False
            End If

            mntr31.Image = ORIGINAL21
            thresh31.Image = FILTRADO21


            Dim ORIGINAL3 As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            Dim FILTRADO3 As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)

            Dim FILTRO3 As New ColorFiltering
            FILTRO3.Red = New IntRange(50, 191)
            FILTRO3.Green = New IntRange(42, 70)
            FILTRO3.Blue = New IntRange(94, 175)
            FILTRO3.ApplyInPlace(FILTRADO3)
            Dim GRIS3 As Grayscale = Grayscale.CommonAlgorithms.BT709
            Dim IMAGENG3 As Bitmap = GRIS3.Apply(FILTRADO3)


            Dim BLOBS3 As New BlobCounter()
            BLOBS3.MinHeight = 10
            BLOBS3.MinWidth = 10
            BLOBS3.ObjectsOrder = ObjectsOrder.Size
            BLOBS3.ProcessImage(IMAGENG3)

            Dim RECTANGULOS3 As Rectangle() = BLOBS3.GetObjectsRectangles()
            If RECTANGULOS3.Count > 0 Then
                lblclr4.Visible = True
                lblclr4.Text = "Blue"
                mntr4.Visible = True
                thresh4.Visible = True
                Dim RECTANGULO3 As Rectangle = RECTANGULOS3(0)
                Dim DIBUJO3 As Graphics = Graphics.FromImage(ORIGINAL3)
                Dim TRAZO3 As New Pen(Color.Lime, 5)

                DIBUJO3.DrawRectangle(TRAZO3, RECTANGULO3)
                DIBUJO3.Dispose()
                lblsize.Text = RECTANGULOS3.Length.ToString()
            Else
                lblclr4.Text = ""
                lblclr4.Visible = False
                mntr4.Visible = False
                thresh4.Visible = False
            End If

            mntr4.Image = ORIGINAL3
            thresh4.Image = FILTRADO3


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnport.Click
        Try
            If SerialPort1.IsOpen Then
                bttnport.Text = "Connect"

                SerialPort1.Close()
            Else
                With SerialPort1
                    .PortName = ComboBox1.SelectedItem.ToString
                    .BaudRate = 9600
                    .Parity = IO.Ports.Parity.None
                    .DataBits = 8
                    .StopBits = IO.Ports.StopBits.One
                    .Handshake = Handshake.None
                    .Encoding = System.Text.Encoding.Default
                End With
                SerialPort1.Open()
                'SerialPort1.Write(0)
                bttnport.Text = "Disconnect"
                cmbcam.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            FUENTE.SignalToStop() 'CIERRA EL THREAD Video_NewFrame
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()


        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(sp)
        Next
        Try
            FUENTES = New FilterInfoCollection(FilterCategory.VideoInputDevice)
            If FUENTES.Count > 0 Then
                For Each ITEM In FUENTES
                    cmbcam.Items.Add(ITEM.Name.ToString())
                Next

                CheckForIllegalCrossThreadCalls = False 'PERMITE QUE SE ESCRIBA EN LAS ETIQUETAS DURANTE EL THREAD Video_NewFrame

                Me.Location = New System.Drawing.Point(Me.Location.X, 0) 'SITUA EL FORMULARIO EN LA PARTE SUPERIOR DE LA PANTALLA
            Else
                MsgBox("No Camera")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        TextBox1.Invoke(New AddText(AddressOf TextBox1.AppendText), SerialPort1.ReadLine + Environment.NewLine)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Contains("Male") Then
            RB1.Checked = True
            TextBox1.Clear()
            Countm += 1
            Lblcountm.Text = Countm.ToString
        End If
        If TextBox1.Text.Contains("Female") Then
            RB2.Checked = True
            TextBox1.Clear()
            Countf += 1
            Lblcountf.Text = Countf.ToString
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcam.SelectedIndexChanged
        FUENTE = New VideoCaptureDevice(FUENTES(cmbcam.SelectedIndex).MonikerString)
        AddHandler FUENTE.NewFrame, New NewFrameEventHandler(AddressOf Video_NewFrame)
        FUENTE.Start()
        ComboBox1.Visible = False

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Picdisplay.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Picdisplay.Image = Imgl.Images(0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub lblclr1_Click(sender As Object, e As EventArgs) Handles lblclr1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblname.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Female = "Female Count " + Lblcountf.Text
        My.Settings.Male = "Male Count " + Lblcountm.Text
        My.Settings.Count = My.Computer.Clock.LocalTime.Month.ToString() + "/" + My.Computer.Clock.LocalTime.Day.ToString() + "/" + My.Computer.Clock.LocalTime.Year.ToString()
        My.Settings.Save()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        List.Items.Clear()
        List.Items.Add(My.Settings.Female)
        List.Items.Add(My.Settings.Male)
        List.Items.Add(My.Settings.Count)
    End Sub

    Private Sub RB2_CheckedChanged(sender As Object, e As EventArgs) Handles RB2.CheckedChanged

    End Sub

    Private Sub lblclr3_Click(sender As Object, e As EventArgs) Handles lblclr3.Click

    End Sub

    Private Sub thresh3_Click(sender As Object, e As EventArgs) Handles thresh3.Click

    End Sub
End Class
