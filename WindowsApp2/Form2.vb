Imports System.Globalization
Imports System.IO

Public Class Form2
    Dim r As StreamReader
    Private Sub Lab2_Click(sender As Object, e As EventArgs) Handles Lab2.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub But3_Click(sender As Object, e As EventArgs) Handles But3.Click
        LISTBOX1.Items.Clear()
        r = New IO.StreamReader("C:\Users\TAYYABA SHAIKH\OneDrive\Desktop\DATA.txt")
        While (r.Peek > -1)
            LISTBOX1.Items.Add(r.ReadLine)


        End While
        r.Close()

    End Sub

    Private Sub But5_Click(sender As Object, e As EventArgs) Handles But5.Click
        Dim target As String = LISTBOX1.Text ' change this to the target string you want to search from

        ' perform the liner search and display the result 
        Dim index As Integer = linearsearch(target)

        If index >= 0 Then

            MessageBox.Show("item found using linear search at :" & index)
        Else
            MessageBox.Show("item not found using linear search")
        End If
    End Sub

    Private Sub But6_Click(sender As Object, e As EventArgs) Handles But6.Click
        Dim data As List(Of String) = LISTBOX1.Items.Cast(Of String)().ToList()
        data.Sort()
        LISTBOX1.Items.Clear()
        LISTBOX1.Items.AddRange(data.ToArray())
        binarysearch(LISTBOX1.Text)

    End Sub
    Public Function linearsearch(ByVal target As String) As Integer
        For i As Integer = 0 To LISTBOX1.Items.Count - 1
            If LISTBOX1.Items(i) = target Then
                ' ItemActivation found return the index 
                Return i
            End If
        Next

        'item not found 
        Return -1
    End Function
    Public Sub binarysearch(ByVal target As String)

        Dim lowerbound As Integer = 0
        Dim upperbound As Integer = LISTBOX1.Items.Count - 1

        While lowerbound <= upperbound
            Dim middle As Integer = (lowerbound + upperbound) \ 2
            Dim currentitem As String = LISTBOX1.Items(middle)

            If currentitem = target Then
                ' item found , do something with it 
                MessageBox.Show("item found using binary search : " & currentitem)
                Exit Sub
            ElseIf currentitem < target Then
                lowerbound = middle + 1
            Else
                upperbound = middle - 1
            End If
        End While
        ' item not found 
        MessageBox.Show("item not found: " & target)
    End Sub


End Class