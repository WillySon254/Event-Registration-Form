Imports System.Data.SQLite
Imports System.Text.RegularExpressions ' REQUIRED for validation patterns

Public Class Form1

    ' This subroutine runs when the form first opens.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Ensure the database file and table exist (calls the function in DBHelper)
        SetupDatabase()

        ' 2. Initialize the Ticket Type ComboBox (cmbTicket)

        ' --- START: UPDATED LOGIC FOR PLACEHOLDER ---
        cmbTicket.Items.Add("-- Select Ticket Type --") ' Placeholder Item (Index 0)
        cmbTicket.Items.Add("Standard")
        cmbTicket.Items.Add("VIP")
        cmbTicket.Items.Add("Student")

        ' Set SelectedIndex to 0 to display the placeholder text by default.
        ' The validation checks the string to ensure this placeholder cannot be submitted.
        cmbTicket.SelectedIndex = 0
        ' --- END: UPDATED LOGIC FOR PLACEHOLDER ---

        ' 3. Hide the status message initially
        lblStatus.Text = ""
    End Sub

    ' This subroutine runs when the user clicks the Register button.
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Clear previous status message
        lblStatus.Text = ""

        ' =================================================================
        ' 1. COMPREHENSIVE INPUT VALIDATION BLOCK
        ' =================================================================

        ' Define regex patterns:
        Dim namePattern As New Regex("^[a-zA-Z\s\-']+$")
        Dim phonePattern As New Regex("^[\d\s\-\(\)\+]+$")


        ' Check A: Name Field (Mandatory + Text Only)
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Validation Error: The Name field cannot be empty.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Return
        ElseIf Not namePattern.IsMatch(txtName.Text.Trim()) Then
            MessageBox.Show("Validation Error: The Name field must contain letters only (no numbers).", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Return
        End If

        ' Check B: Email Field (Mandatory + Enhanced Format)
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Validation Error: The Email field cannot be empty.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        ElseIf Not txtEmail.Text.Contains("@") OrElse Not txtEmail.Text.Contains(".") Then
            MessageBox.Show("Validation Error: Please enter a valid Email address. It must include both the '@' and '.' symbols (e.g., user@domain.com).", "Invalid Email Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If

        ' Check C: Phone Field (Mandatory + Length + Number/Symbol Only)
        If String.IsNullOrWhiteSpace(txtPhone.Text) Then
            MessageBox.Show("Validation Error: The Phone Number field cannot be empty.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Return
        End If

        ' --- Length Check ---
        Dim cleanedPhone As String = Regex.Replace(txtPhone.Text, "[^0-9]", "")

        If cleanedPhone.Length < 10 Then
            MessageBox.Show("Validation Error: The Phone Number must contain at least 10 digits.", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Return
        End If

        ' Format Check 
        If Not phonePattern.IsMatch(txtPhone.Text.Trim()) Then
            MessageBox.Show("Validation Error: The Phone Number must contain valid digits/symbols only.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Return
        End If

        ' Check D: Ticket Type Selection (Mandatory)
        ' We check the selected string value to prevent the placeholder from being registered.
        If cmbTicket.SelectedItem.ToString() = "-- Select Ticket Type --" Then
            MessageBox.Show("Validation Error: Please select a valid Ticket Type.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbTicket.Focus()
            Return
        End If

        ' =================================================================
        ' END VALIDATION
        ' =================================================================

        Try
            ' 2. Prepare Data
            Dim regID As String = GetNextRegistrationID()
            Dim name As String = txtName.Text.Trim()
            Dim email As String = txtEmail.Text.Trim()
            Dim phone As String = txtPhone.Text.Trim()

            ' Since validation passed, we know cmbTicket.SelectedItem.ToString() is a valid option (Standard, VIP, or Student).
            Dim ticketType As String = cmbTicket.SelectedItem.ToString()

            ' 3. Connect to Database and Insert Data
            Using conn As SQLiteConnection = GetConnection()
                conn.Open()

                Dim sql As String = "INSERT INTO Registrations (RegID, Name, Email, Phone, TicketType) 
                                     VALUES (@regID, @name, @email, @phone, @ticketType)"

                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@regID", regID)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@phone", phone)
                    cmd.Parameters.AddWithValue("@ticketType", ticketType)

                    cmd.ExecuteNonQuery()
                End Using

                ' 4. Success Feedback
                lblStatus.Text = $"Registration successful!{Environment.NewLine}Your ID: {regID}"
                lblStatus.ForeColor = System.Drawing.Color.ForestGreen

                ' Reset Form
                txtName.Clear()
                txtEmail.Clear()
                txtPhone.Clear()

                ' Reset ComboBox to show the placeholder again (Index 0)
                cmbTicket.SelectedIndex = 0

            End Using

        Catch ex As Exception
            lblStatus.Text = "Registration failed due to a database error."
            lblStatus.ForeColor = System.Drawing.Color.Red
            MessageBox.Show($"Error details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub cmbTicket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTicket.SelectedIndexChanged

    End Sub
End Class