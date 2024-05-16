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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.But6 = New System.Windows.Forms.Button()
        Me.But5 = New System.Windows.Forms.Button()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Lab2 = New System.Windows.Forms.Label()
        Me.But3 = New System.Windows.Forms.Button()
        Me.LISTBOX1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'But6
        '
        Me.But6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.But6.Font = New System.Drawing.Font("Showcard Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But6.Location = New System.Drawing.Point(442, 271)
        Me.But6.Name = "But6"
        Me.But6.Size = New System.Drawing.Size(346, 138)
        Me.But6.TabIndex = 12
        Me.But6.Text = "BINARY SEARCH FROM USER DATA "
        Me.But6.UseVisualStyleBackColor = False
        '
        'But5
        '
        Me.But5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.But5.Font = New System.Drawing.Font("Showcard Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But5.Location = New System.Drawing.Point(12, 347)
        Me.But5.Name = "But5"
        Me.But5.Size = New System.Drawing.Size(403, 138)
        Me.But5.TabIndex = 11
        Me.But5.Text = "LINEAR SEARCH FROM USER DATA "
        Me.But5.UseVisualStyleBackColor = False
        '
        'Text1
        '
        Me.Text1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Text1.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.Location = New System.Drawing.Point(547, 105)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(150, 37)
        Me.Text1.TabIndex = 10
        '
        'Lab2
        '
        Me.Lab2.AutoSize = True
        Me.Lab2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Lab2.Font = New System.Drawing.Font("Showcard Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab2.Location = New System.Drawing.Point(436, 46)
        Me.Lab2.Name = "Lab2"
        Me.Lab2.Size = New System.Drawing.Size(328, 35)
        Me.Lab2.TabIndex = 9
        Me.Lab2.Text = "Enter No. To Search"
        '
        'But3
        '
        Me.But3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.But3.Font = New System.Drawing.Font("Showcard Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But3.Location = New System.Drawing.Point(12, 46)
        Me.But3.Name = "But3"
        Me.But3.Size = New System.Drawing.Size(184, 148)
        Me.But3.TabIndex = 8
        Me.But3.Text = "DATA FROM EXTERNAL FILE "
        Me.But3.UseVisualStyleBackColor = False
        '
        'LISTBOX1
        '
        Me.LISTBOX1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LISTBOX1.Font = New System.Drawing.Font("Showcard Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LISTBOX1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LISTBOX1.FormattingEnabled = True
        Me.LISTBOX1.ItemHeight = 35
        Me.LISTBOX1.Location = New System.Drawing.Point(225, 7)
        Me.LISTBOX1.Name = "LISTBOX1"
        Me.LISTBOX1.Size = New System.Drawing.Size(170, 284)
        Me.LISTBOX1.TabIndex = 7
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 556)
        Me.Controls.Add(Me.But6)
        Me.Controls.Add(Me.But5)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Lab2)
        Me.Controls.Add(Me.But3)
        Me.Controls.Add(Me.LISTBOX1)
        Me.Name = "Form2"
        Me.Text = "FORMSEARCH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents But6 As Button
    Friend WithEvents But5 As Button
    Friend WithEvents Text1 As TextBox
    Friend WithEvents Lab2 As Label
    Friend WithEvents But3 As Button
    Friend WithEvents LISTBOX1 As ListBox
End Class
