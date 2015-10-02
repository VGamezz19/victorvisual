Public Class Form1

    Dim op1 As Integer
    Dim op2 As Integer
    Dim result As Integer

    Private Sub sumabtm_Click(sender As Object, e As EventArgs) Handles SumaBtn.Click

        op1 = TextBox1.Text       'El op1 es un Integer (numero entero) y TextBox1 es un text. CInt hace la conversion sola para que cumpla la igualdad.  Ejemplo: = CInt(TextBox1.Text)
        op2 = TextBox2.Text       'He quitado el CInt porque VS ya hace la conversion, pero en otros lenguajes no lo hace.

        result = op1 + op2

        Label1.Text = result.ToString() 'ToString hace la misma funcion que el CInt pero alrebes. De entero a texto.
    End Sub

    Private Sub RestaBtn_Click(sender As Object, e As EventArgs) Handles RestaBtn.Click

        op1 = TextBox1.Text
        op2 = TextBox2.Text

        result = op1 - op2

        Label1.Text = result.ToString()
    End Sub
End Class
