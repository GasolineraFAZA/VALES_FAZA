Imports System.Data
Imports System.Data.SqlClient

Public Class FrmLoginForm


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim cnn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader

        Try
            cnn.ConnectionString = "server=FAZASERVER\SQLEXPRESS;database=vales_faza;user id= sa; password= faza.2014"
            cnn.Open()
            Dim sql As String

            sql = "Select * from Usuarios where usuario='" & TxtUsername.Text & "' and password='" & TxtPassword.Text & "'"
            cmd = New SqlCommand(sql, cnn)
            da.SelectCommand = cmd
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                NomUsuario = TxtUsername.Text

                MenuGrupoFaza.Show()

                Me.Hide()
            Else
                MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Information)

            End If
            cnn.Close()



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

   
End Class
