Imports System.Data.SqlClient

Public Class dbVisitor
    Dim con As String = "Data Source=PKT2013\SQLEXPRESS;  Initial Catalog=visitor; Integrated Security=true"

    Public Function FillBuilding() As DataTable
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("spGetBuilding", connection)
            cmd.CommandType = CommandType.StoredProcedure
            connection.Open()
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            connection.Close()

            Return ds.Tables(0)




        Catch ex As Exception
            Throw ex

        End Try
    End Function

    Public Function FillFlats(building As Int16) As DataTable
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("spGetAllFlat", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Fk_flat", building)

            connection.Open()
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)

            connection.Close()
            da.Dispose()

            Return ds.Tables(0)



        Catch ex As Exception
            Throw ex

        End Try
    End Function


    Public Function GetSearchList(dtFrom As DateTime, dtTo As DateTime) As DataTable
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("GetSearchList", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@FromDate", dtFrom)
            cmd.Parameters.AddWithValue("@ToDate", dtTo)

            connection.Open()
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)

            connection.Close()
            da.Dispose()

            Return ds.Tables(0)



        Catch ex As Exception
            Throw ex

        End Try
    End Function


    Public Function GetComplainList(dtFrom As DateTime) As DataTable
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("complaindetails", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@dateon", dtFrom)
            cmd.Parameters.AddWithValue("@request", "list")
            cmd.Parameters.AddWithValue("@id", 0)

            connection.Open()
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)

            connection.Close()
            da.Dispose()

            Return ds.Tables(0)



        Catch ex As Exception
            Throw ex

        End Try
    End Function

    Public Function GetAComplainList(dtFrom As DateTime, id As Integer) As vComplain
        Dim vc As vComplain = New vComplain()

        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("complaindetails", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@dateon", dtFrom)
            cmd.Parameters.AddWithValue("@request", "single")
            cmd.Parameters.AddWithValue("@id", id)

            connection.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()


            If dr.Read() Then
                vc.complain = Formatting.ConvertNullToString(dr("complain"))
                vc.solution = Formatting.ConvertNullToString(dr("solution"))
                vc.fk_flats = Formatting.ConvertNullToInteger(dr("fk_flats"))
                vc.FK_Buildings = Formatting.ConvertNullToString(dr("FK_Buildings"))
                vc.isissueresolved = Formatting.ConvertNullToBoolean(dr("IssueResolved"))

            End If


            connection.Close()

        Catch ex As Exception
            Throw ex

        End Try

        Return vc
    End Function

    Public Function GetBlockList(dtFrom As DateTime) As DataTable
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("blockvisitordetails", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@tilldate", dtFrom)
            cmd.Parameters.AddWithValue("@request", "list")
            cmd.Parameters.AddWithValue("@id", 0)

            connection.Open()
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)

            connection.Close()
            da.Dispose()

            Return ds.Tables(0)



        Catch ex As Exception
            Throw ex

        End Try
    End Function

    Public Function GetABlockList(dtFrom As DateTime, id As Integer) As vBlockVisitor
        Dim vbv As vBlockVisitor = New vBlockVisitor()

        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("blockvisitordetails", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@tilldate", dtFrom)
            cmd.Parameters.AddWithValue("@request", "details")
            cmd.Parameters.AddWithValue("@id", id)

            connection.Open()

            Dim dr As SqlDataReader = cmd.ExecuteReader()


            If dr.Read() Then
                vbv.Id = Formatting.ConvertNullToInteger(dr("id"))
                vbv.GovnNo = Formatting.ConvertNullToString(dr("GovnNo"))
                vbv.GovnIdName = Formatting.ConvertNullToString(dr("GovnIdName"))
                vbv.PhoneNo = Formatting.ConvertNullToString(dr("PhoneNo"))
                vbv.Gender = Formatting.ConvertNullToBoolean(dr("Gender"))

                vbv.name = Formatting.ConvertNullToString(dr("name"))
                vbv.Isblock = Formatting.ConvertNullToBoolean(dr("isblock"))
                vbv.actiontaken = Formatting.ConvertNullToString(dr("actiontaken"))

                vbv.reason = Formatting.ConvertNullToString(dr("reason"))

            End If


            connection.Close()



        Catch ex As Exception
            Throw ex

        End Try

        Return vbv
    End Function



    Function GetSearchRecord(vc As Integer, vq As String, Fid As Integer) As DataTable
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("GetSearchRecord", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@vc", vc)
            cmd.Parameters.AddWithValue("@vq", vq)
            cmd.Parameters.AddWithValue("@Fid", Fid)

            connection.Open()
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)

            connection.Close()
            da.Dispose()

            Return ds.Tables(0)



        Catch ex As Exception
            Throw ex

        End Try
    End Function


    Public Sub SearchAVisitor(GovnIdName As String, GovnNo As String)
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("spSearchAVisitor", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@GovnIdName", GovnIdName)
            cmd.Parameters.AddWithValue("@GovnNo", GovnNo)

            connection.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()


            If dr.Read() Then
                VisitorName = Formatting.ConvertNullToString(dr("name"))
                PhoneNo = Formatting.ConvertNullToString(dr("PhoneNo"))
                Gender = IIf(Formatting.ConvertNullToString(dr("Gender")) = "M", False, True)
                FromPlace = Formatting.ConvertNullToString(dr("FromPlace"))
                Reason = Formatting.ConvertNullToString(dr("Reason"))
                BuildingNo = Formatting.ConvertNullToInteger(dr("BuildingId"))
                FlatNo = Formatting.ConvertNullToInteger(dr("FlatId"))
                BVid = Formatting.ConvertNullToInteger(dr("block"))

            End If
            connection.Close()
            dr = Nothing


        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Public Sub SearchABlockVisitor(GovnIdName As String, GovnNo As String)
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("blockvisitorSearch", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@GovnIdName", GovnIdName)
            cmd.Parameters.AddWithValue("@GovnNo", GovnNo)

            connection.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()


            If dr.Read() Then
                VisitorName = Formatting.ConvertNullToString(dr("name"))
                PhoneNo = Formatting.ConvertNullToString(dr("PhoneNo"))
                Gender = IIf(Formatting.ConvertNullToString(dr("Gender")) = "M", False, True)
                id = Formatting.ConvertNullToInteger(dr("id"))

            End If
            connection.Close()
            dr = Nothing


        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Public Function ValidateLogin(ou As User) As User
        Dim u As User = New User()
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("loggedin", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserName", ou.UserName)
            cmd.Parameters.AddWithValue("@Password", ou.Password)
            cmd.Parameters.AddWithValue("@RequestType", "login")
            cmd.Parameters.Add(New SqlParameter("@Admin", SqlDbType.Bit))
            cmd.Parameters("@Admin").Direction = ParameterDirection.Output
            cmd.Parameters.Add(New SqlParameter("@Validate", SqlDbType.Bit))
            cmd.Parameters("@Validate").Direction = ParameterDirection.Output


            connection.Open()
            cmd.ExecuteNonQuery()

            u.Admin = Formatting.ConvertNullToBoolean(cmd.Parameters("@Admin").Value)
            u.Validate = Formatting.ConvertNullToBoolean(cmd.Parameters("@Validate").Value)
            connection.Close()

            cmd = Nothing


        Catch ex As Exception
            Throw ex

        End Try
        Return u

    End Function

    Public Function LogOut(ou As User) As User
        Dim u As User = New User()
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("loggedin", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserName", ou.UserName)
            cmd.Parameters.AddWithValue("@Password", Formatting.ConvertNullToString(ou.Password))
            cmd.Parameters.AddWithValue("@RequestType", "logout")
            cmd.Parameters.Add(New SqlParameter("@Admin", SqlDbType.Bit))
            cmd.Parameters("@Admin").Direction = ParameterDirection.Output
            cmd.Parameters.Add(New SqlParameter("@Validate", SqlDbType.Bit))
            cmd.Parameters("@Validate").Direction = ParameterDirection.Output


            connection.Open()
            cmd.ExecuteNonQuery()

            connection.Close()

            cmd = Nothing


        Catch ex As Exception
            Throw ex

        End Try
        Return u

    End Function

    Public Function isloginValid(ou As User) As User
        Dim u As User = New User()
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("loggedin", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserName", Formatting.ConvertNullToString(ou.UserName))
            cmd.Parameters.AddWithValue("@Password", Formatting.ConvertNullToString(ou.Password))
            cmd.Parameters.AddWithValue("@RequestType", "isloginValid")
            cmd.Parameters.Add(New SqlParameter("@Admin", SqlDbType.Bit))
            cmd.Parameters("@Admin").Direction = ParameterDirection.Output
            cmd.Parameters.Add(New SqlParameter("@Validate", SqlDbType.Bit))
            cmd.Parameters("@Validate").Direction = ParameterDirection.Output


            connection.Open()
            cmd.ExecuteNonQuery()


            u.Validate = Formatting.ConvertNullToBoolean(cmd.Parameters("@Validate").Value)

            connection.Close()




        Catch ex As Exception
            Throw ex

        End Try
        Return u

    End Function

    Public Function SavePassword(ou As User) As User
        Dim u As User = New User()
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("loggedin", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserName", ou.UserName)
            cmd.Parameters.AddWithValue("@Password", Formatting.ConvertNullToString(ou.Password))
            cmd.Parameters.AddWithValue("@RequestType", "passwordupdate")
            cmd.Parameters.Add(New SqlParameter("@Admin", SqlDbType.Bit))
            cmd.Parameters("@Admin").Direction = ParameterDirection.Output
            cmd.Parameters.Add(New SqlParameter("@Validate", SqlDbType.Bit))
            cmd.Parameters("@Validate").Direction = ParameterDirection.Output


            connection.Open()
               cmd.ExecuteNonQuery()


            u.Validate = Formatting.ConvertNullToBoolean(cmd.Parameters("@Validate").Value)

            connection.Close()




        Catch ex As Exception
            Throw ex

        End Try
        Return u

    End Function



    Public Function UserInfo(Username As String) As User
        Dim u As User = New User()
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("userinfo", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserName", Username)
            cmd.Parameters.AddWithValue("@RequestType", "detailsshow")

            connection.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()


            If dr.Read() Then
                GlobalV.VName = Formatting.ConvertNullToString(dr("Name"))
                GlobalV.VPhone = Formatting.ConvertNullToString(dr("Phoneno"))
                GlobalV.VAddress = Formatting.ConvertNullToString(dr("address"))
                GlobalV.Password = Formatting.ConvertNullToString(dr("password"))

            End If

            connection.Close()




        Catch ex As Exception
            Throw ex

        End Try
        Return u

    End Function

    Sub SaveAVisitor(RequestType As String)
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("spVisitor", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@RequestType", RequestType)
            cmd.Parameters.AddWithValue("@GovnIdName", GovnIdName)
            cmd.Parameters.AddWithValue("@GovnNo", GovnNo)
            cmd.Parameters.AddWithValue("@Name", VisitorName)
            cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo)
            cmd.Parameters.AddWithValue("@Gender", Gender)
            cmd.Parameters.AddWithValue("@From", FromPlace)
            cmd.Parameters.AddWithValue("@Fk_FlatId", FlatNo)
            cmd.Parameters.AddWithValue("@Reason", Reason)


            connection.Open()
            cmd.ExecuteNonQuery()

            connection.Close()
            cmd.Dispose()


        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Sub UserInfoSave()
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("userinfosave", connection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@username", GlobalV.Username)
            cmd.Parameters.AddWithValue("@name", GlobalV.VName)
            cmd.Parameters.AddWithValue("@phoneno", GlobalV.VPhone)
            cmd.Parameters.AddWithValue("@Address", GlobalV.VAddress)
            cmd.Parameters.AddWithValue("@password", GlobalV.Password)


            connection.Open()
            cmd.ExecuteNonQuery()

            connection.Close()
            cmd.Dispose()


        Catch ex As Exception
            Throw ex

        End Try
    End Sub


    Sub complainsave(RequestType As String, vc As vComplain)
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("complainsave", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@RequestType", RequestType)
            cmd.Parameters.AddWithValue("@id", vc.Id)
            cmd.Parameters.AddWithValue("@fk_flats", vc.fk_flats)
            cmd.Parameters.AddWithValue("@complain", vc.complain)
            cmd.Parameters.AddWithValue("@solution", vc.solution)
            cmd.Parameters.AddWithValue("@isIssueResolved", vc.isissueresolved)
            cmd.Parameters.AddWithValue("@fk_user", vc.fk_user)

            connection.Open()
            cmd.ExecuteNonQuery()

            connection.Close()
            cmd.Dispose()


        Catch ex As Exception
            Throw ex

        End Try
    End Sub


    Sub bcedit(RequestType As String, b As vBlockVisitor)
        Try
            Dim connection As SqlConnection = New SqlConnection(con)
            Dim cmd As SqlCommand = New SqlCommand("bcedit", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@request", RequestType)
            cmd.Parameters.AddWithValue("@fk_visitor", b.Id)
            cmd.Parameters.AddWithValue("@isblock", b.Isblock)
            cmd.Parameters.AddWithValue("@reason", b.reason)
            cmd.Parameters.AddWithValue("@actiontaken", b.actiontaken)
            cmd.Parameters.AddWithValue("@fk_user", b.fk_user)
            cmd.Parameters.AddWithValue("@id", b.Id)


            connection.Open()
            cmd.ExecuteNonQuery()

            connection.Close()
            cmd.Dispose()


        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Public id As Integer
    Public GovnIdName As String
    Public GovnNo As String
    Public VisitorName As String
    Public PhoneNo As String
    Public Gender As Boolean
    Public FromPlace As String
    Public BuildingNo As Integer
    Public FlatNo As Integer
    Public Reason As String
    Public BVid As Integer








End Class

Public Class User
    Public Id As Integer
    Public UserName As String
    Public Password As String
    Public Admin As Boolean
    Public Validate As Boolean

End Class

Public Class vComplain
    Public Id As Integer
    Public fk_flats As Integer
    Public complain As String
    Public solution As String
    Public fk_user As String
    Public FK_Buildings As Integer
    Public isissueresolved As Boolean

End Class

Public Class vBlockVisitor
    Public Id As Integer
    Public GovnNo As String
    Public GovnIdName As String
    Public PhoneNo As String
    Public Gender As String
    Public name As String
    Public Isblock As Boolean
    Public reason As String
    Public actiontaken As String
    Public fk_user As String

    Public isissueresolved As Boolean

End Class