<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblPrice1 = New System.Windows.Forms.Label()
        Me.txtPrice1 = New System.Windows.Forms.TextBox()
        Me.lblPrice2 = New System.Windows.Forms.Label()
        Me.txtPrice2 = New System.Windows.Forms.TextBox()
        Me.lblTot = New System.Windows.Forms.Label()
        Me.lblFinalAmount = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.grpOutput.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrice1
        '
        Me.lblPrice1.AutoSize = True
        Me.lblPrice1.Location = New System.Drawing.Point(7, 27)
        Me.lblPrice1.Name = "lblPrice1"
        Me.lblPrice1.Size = New System.Drawing.Size(77, 13)
        Me.lblPrice1.TabIndex = 0
        Me.lblPrice1.Text = "Price of item 1:"
        '
        'txtPrice1
        '
        Me.txtPrice1.Location = New System.Drawing.Point(91, 23)
        Me.txtPrice1.Name = "txtPrice1"
        Me.txtPrice1.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice1.TabIndex = 1
        '
        'lblPrice2
        '
        Me.lblPrice2.AutoSize = True
        Me.lblPrice2.Location = New System.Drawing.Point(7, 53)
        Me.lblPrice2.Name = "lblPrice2"
        Me.lblPrice2.Size = New System.Drawing.Size(77, 13)
        Me.lblPrice2.TabIndex = 3
        Me.lblPrice2.Text = "Price of item 2:"
        '
        'txtPrice2
        '
        Me.txtPrice2.Location = New System.Drawing.Point(91, 49)
        Me.txtPrice2.Name = "txtPrice2"
        Me.txtPrice2.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice2.TabIndex = 2
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.Location = New System.Drawing.Point(6, 27)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(72, 13)
        Me.lblTot.TabIndex = 4
        Me.lblTot.Text = "Total amount:"
        '
        'lblFinalAmount
        '
        Me.lblFinalAmount.BackColor = System.Drawing.SystemColors.Info
        Me.lblFinalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFinalAmount.Location = New System.Drawing.Point(90, 23)
        Me.lblFinalAmount.Name = "lblFinalAmount"
        Me.lblFinalAmount.Size = New System.Drawing.Size(100, 20)
        Me.lblFinalAmount.TabIndex = 5
        Me.lblFinalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(47, 173)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(128, 173)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.lblFinalAmount)
        Me.grpOutput.Controls.Add(Me.lblTot)
        Me.grpOutput.Location = New System.Drawing.Point(27, 96)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(199, 59)
        Me.grpOutput.TabIndex = 9
        Me.grpOutput.TabStop = False
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.txtPrice2)
        Me.grpInput.Controls.Add(Me.lblPrice1)
        Me.grpInput.Controls.Add(Me.lblPrice2)
        Me.grpInput.Controls.Add(Me.txtPrice1)
        Me.grpInput.Location = New System.Drawing.Point(26, 12)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(200, 86)
        Me.grpInput.TabIndex = 8
        Me.grpInput.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 216)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcy’s Store"
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPrice1 As Label
    Friend WithEvents txtPrice1 As TextBox
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents txtPrice2 As TextBox
    Friend WithEvents lblTot As Label
    Friend WithEvents lblFinalAmount As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents grpInput As GroupBox
End Class
