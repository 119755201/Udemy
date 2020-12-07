<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gbxCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.lblPersonalInformation = New System.Windows.Forms.Label()
        Me.txtContactNumPrefix = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.dtbDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbxCustomerInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCustomerInformation
        '
        Me.gbxCustomerInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.gbxCustomerInformation.Controls.Add(Me.lblPersonalInformation)
        Me.gbxCustomerInformation.Controls.Add(Me.txtContactNumPrefix)
        Me.gbxCustomerInformation.Controls.Add(Me.txtCustomerName)
        Me.gbxCustomerInformation.Controls.Add(Me.txtContactNumber)
        Me.gbxCustomerInformation.Controls.Add(Me.dtbDateTimePicker)
        Me.gbxCustomerInformation.Controls.Add(Me.Label2)
        Me.gbxCustomerInformation.Controls.Add(Me.Label1)
        Me.gbxCustomerInformation.Controls.Add(Me.lblCustomerName)
        Me.gbxCustomerInformation.Controls.Add(Me.btnNext)
        Me.gbxCustomerInformation.Controls.Add(Me.btnBack)
        Me.gbxCustomerInformation.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCustomerInformation.Location = New System.Drawing.Point(54, 32)
        Me.gbxCustomerInformation.Name = "gbxCustomerInformation"
        Me.gbxCustomerInformation.Size = New System.Drawing.Size(626, 310)
        Me.gbxCustomerInformation.TabIndex = 10
        Me.gbxCustomerInformation.TabStop = False
        '
        'lblPersonalInformation
        '
        Me.lblPersonalInformation.AutoSize = True
        Me.lblPersonalInformation.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblPersonalInformation.Location = New System.Drawing.Point(180, 30)
        Me.lblPersonalInformation.Name = "lblPersonalInformation"
        Me.lblPersonalInformation.Size = New System.Drawing.Size(263, 37)
        Me.lblPersonalInformation.TabIndex = 20
        Me.lblPersonalInformation.Text = "Personal Information"
        '
        'txtContactNumPrefix
        '
        Me.txtContactNumPrefix.Location = New System.Drawing.Point(283, 170)
        Me.txtContactNumPrefix.MaxLength = 4
        Me.txtContactNumPrefix.Multiline = True
        Me.txtContactNumPrefix.Name = "txtContactNumPrefix"
        Me.txtContactNumPrefix.Size = New System.Drawing.Size(46, 20)
        Me.txtContactNumPrefix.TabIndex = 19
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(283, 91)
        Me.txtCustomerName.MaxLength = 20
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(200, 24)
        Me.txtCustomerName.TabIndex = 18
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(335, 170)
        Me.txtContactNumber.MaxLength = 10
        Me.txtContactNumber.Multiline = True
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(148, 20)
        Me.txtContactNumber.TabIndex = 17
        '
        'dtbDateTimePicker
        '
        Me.dtbDateTimePicker.Location = New System.Drawing.Point(283, 126)
        Me.dtbDateTimePicker.Name = "dtbDateTimePicker"
        Me.dtbDateTimePicker.Size = New System.Drawing.Size(200, 24)
        Me.dtbDateTimePicker.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(142, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Contact Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(142, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Date of Birth"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblCustomerName.Location = New System.Drawing.Point(142, 91)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(135, 21)
        Me.lblCustomerName.TabIndex = 12
        Me.lblCustomerName.Text = "Customer Name"
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
        Me.btnNext.TabIndex = 11
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
        Me.btnBack.Location = New System.Drawing.Point(124, 250)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(93, 37)
        Me.btnBack.TabIndex = 10
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
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmCustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(729, 428)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbxCustomerInformation)
        Me.Name = "frmCustomerDetails"
        Me.gbxCustomerInformation.ResumeLayout(False)
        Me.gbxCustomerInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxCustomerInformation As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dtbDateTimePicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtContactNumPrefix As TextBox
    Friend WithEvents lblPersonalInformation As Label
End Class
