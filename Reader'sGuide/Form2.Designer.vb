<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtTween = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.txtGuideSize = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTween
        '
        Me.txtTween.Location = New System.Drawing.Point(112, 58)
        Me.txtTween.Name = "txtTween"
        Me.txtTween.Size = New System.Drawing.Size(100, 20)
        Me.txtTween.TabIndex = 0
        Me.txtTween.Text = "10"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Set Tween"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "colour"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtColour
        '
        Me.txtColour.Location = New System.Drawing.Point(112, 88)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.Size = New System.Drawing.Size(100, 20)
        Me.txtColour.TabIndex = 3
        Me.txtColour.Text = "10"
        '
        'txtGuideSize
        '
        Me.txtGuideSize.Location = New System.Drawing.Point(112, 114)
        Me.txtGuideSize.Name = "txtGuideSize"
        Me.txtGuideSize.Size = New System.Drawing.Size(100, 20)
        Me.txtGuideSize.TabIndex = 5
        Me.txtGuideSize.Text = "10"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 111)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Guide Size"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(45, 140)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar1.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 182)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.txtGuideSize)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtColour)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTween)
        Me.Name = "Form2"
        Me.Text = "Readers Guide "
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTween As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents txtColour As TextBox
    Friend WithEvents txtGuideSize As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TrackBar1 As TrackBar
End Class
