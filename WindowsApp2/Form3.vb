Imports System.Security.Cryptography
Public Class Form3
    Dim randomnumbers(6) As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub But7_Click(sender As Object, e As EventArgs) Handles But7.Click
        ' Generate 7 random numbers between 1 and 100 (modify min and max as needed )
        For i = 0 To 6
            randomNumbers(i) = CInt(Rnd() * 100) + 1 ' Scale and offset for range 1 to 100

        Next
        ' clear listbox before displaying new data 
        LISTBOX1.Items.Clear()

        ' display unsorted numbers 
        LISTBOX1.Items.Add("unsorted:")
        For i = 0 To 6
            LISTBOX1.Items.Add(randomnumbers(i).ToString())
        Next

        ' Bubble sort logic 
        Dim swapped As Boolean = True ' flag to track if any swaps occured 

        ' loop through the array for mutliple passes 
        Do While swapped
            swapped = False ' Reset flag for each pass 

            ' compare adjacent elements and swap if needed 
            For i = 0 To UBound(randomnumbers) - 1
                If randomnumbers(i) > randomnumbers(i + 1) Then
                    ' swap elements dircetly ( no function needed ) 
                    Dim temp As Integer = randomnumbers(i)
                    randomnumbers(i) = randomnumbers(i + 1)
                    randomnumbers(i + 1) = temp
                    swapped = True ' set flag if a swap happened 


                End If
            Next


        Loop
        ' display sorted numbers 
        LISTBOX1.Items.Add("")
        LISTBOX1.Items.Add("sorted")
        For i = 0 To 6
            LISTBOX1.Items.Add(randomnumbers(i).ToString())





        Next
    End Sub

    Private Sub But8_Click(sender As Object, e As EventArgs) Handles But8.Click
        ' generate random numbers 
        For i = 0 To 6
            randomnumbers(i) = CInt(Rnd() * 100) + 1 ' scale and offset for range 1 to 100 
        Next

        ' clear listbo,x before displaying new data 
        LISTBOX1.Items.Clear()

        'display unsorted numbers 
        LISTBOX1.Items.Add("unsorted")
        For i = 0 To 6
            LISTBOX1.Items.Add(randomnumbers(i).ToString())
        Next

        ' insertion sort logic 
        For i = 1 To 6 ' start from the second element (index 1)
            Dim key As Integer = randomnumbers(i)
            Dim j As Integer = i - 1
            While j >= 0 AndAlso randomnumbers(j) > key
                randomnumbers(j + 1) = randomnumbers(j)
                j -= 1
                If j < 0 Then Exit While ' ensure j doesn't go below 0 

            End While
            randomnumbers(j + 1) = key
        Next

        ' display sorted numbers 
        LISTBOX1.Items.Add("")
        LISTBOX1.Items.Add("sorted:")
        For i = 0 To 6
            LISTBOX1.Items.Add(randomnumbers(i).ToString())

        Next



    End Sub

    Private Sub But9_Click(sender As Object, e As EventArgs) Handles But9.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class