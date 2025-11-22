Public Class Form1
    Dim a As String
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox2.Text
        Dim middle As String
        middle = a.Substring(0, 5)
        TextBox4.Text = middle

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "mohsenh "
        TextBox2.Text = "salim "
        TextBox3.Text = "mubarak "
        TextBox4.Text = TextBox1.Text & TextBox2.Text & TextBox3.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = TextBox3.Text
        Dim cleanstr As String
        cleanstr = a.Remove(0, 7)
        TextBox4.Text = cleanstr + TextBox1.Text & TextBox2.Text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = TextBox1.Text
        Dim newstr As String
        newstr = a.Insert(0, "soona ")
        TextBox4.Text = newstr + TextBox2.Text & TextBox3.Text

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
