<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerInformation
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
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.txtTownCity = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblStreetAddress = New System.Windows.Forms.Label()
        Me.lblTownCity = New System.Windows.Forms.Label()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblPrefixContactNum = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblEirCode = New System.Windows.Forms.Label()
        Me.txtEirCode = New System.Windows.Forms.TextBox()
        Me.txtPrefixPhoneNum = New System.Windows.Forms.TextBox()
        Me.gbxOutput = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(171, 39)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(159, 20)
        Me.txtCustomerName.TabIndex = 0
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(479, 39)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(169, 20)
        Me.txtStreetAddress.TabIndex = 1
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(171, 65)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(159, 20)
        Me.txtAge.TabIndex = 2
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(171, 117)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(159, 20)
        Me.txtCardNumber.TabIndex = 3
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(479, 91)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(169, 20)
        Me.txtCounty.TabIndex = 4
        '
        'txtTownCity
        '
        Me.txtTownCity.Location = New System.Drawing.Point(479, 65)
        Me.txtTownCity.Name = "txtTownCity"
        Me.txtTownCity.Size = New System.Drawing.Size(169, 20)
        Me.txtTownCity.TabIndex = 5
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(56, 42)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(95, 13)
        Me.lblCustomerName.TabIndex = 6
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblStreetAddress
        '
        Me.lblStreetAddress.AutoSize = True
        Me.lblStreetAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreetAddress.Location = New System.Drawing.Point(381, 42)
        Me.lblStreetAddress.Name = "lblStreetAddress"
        Me.lblStreetAddress.Size = New System.Drawing.Size(90, 13)
        Me.lblStreetAddress.TabIndex = 7
        Me.lblStreetAddress.Text = "Street Address"
        '
        'lblTownCity
        '
        Me.lblTownCity.AutoSize = True
        Me.lblTownCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownCity.Location = New System.Drawing.Point(406, 68)
        Me.lblTownCity.Name = "lblTownCity"
        Me.lblTownCity.Size = New System.Drawing.Size(65, 13)
        Me.lblTownCity.TabIndex = 8
        Me.lblTownCity.Text = "Town/City"
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounty.Location = New System.Drawing.Point(425, 94)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(46, 13)
        Me.lblCounty.TabIndex = 9
        Me.lblCounty.Text = "County"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.Location = New System.Drawing.Point(71, 117)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(80, 13)
        Me.lblCardNumber.TabIndex = 9
        Me.lblCardNumber.Text = "Card Number"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(122, 65)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 10
        Me.lblAge.Text = "Age"
        '
        'lblPrefixContactNum
        '
        Me.lblPrefixContactNum.AutoSize = True
        Me.lblPrefixContactNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrefixContactNum.Location = New System.Drawing.Point(15, 94)
        Me.lblPrefixContactNum.Name = "lblPrefixContactNum"
        Me.lblPrefixContactNum.Size = New System.Drawing.Size(136, 13)
        Me.lblPrefixContactNum.TabIndex = 12
        Me.lblPrefixContactNum.Text = "Prefix/Contact Number"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(228, 91)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(102, 20)
        Me.txtContactNumber.TabIndex = 11
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(171, 283)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 56)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(519, 283)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(129, 56)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblEirCode
        '
        Me.lblEirCode.AutoSize = True
        Me.lblEirCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEirCode.Location = New System.Drawing.Point(416, 117)
        Me.lblEirCode.Name = "lblEirCode"
        Me.lblEirCode.Size = New System.Drawing.Size(55, 13)
        Me.lblEirCode.TabIndex = 18
        Me.lblEirCode.Text = "Eir-Code"
        '
        'txtEirCode
        '
        Me.txtEirCode.Location = New System.Drawing.Point(479, 117)
        Me.txtEirCode.Name = "txtEirCode"
        Me.txtEirCode.Size = New System.Drawing.Size(169, 20)
        Me.txtEirCode.TabIndex = 17
        '
        'txtPrefixPhoneNum
        '
        Me.txtPrefixPhoneNum.Location = New System.Drawing.Point(171, 91)
        Me.txtPrefixPhoneNum.Name = "txtPrefixPhoneNum"
        Me.txtPrefixPhoneNum.Size = New System.Drawing.Size(48, 20)
        Me.txtPrefixPhoneNum.TabIndex = 19
        '
        'gbxOutput
        '
        Me.gbxOutput.Location = New System.Drawing.Point(171, 150)
        Me.gbxOutput.Name = "gbxOutput"
        Me.gbxOutput.Size = New System.Drawing.Size(477, 100)
        Me.gbxOutput.TabIndex = 20
        Me.gbxOutput.TabStop = False
        Me.gbxOutput.Text = "Output"
        '
        'frmCustomerInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 397)
        Me.Controls.Add(Me.gbxOutput)
        Me.Controls.Add(Me.txtPrefixPhoneNum)
        Me.Controls.Add(Me.lblEirCode)
        Me.Controls.Add(Me.txtEirCode)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblPrefixContactNum)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblCardNumber)
        Me.Controls.Add(Me.lblCounty)
        Me.Controls.Add(Me.lblTownCity)
        Me.Controls.Add(Me.lblStreetAddress)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.txtTownCity)
        Me.Controls.Add(Me.txtCounty)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtStreetAddress)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Name = "frmCustomerInformation"
        Me.Text = "Customer Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents txtTownCity As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblStreetAddress As Label
    Friend WithEvents lblTownCity As Label
    Friend WithEvents lblCounty As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblPrefixContactNum As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblEirCode As Label
    Friend WithEvents txtEirCode As TextBox
    Friend WithEvents txtPrefixPhoneNum As TextBox
    Friend WithEvents gbxOutput As GroupBox
End Class
