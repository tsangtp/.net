Public Class template
    Dim sitid As Integer
    Dim releaseid As Integer
    Dim operatorid As Integer


    Public Sub New(sitid As Integer, releaseid As Integer, operatorid As Integer)
        Me.sitid = sitid
        Me.releaseid = releaseid
        Me.operatorid = operatorid
    End Sub

    Public Function getsitid()
        Return sitid
    End Function
    Public Function getreleaseid()
        Return releaseid
    End Function
    Public Function getoperatorid()
        Return operatorid
    End Function



End Class
