Imports MySql.Data.MySqlClient

Public Class DB
    Shared DBobjLock As New Object

    Public Shared connectionString As String = "server=trident;user=systemplast;database=trident;port=3306;password=AdminPC;"


    Public Shared Sub ReadHmiData()



        Try
            SyncLock DBobjLock
                Dim SQLConnection As MySqlConnection = New MySqlConnection(connectionString)
                Dim sqlCommand As New MySqlCommand
                Dim str_carSql As String
                Dim rd As MySqlDataReader
                Try
                    SQLConnection.Open()
                    str_carSql = "SELECT `plc_data`.`intval1`," &
                                          "  `plc_data`.`intval2`," &
                                          "  `plc_data`.`intval3`," &
                                          "  `plc_data`.`intval4`," &
                                          "  `plc_data`.`intval5`," &
                                          "  `plc_data`.`intval6`," &
                                          "  `plc_data`.`intval7`," &
                                          "  `plc_data`.`intval8`," &
                                          "  `plc_data`.`intval9`," &
                                          "  `plc_data`.`intval10`," &
                                          "  `plc_data`.`intval11`," &
                                          "  `plc_data`.`intval12`," &
                                          "  `plc_data`.`intval13`," &
                                          "  `plc_data`.`intval14`," &
                                          "  `plc_data`.`intval15`," &
                                          "  `plc_data`.`intval16`," &
                                          "  `plc_data`.`intval17`," &
                                          "  `plc_data`.`intval18`," &
                                          "  `plc_data`.`intval19`," &
                                          "  `plc_data`.`intval20`," &
                                          "  `plc_data`.`intval21`," &
                                          "  `plc_data`.`intval22`," &
                                          "  `plc_data`.`intval23`," &
                                          "  `plc_data`.`intval24`," &
                                          "  `plc_data`.`intval25`," &
                                          "  `plc_data`.`intval26`," &
                                          "  `plc_data`.`intval27`," &
                                          "  `plc_data`.`intval28`," &
                                          "  `plc_data`.`intval29`," &
                                          "  `plc_data`.`intval30`," &
                                          "  `plc_data`.`real1`," &
                                          "  `plc_data`.`real2`," &
                                          "  `plc_data`.`real3`," &
                                          "  `plc_data`.`real4`," &
                                          "  `plc_data`.`real5`," &
                                          "  `plc_data`.`real6`," &
                                          "  `plc_data`.`real7`," &
                                          "  `plc_data`.`real8`," &
                                          "  `plc_data`.`real9`," &
                                          "  `plc_data`.`real10`," &
                                          "  `plc_data`.`real11`," &
                                          "  `plc_data`.`real12`," &
                                          "  `plc_data`.`real13`," &
                                          "  `plc_data`.`real14`," &
                                          "  `plc_data`.`real15`," &
                                          "  `plc_data`.`real16`," &
                                          "  `plc_data`.`real17`," &
                                          "  `plc_data`.`real18`," &
                                          "  `plc_data`.`real19`," &
                                          "  `plc_data`.`real20`," &
                                          "  `plc_data`.`real21`," &
                                          "  `plc_data`.`real22`," &
                                          "  `plc_data`.`real23`," &
                                          "  `plc_data`.`real24`," &
                                          "  `plc_data`.`real25`," &
                                          "  `plc_data`.`real26`," &
                                          "  `plc_data`.`real27`," &
                                          "  `plc_data`.`real28`," &
                                          "  `plc_data`.`real29`," &
                                          "  `plc_data`.`real30`," &
                                          "  `plc_data`.`word1`," &
                                          "  `plc_data`.`word2`," &
                                          "  `plc_data`.`word3`," &
                                          "  `plc_data`.`word4`," &
                                          "  `plc_data`.`word5`," &
                                          "  `plc_data`.`word6`," &
                                          "  `plc_data`.`word7`," &
                                          "  `plc_data`.`word8`," &
                                          "  `plc_data`.`word9`," &
                                          "  `plc_data`.`word10`," &
                                          "  `plc_data`.`word11`," &
                                          "  `plc_data`.`word12`," &
                                          "  `plc_data`.`word13`," &
                                          "  `plc_data`.`word14`," &
                                          "  `plc_data`.`word15`," &
                                          "  `plc_data`.`word16`," &
                                          "  `plc_data`.`word17`," &
                                          "  `plc_data`.`word18`," &
                                          "  `plc_data`.`word19`," &
                                          "  `plc_data`.`word20`," &
                                          "  `plc_data`.`word21`," &
                                          "  `plc_data`.`word22`," &
                                          "  `plc_data`.`word23`," &
                                          "  `plc_data`.`word24`," &
                                          "  `plc_data`.`word25`," &
                                          "  `plc_data`.`word26`," &
                                          "  `plc_data`.`word27`," &
                                          "  `plc_data`.`word28`," &
                                          "  `plc_data`.`word29`," &
                                          "  `plc_data`.`word30`," &
                                          "  `plc_data`.`lastUpdateTime`" &
                                          "  FROM `trident`.`plc_data`;"


                    sqlCommand.Connection = SQLConnection
                    sqlCommand.CommandText = str_carSql
                    rd = sqlCommand.ExecuteReader()

                    If rd.Read Then
                        hmiData.measureInt1 = rd.GetInt16(0)
                        hmiData.measureInt2 = rd.GetInt16(1)
                        hmiData.measureInt3 = rd.GetInt16(2)
                        hmiData.measureInt4 = rd.GetInt16(3)
                        hmiData.measureInt5 = rd.GetInt16(4)
                        hmiData.measureInt6 = rd.GetInt16(5)
                        hmiData.measureInt7 = rd.GetInt16(6)
                        hmiData.measureInt8 = rd.GetInt16(7)
                        hmiData.measureInt9 = rd.GetInt16(8)
                        hmiData.measureInt10 = rd.GetInt16(9)
                        hmiData.measureInt11 = rd.GetInt16(10)
                        hmiData.measureInt12 = rd.GetInt16(11)
                        hmiData.measureInt13 = rd.GetInt16(12)
                        hmiData.measureInt14 = rd.GetInt16(13)
                        hmiData.measureInt15 = rd.GetInt16(14)
                        hmiData.measureInt16 = rd.GetInt16(15)
                        hmiData.measureInt17 = rd.GetInt16(16)
                        hmiData.measureInt18 = rd.GetInt16(17)
                        hmiData.measureInt19 = rd.GetInt16(18)
                        hmiData.measureInt20 = rd.GetInt16(19)
                        hmiData.measureInt21 = rd.GetInt16(20)
                        hmiData.measureInt22 = rd.GetInt16(21)
                        hmiData.measureInt23 = rd.GetInt16(22)
                        hmiData.measureInt24 = rd.GetInt16(23)
                        hmiData.measureInt25 = rd.GetInt16(24)
                        hmiData.measureInt26 = rd.GetInt16(25)
                        hmiData.measureInt27 = rd.GetInt16(26)
                        hmiData.measureInt28 = rd.GetInt16(27)
                        hmiData.measureInt29 = rd.GetInt16(28)
                        hmiData.measureInt30 = rd.GetInt16(29)



                        hmiData.MeasureReal1 = rd.GetFloat(30)
                        hmiData.MeasureReal2 = rd.GetFloat(31)
                        hmiData.MeasureReal3 = rd.GetFloat(32)
                        hmiData.MeasureReal4 = rd.GetFloat(33)
                        hmiData.MeasureReal5 = rd.GetFloat(34)
                        hmiData.MeasureReal6 = rd.GetFloat(35)
                        hmiData.MeasureReal7 = rd.GetFloat(36)
                        hmiData.MeasureReal8 = rd.GetFloat(37)
                        hmiData.MeasureReal9 = rd.GetFloat(38)
                        hmiData.MeasureReal10 = rd.GetFloat(39)
                        hmiData.MeasureReal11 = rd.GetFloat(40)
                        hmiData.MeasureReal12 = rd.GetFloat(41)
                        hmiData.MeasureReal13 = rd.GetFloat(42)
                        hmiData.MeasureReal14 = rd.GetFloat(43)
                        hmiData.MeasureReal15 = rd.GetFloat(44)
                        hmiData.MeasureReal16 = rd.GetFloat(45)
                        hmiData.MeasureReal17 = rd.GetFloat(46)
                        hmiData.MeasureReal18 = rd.GetFloat(47)
                        hmiData.MeasureReal19 = rd.GetFloat(48)
                        hmiData.MeasureReal20 = rd.GetFloat(49)
                        hmiData.MeasureReal21 = rd.GetFloat(50)
                        hmiData.MeasureReal22 = rd.GetFloat(51)
                        hmiData.MeasureReal23 = rd.GetFloat(52)
                        hmiData.MeasureReal24 = rd.GetFloat(53)
                        hmiData.MeasureReal25 = rd.GetFloat(54)
                        hmiData.MeasureReal26 = rd.GetFloat(55)
                        hmiData.MeasureReal27 = rd.GetFloat(56)
                        hmiData.MeasureReal28 = rd.GetFloat(57)
                        hmiData.MeasureReal29 = rd.GetFloat(58)
                        hmiData.MeasureReal30 = rd.GetFloat(59)

                        hmiData.measureWord1 = GlobalVariables.intToStrPhotocells(rd.GetUInt16(60))
                        hmiData.measureWord2 = rd.GetUInt16(61)
                        hmiData.measureWord3 = rd.GetUInt16(62)
                        hmiData.measureWord4 = rd.GetUInt16(63)
                        hmiData.measureWord5 = rd.GetUInt16(64)
                        hmiData.measureWord6 = rd.GetUInt16(65)
                        hmiData.measureWord7 = rd.GetUInt16(66)
                        hmiData.measureWord8 = rd.GetUInt16(67)
                        hmiData.measureWord9 = rd.GetUInt16(68)
                        hmiData.measureWord10 = rd.GetUInt16(69)
                        hmiData.measureWord11 = rd.GetUInt16(70)
                        hmiData.measureWord12 = rd.GetUInt16(71)
                        hmiData.measureWord13 = rd.GetUInt16(72)
                        hmiData.measureWord14 = rd.GetUInt16(73)
                        hmiData.measureWord15 = rd.GetUInt16(74)
                        hmiData.measureWord16 = rd.GetUInt16(75)
                        hmiData.measureWord17 = rd.GetUInt16(76)
                        hmiData.measureWord18 = rd.GetUInt16(77)
                        hmiData.measureWord19 = rd.GetUInt16(78)
                        hmiData.measureWord20 = rd.GetUInt16(79)
                        hmiData.measureWord21 = rd.GetUInt16(80)
                        hmiData.measureWord22 = rd.GetUInt16(81)
                        hmiData.measureWord23 = rd.GetUInt16(82)
                        hmiData.measureWord24 = rd.GetUInt16(83)
                        hmiData.measureWord25 = rd.GetUInt16(84)
                        hmiData.measureWord26 = rd.GetUInt16(85)
                        hmiData.measureWord27 = rd.GetUInt16(86)
                        hmiData.measureWord28 = rd.GetUInt16(87)
                        hmiData.measureWord29 = rd.GetUInt16(88)
                        hmiData.measureWord30 = rd.GetUInt16(89)

                    End If


                Catch ex As Exception

                Finally
                    SQLConnection.Close()
                End Try

            End SyncLock
        Catch ex As Exception

        End Try

    End Sub


    Public Shared Sub ReadBarcodesData(ByRef dgv As DataGridView)



        Try
            SyncLock DBobjLock
                Dim SQLConnection As MySqlConnection = New MySqlConnection(connectionString)
                Dim sqlCommand As New MySqlCommand
                Dim sda As New MySqlDataAdapter
                Dim dt As New DataTable
                Dim bs As New BindingSource
                Dim str_carSql As String
                Dim rd As MySqlDataReader
                Try
                    SQLConnection.Open()
                    str_carSql = "SELECT * FROM `trident`.`barcodes`;"


                    sqlCommand.Connection = SQLConnection
                    sqlCommand.CommandText = str_carSql
                    sda.SelectCommand = sqlCommand
                    sda.Fill(dt)
                    bs.DataSource = dt
                    dgv.DataSource = bs
                    sda.Update(dt)



                Catch ex As Exception

                Finally
                    SQLConnection.Close()
                End Try

            End SyncLock
        Catch ex As Exception

        End Try

    End Sub
End Class
