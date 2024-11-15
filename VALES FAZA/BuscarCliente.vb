Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports EncriptarDesencriptar

Public Class FrmBuscarCliente
    Dim strconexion As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TxtTextoBuscar.Text = ""
        CboBuscarEn.Items.Clear()


        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If CboBuscarEn.Text = "Nombre" Then
                Dim cnn As New SqlConnection
                Dim com As New SqlCommand
                Dim com2 As New SqlCommand
                Dim datos As New DataSet

                cnn.ConnectionString = strconexion
                cnn.Open()

                com2.Connection = cnn
                com2.CommandText = "select IdCliente,Num_cliente,Nombre_cliente,Tipo_cliente,Codigo1,Codigo2,Codigo3,Codigo4,Codigo5,Codigo6,Codigo7,Codigo8,Codigo9,Codigo10,Codigo11,Codigo12 from Clientes where Nombre_cliente like '%" & TxtTextoBuscar.Text & "%'"
                Dim base As New SqlDataAdapter(com2)
                base.Fill(datos)
                frmMenu.DgvGeneral.DataSource = datos.Tables(0)
                cnn.Close()
                frmMenu.DgvGeneral.Columns(0).Visible = False
                frmMenu.DgvGeneral.Columns(1).HeaderText = "Numero de cliente"
                frmMenu.DgvGeneral.Columns(2).HeaderText = "Nombre del cliente"
                frmMenu.DgvGeneral.Columns(3).HeaderText = "Tipo de cliente"
                frmMenu.DgvGeneral.Columns(4).Visible = False
                frmMenu.DgvGeneral.Columns(5).Visible = False
                frmMenu.DgvGeneral.Columns(6).Visible = False
                frmMenu.DgvGeneral.Columns(7).Visible = False
                frmMenu.DgvGeneral.Columns(8).Visible = False
                frmMenu.DgvGeneral.Columns(9).Visible = False
                frmMenu.DgvGeneral.Columns(10).Visible = False
                frmMenu.DgvGeneral.Columns(11).Visible = False
                frmMenu.DgvGeneral.Columns(12).Visible = False
                frmMenu.DgvGeneral.Columns(13).Visible = False
                frmMenu.DgvGeneral.Columns(14).Visible = False
                frmMenu.DgvGeneral.Columns(15).Visible = False
            End If

            If CboBuscarEn.Text = "Numero" Then
                Dim cnn As New SqlConnection
                Dim com As New SqlCommand
                Dim com2 As New SqlCommand
                Dim datos As New DataSet

                cnn.ConnectionString = strconexion
                cnn.Open()

                com2.Connection = cnn
                com2.CommandText = "select IdCliente,Num_cliente,Nombre_cliente,Tipo_cliente,Codigo1,Codigo2,Codigo3,Codigo4,Codigo5,Codigo6,Codigo7,Codigo8,Codigo9,Codigo10,Codigo11,Codigo12 from Clientes where Num_cliente='" & TxtTextoBuscar.Text & "'"
                Dim base As New SqlDataAdapter(com2)
                base.Fill(datos)
                frmMenu.DgvGeneral.DataSource = datos.Tables(0)
                cnn.Close()
                frmMenu.DgvGeneral.Columns(0).Visible = False
                frmMenu.DgvGeneral.Columns(1).HeaderText = "Numero de cliente"
                frmMenu.DgvGeneral.Columns(2).HeaderText = "Nombre del cliente"
                frmMenu.DgvGeneral.Columns(3).HeaderText = "Tipo de cliente"
                frmMenu.DgvGeneral.Columns(4).Visible = False
                frmMenu.DgvGeneral.Columns(5).Visible = False
                frmMenu.DgvGeneral.Columns(6).Visible = False
                frmMenu.DgvGeneral.Columns(7).Visible = False
                frmMenu.DgvGeneral.Columns(8).Visible = False
                frmMenu.DgvGeneral.Columns(9).Visible = False
                frmMenu.DgvGeneral.Columns(10).Visible = False
                frmMenu.DgvGeneral.Columns(11).Visible = False
                frmMenu.DgvGeneral.Columns(12).Visible = False
                frmMenu.DgvGeneral.Columns(13).Visible = False
                frmMenu.DgvGeneral.Columns(14).Visible = False
                frmMenu.DgvGeneral.Columns(15).Visible = False
            End If
            TxtTextoBuscar.Text = ""
            CboBuscarEn.Items.Clear()






            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmBuscarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CboBuscarEn.Items.Add("Nombre")
        CboBuscarEn.Items.Add("Numero")

        Dim EncrDesencr As New EncriptacionDescencriptacion
        strconexion = EncrDesencr.Decrypt(ConfigurationManager.ConnectionStrings("VALES_FAZA").ConnectionString)
    End Sub
End Class