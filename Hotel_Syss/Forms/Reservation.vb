Imports MySql.Data.MySqlClient
Public Class Reservation
    Private connectionString As String = "server=localhost; user id=root; database=hotel"
    Private dgvUsers As DataGridView
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
    End Sub
    Public Sub New(dataGridView As DataGridView)
        InitializeComponent()
        dgvUsers = dataGridView
    End Sub
    Public Sub RefreshDataGridView()
        ' Fetch the data from the 'useraccess' table
        Dim query As String = "SELECT * FROM client_data"

        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                ' Bind the data to the DataGridView
                dataGridViewClients.DataSource = dataTable
            End Using
        End Using
    End Sub

End Class
