<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.But9 = New System.Windows.Forms.Button()
        Me.But8 = New System.Windows.Forms.Button()
        Me.But7 = New System.Windows.Forms.Button()
        Me.LISTBOX1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'But9
        '
        Me.But9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.But9.Font = New System.Drawing.Font("Showcard Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But9.Location = New System.Drawing.Point(478, 307)
        Me.But9.Name = "But9"
        Me.But9.Size = New System.Drawing.Size(194, 85)
        Me.But9.TabIndex = 7
        Me.But9.Text = "MAIN MENU "
        Me.But9.UseVisualStyleBackColor = False
        '
        'But8
        '
        Me.But8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.But8.Font = New System.Drawing.Font("Showcard Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But8.Location = New System.Drawing.Point(478, 157)
        Me.But8.Name = "But8"
        Me.But8.Size = New System.Drawing.Size(192, 89)
        Me.But8.TabIndex = 6
        Me.But8.Text = "INSERTION SORT "
        Me.But8.UseVisualStyleBackColor = False
        '
        'But7
        '
        Me.But7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.But7.Font = New System.Drawing.Font("Showcard Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But7.Location = New System.Drawing.Point(478, 25)
        Me.But7.Name = "But7"
        Me.But7.Size = New System.Drawing.Size(194, 84)
        Me.But7.TabIndex = 5
        Me.But7.Text = "BUBBLE SORT "
        Me.But7.UseVisualStyleBackColor = False
        '
        'LISTBOX1
        '
        Me.LISTBOX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LISTBOX1.Font = New System.Drawing.Font("Showcard Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LISTBOX1.FormattingEnabled = True
        Me.LISTBOX1.ItemHeight = 35
        Me.LISTBOX1.Location = New System.Drawing.Point(129, 13)
        Me.LISTBOX1.Name = "LISTBOX1"
        Me.LISTBOX1.Size = New System.Drawing.Size(187, 424)
        Me.LISTBOX1.TabIndex = 4
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(866, 547)
        Me.Controls.Add(Me.But9)
        Me.Controls.Add(Me.But8)
        Me.Controls.Add(Me.But7)
        Me.Controls.Add(Me.LISTBOX1)
        Me.Name = "Form3"
        Me.Text = "FORMSORT"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents But9 As Button
    Friend WithEvents But8 As Button
    Friend WithEvents But7 As Button
    Friend WithEvents LISTBOX1 As ListBox
End Class
