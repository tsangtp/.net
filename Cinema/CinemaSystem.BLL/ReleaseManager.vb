Imports CinemaSystem.DAL
Imports CinemaSystem.Models
Public Class ReleaseManager
    Dim releaselist As ReleaseService = New ReleaseService()
    Public Function GetReleaseList() As List(Of Release)

        Return releaselist.GetReleaseList()
    End Function
End Class
