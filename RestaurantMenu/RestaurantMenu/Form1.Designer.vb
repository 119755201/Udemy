<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestaurantMenu
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
        Me.chkBurgers = New System.Windows.Forms.CheckBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkDrinks = New System.Windows.Forms.CheckBox()
        Me.gbxBurgers = New System.Windows.Forms.GroupBox()
        Me.gbxFries = New System.Windows.Forms.GroupBox()
        Me.gbxDrinks = New System.Windows.Forms.GroupBox()
        Me.rdoRegular = New System.Windows.Forms.RadioButton()
        Me.rdoWithCheese = New System.Windows.Forms.RadioButton()
        Me.rdoWithBacon = New System.Windows.Forms.RadioButton()
        Me.rdoSmall = New System.Windows.Forms.RadioButton()
        Me.rdoMedium = New System.Windows.Forms.RadioButton()
        Me.rdoLarge = New System.Windows.Forms.RadioButton()
        Me.rdoWater = New System.Windows.Forms.RadioButton()
        Me.rdoSoda = New System.Windows.Forms.RadioButton()
        Me.rdoBaconCheese = New System.Windows.Forms.RadioButton()
        Me.btnCalculateMealCost = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblCostOfMeal = New System.Windows.Forms.Label()
        Me.gbxBurgers.SuspendLayout()
        Me.gbxFries.SuspendLayout()
        Me.gbxDrinks.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkBurgers
        '
        Me.chkBurgers.AutoSize = True
        Me.chkBurgers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBurgers.Location = New System.Drawing.Point(55, 32)
        Me.chkBurgers.Name = "chkBurgers"
        Me.chkBurgers.Size = New System.Drawing.Size(69, 19)
        Me.chkBurgers.TabIndex = 1
        Me.chkBurgers.Text = "Burgers"
        Me.chkBurgers.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFries.Location = New System.Drawing.Point(55, 187)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(53, 19)
        Me.chkFries.TabIndex = 2
        Me.chkFries.Text = "Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkDrinks
        '
        Me.chkDrinks.AutoSize = True
        Me.chkDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDrinks.Location = New System.Drawing.Point(55, 323)
        Me.chkDrinks.Name = "chkDrinks"
        Me.chkDrinks.Size = New System.Drawing.Size(61, 19)
        Me.chkDrinks.TabIndex = 3
        Me.chkDrinks.Text = "Drinks"
        Me.chkDrinks.UseVisualStyleBackColor = True
        '
        'gbxBurgers
        '
        Me.gbxBurgers.Controls.Add(Me.rdoBaconCheese)
        Me.gbxBurgers.Controls.Add(Me.rdoWithBacon)
        Me.gbxBurgers.Controls.Add(Me.rdoWithCheese)
        Me.gbxBurgers.Controls.Add(Me.rdoRegular)
        Me.gbxBurgers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBurgers.Location = New System.Drawing.Point(161, 32)
        Me.gbxBurgers.Name = "gbxBurgers"
        Me.gbxBurgers.Size = New System.Drawing.Size(305, 136)
        Me.gbxBurgers.TabIndex = 4
        Me.gbxBurgers.TabStop = False
        Me.gbxBurgers.Text = "Burgers"
        Me.gbxBurgers.Visible = False
        '
        'gbxFries
        '
        Me.gbxFries.Controls.Add(Me.rdoSmall)
        Me.gbxFries.Controls.Add(Me.rdoMedium)
        Me.gbxFries.Controls.Add(Me.rdoLarge)
        Me.gbxFries.Location = New System.Drawing.Point(161, 187)
        Me.gbxFries.Name = "gbxFries"
        Me.gbxFries.Size = New System.Drawing.Size(305, 111)
        Me.gbxFries.TabIndex = 5
        Me.gbxFries.TabStop = False
        Me.gbxFries.Text = "Fries"
        Me.gbxFries.Visible = False
        '
        'gbxDrinks
        '
        Me.gbxDrinks.Controls.Add(Me.rdoWater)
        Me.gbxDrinks.Controls.Add(Me.rdoSoda)
        Me.gbxDrinks.Location = New System.Drawing.Point(161, 323)
        Me.gbxDrinks.Name = "gbxDrinks"
        Me.gbxDrinks.Size = New System.Drawing.Size(305, 96)
        Me.gbxDrinks.TabIndex = 5
        Me.gbxDrinks.TabStop = False
        Me.gbxDrinks.Text = "Drinks"
        Me.gbxDrinks.Visible = False
        '
        'rdoRegular
        '
        Me.rdoRegular.AutoSize = True
        Me.rdoRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoRegular.Location = New System.Drawing.Point(6, 29)
        Me.rdoRegular.Name = "rdoRegular"
        Me.rdoRegular.Size = New System.Drawing.Size(106, 19)
        Me.rdoRegular.TabIndex = 0
        Me.rdoRegular.TabStop = True
        Me.rdoRegular.Text = "Regular: €4.19"
        Me.rdoRegular.UseVisualStyleBackColor = True
        '
        'rdoWithCheese
        '
        Me.rdoWithCheese.AutoSize = True
        Me.rdoWithCheese.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoWithCheese.Location = New System.Drawing.Point(6, 52)
        Me.rdoWithCheese.Name = "rdoWithCheese"
        Me.rdoWithCheese.Size = New System.Drawing.Size(131, 19)
        Me.rdoWithCheese.TabIndex = 1
        Me.rdoWithCheese.TabStop = True
        Me.rdoWithCheese.Text = "With Cheese: €4.79"
        Me.rdoWithCheese.UseVisualStyleBackColor = True
        '
        'rdoWithBacon
        '
        Me.rdoWithBacon.AutoSize = True
        Me.rdoWithBacon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoWithBacon.Location = New System.Drawing.Point(7, 75)
        Me.rdoWithBacon.Name = "rdoWithBacon"
        Me.rdoWithBacon.Size = New System.Drawing.Size(124, 19)
        Me.rdoWithBacon.TabIndex = 2
        Me.rdoWithBacon.TabStop = True
        Me.rdoWithBacon.Text = "With Bacon: €4.79"
        Me.rdoWithBacon.UseVisualStyleBackColor = True
        '
        'rdoSmall
        '
        Me.rdoSmall.AutoSize = True
        Me.rdoSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSmall.Location = New System.Drawing.Point(6, 25)
        Me.rdoSmall.Name = "rdoSmall"
        Me.rdoSmall.Size = New System.Drawing.Size(94, 19)
        Me.rdoSmall.TabIndex = 5
        Me.rdoSmall.TabStop = True
        Me.rdoSmall.Text = "Small: €2.39"
        Me.rdoSmall.UseVisualStyleBackColor = True
        '
        'rdoMedium
        '
        Me.rdoMedium.AutoSize = True
        Me.rdoMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMedium.Location = New System.Drawing.Point(6, 48)
        Me.rdoMedium.Name = "rdoMedium"
        Me.rdoMedium.Size = New System.Drawing.Size(108, 19)
        Me.rdoMedium.TabIndex = 4
        Me.rdoMedium.TabStop = True
        Me.rdoMedium.Text = "Medium: €3.09"
        Me.rdoMedium.UseVisualStyleBackColor = True
        '
        'rdoLarge
        '
        Me.rdoLarge.AutoSize = True
        Me.rdoLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLarge.Location = New System.Drawing.Point(7, 71)
        Me.rdoLarge.Name = "rdoLarge"
        Me.rdoLarge.Size = New System.Drawing.Size(94, 19)
        Me.rdoLarge.TabIndex = 3
        Me.rdoLarge.TabStop = True
        Me.rdoLarge.Text = "Large: €4.99"
        Me.rdoLarge.UseVisualStyleBackColor = True
        '
        'rdoWater
        '
        Me.rdoWater.AutoSize = True
        Me.rdoWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoWater.Location = New System.Drawing.Point(6, 52)
        Me.rdoWater.Name = "rdoWater"
        Me.rdoWater.Size = New System.Drawing.Size(135, 19)
        Me.rdoWater.TabIndex = 4
        Me.rdoWater.TabStop = True
        Me.rdoWater.Text = "Bottled Water: €1.49"
        Me.rdoWater.UseVisualStyleBackColor = True
        '
        'rdoSoda
        '
        Me.rdoSoda.AutoSize = True
        Me.rdoSoda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSoda.Location = New System.Drawing.Point(6, 19)
        Me.rdoSoda.Name = "rdoSoda"
        Me.rdoSoda.Size = New System.Drawing.Size(91, 19)
        Me.rdoSoda.TabIndex = 3
        Me.rdoSoda.TabStop = True
        Me.rdoSoda.Text = "Soda: €1.69"
        Me.rdoSoda.UseVisualStyleBackColor = True
        '
        'rdoBaconCheese
        '
        Me.rdoBaconCheese.AutoSize = True
        Me.rdoBaconCheese.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoBaconCheese.Location = New System.Drawing.Point(6, 98)
        Me.rdoBaconCheese.Name = "rdoBaconCheese"
        Me.rdoBaconCheese.Size = New System.Drawing.Size(193, 19)
        Me.rdoBaconCheese.TabIndex = 3
        Me.rdoBaconCheese.TabStop = True
        Me.rdoBaconCheese.Text = "With Bacon and Cheese: €5.39"
        Me.rdoBaconCheese.UseVisualStyleBackColor = True
        '
        'btnCalculateMealCost
        '
        Me.btnCalculateMealCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateMealCost.Location = New System.Drawing.Point(55, 440)
        Me.btnCalculateMealCost.Name = "btnCalculateMealCost"
        Me.btnCalculateMealCost.Size = New System.Drawing.Size(139, 55)
        Me.btnCalculateMealCost.TabIndex = 6
        Me.btnCalculateMealCost.Text = "Calculate Meal Cost"
        Me.btnCalculateMealCost.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(350, 440)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 20)
        Me.TextBox1.TabIndex = 7
        '
        'lblCostOfMeal
        '
        Me.lblCostOfMeal.AutoSize = True
        Me.lblCostOfMeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfMeal.Location = New System.Drawing.Point(224, 444)
        Me.lblCostOfMeal.Name = "lblCostOfMeal"
        Me.lblCostOfMeal.Size = New System.Drawing.Size(98, 16)
        Me.lblCostOfMeal.TabIndex = 8
        Me.lblCostOfMeal.Text = "Cost of Meal is:"
        '
        'frmRestaurantMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 519)
        Me.Controls.Add(Me.lblCostOfMeal)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCalculateMealCost)
        Me.Controls.Add(Me.gbxDrinks)
        Me.Controls.Add(Me.gbxFries)
        Me.Controls.Add(Me.gbxBurgers)
        Me.Controls.Add(Me.chkDrinks)
        Me.Controls.Add(Me.chkFries)
        Me.Controls.Add(Me.chkBurgers)
        Me.Name = "frmRestaurantMenu"
        Me.Text = "Restaurant Menu"
        Me.gbxBurgers.ResumeLayout(False)
        Me.gbxBurgers.PerformLayout()
        Me.gbxFries.ResumeLayout(False)
        Me.gbxFries.PerformLayout()
        Me.gbxDrinks.ResumeLayout(False)
        Me.gbxDrinks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkBurgers As CheckBox
    Friend WithEvents chkFries As CheckBox
    Friend WithEvents chkDrinks As CheckBox
    Friend WithEvents gbxBurgers As GroupBox
    Friend WithEvents rdoWithBacon As RadioButton
    Friend WithEvents rdoWithCheese As RadioButton
    Friend WithEvents rdoRegular As RadioButton
    Friend WithEvents gbxFries As GroupBox
    Friend WithEvents rdoSmall As RadioButton
    Friend WithEvents rdoMedium As RadioButton
    Friend WithEvents rdoLarge As RadioButton
    Friend WithEvents gbxDrinks As GroupBox
    Friend WithEvents rdoWater As RadioButton
    Friend WithEvents rdoSoda As RadioButton
    Friend WithEvents rdoBaconCheese As RadioButton
    Friend WithEvents btnCalculateMealCost As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCostOfMeal As Label
End Class
