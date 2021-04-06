'Spencer Gilchrist
Option Explicit On
Option Strict On

Module MultiplicationTable
    Sub Main()
        Dim UserInput As Integer 'This sets the user input as an integer

        Console.WriteLine("Please enter the number of rows you want in the table.")

        Check(UserInput) 'This calls the check function below
        TableFormat(UserInput) 'This calls the tableformat sub below


        Console.Read()
    End Sub

    Function Check(ByRef Number As Integer) As String
        'This function will read the user input and make sure it is a number
        'And is not a letter or decimal
        Try
            Number = CInt(Console.ReadLine())

            Return "" 'This means that it returns nothing

        Catch e As Exception

            Return "Must be a number."

        End Try
    End Function


    Sub TableFormat(UserNumber As Integer)
        Dim temp As String 'Temperary variable

        Console.WriteLine($"{UserNumber} x {UserNumber} Multiplication Table" & vbNewLine)
        'this takes the userinput and makes a multiplication table out of it
        For row = 1 To UserNumber
            For column = 1 To UserNumber

                temp = CStr(row * column) 'This multiplies the top most row and the left most collumn to create a table

                Console.Write(temp.PadLeft(7) & "|") 'This writes and adds | to the table
            Next
            Console.WriteLine()
        Next

    End Sub

End Module
