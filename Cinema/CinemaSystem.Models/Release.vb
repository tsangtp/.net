Public Class Release
    Private _releaseid As Integer
    Private _movieid As Integer
    Private _operatorid As Integer
    Private _playdate As DateTime
    Private _playtime As String
    Private _price As Integer

    Public Property releaseid() As Integer
        Get
            Return _releaseid
        End Get
        Set(ByVal value As Integer)
            _releaseid = value
        End Set
    End Property
    Public Property movieid() As Integer
        Get
            Return _movieid
        End Get
        Set(ByVal value As Integer)
            _movieid = value
        End Set
    End Property
    Public Property operatorid() As Integer
        Get
            Return _operatorid
        End Get
        Set(ByVal value As Integer)
            _operatorid = value
        End Set
    End Property
    Public Property playdate() As DateTime
        Get
            Return _playdate
        End Get
        Set(ByVal value As DateTime)
            _playdate = value
        End Set
    End Property
    Public Property playtime() As String
        Get
            Return _playtime
        End Get
        Set(ByVal value As String)
            _playtime = value
        End Set
    End Property
    Public Property price() As Integer
        Get
            Return _price
        End Get
        Set(ByVal value As Integer)
            _price = value
        End Set
    End Property
End Class
