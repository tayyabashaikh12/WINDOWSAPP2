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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.But2 = New System.Windows.Forms.Button()
        Me.But1 = New System.Windows.Forms.Button()
        Me.Lab1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'But2
        '
        Me.But2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.But2.Font = New System.Drawing.Font("Showcard Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.But2.Location = New System.Drawing.Point(460, 268)
        Me.But2.Name = "But2"
        Me.But2.Size = New System.Drawing.Size(278, 118)
        Me.But2.TabIndex = 5
        Me.But2.Text = "Searching "
        Me.But2.UseVisualStyleBackColor = False
        '
        'But1
        '
        Me.But1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.But1.Font = New System.Drawing.Font("Showcard Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But1.ForeColor = System.Drawing.Color.Blue
        Me.But1.Location = New System.Drawing.Point(63, 187)
        Me.But1.Name = "But1"
        Me.But1.Size = New System.Drawing.Size(249, 115)
        Me.But1.TabIndex = 4
        Me.But1.Text = "Sorting "
        Me.But1.UseVisualStyleBackColor = False
        '
        'Lab1
        '
        Me.Lab1.AutoSize = True
        Me.Lab1.BackColor = System.Drawing.Color.White
        Me.Lab1.Font = New System.Drawing.Font("Showcard Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab1.ForeColor = System.Drawing.Color.Fuchsia
        Me.Lab1.Location = New System.Drawing.Point(98, 65)
        Me.Lab1.Name = "Lab1"
        Me.Lab1.Size = New System.Drawing.Size(605, 50)
        Me.Lab1.TabIndex = 3
        Me.Lab1.Text = "WELCOME TO MY FIRST PAGE "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.But2)
        Me.Controls.Add(Me.But1)
        Me.Controls.Add(Me.Lab1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents But2 As Button
    Friend WithEvents But1 As Button
    Friend WithEvents Lab1 As Label
End Class
