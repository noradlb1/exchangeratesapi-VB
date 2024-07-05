<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.cmbFromCurrency = New System.Windows.Forms.ComboBox()
        Me.cmbToCurrency = New System.Windows.Forms.ComboBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(12, 136)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(168, 23)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "btnConvert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(28, 56)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(125, 20)
        Me.txtAmount.TabIndex = 1
        Me.txtAmount.Text = "txtAmount"
        '
        'cmbFromCurrency
        '
        Me.cmbFromCurrency.FormattingEnabled = True
        Me.cmbFromCurrency.Location = New System.Drawing.Point(28, 82)
        Me.cmbFromCurrency.Name = "cmbFromCurrency"
        Me.cmbFromCurrency.Size = New System.Drawing.Size(125, 21)
        Me.cmbFromCurrency.TabIndex = 2
        '
        'cmbToCurrency
        '
        Me.cmbToCurrency.FormattingEnabled = True
        Me.cmbToCurrency.Location = New System.Drawing.Point(28, 109)
        Me.cmbToCurrency.Name = "cmbToCurrency"
        Me.cmbToCurrency.Size = New System.Drawing.Size(125, 21)
        Me.cmbToCurrency.TabIndex = 3
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(29, 38)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(47, 13)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "lblResult"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(196, 172)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.cmbToCurrency)
        Me.Controls.Add(Me.cmbFromCurrency)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents cmbFromCurrency As ComboBox
    Friend WithEvents cmbToCurrency As ComboBox
    Friend WithEvents lblResult As Label
End Class
