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
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(142, 35)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAge.TabIndex = 0
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(142, 81)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(100, 20)
        Me.txtYears.TabIndex = 1
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(12, 35)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "Age"
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Location = New System.Drawing.Point(12, 81)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(60, 13)
        Me.lblYears.TabIndex = 3
        Me.lblYears.Text = "Experience"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(15, 169)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 226)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtAge)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtYears As System.Windows.Forms.TextBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblYears As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.Button

End Class
