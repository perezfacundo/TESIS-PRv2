Imports System.Data.SqlClient

Public Class DataAccessLayer

    Dim conn As SqlConnection = New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TESIS-PRv2;Data Source=DESKTOP-KVJJO39\SQLEXPRESS")

    Public Sub InsertarCliente(objCliente As Cliente)

        Try
            conn.Open()
            Dim consulta As String = $"INSERT INTO Clientes (dniCliente, apellidos, nombres, fechaNac, telefono, domicilio, idEstado, clave, correo, idProvincia, idLocalidad, idTipoRegistro)
                                        VALUES (@dniCliente, @apellidos, @nombres, @fechaNac, @telefono, @domicilio, @idEstado, @clave, @correo, @idProvincia, @idLocalidad, @idTipoRegistro)"

            Dim dniCliente As SqlParameter = New SqlParameter("@dniCliente", objCliente.DniCliente)
            Dim apellidos As SqlParameter = New SqlParameter("@apellidos", objCliente.Apellidos)
            Dim nombres As SqlParameter = New SqlParameter("@nombres", objCliente.Nombres)
            Dim fechaNac As SqlParameter = New SqlParameter("@fechaNac", objCliente.FechaNac)
            Dim telefono As SqlParameter = New SqlParameter("@telefono", objCliente.Telefono)
            Dim domicilio As SqlParameter = New SqlParameter("@domicilio", objCliente.Domicilio)
            Dim idEstado As SqlParameter = New SqlParameter("@idEstado", objCliente.IdEstado)
            Dim clave As SqlParameter = New SqlParameter("@clave", objCliente.Clave)
            Dim correo As SqlParameter = New SqlParameter("@correo", objCliente.Correo)
            Dim idProvincia As SqlParameter = New SqlParameter("@idProvincia", objCliente.IdProvincia)
            Dim idLocalidad As SqlParameter = New SqlParameter("@idLocalidad", objCliente.IdLocalidad)
            Dim idTipoRegistro As SqlParameter = New SqlParameter("@idTipoRegistro", objCliente.IdTipoRegistro)

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
            Debug.WriteLine("ERROR:" & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub InsertarTransporte(objTransporte As Transporte)

        Try
            conn.Open()
            Dim consulta As String = $"INSERT INTO Transportes (patente, marca, modelo, idEstado, capacidad, idTipoRegistro) 
                                              VALUES (@patente, @marca, @modelo, @idEstado, @capacidad, @idTipoRegistro)"

            Dim patente As SqlParameter = New SqlParameter("@patente", objTransporte.Patente)
            Dim marca As SqlParameter = New SqlParameter("@marca", objTransporte.Marca)
            Dim modelo As SqlParameter = New SqlParameter("@modelo", objTransporte.Modelo)
            Dim idEstado As SqlParameter = New SqlParameter("@idEstado", objTransporte.IdEstado)
            Dim capacidad As SqlParameter = New SqlParameter("@capacidad", objTransporte.Capacidad)
            Dim idTipoRegistro As SqlParameter = New SqlParameter("@idTipoRegistro", objTransporte.IdTipoRegistro)

            Dim command As SqlCommand = New SqlCommand(consulta, conn)

            command.Parameters.Add(patente)
            command.Parameters.Add(marca)
            command.Parameters.Add(modelo)
            command.Parameters.Add(idEstado)
            command.Parameters.Add(capacidad)
            command.Parameters.Add(idTipoRegistro)

            command.ExecuteNonQuery()

        Catch ex As Exception
            Debug.WriteLine("ERROR:" & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Public Sub InsertarEmpleado(objEmpleado As Empleado)

        Try
            conn.Open()
            Dim consulta As String = $"INSERT INTO Empleados (dniEmpleado, apellidos, nombres, fechaNac, porcComision, idEstado, clave, correo, idTipoRegistro) 
                                              VALUES (@dniEmpleado, @apellidos, @nombres, @fechaNac, @porcComision, @idEstado, @clave, @correo, @idTipoRegistro)"

            Dim dniEmpleado As New SqlParameter("@dniEmpleado", objEmpleado.DniEmpleado)
            Dim apellidos As New SqlParameter("@apellidos", objEmpleado.Apellidos)
            Dim nombres As New SqlParameter("@nombres", objEmpleado.Nombres)
            Dim fechaNac As New SqlParameter("@fechaNac", objEmpleado.FechaNac)
            Dim porcComision As New SqlParameter("@porcComision", objEmpleado.PorcComision)
            Dim idEstado As New SqlParameter("@idEstado", objEmpleado.IdEstado)
            Dim clave As New SqlParameter("@clave", objEmpleado.Clave)
            Dim correo As New SqlParameter("@correo", objEmpleado.Correo)
            Dim idTipoRegistro As New SqlParameter("@idTipoRegistro", objEmpleado.IdTipoRegistro)

            Dim Command As New SqlCommand(consulta, conn)

            Command.Parameters.Add(dniEmpleado)
            Command.Parameters.Add(apellidos)
            Command.Parameters.Add(nombres)
            Command.Parameters.Add(fechaNac)
            Command.Parameters.Add(porcComision)
            Command.Parameters.Add(idEstado)
            Command.Parameters.Add(clave)
            Command.Parameters.Add(correo)
            Command.Parameters.Add(idTipoRegistro)

            Command.ExecuteNonQuery()

        Catch ex As Exception
            Debug.WriteLine("ERROR:" & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
End Class
