Public Class Form1
    Dim intp1 As Integer
    Dim intp2 As Integer
    Dim intp3 As Integer
    Dim intp4 As Integer
    Dim intp5 As Integer
    Dim intc1 As Integer
    Dim intc2 As Integer
    Dim intc3 As Integer
    Dim intdraw As Integer
    Dim intpscore As Integer
    Dim intcscore As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        intp1 = Int(Rnd() * 10 + 1)
        intp2 = Int(Rnd() * 10 + 1)
        intc1 = Int(Rnd() * 10 + 1)
        intc2 = Int(Rnd() * 10 + 1)
        intc3 = Int(Rnd() * 10 + 1)

        Lblp1.Text = intp1
        Lblp2.Text = intp2
        Lblc1.Text = intc1
        Lblc2.Text = intc2
        Lblc3.Text = intc3

        Lblc1.Visible = False
        Lblc2.Visible = False
        Lblc3.Visible = False

        Lblpscore.Text = "___"
        Lblcscore.Text = "___"
        Lblp3.Text = "___"
        Lblp4.Text = "___"
        Lblp5.Text = "___"

        intp3 = 0
        intp4 = 0
        intp5 = 0
        intdraw = 0

    End Sub

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click

        intdraw = intdraw + 1

        If (intdraw = 1) Then
            intp3 = Int(Rnd() * 10 + 1)
            Lblp3.Text = intp3
        ElseIf (intdraw = 2) Then
            intp4 = Int(Rnd() * 10 + 1)
            Lblp4.Text = intp4
        ElseIf (intdraw = 3) Then
            intp5 = Int(Rnd() * 10 + 1)
            Lblp5.Text = intp5
        Else : MessageBox.Show("No more draw cards")
        End If


    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        intpscore = intp1 + intp2 + intp3 + intp4 + intp5
        intcscore = intc1 + intc2 + intc3

        Lblpscore.Text = intpscore
        Lblcscore.Text = intcscore

        Lblc1.Visible = True
        Lblc2.Visible = True
        Lblc3.Visible = True

        If (intpscore > 21 And intcscore > 21) Then
            MessageBox.Show("Bust")
        ElseIf (intpscore = intcscore) Then
            MessageBox.Show("Draw")
        ElseIf (intpscore > 21 And intcscore < 21) Then
            MessageBox.Show("Computer Wins")
        ElseIf (intpscore < 21 And intcscore > 21) Then
            MessageBox.Show("Player Wins")
        ElseIf (intpscore <= 21 And intcscore <= 21 And intpscore > intcscore) Then
            MessageBox.Show("Player Wins")
        ElseIf (intpscore <= 21 And intcscore <= 21 And intcscore > intpscore) Then
            MessageBox.Show("Computer Wins")
        End If

    End Sub

    Private Sub btnPlayAgn_Click(sender As Object, e As EventArgs) Handles btnPlayAgn.Click
        Call Form1_Load(sender, e)
    End Sub
End Class
