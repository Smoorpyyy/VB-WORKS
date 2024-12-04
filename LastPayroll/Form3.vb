Imports Google.Protobuf.WellKnownTypes
Imports K4os.Compression.LZ4.Streams.Adapters

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox12.Text) Then
            MessageBox.Show("Please ensure all required fields are filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim total As Double = CDbl(TextBox1.Text) * CDbl(TextBox2.Text) * CDbl(TextBox3.Text)
            TextBox4.Text = total.ToString()
            If String.IsNullOrWhiteSpace(TextBox13.Text) Then
                TextBox13.Text = 0
            End If
            Dim rate As Double = CDbl(TextBox1.Text)
            Dim overtime As Double = CDbl(TextBox13.Text)
            Dim overtimepay As Double = overtime * (rate * 0.25)
            TextBox14.Text = overtimepay.ToString("F2")

            Dim gross As Double = total + overtimepay
            TextBox15.Text = gross.ToString("F2")

            Dim tax As Double = gross * 0.02
            TextBox5.Text = tax.ToString("F2")
            Dim phil As Double = gross * 0.05
            TextBox6.Text = phil.ToString("F2")
            Dim sss As Double = gross * 0.03
            TextBox7.Text = sss.ToString("F2")
            Dim deduc As Double = tax + phil + sss
            TextBox8.Text = deduc.ToString("F2")

            TextBox11.Text = (gross - deduc).ToString("F2")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrWhiteSpace(TextBox12.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox16.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox4.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox15.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox5.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox6.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox7.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox8.Text) Then

            MessageBox.Show("Please ensure all required fields are filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim result = MessageBox.Show("View my payslip?", "Withdraw Successfully!", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim name = TextBox12.Text
            Dim position = TextBox16.Text
            Dim datetime = DateTimePicker1.Value.ToString
            Dim salarywithoutpay As Double = TextBox4.Text
            Dim overtimePay As Double = TextBox14.Text
            Dim gross As Double = TextBox15.Text
            Dim tax As Double = TextBox5.Text
            Dim philHealth As Double = TextBox6.Text
            Dim sss As Double = TextBox7.Text
            Dim deductions As Double = TextBox8.Text
            Dim payslip As New Text.StringBuilder

            payslip.AppendLine("========= PAYSLIP =========")
            payslip.AppendLine("Date: " & datetime.ToString)
            payslip.AppendLine("Name of Employee: " & name.ToString)
            payslip.AppendLine("Position: " & position.ToString)
            payslip.AppendLine("Salary without Overtime Pay: " & salarywithoutpay.ToString("F2"))
            payslip.AppendLine("Overtime Pay: " & overtimePay.ToString("F2"))
            payslip.AppendLine("Gross Salary: " & gross.ToString("F2"))
            payslip.AppendLine("----------------------------")
            payslip.AppendLine("Deductions:")
            payslip.AppendLine("Tax: " & tax.ToString("F2"))
            payslip.AppendLine("PhilHealth: " & philHealth.ToString("F2"))
            payslip.AppendLine("SSS: " & sss.ToString("F2"))
            payslip.AppendLine("----------------------------")
            payslip.AppendLine("Total Deductions: " & deductions.ToString("F2"))
            payslip.AppendLine("----------------------------")
            payslip.AppendLine("Net Pay: " & (gross - deductions).ToString("F2"))
            payslip.AppendLine("============================")

            Dim back = MessageBox.Show(payslip.ToString, "PAYSLIP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If back = DialogResult.OK Then
                Button2.PerformClick()
            ElseIf result = DialogResult.Cancel Then
                Button2.PerformClick()
            End If
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class