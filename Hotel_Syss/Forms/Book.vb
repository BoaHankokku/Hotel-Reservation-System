Imports MySql.Data.MySqlClient

Public Class Book
    Private connectionString As String = "Server=localhost; Database=hotel; User ID=root;"
    Private connection As MySqlConnection
    Private dgvUsers As DataGridView

    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()
        dgvUsers = dataGridView
    End Sub

    Private Sub Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection(connectionString)
        Dim Rooms() As String = {"ROOM 1", "ROOM 2", "ROOM 3", "ROOM 4", "ROOM 5"}
        Dim Packs() As String = {"SINGLE", "2 PERSON", "4 PERSON", "6 PERSON", "12 PERSON"}
        Dim Payment() As String = {"Walk-In", "E-Wallet", "Credit Card"}
        cmbRooms.Items.AddRange(Rooms)
        cmbPacks.Items.AddRange(Packs)
        cmbPayment.Items.AddRange(Payment)
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            Dim Rooms As String = cmbRooms.SelectedItem?.ToString
            Dim name As String = txtClientName.Text
            Dim email As String = txtClientEmail.Text
            Dim phone As String = txtClientPhone.Text
            Dim ephone As String = txtClientEPhone.Text
            Dim payment As String = cmbPayment.SelectedItem?.ToString
            Dim Packs As String = cmbPacks.SelectedItem?.ToString
            Dim checkInTime As DateTime = DateTime.Now
            Dim checkOutTime As DateTime = DateTime.Now
            Dim note As String = txtClientNote.Text

            Dim query As String = "INSERT INTO client_data (Rooms, Name, Email, PhoneNo, EmergencyNo, Payment, Packs, Check_In_Time, Check_Out_Time, NOte ) VALUES (@Rooms, @Name, @Email, @PhoneNO, @EmergencyNo, @Payment, @Packs, @Check_In_Time, @Check_Out_Time, @Note )"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using Command As New MySqlCommand(query, connection)
                    Command.Parameters.AddWithValue("@Rooms", Rooms)
                    Command.Parameters.AddWithValue("@Name", name)
                    Command.Parameters.AddWithValue("@Email", email)
                    Command.Parameters.AddWithValue("@PhoneNO", phone)
                    Command.Parameters.AddWithValue("@EmergencyNo", ephone)
                    Command.Parameters.AddWithValue("@Payment", payment)
                    Command.Parameters.AddWithValue("@Packs", Packs)
                    Command.Parameters.AddWithValue("@Check_In_Time", checkInTime)
                    Command.Parameters.AddWithValue("@Check_Out_Time", checkOutTime)
                    Command.Parameters.AddWithValue("@Note", note)

                    Dim rowsAffected As Integer = Command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to insert record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error inserting record: {ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        txtClientName.Text = ""
        txtClientEmail.Text = ""
        txtClientPhone.Text = ""
        txtClientNote.Text = ""
        txtClientEPhone.Text = ""

        cmbPacks.SelectedIndex = -1
        cmbPayment.SelectedIndex = -1
        cmbRooms.SelectedIndex = -1

        dtpCheckIn.Value = DateTime.Now
        dtpCheckOut.Value = DateTime.Now

    End Sub
End Class
