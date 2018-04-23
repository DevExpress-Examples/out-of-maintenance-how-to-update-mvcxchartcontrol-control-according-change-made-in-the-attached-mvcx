@Html.DevExpress().Chart(Sub(settings)
    settings.Name = "Chart"
    settings.CallbackRouteValues = New With { .Controller = "Home", .Action = "ChartPartial" }
    settings.ClientSideEvents.BeginCallback = "ChartBeginCallback"
    settings.Width = System.Web.UI.WebControls.Unit.Pixel(600)
    settings.Height = System.Web.UI.WebControls.Unit.Pixel(300)    
End Sub
).Bind(PivotGridExtension.GetDataObject(MvcApplication1.Helper.PivotGridSettingsHelper.CreatePivotGridSettings(), Model)).GetHtml()