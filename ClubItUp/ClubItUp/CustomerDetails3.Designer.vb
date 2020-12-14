<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerDetails3
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
        Me.gbxPaymentInformation = New System.Windows.Forms.GroupBox()
        Me.txtCardHolderName = New System.Windows.Forms.TextBox()
        Me.lblCardHolderName = New System.Windows.Forms.Label()
        Me.lbxPaymentType = New System.Windows.Forms.ListBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.lblPaymentInformation = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbxPaymentInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxPaymentInformation
        '
        Me.gbxPaymentInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.gbxPaymentInformation.Controls.Add(Me.txtCardHolderName)
        Me.gbxPaymentInformation.Controls.Add(Me.lblCardHolderName)
        Me.gbxPaymentInformation.Controls.Add(Me.lbxPaymentType)
        Me.gbxPaymentInformation.Controls.Add(Me.txtCardNumber)
        Me.gbxPaymentInformation.Controls.Add(Me.lblPaymentInformation)
        Me.gbxPaymentInformation.Controls.Add(Me.lblCardNumber)
        Me.gbxPaymentInformation.Controls.Add(Me.lblPaymentType)
        Me.gbxPaymentInformation.Controls.Add(Me.btnNext)
        Me.gbxPaymentInformation.Controls.Add(Me.btnBack)
        Me.gbxPaymentInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbxPaymentInformation.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPaymentInformation.Location = New System.Drawing.Point(54, 32)
        Me.gbxPaymentInformation.Name = "gbxPaymentInformation"
        Me.gbxPaymentInformation.Size = New System.Drawing.Size(626, 310)
        Me.gbxPaymentInformation.TabIndex = 12
        Me.gbxPaymentInformation.TabStop = False
        '
        'txtCardHolderName
        '
        Me.txtCardHolderName.Location = New System.Drawing.Point(285, 85)
        Me.txtCardHolderName.MaxLength = 30
        Me.txtCardHolderName.Name = "txtCardHolderName"
        Me.txtCardHolderName.Size = New System.Drawing.Size(197, 24)
        Me.txtCardHolderName.TabIndex = 24
        '
        'lblCardHolderName
        '
        Me.lblCardHolderName.AutoSize = True
        Me.lblCardHolderName.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardHolderName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblCardHolderName.Location = New System.Drawing.Point(109, 85)
        Me.lblCardHolderName.Name = "lblCardHolderName"
        Me.lblCardHolderName.Size = New System.Drawing.Size(153, 21)
        Me.lblCardHolderName.TabIndex = 23
        Me.lblCardHolderName.Text = "Card Holder Name"
        '
        'lbxPaymentType
        '
        Me.lbxPaymentType.FormattingEnabled = True
        Me.lbxPaymentType.ItemHeight = 19
        Me.lbxPaymentType.Items.AddRange(New Object() {"Visa", "Mastercard", "Laser", "AmEx"})
        Me.lbxPaymentType.Location = New System.Drawing.Point(285, 128)
        Me.lbxPaymentType.Name = "lbxPaymentType"
        Me.lbxPaymentType.Size = New System.Drawing.Size(197, 23)
        Me.lbxPaymentType.TabIndex = 22
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(285, 177)
        Me.txtCardNumber.MaxLength = 20
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(197, 24)
        Me.txtCardNumber.TabIndex = 21
        '
        'lblPaymentInformation
        '
        Me.lblPaymentInformation.AutoSize = True
        Me.lblPaymentInformation.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblPaymentInformation.Location = New System.Drawing.Point(180, 30)
        Me.lblPaymentInformation.Name = "lblPaymentInformation"
        Me.lblPaymentInformation.Size = New System.Drawing.Size(265, 37)
        Me.lblPaymentInformation.TabIndex = 20
        Me.lblPaymentInformation.Text = "Payment Information"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lblCardNumber.Location = New System.Drawing.Point(148, 177)
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
        Me.lblPaymentType.Location = New System.Drawing.Point(144, 128)
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
        'frmCustomerDetails3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(729, 428)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbxPaymentInformation)
        Me.Name = "frmCustomerDetails3"
        Me.Text = "Customer Details (3/3)"
        Me.gbxPaymentInformation.ResumeLayout(False)
        Me.gbxPaymentInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxPaymentInformation As GroupBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents lblPaymentInformation As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbxPaymentType As ListBox
    Friend WithEvents txtCardHolderName As TextBox
    Friend WithEvents lblCardHolderName As Label
End Class
