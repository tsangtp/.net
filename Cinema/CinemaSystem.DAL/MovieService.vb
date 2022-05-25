Imports CinemaSystem.Models
Imports System.Data.SqlClient
Public Class MovieService
    Dim con As SqlConnection = New SqlConnection("server=.;uid=sa;pwd=sa;database=project3;")
    Public Function GetMovieList() As List(Of Movie)
        Dim sql As SqlCommand = New SqlCommand("select * from dbo.movie where istop = 1", con)
        Dim dr As SqlDataReader
        Dim listMovie As List(Of Movie) = New List(Of Movie)
        con.Open()
        dr = sql.ExecuteReader
        While dr.Read()
            Dim movie As Movie = New Movie()
            movie.movieid = dr.GetInt32(0)
            movie.moviename = dr.GetString(1)
            movie.director = dr.GetString(2)
            movie.actor = dr.GetString(3)
            movie.type = dr.GetString(4)
            movie.duration = dr.GetInt32(5)
            movie.istop = dr.GetBoolean(6)
            movie.poster = dr.GetString(7)
            listMovie.Add(movie)
        End While
        con.Close()
        Return listMovie
    End Function

End Class
