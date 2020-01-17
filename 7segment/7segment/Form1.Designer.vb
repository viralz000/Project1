<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(388, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(71, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(388, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(71, 414)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(388, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.ImageIndex = 3
        Me.Button4.Location = New System.Drawing.Point(18, 69)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(41, 179)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.ImageIndex = 3
        Me.Button5.Location = New System.Drawing.Point(468, 69)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(41, 179)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.ImageIndex = 3
        Me.Button6.Location = New System.Drawing.Point(468, 254)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(41, 179)
        Me.Button6.TabIndex = 5
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.ImageIndex = 3
        Me.Button7.Location = New System.Drawing.Point(18, 254)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(41, 179)
        Me.Button7.TabIndex = 6
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 507)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Timer1 As Timer
End Class
