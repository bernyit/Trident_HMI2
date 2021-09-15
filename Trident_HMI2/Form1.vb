Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TabControl1.SelectedTab = Me.TabPage1
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TabControl1.SelectedTab = Me.TabPage2
    End Sub

    Private Sub tmrUpdateScreen_Tick(sender As Object, e As EventArgs) Handles tmrUpdateScreen.Tick

        Try


            DB.ReadHmiData()
            lblDateTime.Text = GlobalVariables.hmiData.year & "-" _
                               & GlobalVariables.hmiData.month & "-" _
                               & GlobalVariables.hmiData.day & " " _
                               & GlobalVariables.hmiData.hour & ":" _
                               & GlobalVariables.hmiData.minute & ":" _
                               & GlobalVariables.hmiData.second
            updatePhotocells()
            updateTriggerInfo()
            updateConnectionStatus()



        Catch ex As Exception

        End Try
    End Sub


    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        Dim myPen As Pen

        'instantiate a new pen object using the color structure
        myPen = New Pen(Color.Lime, 7)
        'Create point objects      
        Dim pt As New Point(725, 115)
        Dim pt1 As New Point(800, 230)
        e.Graphics.DrawLine(myPen, pt, pt1)
    End Sub


    Private Sub updatePhotocells()
        ph01.Visible = IIf(GlobalVariables.hmiData.photocells.ph01, 1, 0)
        ph02.Visible = IIf(GlobalVariables.hmiData.photocells.ph02, 1, 0)
        ph03.Visible = IIf(GlobalVariables.hmiData.photocells.ph03, 1, 0)
        ph04.Visible = IIf(GlobalVariables.hmiData.photocells.ph04, 1, 0)
        ph05.Visible = IIf(GlobalVariables.hmiData.photocells.ph05, 1, 0)
        'ph06.Visible = IIf(GlobalVariables.hmiData.photocells.ph06, 1, 0)
        ph07.Visible = IIf(GlobalVariables.hmiData.photocells.ph07, 1, 0)
        'ph08.Visible = IIf(GlobalVariables.hmiData.photocells.ph08, 1, 0)
        'ph09.Visible = IIf(GlobalVariables.hmiData.photocells.ph09, 1, 0)
        ph10.Visible = IIf(GlobalVariables.hmiData.photocells.ph10, 1, 0)
        'ph11.Visible = IIf(GlobalVariables.hmiData.photocells.ph11, 1, 0)
        ph12.Visible = IIf(GlobalVariables.hmiData.photocells.ph12, 1, 0)

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

        If GlobalVariables.scannerConnectionStatus > 0 Then
            lblScannerStatus.Text = "VICAM CONNECTED"
            lblScannerStatus.BackColor = Color.Lime
        Else
            lblScannerStatus.Text = "NO VICAM"
            lblScannerStatus.BackColor = Color.Red
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

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DB.ReadStatus()
    End Sub
End Class
