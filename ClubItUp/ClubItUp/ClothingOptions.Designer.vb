<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClothingOptions
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblEirCode = New System.Windows.Forms.Label()
        Me.txtTownCity = New System.Windows.Forms.TextBox()
        Me.lblAddressInformation = New System.Windows.Forms.Label()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTownCity = New System.Windows.Forms.Label()
        Me.lblStreetAddress = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbxCustomerInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCustomerInformation
        '
        Me.gbxCustomerInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.gbxCustomerInformation.Controls.Add(Me.TextBox1)
        Me.gbxCustomerInformation.Controls.Add(Me.lblEirCode)
        Me.gbxCustomerInformation.Controls.Add(Me.txtTownCity)
        Me.gbxCustomerInformation.Controls.Add(Me.lblAddressInformation)
        Me.gbxCustomerInformation.Controls.Add(Me.txtStreetAddress)
        Me.gbxCustomerInformation.Controls.Add(Me.txtCounty)
        Me.gbxCustomerInformation.Controls.Add(Me.Label2)
        Me.gbxCustomerInformation.Controls.Add(Me.lblTownCity)
        Me.gbxCustomerInformation.Controls.Add(Me.lblStreetAddress)
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(283, 210)
        Me.TextBox1.MaxLength = 7
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 20)
        Me.TextBox1.TabIndex = 23
        '
        'lblEirCode
        '
        Me.lblEirCode.AutoSize = True
        Me.lblEirCode.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEirCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblEirCode.Location = New System.Drawing.Point(142, 209)
        Me.lblEirCode.Name = "lblEirCode"
        Me.lblEirCode.Size = New System.Drawing.Size(74, 21)
        Me.lblEirCode.TabIndex = 22
        Me.lblEirCode.Text = "Eir Code"
        '
        'txtTownCity
        '
        Me.txtTownCity.Location = New System.Drawing.Point(283, 128)
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
        Me.lblAddressInformation.Size = New System.Drawing.Size(257, 37)
        Me.lblAddressInformation.TabIndex = 20
        Me.lblAddressInformation.Text = "Address Information"
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(283, 91)
        Me.txtStreetAddress.MaxLength = 20
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(200, 24)
        Me.txtStreetAddress.TabIndex = 18
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(283, 170)
        Me.txtCounty.MaxLength = 10
        Me.txtCounty.Multiline = True
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(197, 20)
        Me.txtCounty.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(142, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "County"
        '
        'lblTownCity
        '
        Me.lblTownCity.AutoSize = True
        Me.lblTownCity.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblTownCity.Location = New System.Drawing.Point(142, 128)
        Me.lblTownCity.Name = "lblTownCity"
        Me.lblTownCity.Size = New System.Drawing.Size(88, 21)
        Me.lblTownCity.TabIndex = 13
        Me.lblTownCity.Text = "Town/City"
        '
        'lblStreetAddress
        '
        Me.lblStreetAddress.AutoSize = True
        Me.lblStreetAddress.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreetAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblStreetAddress.Location = New System.Drawing.Point(142, 91)
        Me.lblStreetAddress.Name = "lblStreetAddress"
        Me.lblStreetAddress.Size = New System.Drawing.Size(120, 21)
        Me.lblStreetAddress.TabIndex = 12
        Me.lblStreetAddress.Text = "Street Address"
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
        'frmClothingOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(729, 428)
        Me.Controls.Add(Me.gbxCustomerInformation)
        Me.Name = "frmClothingOptions"
        Me.Text = "Clothing Options"
        Me.gbxCustomerInformation.ResumeLayout(False)
        Me.gbxCustomerInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxCustomerInformation As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblEirCode As Label
    Friend WithEvents txtTownCity As TextBox
    Friend WithEvents lblAddressInformation As Label
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTownCity As Label
    Friend WithEvents lblStreetAddress As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
End Class
