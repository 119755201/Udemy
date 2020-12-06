<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetails3
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
        Me.gbxCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.txtTownCity = New System.Windows.Forms.TextBox()
        Me.lblAddressInformation = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbx = New System.Windows.Forms.ListBox()
        Me.gbxCustomerInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCustomerInformation
        '
        Me.gbxCustomerInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.gbxCustomerInformation.Controls.Add(Me.lbx)
        Me.gbxCustomerInformation.Controls.Add(Me.txtTownCity)
        Me.gbxCustomerInformation.Controls.Add(Me.lblAddressInformation)
        Me.gbxCustomerInformation.Controls.Add(Me.lblCardNumber)
        Me.gbxCustomerInformation.Controls.Add(Me.lblPaymentType)
        Me.gbxCustomerInformation.Controls.Add(Me.btnNext)
        Me.gbxCustomerInformation.Controls.Add(Me.btnBack)
        Me.gbxCustomerInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbxCustomerInformation.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCustomerInformation.Location = New System.Drawing.Point(54, 32)
        Me.gbxCustomerInformation.Name = "gbxCustomerInformation"
        Me.gbxCustomerInformation.Size = New System.Drawing.Size(626, 310)
        Me.gbxCustomerInformation.TabIndex = 12
        Me.gbxCustomerInformation.TabStop = False
        '
        'txtTownCity
        '
        Me.txtTownCity.Location = New System.Drawing.Point(285, 156)
        Me.txtTownCity.MaxLength = 20
        Me.txtTownCity.Name = "txtTownCity"
        Me.txtTownCity.Size = New System.Drawing.Size(200, 24)
        Me.txtTownCity.TabIndex = 21
        '
        'lblAddressInformation
        '
        Me.lblAddressInformation.AutoSize = True
        Me.lblAddressInformation.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblAddressInformation.Location = New System.Drawing.Point(180, 30)
        Me.lblAddressInformation.Name = "lblAddressInformation"
        Me.lblAddressInformation.Size = New System.Drawing.Size(265, 37)
        Me.lblAddressInformation.TabIndex = 20
        Me.lblAddressInformation.Text = "Payment Information"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblCardNumber.Location = New System.Drawing.Point(144, 156)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(114, 21)
        Me.lblCardNumber.TabIndex = 13
        Me.lblCardNumber.Text = "Card Number"
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblPaymentType.Location = New System.Drawing.Point(144, 119)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(118, 21)
        Me.lblPaymentType.TabIndex = 12
        Me.lblPaymentType.Text = "Payment Type"
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
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lbx
        '
        Me.lbx.FormattingEnabled = True
        Me.lbx.ItemHeight = 19
        Me.lbx.Items.AddRange(New Object() {"Visa", "Mastercard", "Laser", "AmEx"})
        Me.lbx.Location = New System.Drawing.Point(285, 119)
        Me.lbx.Name = "lbx"
        Me.lbx.Size = New System.Drawing.Size(197, 23)
        Me.lbx.TabIndex = 22
        '
        'CustomerDetails3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(729, 428)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbxCustomerInformation)
        Me.Name = "CustomerDetails3"
        Me.Text = "Customer Details (3/3)"
        Me.gbxCustomerInformation.ResumeLayout(False)
        Me.gbxCustomerInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxCustomerInformation As GroupBox
    Friend WithEvents txtTownCity As TextBox
    Friend WithEvents lblAddressInformation As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbx As ListBox
End Class
