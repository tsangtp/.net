
Public Class Movie

    Private _movieid As Integer
    Private _moviename As String
    Private _director As String
    Private _actor As String
    Private _type As String
    Private _duration As String
    Private _istop As Boolean
    Private _poster As String


    Public Property movieid() As Integer
            Get
                Return _movieid
            End Get
            Set(ByVal value As Integer)
                _movieid = value
            End Set
        End Property
        Public Property moviename() As String
            Get
                Return _moviename
            End Get
            Set(ByVal value As String)
                _moviename = value
            End Set
        End Property
        Public Property director() As String
            Get
                Return _director
            End Get
            Set(ByVal value As String)
                _director = value
            End Set
        End Property
        Public Property actor() As String
            Get
                Return _actor
            End Get
            Set(ByVal value As String)
                _actor = value
            End Set
        End Property
        Public Property type() As String
            Get
                Return _type
            End Get
            Set(ByVal value As String)
                _type = value
            End Set
        End Property
    Public Property duration() As String
        Get
            Return _duration
        End Get
        Set(ByVal value As String)
            _duration = value
        End Set
    End Property
    Public Property istop() As Boolean
            Get
                Return _istop
            End Get
            Set(ByVal value As Boolean)
                _istop = value
            End Set
        End Property

    Public Property poster() As String
        Get
            Return _poster
        End Get
        Set(ByVal value As String)
            _poster = value
        End Set
    End Property

End Class
