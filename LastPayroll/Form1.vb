Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form1

    Private ReadOnly conn As New MySqlConnection("server=localhost;userid=root;password=;database=db_payroll;")
    Private dr As MySqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim form2 As New Form2()
        form2.ShowDialog()
        datagrid_load()
    End Sub

    Private Function GetNextEmployeeID() As Integer
        Dim nextID As Integer = 1
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim s_command As New MySqlCommand("SELECT MAX(`Employee ID`) FROM `tbl_employee`", conn)
            Dim result = s_command.ExecuteScalar()

            If Not IsDBNull(result) AndAlso result IsNot Nothing Then
                nextID = CInt(result) + 1
            End If
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        Return nextID
    End Function
    Public Sub datagrid_load()
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim s_command As New MySqlCommand("SELECT * FROM tbl_employee", conn)
            dr = s_command.ExecuteReader()
            While dr.Read()
                DataGridView1.Rows.Add(dr("Employee ID"), dr("LastName"), dr("FirstName"), dr("MiddleName"), dr("Position"), CInt(dr("Age")), dr("Sex"))
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dr?.Close()
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        save()
    End Sub
    Public Sub save()
        Try
            Dim nextID As Integer = GetNextEmployeeID()

            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim s_command As New MySqlCommand(
                "INSERT INTO `tbl_employee`(`Employee ID`, `LastName`, `FirstName`, `MiddleName`, `Position`, `Age`, `Sex`) 
                 VALUES (@EmployeeID, @LastName, @FirstName, @MiddleName, @Position, @Age, @Sex)", conn)

            s_command.Parameters.Clear()
            s_command.Parameters.AddWithValue("@EmployeeID", nextID)
            s_command.Parameters.AddWithValue("@LastName", TextBox1.Text)
            s_command.Parameters.AddWithValue("@FirstName", TextBox2.Text)
            s_command.Parameters.AddWithValue("@MiddleName", TextBox3.Text)
            s_command.Parameters.AddWithValue("@Position", TextBox4.Text)
            s_command.Parameters.AddWithValue("@Age", CInt(TextBox5.Text))
            s_command.Parameters.AddWithValue("@Sex", ComboBox1.Text)

            Dim i = s_command.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record Saved!", "tbl_employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
                datagrid_load()
                clear()
            Else
                MessageBox.Show("Failed to save record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
    Private Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        ComboBox1.Text = String.Empty
    End Sub

    Private Sub edit()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim s_command As New MySqlCommand(
                "UPDATE `tbl_employee` 
                 SET `LastName`=@LastName, `FirstName`=@FirstName, `MiddleName`=@MiddleName, `Position`=@Position, `Age`=@Age, `Sex`=@Sex 
                 WHERE `Employee ID` = @EmployeeID", conn)

            s_command.Parameters.Clear()
            s_command.Parameters.AddWithValue("@EmployeeID", TextBox6.Text)
            s_command.Parameters.AddWithValue("@LastName", TextBox1.Text)
            s_command.Parameters.AddWithValue("@FirstName", TextBox2.Text)
            s_command.Parameters.AddWithValue("@MiddleName", TextBox3.Text)
            s_command.Parameters.AddWithValue("@Position", TextBox4.Text)
            s_command.Parameters.AddWithValue("@Age", CInt(TextBox5.Text))
            s_command.Parameters.AddWithValue("@Sex", ComboBox1.Text)

            Dim i = s_command.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record Updated!", "tbl_employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
                datagrid_load()
                clear()
            Else
                MessageBox.Show("Update Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
    Public Sub delete()

        If MsgBox("Are you sure you want to delete this Record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then

            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim s_command As New MySqlCommand(
                "DELETE FROM `tbl_employee` WHERE `Employee ID` = @EmployeeID", conn)

                s_command.Parameters.Clear()
                s_command.Parameters.AddWithValue("@EmployeeID", TextBox6.Text)

                Dim i = s_command.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Record Deleted!", "tbl_employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    datagrid_load()
                    clear()
                Else
                    MessageBox.Show("Delete Failed! No record found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As MySqlException
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End If
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Hide()
        Form2.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        save()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        edit()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        delete()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        clear()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow = DataGridView1.Rows(e.RowIndex)
            TextBox6.Text = selectedRow.Cells(0).Value.ToString
            TextBox1.Text = selectedRow.Cells(1).Value.ToString
            TextBox2.Text = selectedRow.Cells(2).Value.ToString
            TextBox3.Text = selectedRow.Cells(3).Value.ToString
            TextBox4.Text = selectedRow.Cells(4).Value.ToString
            TextBox5.Text = selectedRow.Cells(5).Value.ToString
            ComboBox1.Text = selectedRow.Cells(6).Value.ToString
        End If
    End Sub

    Private Sub TextBox6_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
    End Sub
End Class
