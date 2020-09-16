Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Const strMsg As String = "Saved amount: "
        'declare variables
        Dim dblPrice1 As Double
        Dim dblPrice2 As Double
        Dim dblFinalAmount As Double
        Dim dblSavedAmount As Double

        'parsing or assigning values

        Double.TryParse(txtPrice1.Text, dblPrice1)
        Double.TryParse(txtPrice2.Text, dblPrice2)

        'if price 1 < price2
        If dblPrice1 < dblPrice2 Then
            dblSavedAmount = dblPrice1 / 2.0
            dblFinalAmount = (dblPrice1 / 2.0) + dblPrice2
        Else
            dblSavedAmount = dblPrice2 / 2.0
            dblFinalAmount = (dblPrice2 / 2.0) + dblPrice1
        End If


        'display total amount after discount
        lblFinalAmount.Text = dblFinalAmount.ToString("c2")

        'message box
        MessageBox.Show(strMsg + dblSavedAmount.ToString("c2"), "Total saved amount",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        'set the focus back
        txtPrice1.Focus()
        txtPrice1.SelectAll()
    End Sub
    'exit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'only madawat na input
    Private Sub txtPrice1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice1.KeyPress, txtPrice2.KeyPress
        ' allow only numbers and the Backspace, dot

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    'empty if txtboxes changed
    Private Sub txtPrice1_TextChanged(sender As Object, e As EventArgs) Handles txtPrice1.TextChanged, txtPrice2.TextChanged
        lblFinalAmount.Text = String.Empty
    End Sub

    'highlight tanan when focused
    Private Sub txtPrice1_MouseUp(sender As Object, e As EventArgs) Handles txtPrice1.MouseUp
        txtPrice1.SelectAll()
    End Sub
    Private Sub txtPrice2_MouseUp(sender As Object, e As EventArgs) Handles txtPrice2.MouseUp
        txtPrice2.SelectAll()
    End Sub

End Class
