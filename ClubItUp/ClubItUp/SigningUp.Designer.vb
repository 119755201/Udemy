<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterDetails
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblYourDetails = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeEmail = New System.Windows.Forms.TextBox()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.gbxRegistrationDetails = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtRetypedPassword = New System.Windows.Forms.TextBox()
        Me.lblEmployeeEmail = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbxRegistrationDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(107, 242)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(93, 37)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblYourDetails
        '
        Me.lblYourDetails.AutoSize = True
        Me.lblYourDetails.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblYourDetails.Location = New System.Drawing.Point(26, 30)
        Me.lblYourDetails.Name = "lblYourDetails"
        Me.lblYourDetails.Size = New System.Drawing.Size(158, 37)
        Me.lblYourDetails.TabIndex = 0
        Me.lblYourDetails.Text = "Your Details"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeName.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEmployeeName.Location = New System.Drawing.Point(86, 118)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(155, 27)
        Me.txtEmployeeName.TabIndex = 2
        '
        'txtEmployeeEmail
        '
        Me.txtEmployeeEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeEmail.Location = New System.Drawing.Point(86, 179)
        Me.txtEmployeeEmail.Name = "txtEmployeeEmail"
        Me.txtEmployeeEmail.Size = New System.Drawing.Size(155, 34)
        Me.txtEmployeeEmail.TabIndex = 3
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblEmployeeName.Location = New System.Drawing.Point(82, 94)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(88, 21)
        Me.lblEmployeeName.TabIndex = 1
        Me.lblEmployeeName.Text = "Full Name"
        '
        'gbxRegistrationDetails
        '
        Me.gbxRegistrationDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.gbxRegistrationDetails.Controls.Add(Me.Label2)
        Me.gbxRegistrationDetails.Controls.Add(Me.btnNext)
        Me.gbxRegistrationDetails.Controls.Add(Me.Label1)
        Me.gbxRegistrationDetails.Controls.Add(Me.txtPassword)
        Me.gbxRegistrationDetails.Controls.Add(Me.txtRetypedPassword)
        Me.gbxRegistrationDetails.Controls.Add(Me.lblEmployeeEmail)
        Me.gbxRegistrationDetails.Controls.Add(Me.btnBack)
        Me.gbxRegistrationDetails.Controls.Add(Me.lblYourDetails)
        Me.gbxRegistrationDetails.Controls.Add(Me.txtEmployeeName)
        Me.gbxRegistrationDetails.Controls.Add(Me.txtEmployeeEmail)
        Me.gbxRegistrationDetails.Controls.Add(Me.lblEmployeeName)
        Me.gbxRegistrationDetails.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbxRegistrationDetails.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRegistrationDetails.Location = New System.Drawing.Point(54, 32)
        Me.gbxRegistrationDetails.Name = "gbxRegistrationDetails"
        Me.gbxRegistrationDetails.Size = New System.Drawing.Size(626, 310)
        Me.gbxRegistrationDetails.TabIndex = 5
        Me.gbxRegistrationDetails.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(401, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Re-Typed Password"
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
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(401, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.Location = New System.Drawing.Point(405, 118)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(155, 27)
        Me.txtPassword.TabIndex = 6
        '
        'txtRetypedPassword
        '
        Me.txtRetypedPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRetypedPassword.Location = New System.Drawing.Point(405, 179)
        Me.txtRetypedPassword.Name = "txtRetypedPassword"
        Me.txtRetypedPassword.Size = New System.Drawing.Size(155, 34)
        Me.txtRetypedPassword.TabIndex = 7
        '
        'lblEmployeeEmail
        '
        Me.lblEmployeeEmail.AutoSize = True
        Me.lblEmployeeEmail.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblEmployeeEmail.Location = New System.Drawing.Point(82, 155)
        Me.lblEmployeeEmail.Name = "lblEmployeeEmail"
        Me.lblEmployeeEmail.Size = New System.Drawing.Size(116, 21)
        Me.lblEmployeeEmail.TabIndex = 5
        Me.lblEmployeeEmail.Text = "Email Address"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(321, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 37)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmRegisterDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(729, 428)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbxRegistrationDetails)
        Me.Name = "frmRegisterDetails"
        Me.Text = "Register Details"
        Me.gbxRegistrationDetails.ResumeLayout(False)
        Me.gbxRegistrationDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblYourDetails As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtEmployeeEmail As TextBox
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents gbxRegistrationDetails As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtRetypedPassword As TextBox
    Friend WithEvents lblEmployeeEmail As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
End Class
