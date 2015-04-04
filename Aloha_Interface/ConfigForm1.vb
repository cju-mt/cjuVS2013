Imports System
Imports System.Xml

Public Class ConfigForm1

    Private Sub ConfigForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check if file ConfigXML.xml is existing
        If (IO.File.Exists("ConfigXML.xml")) Then

            'create a new xmltextreader object
            'this is the object that we will loop and will be used to read the xml file
            Dim document As XmlReader = New XmlTextReader("ConfigXML.xml")

            'loop through the xml file
            While (document.Read())

                Dim type = document.NodeType

                'if node type was element
                If (type = XmlNodeType.Element) Then

                    'if the loop found a <Aloha_Path> tag
                    If (document.Name = "Aloha_Path") Then

                        Aloha_Path.Text = document.ReadInnerXml.ToString()

                    End If

                    'if the loop found a <Days> tag
                    If (document.Name = "Days") Then

                        Days.Text = document.ReadInnerXml.ToString()

                    End If

                    If (document.Name = "Store_Number") Then

                        Store_Number.Text = document.ReadInnerXml.ToString()

                    End If

                End If

            End While
            document.Close()
        Else

            MessageBox.Show("The filename you selected was not found.")
        End If
    End Sub

    Private Sub Save_Data_Click(sender As Object, e As EventArgs) Handles Save_Data.Click
        If IO.File.Exists("ConfigXML.xml") = False Then
            'declare our xmlwritersettings object
            Dim settings As New XmlWriterSettings()
            'lets tell to our xmlwritersettings that it must use indention for our xml
            settings.Indent = True
            Dim XmlWrtDave As XmlWriter = XmlWriter.Create("ConfigXML.xml", settings)

            MessageBox.Show("Created a new ConfigXML.xml.")
            XmlWrtDave.Close()
        End If

       

        'Dim XmlWrt As XmlWriter = XmlWriter.Create("ConfigXML.xml", settings)
        Dim XmlWrt As XmlTextWriter = New XmlTextWriter("ConfigXML.xml", System.Text.Encoding.UTF8)
        XmlWrt.Formatting = System.Xml.Formatting.Indented
        With XmlWrt
            ' Write the Xml declaration.
            .WriteStartDocument()
            ' Write a comment.
            .WriteComment("XML Database.")
            ' Write the root element.
            .WriteStartElement("Data")
            ' Start our section.
            .WriteStartElement("Aloha_Info")
            .WriteStartElement("Aloha_Path")
            .WriteString(Aloha_Path.Text)
            .WriteEndElement()
            .WriteStartElement("Days")
            .WriteString(Days.Text)
            .WriteEndElement()
            .WriteStartElement("Store_Number")
            .WriteString(Store_Number.Text)
            .WriteEndElement()
            .WriteEndElement()
            ' Close the XmlTextWriter.
            .WriteEndDocument()
            .Close()
        End With
        MessageBox.Show("XML file saved.")






























    End Sub

    
End Class