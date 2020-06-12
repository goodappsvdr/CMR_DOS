Imports CMR_DOS.AD
Imports System.IO



Public Class FrmGenerador

    Private Sub FrmGeneradorClases_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        TraerTablas()
        TraerColumnas(CboTablas.SelectedValue)

    End Sub
 

    Private Sub TraerTablas()

        Dim oDs As New DataSet
        Dim oSistema As New Sistemas

        oDs = oSistema.TraerTablas

        CboTablas.DataSource = oDs.Tables(0)
        CboTablas.DisplayMember = oDs.Tables(0).Columns(0).Caption.ToString
        CboTablas.ValueMember = oDs.Tables(0).Columns(0).Caption.ToString

    End Sub



    Private Sub TraerColumnas(ByVal Tabla As String)

        LstColumnasClave.Items.Clear()
        LstColumnas.Items.Clear()

        Dim oDs As New DataSet
        Dim oSistema As New Sistemas

        oDs = oSistema.TraerColumnas(Tabla)

        For i = 0 To oDs.Tables(0).Rows.Count - 1

            If CBool(oDs.Tables(0).Rows(i).Item("is_Identity")) = True Then

                LstColumnasClave.Items.Add(oDs.Tables(0).Rows(i).Item("name"), True)
                LstColumnas.Items.Add(oDs.Tables(0).Rows(i).Item("name"), False)

            Else

                LstColumnasClave.Items.Add(oDs.Tables(0).Rows(i).Item("name"), False)
                LstColumnas.Items.Add(oDs.Tables(0).Rows(i).Item("name"), False)

            End If


        Next


    End Sub

    Private Sub CboTablas_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboTablas.SelectionChangeCommitted
        TraerColumnas(CboTablas.SelectedValue)
    End Sub


    Private Sub CmdGenerar_Click(sender As System.Object, e As System.EventArgs) Handles CmdGenerar.Click

        Dim oDs As New DataSet
        Dim oSistema As New Sistemas


        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        If (Not System.IO.Directory.Exists(mydocpath + "\Clases")) Then
            System.IO.Directory.CreateDirectory(mydocpath + "\Clases")
        End If



        If System.IO.File.Exists(mydocpath & "\Clases\" + CboTablas.SelectedValue + ".vb") = True Then

            System.IO.File.Delete(mydocpath & "\Clases\" + CboTablas.SelectedValue + ".vb")

        End If


        Using outputFile As New StreamWriter(mydocpath & Convert.ToString("\Clases\" + CboTablas.SelectedValue + ".vb"), True)

            'Cabecera
            outputFile.WriteLine("Imports Microsoft.VisualBasic")
            outputFile.WriteLine("Imports System.Data")
            outputFile.WriteLine("Imports System.Data.SqlClient")
            outputFile.WriteLine("Imports System.IO")
            outputFile.WriteLine("Imports Microsoft.Practices.EnterpriseLibrary.Data")
            outputFile.WriteLine("")
            outputFile.WriteLine("'*************************************************************************************************")
            outputFile.WriteLine("'Clase Generada por IDEAS SA")
            outputFile.WriteLine("'*************************************************************************************************")
            outputFile.WriteLine("")

            'Abro la Clase
            outputFile.WriteLine("Public Class " + CboTablas.SelectedValue)
            outputFile.WriteLine("")
            outputFile.WriteLine("Dim oDatabase As Database")
            outputFile.WriteLine("")
            outputFile.WriteLine("Public Sub New()")
            outputFile.WriteLine("")
            outputFile.WriteLine("oDatabase = DatabaseFactory.CreateDatabase(" & Chr(34) & "Conn" & Chr(34) & ")")
            outputFile.WriteLine("")
            outputFile.WriteLine("End Sub")
            outputFile.WriteLine("")


            outputFile.WriteLine("Public Sub New(ByVal str As String)")
            outputFile.WriteLine("End Sub")
            outputFile.WriteLine("")

            'Buscar por ID

            For i = 0 To LstColumnasClave.Items.Count - 1

                If CBool(LstColumnasClave.GetItemCheckState(i)) = True Then

                    oDs = oSistema.TraerColumna(CboTablas.SelectedValue, LstColumnasClave.Items(i).ToString())

                    outputFile.WriteLine("Public Function BuscarPorID(ByVal " + LstColumnasClave.Items(i).ToString() + " As " + TraerTipoDato(oDs.Tables(0).Rows(0).Item("system_type_id")) + ") As DataSet")
                    outputFile.WriteLine("Try")
                    outputFile.WriteLine("Return oDatabase.ExecuteDataSet(" & Chr(34) & CboTablas.SelectedValue & "_BuscarPorID" & Chr(34) & "," & LstColumnasClave.Items(i).ToString() & ")")
                    outputFile.WriteLine("Catch ex As System.Exception")
                    outputFile.WriteLine("Throw ex")
                    outputFile.WriteLine("End Try")
                    outputFile.WriteLine("End Function")
                    outputFile.WriteLine("")

                End If

            Next


            'BuscarTodos
            outputFile.WriteLine("")
            outputFile.WriteLine("Public Function BuscarTodos() As DataSet")
            outputFile.WriteLine("Try")
            outputFile.WriteLine(" Return oDatabase.ExecuteDataSet(" & Chr(34) & CboTablas.SelectedValue & "_BuscarTodos" & Chr(34) & ")")
            outputFile.WriteLine("Catch ex As System.Exception")
            outputFile.WriteLine("Throw ex")
            outputFile.WriteLine("End Try")
            outputFile.WriteLine("End Function")
            outputFile.WriteLine("")

            'Buscar por los diferentes campos seleccionados

            For i = 0 To LstColumnas.Items.Count - 1

                If CBool(LstColumnas.GetItemCheckState(i)) = True Then

                    oDs = oSistema.TraerColumna(CboTablas.SelectedValue, LstColumnas.Items(i).ToString())

                    outputFile.WriteLine("Public Function BuscarPor" & LstColumnas.Items(i).ToString() & "(ByVal " + LstColumnas.Items(i).ToString() + " As " + TraerTipoDato(oDs.Tables(0).Rows(0).Item("system_type_id")) + ") As DataSet")
                    outputFile.WriteLine("Try")
                    outputFile.WriteLine("Return oDatabase.ExecuteDataSet(" & Chr(34) & CboTablas.SelectedValue & "_BuscarPor" & LstColumnas.Items(i).ToString() & Chr(34) & "," & LstColumnasClave.Items(i).ToString() & ")")
                    outputFile.WriteLine("Catch ex As System.Exception")
                    outputFile.WriteLine("Throw ex")
                    outputFile.WriteLine("End Try")
                    outputFile.WriteLine("End Function")
                    outputFile.WriteLine("")

                End If

            Next


            'Insert

            Dim Cadena As String
            Dim Parametros As String

            Cadena = "ByVal "
            Parametros = ","

            oDs = oSistema.TraerColumnas(CboTablas.SelectedValue)

            For i = 1 To oDs.Tables(0).Rows.Count - 1

                Cadena = Cadena + oDs.Tables(0).Rows(i).Item("Name") + " As " + TraerTipoDato(oDs.Tables(0).Rows(i).Item("system_type_id"))
                Parametros = Parametros + oDs.Tables(0).Rows(i).Item("Name")

                If i < oDs.Tables(0).Rows.Count - 1 Then

                    Cadena = Cadena + ",ByVal "
                    Parametros = Parametros + ","

                Else

                    Cadena = Cadena + ") as Double"
                    Parametros = Parametros + ")"

                End If


            Next


            outputFile.WriteLine("Public Function Agregar(" & Cadena)
            outputFile.WriteLine("Try")
            outputFile.WriteLine("Return oDatabase.ExecuteScalar(" & Chr(34) & CboTablas.SelectedValue & "_Agregar" & Chr(34) & Parametros)
            outputFile.WriteLine("Catch ex As System.Exception")
            outputFile.WriteLine("Throw ex")
            outputFile.WriteLine("End Try")
            outputFile.WriteLine("End Function")
            outputFile.WriteLine("")





            'Update

            Cadena = "ByVal "
            Parametros = ","

            oDs = oSistema.TraerColumnas(CboTablas.SelectedValue)

            For i = 0 To oDs.Tables(0).Rows.Count - 1

                Cadena = Cadena + oDs.Tables(0).Rows(i).Item("Name") + " As " + TraerTipoDato(oDs.Tables(0).Rows(i).Item("system_type_id"))
                Parametros = Parametros + oDs.Tables(0).Rows(i).Item("Name")

                If i < oDs.Tables(0).Rows.Count - 1 Then

                    Cadena = Cadena + ",ByVal "
                    Parametros = Parametros + ","

                Else

                    Cadena = Cadena + ") as Dataset"
                    Parametros = Parametros + ")"

                End If


            Next


            outputFile.WriteLine("Public Function Modificar(" & Cadena)
            outputFile.WriteLine("Try")
            outputFile.WriteLine("Return oDatabase.ExecuteDataSet(" & Chr(34) & CboTablas.SelectedValue & "_Modificar" & Chr(34) & Parametros)
            outputFile.WriteLine("Catch ex As System.Exception")
            outputFile.WriteLine("Throw ex")
            outputFile.WriteLine("End Try")
            outputFile.WriteLine("End Function")
            outputFile.WriteLine("")

            'Cierro la Clase
            outputFile.WriteLine("End Class")


        End Using


        MsgBox("Clase " + CboTablas.SelectedValue + " generada correctamente, los archivos se guardaron en Mis Documentos, carpeta Clases.", vbInformation, "IDEAS SA")


    End Sub


    Public Function TraerTipoDato(ByVal Nro As Integer) As String

        Select Case Nro

            Case 56
                Return "Integer"
            Case 127
                Return "Double"
            Case 52
                Return "Integer"
            Case 61
                Return "Date"
            Case 60
                Return "Double"
            Case 167
                Return "String"
            Case 104
                Return "Boolean"
            Case Else
                Return "String"
        End Select

    End Function


    Public Function TraerTipoDatoSQL(ByVal Nro As Integer) As String

        Select Case Nro

            Case 56
                Return "int"
            Case 127
                Return "money"
            Case 52
                Return "int"
            Case 61
                Return "datetime"
            Case 60
                Return "money"
            Case 167
                Return "varchar(50)"
            Case 104
                Return "bit"
            Case Else
                Return "varchar(50)"
        End Select

    End Function


    Private Sub Cmd_SP_Click(sender As System.Object, e As System.EventArgs) Handles Cmd_SP.Click

        Dim oDs As New DataSet
        Dim oSistema As New Sistemas


        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        If (Not System.IO.Directory.Exists(mydocpath + "\Procedimientos Almacenados")) Then
            System.IO.Directory.CreateDirectory(mydocpath + "\Procedimientos Almacenados")
        End If



        If System.IO.File.Exists(mydocpath & "\Procedimientos Almacenados\" + CboTablas.SelectedValue + ".sql") = True Then

            System.IO.File.Delete(mydocpath & "\Procedimientos Almacenados\" + CboTablas.SelectedValue + ".sql")

        End If


        Using outputFile As New StreamWriter(mydocpath & Convert.ToString("\Procedimientos Almacenados\" + CboTablas.SelectedValue + ".sql"), True)


            outputFile.WriteLine("--*************************************************************************************************")
            outputFile.WriteLine("--Query generado por IDEAS SA")
            outputFile.WriteLine("--*************************************************************************************************")
            outputFile.WriteLine("")

            'INSERT
            outputFile.WriteLine("--INSERTAR")
            outputFile.WriteLine("")
            outputFile.WriteLine("CREATE PROCEDURE " + CboTablas.SelectedValue + "_Agregar")

            oDs = oSistema.TraerColumnas(CboTablas.SelectedValue)

            Dim Cadena As String
            Dim CadenaParametro As String
            Dim Parametros As String

            Cadena = "@"
            Parametros = ""
            CadenaParametro = "@"

            For i = 1 To oDs.Tables(0).Rows.Count - 1

                Cadena = Cadena + oDs.Tables(0).Rows(i).Item("name") + " " + TraerTipoDatoSQL(oDs.Tables(0).Rows(i).Item("system_type_id"))
                Parametros = Parametros + oDs.Tables(0).Rows(i).Item("name")
                CadenaParametro = CadenaParametro + oDs.Tables(0).Rows(i).Item("name")

                If i < oDs.Tables(0).Rows.Count - 1 Then
                    Cadena = Cadena + "," + vbCrLf + "@"
                    CadenaParametro = CadenaParametro + "," + vbCrLf + "@"
                    Parametros = Parametros + "," + vbCrLf
                End If


            Next

            outputFile.WriteLine(Cadena)
            outputFile.WriteLine("AS")

            outputFile.WriteLine("INSERT INTO " + CboTablas.SelectedValue + "(")
            outputFile.WriteLine(Parametros + ")")
            outputFile.WriteLine("VALUES")
            outputFile.WriteLine("(" + CadenaParametro + ")")
            outputFile.WriteLine("SELECT @@Identity")

            outputFile.WriteLine("")

            outputFile.WriteLine("GO")

            'UPDATE

            outputFile.WriteLine("--MODIFICAR")

            outputFile.WriteLine("")


            outputFile.WriteLine("CREATE PROCEDURE " + CboTablas.SelectedValue + "_Modificar")

            oDs = oSistema.TraerColumnas(CboTablas.SelectedValue)

            Cadena = "@"
            Parametros = ""

            For i = 0 To oDs.Tables(0).Rows.Count - 1

                Cadena = Cadena + oDs.Tables(0).Rows(i).Item("name") + " " + TraerTipoDatoSQL(oDs.Tables(0).Rows(i).Item("system_type_id"))

                If i < oDs.Tables(0).Rows.Count - 1 Then
                    Cadena = Cadena + "," + vbCrLf + "@"
                End If


            Next

            outputFile.WriteLine(Cadena)
            outputFile.WriteLine("AS")

            outputFile.WriteLine("UPDATE " + CboTablas.SelectedValue + " SET")



            For i = 1 To oDs.Tables(0).Rows.Count - 1

                Parametros = Parametros + oDs.Tables(0).Rows(i).Item("name") + "= @" + oDs.Tables(0).Rows(i).Item("name")

                If i < oDs.Tables(0).Rows.Count - 1 Then
                    Parametros = Parametros + "," + vbCrLf
                End If


            Next

            outputFile.WriteLine(Parametros)
            outputFile.WriteLine("WHERE " + oDs.Tables(0).Rows(0).Item("name") + "= @" + oDs.Tables(0).Rows(0).Item("name"))
            outputFile.WriteLine("")

            outputFile.WriteLine("GO")


            'BUSCAR TODOS

            outputFile.WriteLine("--BUSCAR TODOS")
            outputFile.WriteLine("")
            outputFile.WriteLine("CREATE PROCEDURE " + CboTablas.SelectedValue + "_BuscarTodos")
            outputFile.WriteLine("AS")
            outputFile.WriteLine("SELECT")


            oDs = oSistema.TraerColumnas(CboTablas.SelectedValue)

            Cadena = ""

            For i = 0 To oDs.Tables(0).Rows.Count - 1

                Cadena = Cadena + oDs.Tables(0).Rows(i).Item("name")

                If i < oDs.Tables(0).Rows.Count - 1 Then
                    Cadena = Cadena + "," + vbCrLf
                End If


            Next

            outputFile.WriteLine(Cadena)
            outputFile.WriteLine("FROM " + CboTablas.SelectedValue)
            outputFile.WriteLine("Return @@rowcount")
            outputFile.WriteLine("")

            outputFile.WriteLine("GO")


            'BUSCAR POR ID

            outputFile.WriteLine("--BUSCAR POR ID")
            outputFile.WriteLine("")

            outputFile.WriteLine("CREATE PROCEDURE " + CboTablas.SelectedValue + "_BuscarPorID")


            oDs = oSistema.TraerColumnas(CboTablas.SelectedValue)

            Cadena = "@" + oDs.Tables(0).Rows(0).Item("name") + " " + TraerTipoDatoSQL(oDs.Tables(0).Rows(0).Item("system_type_id"))
            outputFile.WriteLine(Cadena)
            outputFile.WriteLine("AS")
            outputFile.WriteLine("SELECT")

            Cadena = ""

            For i = 0 To oDs.Tables(0).Rows.Count - 1

                Cadena = Cadena + oDs.Tables(0).Rows(i).Item("name")

                If i < oDs.Tables(0).Rows.Count - 1 Then
                    Cadena = Cadena + "," + vbCrLf
                End If

            Next
            outputFile.WriteLine(Cadena)
            outputFile.WriteLine("FROM " + CboTablas.SelectedValue)
            outputFile.WriteLine("WHERE " + oDs.Tables(0).Rows(0).Item("name") + "=" + "@" + oDs.Tables(0).Rows(0).Item("name"))
            outputFile.WriteLine("Return @@rowcount")
            outputFile.WriteLine("")

            outputFile.WriteLine("GO")


            'BUSCAR POR LOS DISTINTOS CAMPOS SELECCIONADOS

            For i = 0 To LstColumnas.Items.Count - 1


                If CBool(LstColumnas.GetItemCheckState(i)) = True Then

                    oDs = oSistema.TraerColumna(CboTablas.SelectedValue, LstColumnas.Items(i).ToString())


                    outputFile.WriteLine("--BUSCAR POR " + LstColumnas.Items(i).ToString())
                    outputFile.WriteLine("")

                    outputFile.WriteLine("CREATE PROCEDURE " + CboTablas.SelectedValue + "_BuscarPor" + LstColumnas.Items(i).ToString())

                    oDs = oSistema.TraerColumna(CboTablas.SelectedValue, LstColumnas.Items(i).ToString())



                    Cadena = "@" + oDs.Tables(0).Rows(0).Item("name") + " " + TraerTipoDatoSQL(oDs.Tables(0).Rows(0).Item("system_type_id"))
                    outputFile.WriteLine(Cadena)
                    outputFile.WriteLine("AS")
                    outputFile.WriteLine("SELECT")

                    oDs = oSistema.TraerColumnas(CboTablas.SelectedValue)

                    Cadena = ""

                    For j = 0 To oDs.Tables(0).Rows.Count - 1

                        Cadena = Cadena + oDs.Tables(0).Rows(j).Item("name")

                        If j < oDs.Tables(0).Rows.Count - 1 Then
                            Cadena = Cadena + "," + vbCrLf
                        End If

                    Next
                    outputFile.WriteLine(Cadena)
                    outputFile.WriteLine("FROM " + CboTablas.SelectedValue)
                    outputFile.WriteLine("WHERE " + LstColumnas.Items(i).ToString() + "=" + "@" + LstColumnas.Items(i).ToString())
                    outputFile.WriteLine("Return @@rowcount")
                    outputFile.WriteLine("")

                    outputFile.WriteLine("GO")





                End If


            Next


        End Using


        MsgBox("Procedimientos Almacenados para la tabla " + CboTablas.SelectedValue + " fueron generados correctamente, los archivos se guardaron en Mis Documentos, carpeta Procedimientos Almacenados.", vbInformation, "IDEAS SA")



    End Sub
End Class