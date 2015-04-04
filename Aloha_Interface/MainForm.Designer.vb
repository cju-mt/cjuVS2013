<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Config_Settings = New System.Windows.Forms.Button()
        Me.Run_Export = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(387, 441)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "About"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Config_Settings
        '
        Me.Config_Settings.Location = New System.Drawing.Point(24, 441)
        Me.Config_Settings.Name = "Config_Settings"
        Me.Config_Settings.Size = New System.Drawing.Size(119, 23)
        Me.Config_Settings.TabIndex = 1
        Me.Config_Settings.Text = "Config Settings"
        Me.Config_Settings.UseVisualStyleBackColor = True
        '
        'Run_Export
        '
        Me.Run_Export.Location = New System.Drawing.Point(24, 52)
        Me.Run_Export.Name = "Run_Export"
        Me.Run_Export.Size = New System.Drawing.Size(75, 23)
        Me.Run_Export.TabIndex = 2
        Me.Run_Export.Text = "Run Export"
        Me.Run_Export.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 476)
        Me.Controls.Add(Me.Run_Export)
        Me.Controls.Add(Me.Config_Settings)
        Me.Controls.Add(Me.Button1)
        Me.Name = "MainForm"
        Me.Text = "Bridg Interface Main"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Config_Settings As System.Windows.Forms.Button
    Friend WithEvents Run_Export As System.Windows.Forms.Button

End Class
