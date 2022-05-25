Imports CinemaSystem.DAL
Imports CinemaSystem.Models
Public Class MovieManager
    Dim movieservice As MovieService = New MovieService()
    Public Function GetMovieList() As List(Of Movie)

        Return movieservice.GetMovieList()
    End Function

End Class
