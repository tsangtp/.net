Imports System.Data.SqlClient
Imports CinemaSystem.Models
Public Class ReleaseService
    Dim con As SqlConnection = New SqlConnection("server=.;uid=sa;pwd=sa;database=project3;")
    Public Function GetReleaseList() As List(Of Release)
        Dim listRelease As List(Of Release) = New List(Of Release)
        Dim sql As SqlCommand = New SqlCommand("select * from dbo.release where 
        movieid in (select movieid from dbo.movie where istop = 1) order by movieid asc,playtime desc", con)
        Dim dr As SqlDataReader
        con.Open()
        dr = sql.ExecuteReader
        While dr.Read()
            Dim release As Release = New Release()
            release.releaseid = dr.GetInt32(0)
            release.movieid = dr.GetInt32(1)
            release.operatorid = dr.GetInt32(2)
            release.playdate = dr.GetDateTime(3)
            release.playtime = dr.GetString(4)
            release.price = dr.GetInt32(5)
            listRelease.Add(release)
        End While
        con.Close()
        Return listRelease

    End Function


End Class
