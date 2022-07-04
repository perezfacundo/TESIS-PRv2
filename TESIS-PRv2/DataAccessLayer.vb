Imports System.Data.SqlClient

Public Class DataAccessLayer

    Dim conn As SqlConnection = New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TESIS-PRv2;Data Source=DESKTOP-KVJJO39\SQLEXPRESS")

    Public Sub InsertarCliente(Cli As Cliente)

        Try
            conn.Open()
            Dim consulta As String = $"INSERT INTO Clientes (dniCliente, apellidos, nombres, fechaNac, telefono, domicilio, idEstado, clave, correo, idProvincia, idLocalidad, idTipoRegistro)
                                        VALUES (@dniCliente, @apellidos, @nombres, @fechaNac, @telefono, @domicilio, @idEstado, @clave, @correo, @idProvincia, @idLocalidad, @idTipoRegistro)"

            Dim dniCliente As SqlParameter = New SqlParameter("@dniCliente", Cli.DniCliente)
            Dim apellidos As SqlParameter = New SqlParameter("@apellidos", Cli.Apellidos)
            Dim nombres As SqlParameter = New SqlParameter("@nombres", Cli.Nombres)
            Dim fechaNac As SqlParameter = New SqlParameter("@fechaNac", Cli.FechaNac)
            Dim telefono As SqlParameter = New SqlParameter("@telefono", Cli.Telefono)
            Dim domicilio As SqlParameter = New SqlParameter("@domicilio", Cli.Domicilio)
            Dim idEstado As SqlParameter = New SqlParameter("@idEstado", Cli.IdEstado)
            Dim clave As SqlParameter = New SqlParameter("@clave", Cli.Clave)
            Dim correo As SqlParameter = New SqlParameter("@correo", Cli.Correo)
            Dim idProvincia As SqlParameter = New SqlParameter("@idProvincia", Cli.IdProvincia)
            Dim idLocalidad As SqlParameter = New SqlParameter("@idLocalidad", Cli.IdLocalidad)
            Dim idTipoRegistro As SqlParameter = New SqlParameter("@idTipoRegistro", Cli.IdTipoRegistro)

            Dim command As SqlCommand = New SqlCommand(consulta, conn)

            command.Parameters.Add(dniCliente)
            command.Parameters.Add(apellidos)
            command.Parameters.Add(nombres)
            command.Parameters.Add(fechaNac)
            command.Parameters.Add(telefono)
            command.Parameters.Add(domicilio)
            command.Parameters.Add(idEstado)
            command.Parameters.Add(clave)
            command.Parameters.Add(correo)
            command.Parameters.Add(idProvincia)
            command.Parameters.Add(idLocalidad)
            command.Parameters.Add(idTipoRegistro)

            command.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine("Ocurrio un error al grabar el registro")
        Finally
            conn.Close()
        End Try
    End Sub

End Class
