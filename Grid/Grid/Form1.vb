Public Class Form1
    Dim canvas As Bitmap
    Dim canvaspen, formpen As Graphics

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        canvas = New Bitmap(Me.Width, Me.Height)
        canvaspen = Graphics.FromImage(canvas)
        formpen = Me.CreateGraphics

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        canvaspen.Clear(Color.Black)
        For y = 0 To 900 Step 50
            canvaspen.FillRectangle(Brushes.Red, 0, y, Me.ClientSize.Width, 1)
            canvaspen.DrawString(y, New Font("Tahoma", 10, FontStyle.Regular), Brushes.White, 0, y)
        Next

        For x = 0 To 1500 Step 50
            canvaspen.FillRectangle(Brushes.Red, x, 0, 1, Me.ClientSize.Height)
            canvaspen.DrawString(x, New Font("Tahoma", 10, FontStyle.Regular), Brushes.White, x, 0)
        Next
        canvaspen.FillRectangle(Brushes.Blue, 0, Me.ClientSize.Height - 25, Me.ClientSize.Width, 25)



        formpen.DrawImage(canvas, 0, 0)
    End Sub
End Class
