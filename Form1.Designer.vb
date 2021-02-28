<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MAIN
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
        Me.BTN_START = New System.Windows.Forms.Button()
        Me.BTN_STOP = New System.Windows.Forms.Button()
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.TMR_POMODORO = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BTN_START
        '
        Me.BTN_START.Location = New System.Drawing.Point(12, 54)
        Me.BTN_START.Name = "BTN_START"
        Me.BTN_START.Size = New System.Drawing.Size(75, 23)
        Me.BTN_START.TabIndex = 0
        Me.BTN_START.Text = "START"
        Me.BTN_START.UseVisualStyleBackColor = True
        '
        'BTN_STOP
        '
        Me.BTN_STOP.Location = New System.Drawing.Point(124, 54)
        Me.BTN_STOP.Name = "BTN_STOP"
        Me.BTN_STOP.Size = New System.Drawing.Size(75, 23)
        Me.BTN_STOP.TabIndex = 1
        Me.BTN_STOP.Text = "STOP"
        Me.BTN_STOP.UseVisualStyleBackColor = True
        '
        'LabelTimer
        '
        Me.LabelTimer.AutoSize = True
        Me.LabelTimer.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTimer.Location = New System.Drawing.Point(85, 9)
        Me.LabelTimer.Name = "LabelTimer"
        Me.LabelTimer.Size = New System.Drawing.Size(50, 42)
        Me.LabelTimer.TabIndex = 2
        Me.LabelTimer.Text = "25"
        '
        'TMR_POMODORO
        '
        Me.TMR_POMODORO.Interval = 60000
        '
        'FRM_MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 85)
        Me.Controls.Add(Me.LabelTimer)
        Me.Controls.Add(Me.BTN_STOP)
        Me.Controls.Add(Me.BTN_START)
        Me.Name = "FRM_MAIN"
        Me.Text = "Simple Pomodoro Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_START As Button
    Friend WithEvents BTN_STOP As Button
    Friend WithEvents LabelTimer As Label
    Friend WithEvents TMR_POMODORO As Timer
End Class
