Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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

        Catch ex As Exception

        End Try
    End Sub

End Class
