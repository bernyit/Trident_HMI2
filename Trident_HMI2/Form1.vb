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
            lblDateTime.Text = GlobalVariables.hmiData.measureInt1 & "-" _
                               & GlobalVariables.hmiData.measureInt2 & "-" _
                               & GlobalVariables.hmiData.measureInt3 & " " _
                               & GlobalVariables.hmiData.measureInt4 & ":" _
                               & GlobalVariables.hmiData.measureInt5 & ":" _
                               & GlobalVariables.hmiData.measureInt6
            updatePhotocells()
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
        ph01.Visible = IIf(GlobalVariables.hmiData.measureWord1.ph01, 1, 0)
        ph02.Visible = IIf(GlobalVariables.hmiData.measureWord1.ph02, 1, 0)
        ph03.Visible = IIf(GlobalVariables.hmiData.measureWord1.ph03, 1, 0)
        ph04.Visible = IIf(GlobalVariables.hmiData.measureWord1.ph04, 1, 0)
        ph05.Visible = IIf(GlobalVariables.hmiData.measureWord1.ph05, 1, 0)
        'ph06.Visible = IIf(GlobalVariables.hmiData.measureWord1.ph06, 1, 0)
        ph07.Visible = IIf(GlobalVariables.hmiData.measureWord1.ph07, 1, 0)
        'ph08.Visible = IIf(GlobalVariables.hmiData.measureWord1.ph08, 1, 0)
        'ph09.Visible = IIf(GlobalVariables.hmiData.measureWord1.ph09, 1, 0)
        ph10.Visible = IIf(GlobalVariables.hmiData.measureWord1.ph10, 1, 0)
        'ph11.Visible = IIf(GlobalVariables.hmiData.measureWord1.ph11, 1, 0)
        ph12.Visible = IIf(GlobalVariables.hmiData.measureWord1.ph12, 1, 0)

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
End Class
