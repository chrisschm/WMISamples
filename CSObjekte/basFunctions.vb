Module basFunctions

    Friend Function GetReleaseDate(UTCFormat As String) As Date

        Dim year As String
        Dim month As String
        Dim day As String
        Dim hour As String
        Dim minute As String
        Dim second As String
        Dim strDate As String

        ' YYYYMMDDHHMMSS.MMMMMM(+-)OOO.

        year = Mid(UTCFormat, 1, 4)
        month = Mid(UTCFormat, 5, 2)
        day = Mid(UTCFormat, 7, 2)
        hour = Mid(UTCFormat, 9, 2)
        minute = Mid(UTCFormat, 11, 2)
        second = Mid(UTCFormat, 13, 2)

        strDate = "#" & day & "/" & month & "/" & year & " " & hour & ":" & minute & ":" & second & "#"

        Return Date.Parse(strDate)

    End Function

End Module
