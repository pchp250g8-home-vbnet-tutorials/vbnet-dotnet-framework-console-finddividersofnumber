Module Module1

    Sub Main()
		Console.WriteLine("Input an integer positive number")
		Dim ulNumber As ULong
		UInt64.TryParse(Console.ReadLine(), ulNumber)
		Console.WriteLine("The number {0} has the folowing dividers:")
		For i As ULong = 1 To ulNumber
			If ulNumber Mod i = 0 Then
				Console.Write("{0} ", i)
			End If
		Next i
		Console.WriteLine()
		Console.Read()
	End Sub

End Module
