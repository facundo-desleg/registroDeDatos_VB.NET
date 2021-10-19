Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Private Sub TexFecha_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True

            Texmail.Focus()
        End If
    End Sub

    Private Sub Butaceptar_Click(sender As Object, e As EventArgs) Handles Butaceptar.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=C:\Registro_Datos\Base_Datos\bd_Regis.mdb")
        con.Open()
        Dim consulta As String = "insert  into Registro(Num_Cliente,Nombre,Apellido,Edad,Direccion,Fecha_Nacimiento,Mail)values('" & TexCliente.Text & "','" & TexNombre.Text & "','" & TexApellido.Text & "','" & Texedad.Text & "','" & Texdireccion.Text & "','" & DateFecha.Text & "', '" & Texmail.Text & "')"

        Dim COMANDO As New OleDbCommand(consulta, con)
        Dim DR As OleDbDataReader = COMANDO.ExecuteReader
        DR.Close()
        con.Close()

        MsgBox("Datos Guardados", vbCritical)
        Call Blanquea()


    End Sub
    Private Sub Blanquea()
        TexCliente.Text = ""
        TexNombre.Text = ""
        TexApellido.Text = ""
        Texedad.Text = ""
        Texdireccion.Text = ""
        DateFecha.Text = ""
        Texmail.Text = ""

        TexNombre.Focus()
    End Sub

    Private Sub Texnombre_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TexNombre.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            TexApellido.Focus()

        End If
    End Sub

    Private Sub Texapellido_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TexApellido.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Texdireccion.Focus()

        End If
    End Sub

    Private Sub DateFecha_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.ToString = Convert.ToDateTime(Keys.Return) Then
            e.Handled = True
            Texmail.Focus()
        End If
    End Sub

    Private Sub Texmail_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Texmail.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            TexNombre.Focus()

        End If
    End Sub

    Private Sub Butcancelar_Click(sender As Object, e As EventArgs) Handles Butcancelar.Click
        Call Blanquea()
    End Sub

    Private Sub Texedad_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Texedad.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            DateFecha.Focus()
        End If
    End Sub

    Private Sub Texcliente_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TexCliente.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            TexNombre.Show()
            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                e.Handled = True
                TexNombre.Focus()
            End If
        End If
    End Sub

    Private Sub Texdireccion_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Texdireccion.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Texedad.Focus()
        End If
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        MsgBox("Indique su Numero de Usuario", vbCritical)
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MsgBox("Indique su Nombre", vbCritical)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MsgBox("Indique su Apellido", vbCritical)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        MsgBox("Indique su Dirección de su casa", vbCritical)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("Indique su Edad", vbCritical)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MsgBox("Indique su Fecha de Nacimiento", vbCritical)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        MsgBox("Indique su Mail", vbCritical)
    End Sub

End Class
'\Users\facunz\Source