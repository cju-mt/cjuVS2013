Imports System
Imports System.Xml
Public Class MainForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aboutForm As New AboutBox1
        aboutForm.Show()
    End Sub

    Private Sub Config_Settings_Click(sender As Object, e As EventArgs) Handles Config_Settings.Click
        Dim ConfigForm As New ConfigForm1
        ConfigForm.Show()
    End Sub

    Private Sub Run_Export_Click(sender As Object, e As EventArgs) Handles Run_Export.Click
        Dim strPath, strProgram, strParameters, strCommand As String
        Using reader As XmlReader = XmlTextReader.Create("ConfigXML.xml")

            strPath = " ""C:\Program Files (x86)\DBF to CSV\"
            strProgram = "dbf2csv.exe"" "

            'strParameters = " d:\aloha\20141220\GNDTNDR.DBF d:\temp\csvtodbf\GNDTNDR.CSV /log /silent"
            strParameters =
            strCommand = strPath + strProgram + strParameters
            MessageBox.Show(strCommand)
            'Shell("CMD /k" & strCommand, AppWinStyle.NormalFocus)
            Shell("CMD /k" & strCommand, AppWinStyle.Hide)
        End Using

    End Sub
End Class
