
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_186

	''' <summary>
	'''     Returns the largest integer less than or equal to the specified decimal number.
	''' </summary>
	''' <param name="d">A decimal number.</param>
	''' <returns>
	'''     The largest integer less than or equal to .  Note that the method returns an integral value of type .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Floor(d As [Decimal]) As [Decimal]
		Return Math.Floor(d)
	End Function
End Module


