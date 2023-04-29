<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.picWheel = New System.Windows.Forms.PictureBox()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.TimerSpin = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picWheel
        '
        Me.picWheel.Image = Global.spin_the_wheel.My.Resources.Resources.spin_0
        Me.picWheel.Location = New System.Drawing.Point(104, 32)
        Me.picWheel.Name = "picWheel"
        Me.picWheel.Size = New System.Drawing.Size(561, 368)
        Me.picWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWheel.TabIndex = 0
        Me.picWheel.TabStop = False
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(339, 406)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(94, 41)
        Me.btnSpin.TabIndex = 1
        Me.btnSpin.Text = "Spin"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'TimerSpin
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 479)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.picWheel)
        Me.Name = "frmMain"
        Me.Text = "Spin the Wheel!"
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picWheel As PictureBox
    Friend WithEvents btnSpin As Button
    Friend WithEvents TimerSpin As Timer
End Class
