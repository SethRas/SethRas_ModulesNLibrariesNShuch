Module MyCoolLbrary


    'Public Function SayJello()
    '    Return "Jello"
    'End Function


    ''' <summary> 
    ''' Displays the contes of arguments displayMessage the returns the user response. 
    ''' <returns> string: user response
    '''

    Public Function Prompt(ByVal Optional displayMessage As String = "<empty>") As String

        Console.WriteLine(displayMessage)
        Return Console.ReadLine()

    End Function


    Public Function randomWithinRange(max As Integer, min As Integer) As Integer
        max = max - min
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Rnd() * max) + min
    End Function
End Module
