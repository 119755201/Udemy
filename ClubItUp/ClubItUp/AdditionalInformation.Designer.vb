<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdditionalInformation
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
        Me.gbxEmployeeInformation = New System.Windows.Forms.GroupBox()
        Me.rdoCorrectNo = New System.Windows.Forms.RadioButton()
        Me.rdoCorrectYes = New System.Windows.Forms.RadioButton()
        Me.lblDetailsCorrect = New System.Windows.Forms.Label()
        Me.lblImportantInformation = New System.Windows.Forms.Label()
        Me.gbxInformationConfirmation = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbxEmployeeInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxEmployeeInformation
        '
        Me.gbxEmployeeInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.gbxEmployeeInformation.Controls.Add(Me.rdoCorrectNo)
        Me.gbxEmployeeInformation.Controls.Add(Me.rdoCorrectYes)
        Me.gbxEmployeeInformation.Controls.Add(Me.lblDetailsCorrect)
        Me.gbxEmployeeInformation.Controls.Add(Me.lblImportantInformation)
        Me.gbxEmployeeInformation.Controls.Add(Me.gbxInformationConfirmation)
        Me.gbxEmployeeInformation.Controls.Add(Me.btnNext)
        Me.gbxEmployeeInformation.Controls.Add(Me.btnBack)
        Me.gbxEmployeeInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbxEmployeeInformation.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxEmployeeInformation.Location = New System.Drawing.Point(54, 32)
        Me.gbxEmployeeInformation.Name = "gbxEmployeeInformation"
        Me.gbxEmployeeInformation.Size = New System.Drawing.Size(626, 310)
        Me.gbxEmployeeInformation.TabIndex = 10
        Me.gbxEmployeeInformation.TabStop = False
        '
        'rdoCorrectNo
        '
        Me.rdoCorrectNo.AutoSize = True
        Me.rdoCorrectNo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCorrectNo.Location = New System.Drawing.Point(357, 226)
        Me.rdoCorrectNo.Name = "rdoCorrectNo"
        Me.rdoCorrectNo.Size = New System.Drawing.Size(46, 23)
        Me.rdoCorrectNo.TabIndex = 17
        Me.rdoCorrectNo.TabStop = True
        Me.rdoCorrectNo.Text = "No"
        Me.rdoCorrectNo.UseVisualStyleBackColor = True
        '
        'rdoCorrectYes
        '
        Me.rdoCorrectYes.AutoSize = True
        Me.rdoCorrectYes.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCorrectYes.Location = New System.Drawing.Point(212, 226)
        Me.rdoCorrectYes.Name = "rdoCorrectYes"
        Me.rdoCorrectYes.Size = New System.Drawing.Size(48, 23)
        Me.rdoCorrectYes.TabIndex = 16
        Me.rdoCorrectYes.TabStop = True
        Me.rdoCorrectYes.Text = "Yes"
        Me.rdoCorrectYes.UseVisualStyleBackColor = True
        '
        'lblDetailsCorrect
        '
        Me.lblDetailsCorrect.AutoSize = True
        Me.lblDetailsCorrect.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailsCorrect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblDetailsCorrect.Location = New System.Drawing.Point(139, 202)
        Me.lblDetailsCorrect.Name = "lblDetailsCorrect"
        Me.lblDetailsCorrect.Size = New System.Drawing.Size(390, 21)
        Me.lblDetailsCorrect.TabIndex = 15
        Me.lblDetailsCorrect.Text = "Have you read and understood the above details?"
        '
        'lblImportantInformation
        '
        Me.lblImportantInformation.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImportantInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblImportantInformation.Location = New System.Drawing.Point(178, 30)
        Me.lblImportantInformation.Name = "lblImportantInformation"
        Me.lblImportantInformation.Size = New System.Drawing.Size(292, 37)
        Me.lblImportantInformation.TabIndex = 11
        Me.lblImportantInformation.Text = "Important Information"
        '
        'gbxInformationConfirmation
        '
        Me.gbxInformationConfirmation.BackColor = System.Drawing.Color.White
        Me.gbxInformationConfirmation.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxInformationConfirmation.Location = New System.Drawing.Point(32, 87)
        Me.gbxInformationConfirmation.Name = "gbxInformationConfirmation"
        Me.gbxInformationConfirmation.Size = New System.Drawing.Size(558, 96)
        Me.gbxInformationConfirmation.TabIndex = 10
        Me.gbxInformationConfirmation.TabStop = False
        Me.gbxInformationConfirmation.Text = "Information Confirmation"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(434, 250)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(93, 37)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(107, 250)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(93, 37)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(318, 366)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 37)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmAdditionalInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(729, 428)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbxEmployeeInformation)
        Me.Name = "frmAdditionalInformation"
        Me.Text = "Additional Information"
        Me.gbxEmployeeInformation.ResumeLayout(False)
        Me.gbxEmployeeInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxEmployeeInformation As GroupBox
    Friend WithEvents lblImportantInformation As Label
    Friend WithEvents gbxInformationConfirmation As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents rdoCorrectNo As RadioButton
    Friend WithEvents rdoCorrectYes As RadioButton
    Friend WithEvents lblDetailsCorrect As Label
    Friend WithEvents btnExit As Button
End Class
