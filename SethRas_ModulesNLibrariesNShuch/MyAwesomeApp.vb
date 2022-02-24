Module MyAwesomeApp


    Sub Main()
        Dim temp As String
        Dim menu As String

        'menu = "1. Delete" & vbNewLine _ 'space underscore indicates to software that the instruction is the same just on a new line
        '    & "2. Save" & vbNewLine _
        '    & "3. Rename" & vbNewLine

        'temp = (MyCoolLbrary.Prompt(menu))

        Prompt()

        'Console.WriteLine(temp)
        Console.Read()


    End Sub

End Module
