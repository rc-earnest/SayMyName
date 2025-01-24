'Rudy Earnest
'RCET2265
'Spring 2025
'Say My Name
'https://github.com/rc-earnest/SayMyName.git
Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()
        Dim Name As String
        Console.WriteLine("What is your name?")
        Console.WriteLine()
        Name = Console.ReadLine 'gets user input
        Console.WriteLine()
        Console.WriteLine(Name & "?!" & " Who was in charge of naming you human?") 'displays user input
    End Sub

End Module
