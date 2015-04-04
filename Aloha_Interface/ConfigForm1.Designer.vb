<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigForm1
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
        Me.Aloha_Path = New System.Windows.Forms.TextBox()
        Me.Days = New System.Windows.Forms.TextBox()
        Me.Aloha_Path_Label = New System.Windows.Forms.Label()
        Me.Days_Label = New System.Windows.Forms.Label()
        Me.Save_Data = New System.Windows.Forms.Button()
        Me.StoreNumber_Label = New System.Windows.Forms.Label()
        Me.Store_Number = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Aloha_Path
        '
        Me.Aloha_Path.Location = New System.Drawing.Point(104, 49)
        Me.Aloha_Path.Name = "Aloha_Path"
        Me.Aloha_Path.Size = New System.Drawing.Size(174, 20)
        Me.Aloha_Path.TabIndex = 0
        '
        'Days
        '
        Me.Days.Location = New System.Drawing.Point(103, 98)
        Me.Days.Name = "Days"
        Me.Days.Size = New System.Drawing.Size(174, 20)
        Me.Days.TabIndex = 1
        '
        'Aloha_Path_Label
        '
        Me.Aloha_Path_Label.AutoSize = True
        Me.Aloha_Path_Label.Location = New System.Drawing.Point(19, 52)
        Me.Aloha_Path_Label.Name = "Aloha_Path_Label"
        Me.Aloha_Path_Label.Size = New System.Drawing.Size(59, 13)
        Me.Aloha_Path_Label.TabIndex = 2
        Me.Aloha_Path_Label.Text = "Aloha Path"
        '
        'Days_Label
        '
        Me.Days_Label.AutoSize = True
        Me.Days_Label.Location = New System.Drawing.Point(12, 101)
        Me.Days_Label.Name = "Days_Label"
        Me.Days_Label.Size = New System.Drawing.Size(85, 13)
        Me.Days_Label.TabIndex = 3
        Me.Days_Label.Text = "How Many Days"
        '
        'Save_Data
        '
        Me.Save_Data.Location = New System.Drawing.Point(103, 243)
        Me.Save_Data.Name = "Save_Data"
        Me.Save_Data.Size = New System.Drawing.Size(75, 23)
        Me.Save_Data.TabIndex = 4
        Me.Save_Data.Text = "Save"
        Me.Save_Data.UseVisualStyleBackColor = True
        '
        'StoreNumber_Label
        '
        Me.StoreNumber_Label.AutoSize = True
        Me.StoreNumber_Label.Location = New System.Drawing.Point(12, 149)
        Me.StoreNumber_Label.Name = "StoreNumber_Label"
        Me.StoreNumber_Label.Size = New System.Drawing.Size(72, 13)
        Me.StoreNumber_Label.TabIndex = 6
        Me.StoreNumber_Label.Text = "Store Number"
        '
        'Store_Number
        '
        Me.Store_Number.Location = New System.Drawing.Point(103, 146)
        Me.Store_Number.Name = "Store_Number"
        Me.Store_Number.Size = New System.Drawing.Size(75, 20)
        Me.Store_Number.TabIndex = 5
        '
        'ConfigForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 393)
        Me.Controls.Add(Me.StoreNumber_Label)
        Me.Controls.Add(Me.Store_Number)
        Me.Controls.Add(Me.Save_Data)
        Me.Controls.Add(Me.Days_Label)
        Me.Controls.Add(Me.Aloha_Path_Label)
        Me.Controls.Add(Me.Days)
        Me.Controls.Add(Me.Aloha_Path)
        Me.Name = "ConfigForm1"
        Me.Text = "Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Aloha_Path As System.Windows.Forms.TextBox
    Friend WithEvents Days As System.Windows.Forms.TextBox
    Friend WithEvents Aloha_Path_Label As System.Windows.Forms.Label
    Friend WithEvents Days_Label As System.Windows.Forms.Label
    Friend WithEvents Save_Data As System.Windows.Forms.Button
    Friend WithEvents StoreNumber_Label As System.Windows.Forms.Label
    Friend WithEvents Store_Number As System.Windows.Forms.TextBox
End Class
