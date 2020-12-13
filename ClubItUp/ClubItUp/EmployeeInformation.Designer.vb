<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeConfirmation
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbxEmployeeInformation = New System.Windows.Forms.GroupBox()
        Me.lstUserInfoOutput = New System.Windows.Forms.ListBox()
        Me.btnUpdateDetails = New System.Windows.Forms.Button()
        Me.lblUpdateDetails = New System.Windows.Forms.Label()
        Me.lblContinue = New System.Windows.Forms.Label()
        Me.rdoCorrectNo = New System.Windows.Forms.RadioButton()
        Me.rdoCorrectYes = New System.Windows.Forms.RadioButton()
        Me.lblDetailsCorrect = New System.Windows.Forms.Label()
        Me.lblYourDetails = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbxEmployeeInformation.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'gbxEmployeeInformation
        '
        Me.gbxEmployeeInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.gbxEmployeeInformation.Controls.Add(Me.lstUserInfoOutput)
        Me.gbxEmployeeInformation.Controls.Add(Me.btnUpdateDetails)
        Me.gbxEmployeeInformation.Controls.Add(Me.lblUpdateDetails)
        Me.gbxEmployeeInformation.Controls.Add(Me.lblContinue)
        Me.gbxEmployeeInformation.Controls.Add(Me.rdoCorrectNo)
        Me.gbxEmployeeInformation.Controls.Add(Me.rdoCorrectYes)
        Me.gbxEmployeeInformation.Controls.Add(Me.lblDetailsCorrect)
        Me.gbxEmployeeInformation.Controls.Add(Me.lblYourDetails)
        Me.gbxEmployeeInformation.Controls.Add(Me.btnNext)
        Me.gbxEmployeeInformation.Controls.Add(Me.btnBack)
        Me.gbxEmployeeInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbxEmployeeInformation.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxEmployeeInformation.Location = New System.Drawing.Point(54, 32)
        Me.gbxEmployeeInformation.Name = "gbxEmployeeInformation"
        Me.gbxEmployeeInformation.Size = New System.Drawing.Size(626, 310)
        Me.gbxEmployeeInformation.TabIndex = 9
        Me.gbxEmployeeInformation.TabStop = False
        '
        'lstUserInfoOutput
        '
        Me.lstUserInfoOutput.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUserInfoOutput.FormattingEnabled = True
        Me.lstUserInfoOutput.ItemHeight = 19
        Me.lstUserInfoOutput.Location = New System.Drawing.Point(58, 87)
        Me.lstUserInfoOutput.Name = "lstUserInfoOutput"
        Me.lstUserInfoOutput.Size = New System.Drawing.Size(235, 118)
        Me.lstUserInfoOutput.TabIndex = 18
        '
        'btnUpdateDetails
        '
        Me.btnUpdateDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnUpdateDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdateDetails.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDetails.ForeColor = System.Drawing.Color.White
        Me.btnUpdateDetails.Location = New System.Drawing.Point(409, 168)
        Me.btnUpdateDetails.Name = "btnUpdateDetails"
        Me.btnUpdateDetails.Size = New System.Drawing.Size(118, 37)
        Me.btnUpdateDetails.TabIndex = 17
        Me.btnUpdateDetails.Text = "Update Details"
        Me.btnUpdateDetails.UseVisualStyleBackColor = False
        Me.btnUpdateDetails.Visible = False
        '
        'lblUpdateDetails
        '
        Me.lblUpdateDetails.AutoSize = True
        Me.lblUpdateDetails.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblUpdateDetails.Location = New System.Drawing.Point(390, 144)
        Me.lblUpdateDetails.Name = "lblUpdateDetails"
        Me.lblUpdateDetails.Size = New System.Drawing.Size(167, 21)
        Me.lblUpdateDetails.TabIndex = 16
        Me.lblUpdateDetails.Text = "Update your details?"
        Me.lblUpdateDetails.Visible = False
        '
        'lblContinue
        '
        Me.lblContinue.AutoSize = True
        Me.lblContinue.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblContinue.Location = New System.Drawing.Point(377, 218)
        Me.lblContinue.Name = "lblContinue"
        Me.lblContinue.Size = New System.Drawing.Size(192, 21)
        Me.lblContinue.TabIndex = 15
        Me.lblContinue.Text = "Select Next to Continue"
        Me.lblContinue.Visible = False
        '
        'rdoCorrectNo
        '
        Me.rdoCorrectNo.AutoSize = True
        Me.rdoCorrectNo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCorrectNo.Location = New System.Drawing.Point(521, 109)
        Me.rdoCorrectNo.Name = "rdoCorrectNo"
        Me.rdoCorrectNo.Size = New System.Drawing.Size(46, 23)
        Me.rdoCorrectNo.TabIndex = 14
        Me.rdoCorrectNo.TabStop = True
        Me.rdoCorrectNo.Text = "No"
        Me.rdoCorrectNo.UseVisualStyleBackColor = True
        '
        'rdoCorrectYes
        '
        Me.rdoCorrectYes.AutoSize = True
        Me.rdoCorrectYes.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCorrectYes.Location = New System.Drawing.Point(378, 109)
        Me.rdoCorrectYes.Name = "rdoCorrectYes"
        Me.rdoCorrectYes.Size = New System.Drawing.Size(48, 23)
        Me.rdoCorrectYes.TabIndex = 13
        Me.rdoCorrectYes.TabStop = True
        Me.rdoCorrectYes.Text = "Yes"
        Me.rdoCorrectYes.UseVisualStyleBackColor = True
        '
        'lblDetailsCorrect
        '
        Me.lblDetailsCorrect.AutoSize = True
        Me.lblDetailsCorrect.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailsCorrect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblDetailsCorrect.Location = New System.Drawing.Point(374, 85)
        Me.lblDetailsCorrect.Name = "lblDetailsCorrect"
        Me.lblDetailsCorrect.Size = New System.Drawing.Size(195, 21)
        Me.lblDetailsCorrect.TabIndex = 12
        Me.lblDetailsCorrect.Text = "Are your details correct?"
        '
        'lblYourDetails
        '
        Me.lblYourDetails.AutoSize = True
        Me.lblYourDetails.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblYourDetails.Location = New System.Drawing.Point(180, 30)
        Me.lblYourDetails.Name = "lblYourDetails"
        Me.lblYourDetails.Size = New System.Drawing.Size(292, 37)
        Me.lblYourDetails.TabIndex = 11
        Me.lblYourDetails.Text = "Confirmation of Details"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(421, 242)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(93, 37)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        Me.btnNext.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(111, 242)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(93, 37)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmEmployeeConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(729, 428)
        Me.Controls.Add(Me.gbxEmployeeInformation)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmEmployeeConfirmation"
        Me.Text = "Employee Information"
        Me.gbxEmployeeInformation.ResumeLayout(False)
        Me.gbxEmployeeInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents gbxEmployeeInformation As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblYourDetails As Label
    Friend WithEvents lblDetailsCorrect As Label
    Friend WithEvents rdoCorrectNo As RadioButton
    Friend WithEvents rdoCorrectYes As RadioButton
    Friend WithEvents lblContinue As Label
    Friend WithEvents lblUpdateDetails As Label
    Friend WithEvents btnUpdateDetails As Button
    Friend WithEvents lstUserInfoOutput As ListBox
End Class
