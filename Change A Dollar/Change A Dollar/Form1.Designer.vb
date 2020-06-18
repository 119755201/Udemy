<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeADollar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeADollar))
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAmountInput = New System.Windows.Forms.Label()
        Me.lbl1Cent = New System.Windows.Forms.Label()
        Me.lbl5Cents = New System.Windows.Forms.Label()
        Me.lbl10Cents = New System.Windows.Forms.Label()
        Me.lbl25Cents = New System.Windows.Forms.Label()
        Me.txt1Cent = New System.Windows.Forms.TextBox()
        Me.txt5Cents = New System.Windows.Forms.TextBox()
        Me.txt10Cents = New System.Windows.Forms.TextBox()
        Me.txt25Cents = New System.Windows.Forms.TextBox()
        Me.txtAmountInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        resources.ApplyResources(Me.btnCalculate, "btnCalculate")
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAmountInput
        '
        resources.ApplyResources(Me.lblAmountInput, "lblAmountInput")
        Me.lblAmountInput.Name = "lblAmountInput"
        '
        'lbl1Cent
        '
        resources.ApplyResources(Me.lbl1Cent, "lbl1Cent")
        Me.lbl1Cent.Name = "lbl1Cent"
        '
        'lbl5Cents
        '
        resources.ApplyResources(Me.lbl5Cents, "lbl5Cents")
        Me.lbl5Cents.Name = "lbl5Cents"
        '
        'lbl10Cents
        '
        resources.ApplyResources(Me.lbl10Cents, "lbl10Cents")
        Me.lbl10Cents.Name = "lbl10Cents"
        '
        'lbl25Cents
        '
        resources.ApplyResources(Me.lbl25Cents, "lbl25Cents")
        Me.lbl25Cents.Name = "lbl25Cents"
        '
        'txt1Cent
        '
        Me.txt1Cent.BackColor = System.Drawing.SystemColors.ActiveCaption
        resources.ApplyResources(Me.txt1Cent, "txt1Cent")
        Me.txt1Cent.Name = "txt1Cent"
        Me.txt1Cent.ReadOnly = True
        '
        'txt5Cents
        '
        Me.txt5Cents.BackColor = System.Drawing.SystemColors.ActiveCaption
        resources.ApplyResources(Me.txt5Cents, "txt5Cents")
        Me.txt5Cents.Name = "txt5Cents"
        Me.txt5Cents.ReadOnly = True
        '
        'txt10Cents
        '
        Me.txt10Cents.BackColor = System.Drawing.SystemColors.ActiveCaption
        resources.ApplyResources(Me.txt10Cents, "txt10Cents")
        Me.txt10Cents.Name = "txt10Cents"
        Me.txt10Cents.ReadOnly = True
        '
        'txt25Cents
        '
        Me.txt25Cents.BackColor = System.Drawing.SystemColors.ActiveCaption
        resources.ApplyResources(Me.txt25Cents, "txt25Cents")
        Me.txt25Cents.Name = "txt25Cents"
        Me.txt25Cents.ReadOnly = True
        '
        'txtAmountInput
        '
        resources.ApplyResources(Me.txtAmountInput, "txtAmountInput")
        Me.txtAmountInput.Name = "txtAmountInput"
        '
        'frmChangeADollar
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblAmountInput)
        Me.Controls.Add(Me.lbl1Cent)
        Me.Controls.Add(Me.lbl5Cents)
        Me.Controls.Add(Me.lbl10Cents)
        Me.Controls.Add(Me.lbl25Cents)
        Me.Controls.Add(Me.txt1Cent)
        Me.Controls.Add(Me.txt5Cents)
        Me.Controls.Add(Me.txt10Cents)
        Me.Controls.Add(Me.txt25Cents)
        Me.Controls.Add(Me.txtAmountInput)
        Me.Name = "frmChangeADollar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblAmountInput As Label
    Friend WithEvents lbl1Cent As Label
    Friend WithEvents lbl5Cents As Label
    Friend WithEvents lbl10Cents As Label
    Friend WithEvents lbl25Cents As Label
    Friend WithEvents txt1Cent As TextBox
    Friend WithEvents txt5Cents As TextBox
    Friend WithEvents txt10Cents As TextBox
    Friend WithEvents txt25Cents As TextBox
    Friend WithEvents txtAmountInput As TextBox
End Class
