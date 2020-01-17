Public Class Form1
    Dim numbers() As String
    Dim operators() As String
    Dim counter As Integer = -1
    Dim check As Boolean = False
    Dim dot As Boolean = False
    Dim sign As Boolean = True
    Dim memory As String

    Private Sub memClear_Click(sender As Object, e As EventArgs) Handles memClear.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub memAll_Click(sender As Object, e As EventArgs) Handles memAll.Click

    End Sub

    Private Sub memSave_Click(sender As Object, e As EventArgs) Handles memSave.Click

    End Sub

    Private Sub memMinus_Click(sender As Object, e As EventArgs) Handles memMinus.Click

    End Sub

    Private Sub memPlus_Click(sender As Object, e As EventArgs) Handles memPlus.Click

    End Sub

    Private Sub memRestore_Click(sender As Object, e As EventArgs) Handles memRestore.Click

    End Sub
    Private Sub percentButton_Click(sender As Object, e As EventArgs) Handles percentButton.Click

    End Sub

    Private Sub clearEntryButton_Click(sender As Object, e As EventArgs) Handles clearEntryButton.Click
        botTextBox.Text = "0"

        check = False
        dot = False
    End Sub

    Private Sub clearAllButton_Click(sender As Object, e As EventArgs) Handles clearAllButton.Click
        topTextBox.Text = ""
        botTextBox.Text = "0"

        counter = -1
        check = False
        dot = False
    End Sub

    Private Sub reciprocalButton_Click(sender As Object, e As EventArgs) Handles reciprocalButton.Click
        Dim expression As String = "1/" + botTextBox.Text
        Dim result = New DataTable().Compute(expression, Nothing)

        topTextBox.Text = "1/(" + botTextBox.Text + ")"
        botTextBox.Text = result

        check = True
    End Sub

    Private Sub sqButton_Click(sender As Object, e As EventArgs) Handles sqButton.Click
        Dim expression As String = botTextBox.Text + "*" + botTextBox.Text
        Dim result = New DataTable().Compute(expression, Nothing)

        topTextBox.Text = "sqr(" + botTextBox.Text + ")"
        botTextBox.Text = result

        check = True
    End Sub

    Private Sub sqrtButton_Click(sender As Object, e As EventArgs) Handles sqrtButton.Click
        Dim result As Double
        Dim returnValue As Boolean = Double.TryParse(botTextBox.Text, result)

        topTextBox.Text = "sqrt(" + botTextBox.Text + ")"
        botTextBox.Text = Math.Sqrt(result)

        check = True
    End Sub

    Private Sub divButton_Click(sender As Object, e As EventArgs) Handles divButton.Click
        counter += 1
        ReDim numbers(counter)
        ReDim operators(counter)
        numbers(counter) = botTextBox.Text
        operators(counter) = "/"
        topTextBox.Text += numbers(counter) + " " + operators(counter) + " "

        check = True
        dot = False
    End Sub

    Private Sub sevenButton_Click(sender As Object, e As EventArgs) Handles sevenButton.Click
        If botTextBox.Text = "0" Or check = True Then
            botTextBox.Text = "7"
        Else
            botTextBox.Text += "7"
        End If

        check = False
    End Sub

    Private Sub eightButton_Click(sender As Object, e As EventArgs) Handles eightButton.Click
        If botTextBox.Text = "0" Or check = True Then
            botTextBox.Text = "8"
        Else
            botTextBox.Text += "8"
        End If

        check = False
    End Sub

    Private Sub nineButton_Click(sender As Object, e As EventArgs) Handles nineButton.Click
        If botTextBox.Text = "0" Or check = True Then
            botTextBox.Text = "9"
        Else
            botTextBox.Text += "9"
        End If

        check = False
    End Sub

    Private Sub multButton_Click(sender As Object, e As EventArgs) Handles multButton.Click
        counter += 1
        ReDim numbers(counter)
        ReDim operators(counter)
        numbers(counter) = botTextBox.Text
        operators(counter) = "*"
        topTextBox.Text += numbers(counter) + " " + operators(counter) + " "

        check = True
        dot = False
    End Sub

    Private Sub fourButton_Click(sender As Object, e As EventArgs) Handles fourButton.Click
        If botTextBox.Text = "0" Or check = True Then
            botTextBox.Text = "4"
        Else
            botTextBox.Text += "4"
        End If

        check = False
    End Sub
    Private Sub fiveButton_Click(sender As Object, e As EventArgs) Handles fiveButton.Click
        If botTextBox.Text = "0" Or check = True Then
            botTextBox.Text = "5"
        Else
            botTextBox.Text += "5"
        End If

        check = False
    End Sub

    Private Sub sixButton_Click(sender As Object, e As EventArgs) Handles sixButton.Click
        If botTextBox.Text = "0" Or check = True Then
            botTextBox.Text = "6"
        Else
            botTextBox.Text += "6"
        End If

        check = False
    End Sub

    Private Sub subButton_Click(sender As Object, e As EventArgs) Handles subButton.Click
        counter += 1
        ReDim numbers(counter)
        ReDim operators(counter)
        numbers(counter) = botTextBox.Text
        operators(counter) = "-"
        topTextBox.Text += numbers(counter) + " " + operators(counter) + " "

        check = True
        dot = False
    End Sub

    Private Sub oneButton_Click(sender As Object, e As EventArgs) Handles oneButton.Click
        If botTextBox.Text = "0" Or check = True Then
            botTextBox.Text = "1"
        Else
            botTextBox.Text += "1"
        End If

        check = False
    End Sub

    Private Sub twoButton_Click(sender As Object, e As EventArgs) Handles twoButton.Click
        If botTextBox.Text = "0" Or check = True Then
            botTextBox.Text = "2"
        Else
            botTextBox.Text += "2"
        End If

        check = False
    End Sub
    Private Sub threeButton_Click(sender As Object, e As EventArgs) Handles threeButton.Click
        If botTextBox.Text = "0" Or check = True Then
            botTextBox.Text = "3"
        Else
            botTextBox.Text += "3"
        End If

        check = False
    End Sub

    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        counter += 1
        ReDim numbers(counter)
        ReDim operators(counter)
        numbers(counter) = botTextBox.Text
        operators(counter) = "+"
        topTextBox.Text += numbers(counter) + " " + operators(counter) + " "

        check = True
        dot = False
    End Sub
    Private Sub plmnButton_Click(sender As Object, e As EventArgs) Handles plmnButton.Click
        If sign = True Then
            botTextBox.Text = "-" + botTextBox.Text
            sign = False
        ElseIf sign = False Then
            botTextBox.Text = botTextBox.Text.Replace("-", "")
            sign = True
        End If
    End Sub

    Private Sub zeroButton_Click(sender As Object, e As EventArgs) Handles zeroButton.Click
        If botTextBox.Text = "0" Or check = True Then
            botTextBox.Text = "0"
        Else
            botTextBox.Text += "0"
        End If

        check = False
    End Sub

    Private Sub dotButton_Click(sender As Object, e As EventArgs) Handles dotButton.Click
        If check = True Then
            botTextBox.Text = "0."
            dot = True
        ElseIf botTextBox.Text = "0" Or dot = False Then
            botTextBox.Text += "."
            dot = True
        End If

        check = False
    End Sub

    Private Sub equalButton_Click(sender As Object, e As EventArgs) Handles equalButton.Click
        Dim expression As String = topTextBox.Text + botTextBox.Text
        Dim result = New DataTable().Compute(expression, Nothing)

        topTextBox.Text = expression + " = "
        botTextBox.Text = result

        check = True
    End Sub

End Class
