Public Class OrdenaMayMen



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)

        If a > b And a > c Then GoTo mayor_a Else GoTo mayor_b
mayor_a:
        Label1.Text = a
        GoTo MedioA
mayor_b:
        If b > a And b > c Then GoTo mayor_b2 Else GoTo mayor_c
mayor_b2:
        Label1.Text = b
        GoTo MedioB
mayor_c:
        If c > a And c > b Then GoTo mayor_c2
mayor_c2:
        Label1.Text = c
        GoTo MedioC
MedioA:
        If b > c Then GoTo medio_b Else GoTo medio_c
medio_b:
        Label2.Text = b
        Label3.Text = c
        GoTo Fin
medio_c:
        Label2.Text = c
        Label3.Text = b
        GoTo Fin

MedioB:
        If a > c Then GoTo medio_a Else GoTo medio_c2
medio_a:
        Label2.Text = a
        Label3.Text = c
        GoTo Fin
medio_c2:
        Label2.Text = c
        Label3.Text = a
        GoTo Fin
MedioC:
        If a > b Then GoTo medio_a2 Else GoTo medio_b2
medio_a2:
        Label2.Text = a
        Label3.Text = b
        GoTo Fin
medio_b2:
        Label2.Text = b
        Label3.Text = a
        GoTo Fin

Fin:
    End Sub

End Class


