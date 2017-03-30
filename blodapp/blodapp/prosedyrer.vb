Public Class prosedyrer
    Public Function lastinnBlodtype()
        Dim info As New info
        Dim CountTabell As New DataTable
        CountTabell = info.query("blodtype", "blodgiver", "1 GROUP BY blodtype")
        Return CountTabell
    End Function
End Class
