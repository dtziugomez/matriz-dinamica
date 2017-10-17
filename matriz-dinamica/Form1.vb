Public Class Form1
    Dim lblnombre, lblpassword As New Label
    Dim txtNombre, txtpassword As New TextBox
    Dim boton As New Button

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ClientSize = New System.Drawing.Size(272, 182)
        lblnombre.Text = "Nombre"
        lblpassword.Text = "password"
        lblnombre.Location = New Point(16, 16)
        lblpassword.Location = New Point(16, 80)
        txtNombre.Location = New Point(162, 16)
        txtpassword.Location = New Point(162, 80)
        txtpassword.PasswordChar = "*"
        boton.Text = "Login"
        boton.Location = New Point(96, 128)
        lblnombre.Parent = Me
        Me.Controls.Add(txtNombre)
        Me.Controls.AddRange(New Control() {lblpassword, txtpassword, boton})
    End Sub
End Class
