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
        Me.listRandomNumbers = New System.Windows.Forms.ListBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listRandomNumbers
        '
        Me.listRandomNumbers.FormattingEnabled = True
        Me.listRandomNumbers.Location = New System.Drawing.Point(12, 12)
        Me.listRandomNumbers.Name = "listRandomNumbers"
        Me.listRandomNumbers.Size = New System.Drawing.Size(202, 264)
        Me.listRandomNumbers.TabIndex = 0
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(12, 293)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(202, 23)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "Random Numbers"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 355)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.listRandomNumbers)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listRandomNumbers As ListBox
    Friend WithEvents btnGenerate As Button
End Class
