Imports System.IO, System.Net, System.Web
Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://raw.githubusercontent.com/Nick-JKSHOP/Calculator/main/Version.txt")
            Dim respones As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(respones.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            version.Text = currentversion.ToString
            lblNewestVersion.Text = newestversion.ToString

            If lblNewestVersion.Text > version.Text Then
                MessageBox.Show("Ein neues Update ist Verfügbar", "Update")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height As Double
        Try
            height = TextBox1.Text

            If RadioButton1.Checked Then
                MsgBox("Your height is " & Height & "cm", vbInformation, "result")

            ElseIf RadioButton2.Checked Then

                MsgBox("Your weight is " & Height & "kg", vbInformation, "result")

            ElseIf RadioButton3.Checked Then
                MsgBox("Your dick size is " & Height & "cm", vbInformation, "result")
            End If
        Catch ex As Exception
            If TextBox1.Text = "" Then
                MsgBox("Error, please insert you valid value", vbCritical)
            End If
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "Input your weight"
        Label2.Text = "kg"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "Input your height"
        Label2.Text = "cm"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label1.Text = "Input your dick size"
        Label2.Text = "cm"
    End Sub


End Class
