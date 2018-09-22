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
        Me.MayorButton = New System.Windows.Forms.RadioButton()
        Me.MenorButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.ApostarLabel = New System.Windows.Forms.Label()
        Me.ApostarText = New System.Windows.Forms.TextBox()
        Me.ApostarButton = New System.Windows.Forms.Button()
        Me.GroupBox.SuspendLayout()
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
        'MayorButton
        '
        Me.MayorButton.AutoSize = True
        Me.MayorButton.Location = New System.Drawing.Point(98, 44)
        Me.MayorButton.Name = "MayorButton"
        Me.MayorButton.Size = New System.Drawing.Size(69, 21)
        Me.MayorButton.TabIndex = 1
        Me.MayorButton.TabStop = True
        Me.MayorButton.Text = "Mayor"
        Me.MayorButton.UseVisualStyleBackColor = True
        '
        'MenorButton
        '
        Me.MenorButton.AutoSize = True
        Me.MenorButton.Location = New System.Drawing.Point(224, 44)
        Me.MenorButton.Name = "MenorButton"
        Me.MenorButton.Size = New System.Drawing.Size(70, 21)
        Me.MenorButton.TabIndex = 2
        Me.MenorButton.TabStop = True
        Me.MenorButton.Text = "Menor"
        Me.MenorButton.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.MayorButton)
        Me.GroupBox.Controls.Add(Me.MenorButton)
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
        'ApostarText
        '
        Me.ApostarText.Font = New System.Drawing.Font("Liberation Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApostarText.Location = New System.Drawing.Point(229, 210)
        Me.ApostarText.Name = "ApostarText"
        Me.ApostarText.Size = New System.Drawing.Size(100, 23)
        Me.ApostarText.TabIndex = 5
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
        'MayorOMenor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.ApostarButton)
        Me.Controls.Add(Me.ApostarText)
        Me.Controls.Add(Me.ApostarLabel)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.BitsLabel)
        Me.MaximizeBox = False
        Me.Name = "MayorOMenor"
        Me.Text = "Mayor o Menor"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BitsLabel As Label
    Friend WithEvents MayorButton As RadioButton
    Friend WithEvents MenorButton As RadioButton
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents ApostarLabel As Label
    Friend WithEvents ApostarText As TextBox
    Friend WithEvents ApostarButton As Button
End Class
