Public Class Splittest

    Private Class cPlayer
        Public Property ID As Integer
        Public Property UserType As Boolean
        Public Property Nickname As String
        Public Property Password As String
        Public Property Email As String
        Public Property XP As Integer
        Public Property Credit As Integer
        Public Property Games As List(Of cGame)
    End Class

    Private Class cGame
        Public Property Name As String
        Public Property Unlocked As Boolean
        Public Property Credit As Integer
        Public Property BestScore As Integer
        Public Property Trophies As List(Of cTrophy)
    End Class

    Private Class cTrophy
        Public Property Name As String
        Public Property Unlocked As Boolean
        Public Property Credit As Integer
    End Class

    'Dim grid As New DataGridView

    Dim players As New List(Of cPlayer)

    Public Sub New()
        InitializeComponent()
        Read_File()
        'MsgBox(players(0).Games(1).Trophies(1).Name)
        InitGrid()
        FillGrid()
        AddHandler grid.CellClick, AddressOf ColumnClick
        'Me.Controls.Add(grid)
    End Sub

    Private Sub InitGrid()
        grid.Columns(0).Name = "Id"
        grid.Columns(0).HeaderText = grid.Columns(0).Name
        grid.Columns(1).Name = "UserType"
        grid.Columns(1).HeaderText = grid.Columns(1).Name
        grid.Columns(2).Name = "Nickname"
        grid.Columns(2).HeaderText = grid.Columns(2).Name
        grid.Columns(3).Name = "Password"
        grid.Columns(3).HeaderText = grid.Columns(3).Name
        grid.Columns(4).Name = "Email"
        grid.Columns(4).HeaderText = grid.Columns(4).Name
        grid.Columns(5).Name = "XP"
        grid.Columns(5).HeaderText = grid.Columns(5).Name
        'Dim column As New DataGridViewColumn
        grid.Columns(6).Name = "Credit"
        grid.Columns(6).HeaderText = grid.Columns(6).Name
        grid.Columns(7).Name = "Games"
        grid.Columns(7).HeaderText = grid.Columns(7).Name



    End Sub

    Private Sub FillGrid()
        grid.Rows.Clear()
        For Each player In players
            Dim row(7) As String
            row(0) = player.ID
            row(1) = player.UserType
            row(2) = player.Nickname
            row(3) = player.Password
            row(4) = player.Email
            row(5) = player.XP
            row(6) = player.Credit
            row(7) = player.Games(0).ToString
            grid.Rows.Add(row)
        Next
        Dim columns_total_width As Integer
        For Each column As DataGridViewColumn In grid.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            columns_total_width += column.Width
        Next
        grid.Width = columns_total_width - 80
    End Sub

    Private Sub ColumnClick(ByVal sender As DataGridViewCell)

    End Sub

    Private Sub Read_File()
        Dim textInFile As String
        Dim path As String
        path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory.ToString(), "UsersData.txt")
        If Not (System.IO.File.Exists("UsersData.txt")) Then
            MsgBox("File don't exist", 16)
        Else
            textInFile = My.Computer.FileSystem.ReadAllText(path, System.Text.Encoding.UTF8)
            If textInFile <> "" Then
                Dim players_string() As String = Split(textInFile, vbCrLf)
                For Each player_string As String In players_string
                    Create_Players(player_string)
                Next
            End If
        End If
    End Sub

    Private Sub Create_Players(ByVal player_string As String)
        Dim player As New cPlayer
        Dim player_info() As String = Split(player_string, ";")
        player.ID = player_info(0)
        player.UserType = player_info(1)
        player.Nickname = player_info(2)
        player.Password = player_info(3)
        player.Email = player_info(4)
        player.XP = player_info(5)
        player.Credit = player_info(6)
        player.Games = Add_Games(player_info(7))
        players.Add(player)
    End Sub

    Private Function Add_Games(ByVal games_string As String) As List(Of cGame)
        Dim gamesList As New List(Of cGame)
        Dim games() As String = Split(games_string, "\")
        For Each game_string In games
            Dim game As New cGame
            Dim game_info() As String = Split(game_string, "|")
            game.Name = game_info(0)
            game.Unlocked = game_info(1)
            game.Credit = game_info(2)
            game.BestScore = game_info(3)
            game.Trophies = Add_Trophies(game_info(4))
            gamesList.Add(game)
        Next
        Return gamesList
    End Function

    Private Function Add_Trophies(ByVal trophies_string As String) As List(Of cTrophy)
        Dim trophiesList As New List(Of cTrophy)
        Dim trophies() As String = Split(trophies_string, "~")
        For Each trophie_string In trophies
            Dim trophy As New cTrophy
            Dim trophy_info() As String = Split(trophie_string, "#")
            trophy.Name = trophy_info(0)
            trophy.Unlocked = trophy_info(1)
            trophy.Credit = trophy_info(2)
            trophiesList.Add(trophy)
        Next
        Return trophiesList
    End Function


    Private Sub Save_File()
        Dim path As String = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory.ToString(), "StudentsInfo.txt")
        Dim echo As String = ""
        For Each person In players
            'echo &= person.id & ";" & person.name & ";" & person.birthday.ToString & ";" & "maths>" & person.maths & "@" & "tecno>" & person.tecno & "@" & "sport>" & person.Sport & vbCrLf
        Next
        echo &= "EOF"
        'Dim actSettings As String = tb_actName.Text & "," & dp_startDate.Value.ToString("dd-MM") & "," & tb_duration.Text & "," & Me.BackColor.ToArgb & ";"
        My.Computer.FileSystem.WriteAllText(path, echo, False)
        MsgBox("Update complete!")
    End Sub

End Class
