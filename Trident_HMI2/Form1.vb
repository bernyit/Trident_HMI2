Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TabControl1.SelectedTab = Me.TabPage1
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TabControl1.SelectedTab = Me.TabPage2
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.TabControl1.SelectedTab = Me.TabPage3
    End Sub

    Private Sub tmrUpdateScreen_Tick(sender As Object, e As EventArgs) Handles tmrUpdateScreen.Tick

        Try


            DB.ReadHmiData()
            lblDateTime.Text = GlobalVariables.hmiData.year.ToString("0000") & "-" _
                               & GlobalVariables.hmiData.month.ToString("00") & "-" _
                               & GlobalVariables.hmiData.day.ToString("00") & " " _
                               & GlobalVariables.hmiData.hour.ToString("00") & ":" _
                               & GlobalVariables.hmiData.minute.ToString("00") & ":" _
                               & GlobalVariables.hmiData.second.ToString("00")

            updateEmergency()
            updatePhotocells()
            updateTriggerInfo()
            updateConnectionStatus()
            updateFaultsAndAlarms()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint

        Exit Sub

        Dim myPen As Pen

        'instantiate a new pen object using the color structure
        myPen = New Pen(Color.Lime, 7)
        'Create point objects      
        Dim pt As New Point(725, 115)
        Dim pt1 As New Point(800, 230)
        e.Graphics.DrawLine(myPen, pt, pt1)
    End Sub


    Private Sub updatePhotocells()

        Dim busyColor As Color = Color.LightGreen
        Dim freeColor As Color = Color.White

        PH01.BackColor = IIf(GlobalVariables.hmiData.photocells.ph01, busyColor, freeColor)
        ph02.BackColor = IIf(GlobalVariables.hmiData.photocells.ph02, busyColor, freeColor)
        ph03.BackColor = IIf(GlobalVariables.hmiData.photocells.ph03, busyColor, freeColor)
        ph04.BackColor = IIf(GlobalVariables.hmiData.photocells.ph04, busyColor, freeColor)
        ph05.BackColor = IIf(GlobalVariables.hmiData.photocells.ph05, busyColor, freeColor)
        ph06.BackColor = IIf(GlobalVariables.hmiData.photocells.ph06, busyColor, freeColor)
        'ph07.BackColor = IIf(GlobalVariables.hmiData.photocells.ph07, busyColor, freeColor)
        ph08.BackColor = IIf(GlobalVariables.hmiData.photocells.ph08, busyColor, freeColor)
        ph09.BackColor = IIf(GlobalVariables.hmiData.photocells.ph09, busyColor, freeColor)
        ph10.BackColor = IIf(GlobalVariables.hmiData.photocells.ph10, busyColor, freeColor)
        ph11.BackColor = IIf(GlobalVariables.hmiData.photocells.ph11, busyColor, freeColor)
        ph12.BackColor = IIf(GlobalVariables.hmiData.photocells.ph12, busyColor, freeColor)
        ph13.BackColor = IIf(GlobalVariables.hmiData.photocells.ph13, busyColor, freeColor)
    End Sub

    Private Sub updateEmergency()

        Dim OkColor As Color = Color.White
        Dim NotOkColor As Color = Color.Red


        lblEstop01.BackColor = IIf(GlobalVariables.hmiData.faultW2.bit02 = 0 And Now.Second Mod 2 = 0, NotOkColor, OkColor)
        lblEstop02.BackColor = IIf(GlobalVariables.hmiData.faultW2.bit03 = 0 And Now.Second Mod 2 = 0, NotOkColor, OkColor)
        lblEstop03.BackColor = IIf(GlobalVariables.hmiData.faultW2.bit04 = 0 And Now.Second Mod 2 = 0, NotOkColor, OkColor)
        lblEstop04.BackColor = IIf(GlobalVariables.hmiData.faultW2.bit05 = 0 And Now.Second Mod 2 = 0, NotOkColor, OkColor)
    End Sub


    Private Sub updateTriggerInfo()
        lblParcelID_PH01.Text = GlobalVariables.hmiData.PH01_Parcel_ID
        If GlobalVariables.hmiData.triggers.newParcelOnPH01 Then
            lblParcelID_PH01.BackColor = Color.LightGreen
        Else
            lblParcelID_PH01.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub updateConnectionStatus()
        DB.ReadStatus()

        If GlobalVariables.plcConnectionStatus > 0 Then
            lblPlcConnectionStatus.Text = "PLC CONNECTED"
            lblPlcConnectionStatus.BackColor = Color.Lime
        Else
            lblPlcConnectionStatus.Text = "NO PLC"
            lblPlcConnectionStatus.BackColor = Color.Red
        End If

        If GlobalVariables.hmiData.statusW1.bit01 = True Then
            lblScannerLeftStatus.Text = "VICAM LEFT CONNECTED"
            lblScannerLeftStatus.BackColor = Color.Lime
            picVicamLeftGreen.Visible = True
            picVicamLeftRed.Visible = False
        Else
            lblScannerLeftStatus.Text = "VICAM LEFT NOT CONNECTED"
            lblScannerLeftStatus.BackColor = Color.Red
            picVicamLeftGreen.Visible = False
            picVicamLeftRed.Visible = True
        End If

        If GlobalVariables.hmiData.statusW1.bit02 = True Then
            lblScannerRightStatus.Text = "VICAM RIGHT CONNECTED"
            lblScannerRightStatus.BackColor = Color.Lime
            picVicamRightGreen.Visible = True
            picVicamRightRed.Visible = False
        Else
            lblScannerRightStatus.Text = "VICAM RIGHT NOT CONNECTED"
            lblScannerRightStatus.BackColor = Color.Red
            picVicamRightGreen.Visible = False
            picVicamRightRed.Visible = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DB.ReadBarcodesData(DataGridView1)
    End Sub

    Private Sub btnSelectBarcodeFile_Click(sender As Object, e As EventArgs) Handles btnSelectBarcodeFile.Click

        OpenFileDialog1.Title = "Select barcodes/destination file"
        OpenFileDialog1.Filter = "CSV|*.csv"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtBarcodeFileName.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub btnImportBarcodes_Click(sender As Object, e As EventArgs) Handles btnImportBarcodes.Click
        If MsgBox("Delete old data and import new association", MsgBoxStyle.OkCancel, "Barcodes / Destination import") = MsgBoxResult.Ok Then

            DB.insertBarcodesData(FileManagement.readCsv(txtBarcodeFileName.Text))
            DB.ReadBarcodesData(DataGridView1)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DB.ReadStatus()
    End Sub

    Private Sub btnPreviewCsv_Click(sender As Object, e As EventArgs) Handles btnPreviewCsv.Click

        showList(FileManagement.readCsv(txtBarcodeFileName.Text))

    End Sub

    Private Sub showList(ByVal data As List(Of strBarcodeDestination))
        lstBarcodePreview.View = System.Windows.Forms.View.Details
        lstBarcodePreview.Columns.Add("Barcode", 100, HorizontalAlignment.Center)
        lstBarcodePreview.Columns.Add("Destination", 100, HorizontalAlignment.Center)
        lstBarcodePreview.Columns.Add("Destination", 100, HorizontalAlignment.Center)

        Dim itemCounter As Integer = 0
        For Each item In data

            Dim newItem As New ListViewItem(item.barcode)
            newItem.SubItems.Add(item.destination)
            newItem.SubItems.Add(intDestinationToText(item.destination))
            lstBarcodePreview.Items.Add(newItem)
        Next
    End Sub

    Private Sub updateFaultsAndAlarms()

        Dim faultOkColor As Color = Color.Lime
        Dim faultNotOkColor As Color = Color.Red

        Dim alarmOkColor As Color = Color.LightGreen
        Dim alarmNotOkColor As Color = Color.Yellow


        lblFaultW1_00.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit00, faultOkColor, faultNotOkColor)
        lblFaultW1_01.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit01, faultOkColor, faultNotOkColor)
        lblFaultW1_02.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit02, faultOkColor, faultNotOkColor)
        lblFaultW1_03.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit03, faultOkColor, faultNotOkColor)
        lblFaultW1_04.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit04, faultOkColor, faultNotOkColor)
        lblFaultW1_05.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit05, faultOkColor, faultNotOkColor)
        lblFaultW1_06.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit06, faultOkColor, faultNotOkColor)
        lblFaultW1_07.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit07, faultOkColor, faultNotOkColor)
        lblFaultW1_08.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit08, faultOkColor, faultNotOkColor)
        lblFaultW1_09.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit09, faultOkColor, faultNotOkColor)
        lblFaultW1_10.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit10, faultOkColor, faultNotOkColor)
        lblFaultW1_11.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit11, faultOkColor, faultNotOkColor)
        lblFaultW1_12.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit12, faultOkColor, faultNotOkColor)
        lblFaultW1_13.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit13, faultOkColor, faultNotOkColor)
        lblFaultW1_14.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit14, faultOkColor, faultNotOkColor)
        lblFaultW1_15.BackColor = IIf(GlobalVariables.hmiData.faultW1.bit15, faultOkColor, faultNotOkColor)

        lblFaultW2_00.BackColor = IIf(GlobalVariables.hmiData.faultW2.bit00, faultOkColor, faultNotOkColor)
        lblFaultW2_01.BackColor = IIf(GlobalVariables.hmiData.faultW2.bit01, faultOkColor, faultNotOkColor)
        lblFaultW2_02.BackColor = IIf(GlobalVariables.hmiData.faultW2.bit02, faultOkColor, faultNotOkColor)
        lblFaultW2_03.BackColor = IIf(GlobalVariables.hmiData.faultW2.bit03, faultOkColor, faultNotOkColor)
        lblFaultW2_04.BackColor = IIf(GlobalVariables.hmiData.faultW2.bit04, faultOkColor, faultNotOkColor)
        lblFaultW2_05.BackColor = IIf(GlobalVariables.hmiData.faultW2.bit05, faultOkColor, faultNotOkColor)

        lblAlarmW1_00.BackColor = IIf(GlobalVariables.hmiData.alarmW1.bit00, alarmOkColor, alarmNotOkColor)
        lblAlarmW1_01.BackColor = IIf(GlobalVariables.hmiData.alarmW1.bit01, alarmOkColor, alarmNotOkColor)
        lblAlarmW1_02.BackColor = IIf(GlobalVariables.hmiData.alarmW1.bit02, alarmOkColor, alarmNotOkColor)
        lblAlarmW1_03.BackColor = IIf(GlobalVariables.hmiData.alarmW1.bit03, alarmOkColor, alarmNotOkColor)


        If GlobalVariables.hmiData.faultW1.word <> 65535 Or GlobalVariables.hmiData.faultW2.word <> 65535 Then
            GlobalVariables.faultPresence = True
        Else
            GlobalVariables.faultPresence = False
        End If

        If GlobalVariables.hmiData.alarmW1.word <> 65535 Then
            GlobalVariables.alarmPresence = True
        Else
            GlobalVariables.alarmPresence = False
        End If

        If GlobalVariables.faultPresence Then
            If Now.Second Mod 2 = 0 Then
                Button5.BackColor = Color.Red
            Else
                Button5.BackColor = Color.Yellow
            End If

        ElseIf GlobalVariables.alarmPresence Then
            Button5.BackColor = Color.Yellow
        Else
            Button5.BackColor = Color.LightGray
        End If

    End Sub
End Class
