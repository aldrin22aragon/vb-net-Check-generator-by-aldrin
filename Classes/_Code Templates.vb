﻿Public Class _Code_Templates
   Public Templates As List(Of Template) = Nothing
   Public SampleValues As New TmpValues

   Class TmpValues
      Public [Date] As String = "2024-01-13"
      Public CrossLine As String = ""
      Public PayeeLine1 As String = "Aldrin Aragon"
      Public PayeeLine2 As String = "Teraza Palo, Leyte"
      Public Amount As String = "56,245.90"
   End Class


   Sub New()
      Templates.Add(New Template())
      [DateTime] = New Template(Template.ENUM_TYPE.DATE)
      CrossLine = New Template(Template.ENUM_TYPE.CROSS_CHECK)
      PayeeLine1 = New Template(Template.ENUM_TYPE.PAYEELINE1)
      PayeeLine2 = New Template(Template.ENUM_TYPE.PAYEELINE2)
      Amount = New Template(Template.ENUM_TYPE.AMOUNT)
   End Sub



   Public Overrides Function ToString() As String
      Return MyBase.ToString
   End Function
End Class