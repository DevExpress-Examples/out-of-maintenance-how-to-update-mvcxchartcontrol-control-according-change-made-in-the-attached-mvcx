Imports DevExpress.Web.Mvc
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace MvcApplication1.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function


		<ValidateInput(False)>
		Public Function PivotGridPartial() As ActionResult
			Return PartialView("_PivotGridPartial", GetData())
		End Function

		Public Function ChartPartial() As ActionResult
			Return PartialView("_ChartPartial", GetData())
		End Function
		Public Shared Function GetData() As DataTable
			Dim names() As String = { "Aaa", "Bbb", "Ccc", "Ddd" }

			Dim dt As New DataTable()
			Dim _r As New Random()
			dt.Columns.Add("Date", GetType(Date))
			dt.Columns.Add("Name", GetType(String))
			dt.Columns.Add("Value", GetType(Decimal))
			For i As Integer = 0 To 27
				dt.Rows.Add(Date.Today.AddHours(6 * i), names(i Mod 4), i Mod 5 * 6 + i Mod 3 * 7 + 20)
			Next i
			Return dt
		End Function
	End Class
End Namespace
