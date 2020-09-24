<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuadraticEquation
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
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.btnSolutions = New System.Windows.Forms.Button()
        Me.txtSolutions = New System.Windows.Forms.TextBox()
        Me.lblSolutions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(36, 62)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(13, 13)
        Me.lblA.TabIndex = 0
        Me.lblA.Text = "a"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(208, 62)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(13, 13)
        Me.lblB.TabIndex = 1
        Me.lblB.Text = "b"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Location = New System.Drawing.Point(380, 62)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(13, 13)
        Me.lblC.TabIndex = 2
        Me.lblC.Text = "c"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(56, 62)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 20)
        Me.txtA.TabIndex = 3
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(227, 62)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 4
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(399, 62)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 20)
        Me.txtC.TabIndex = 5
        '
        'btnSolutions
        '
        Me.btnSolutions.Location = New System.Drawing.Point(183, 148)
        Me.btnSolutions.Name = "btnSolutions"
        Me.btnSolutions.Size = New System.Drawing.Size(166, 64)
        Me.btnSolutions.TabIndex = 6
        Me.btnSolutions.Text = "Find Solution"
        Me.btnSolutions.UseVisualStyleBackColor = True
        '
        'txtSolutions
        '
        Me.txtSolutions.Location = New System.Drawing.Point(140, 271)
        Me.txtSolutions.Name = "txtSolutions"
        Me.txtSolutions.Size = New System.Drawing.Size(270, 20)
        Me.txtSolutions.TabIndex = 7
        '
        'lblSolutions
        '
        Me.lblSolutions.AutoSize = True
        Me.lblSolutions.Location = New System.Drawing.Point(70, 274)
        Me.lblSolutions.Name = "lblSolutions"
        Me.lblSolutions.Size = New System.Drawing.Size(50, 13)
        Me.lblSolutions.TabIndex = 8
        Me.lblSolutions.Text = "Solutions"
        '
        'frmQuadraticEquation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 402)
        Me.Controls.Add(Me.lblSolutions)
        Me.Controls.Add(Me.txtSolutions)
        Me.Controls.Add(Me.btnSolutions)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Name = "frmQuadraticEquation"
        Me.Text = "Quadratic Equation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblC As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents btnSolutions As Button
    Friend WithEvents txtSolutions As TextBox
    Friend WithEvents lblSolutions As Label
End Class
