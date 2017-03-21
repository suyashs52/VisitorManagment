Public Class Formatting

    Public Shared Function ConvertNullToInteger(value As Object)
        Try
            If Not IsDBNull(value) Then
                Dim i As Integer = 0
                Dim isInt As Boolean = Integer.TryParse(value.ToString(), i)

                If (isInt = True) Then
                    Return Convert.ToInt32(value)
                Else : Return 0

                End If

            Else : Return 0
            End If


        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Shared Function ConvertNullToString(value As Object)
        Try
            If Not IsDBNull(value) Then

                Return value.ToString().Trim()

            Else : Return ""
            End If


        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Shared Function ConvertNullToBoolean(value As Object)
        Try
            If Not IsDBNull(value) Then
                Dim i As Boolean = 0
                Dim isInt As Boolean = Boolean.TryParse(value.ToString(), i)

                If (isInt = True) Then
                    Return Convert.ToBoolean(value)
                Else : Return False

                End If

            Else : Return False

            End If


        Catch ex As Exception
            Return False
        End Try
    End Function


End Class
