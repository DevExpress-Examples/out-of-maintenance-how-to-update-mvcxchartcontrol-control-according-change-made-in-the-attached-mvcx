Imports DevExpress.Web.Mvc
Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace MvcApplication1.Helper
	Public Class PivotGridSettingsHelper
		Public Shared Sub CustomizePivotGridSettings(ByVal settings As PivotGridSettings)
			settings.Name = "PivotGrid"
			settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "PivotGridPartial"}

			settings.OptionsChartDataSource.ProvideDataByColumns = False
			settings.ClientSideEvents.EndCallback = "PivotEndCallback"

			settings.BeforeGetCallbackResult = Sub(sender, e)
				Dim pivot As MVCxPivotGrid = CType(sender, MVCxPivotGrid)
				pivot.JSProperties("cpLayoutUpdated") = False
			End Sub
			settings.GridLayout = Sub(sender, e)
				Dim pivot As MVCxPivotGrid = CType(sender, MVCxPivotGrid)
				pivot.JSProperties("cpLayoutUpdated") = True
			End Sub

			settings.Fields.Add(Sub(field)
				field.ID = "fieldDate"
				field.Area = PivotArea.ColumnArea
				field.FieldName = "Date"
				field.GroupInterval = PivotGroupInterval.Date
				field.Caption = "Date"
			End Sub)
			settings.Fields.Add(Sub(field)
				field.ID = "fieldName"
				field.Area = PivotArea.RowArea
				field.FieldName = "Name"
				field.Caption = "Name"
			End Sub)
			settings.Fields.Add(Sub(field)
				field.ID = "fieldValue"
				field.Area = PivotArea.DataArea
				field.FieldName = "Value"
				field.Caption = "Value"
			End Sub)

		End Sub
		Public Shared Function CreatePivotGridSettings() As PivotGridSettings
			Dim settings As New PivotGridSettings()
			CustomizePivotGridSettings(settings)
			Return settings
		End Function
	End Class
End Namespace