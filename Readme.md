<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/MvcPivotChartIntegration/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MvcPivotChartIntegration/Controllers/HomeController.vb))
* [PivotGridSettingsHelper.cs](./CS/MvcPivotChartIntegration/Helper/PivotGridSettingsHelper.cs) (VB: [PivotGridSettingsHelper.vb](./VB/MvcPivotChartIntegration/Helper/PivotGridSettingsHelper.vb))
* [_ChartPartial.cshtml](./CS/MvcPivotChartIntegration/Views/Home/_ChartPartial.cshtml)
* [_PivotGridPartial.cshtml](./CS/MvcPivotChartIntegration/Views/Home/_PivotGridPartial.cshtml)
* [Index.cshtml](./CS/MvcPivotChartIntegration/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to update MVCxChartControl control according change made in the attached MVCxPivotGrid


<p>This example illustrates how to manually update a chart according to pivot changes. To do that, it is necessary to call the chart's <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMVCScriptsMVCxClientChart_PerformCallbacktopic">MVCxClientChart.PerformCallback</a> method. You can call it from the <a href="https://documentation.devexpress.com/AspNet/clsDevExpressWebMvcPivotGridSettingstopic.aspx">PivotGridSettings</a>.<a href="https://documentation.devexpress.com/AspNet/DevExpressWebMvcPivotGridSettings_ClientSideEventstopic.aspx">ClientSideEvents</a>.<a href="https://documentation.devexpress.com/AspNet/DevExpressWebASPxPivotGridPivotGridClientSideEvents_EndCallbacktopic.aspx">EndCallback</a> event handler. It is also necessary to send information about the pivot control's state to the server side by calling the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMVCScriptsMVCxClientPivotGrid_FillStateObjecttopic">MVCxClientPivotGrid.FillStateObject Method</a> from the chart's BeginCallback client-side event handler. <br>To check whether an update is necessary, handle the server-side <a href="https://documentation.devexpress.com/AspNet/DevExpressWebMvcPivotGridSettings_GridLayouttopic.aspx">GridLayout</a> event and pass this information to the client side using <a href="https://documentation.devexpress.com/AspNet/DevExpressWebASPxPivotGridASPxPivotGrid_JSPropertiestopic.aspx">JSProperties.</a></p>

<br/>


