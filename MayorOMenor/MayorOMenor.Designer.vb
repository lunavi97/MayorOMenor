<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MayorOMenor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BitsLabel = New System.Windows.Forms.Label()
        Me.MayorSel = New System.Windows.Forms.RadioButton()
        Me.MenorSel = New System.Windows.Forms.RadioButton()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.ApostarLabel = New System.Windows.Forms.Label()
        Me.ApostarButton = New System.Windows.Forms.Button()
        Me.CantidadApostar = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox.SuspendLayout()
        CType(Me.CantidadApostar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BitsLabel
        '
        Me.BitsLabel.AutoSize = True
        Me.BitsLabel.Font = New System.Drawing.Font("Liberation Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BitsLabel.Location = New System.Drawing.Point(466, 19)
        Me.BitsLabel.Name = "BitsLabel"
        Me.BitsLabel.Size = New System.Drawing.Size(106, 23)
        Me.BitsLabel.TabIndex = 0
        Me.BitsLabel.Text = "Bits: 1000"
        '
        'MayorSel
        '
        Me.MayorSel.AutoSize = True
        Me.MayorSel.Location = New System.Drawing.Point(98, 44)
        Me.MayorSel.Name = "MayorSel"
        Me.MayorSel.Size = New System.Drawing.Size(69, 21)
        Me.MayorSel.TabIndex = 1
        Me.MayorSel.TabStop = True
        Me.MayorSel.Text = "Mayor"
        Me.MayorSel.UseVisualStyleBackColor = True
        '
        'MenorSel
        '
        Me.MenorSel.AutoSize = True
        Me.MenorSel.Location = New System.Drawing.Point(224, 44)
        Me.MenorSel.Name = "MenorSel"
        Me.MenorSel.Size = New System.Drawing.Size(70, 21)
        Me.MenorSel.TabIndex = 2
        Me.MenorSel.TabStop = True
        Me.MenorSel.Text = "Menor"
        Me.MenorSel.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.MayorSel)
        Me.GroupBox.Controls.Add(Me.MenorSel)
        Me.GroupBox.Font = New System.Drawing.Font("Liberation Sans", 12.0!)
        Me.GroupBox.Location = New System.Drawing.Point(100, 71)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(385, 95)
        Me.GroupBox.TabIndex = 3
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "¿El número siguiente es mayor o menor a 50?"
        '
        'ApostarLabel
        '
        Me.ApostarLabel.AutoSize = True
        Me.ApostarLabel.Font = New System.Drawing.Font("Liberation Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApostarLabel.Location = New System.Drawing.Point(120, 213)
        Me.ApostarLabel.Name = "ApostarLabel"
        Me.ApostarLabel.Size = New System.Drawing.Size(103, 16)
        Me.ApostarLabel.TabIndex = 4
        Me.ApostarLabel.Text = "Bits a apostar: "
        '
        'ApostarButton
        '
        Me.ApostarButton.Location = New System.Drawing.Point(384, 210)
        Me.ApostarButton.Name = "ApostarButton"
        Me.ApostarButton.Size = New System.Drawing.Size(75, 23)
        Me.ApostarButton.TabIndex = 6
        Me.ApostarButton.Text = "Apostar"
        Me.ApostarButton.UseVisualStyleBackColor = True
        '
        'CantidadApostar
        '
        Me.CantidadApostar.Location = New System.Drawing.Point(229, 212)
        Me.CantidadApostar.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.CantidadApostar.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CantidadApostar.Name = "CantidadApostar"
        Me.CantidadApostar.Size = New System.Drawing.Size(120, 20)
        Me.CantidadApostar.TabIndex = 7
        Me.CantidadApostar.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'MayorOMenor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.CantidadApostar)
        Me.Controls.Add(Me.ApostarButton)
        Me.Controls.Add(Me.ApostarLabel)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.BitsLabel)
        Me.MaximizeBox = False
        Me.Name = "MayorOMenor"
        Me.Text = "Mayor o Menor"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.CantidadApostar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BitsLabel As Label
    Friend WithEvents MayorSel As RadioButton
    Friend WithEvents MenorSel As RadioButton
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents ApostarLabel As Label
    Friend WithEvents ApostarButton As Button
    Friend WithEvents CantidadApostar As NumericUpDown
End Class
