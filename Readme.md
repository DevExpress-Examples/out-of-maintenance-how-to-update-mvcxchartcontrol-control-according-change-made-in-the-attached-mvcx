<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128572431/16.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T433948)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/MvcPivotChartIntegration/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MvcPivotChartIntegration/Controllers/HomeController.vb))
* [PivotGridSettingsHelper.cs](./CS/MvcPivotChartIntegration/Helper/PivotGridSettingsHelper.cs) (VB: [PivotGridSettingsHelper.vb](./VB/MvcPivotChartIntegration/Helper/PivotGridSettingsHelper.vb))
* [_ChartPartial.cshtml](./CS/MvcPivotChartIntegration/Views/Home/_ChartPartial.cshtml)
* [_PivotGridPartial.cshtml](./CS/MvcPivotChartIntegration/Views/Home/_PivotGridPartial.cshtml)
* [Index.cshtml](./CS/MvcPivotChartIntegration/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to update MVCxChartControl control according change made in the attached MVCxPivotGrid


This example illustrates how to manually update a chart according to pivot changes. To do that, it is necessary to call the chart's [MVCxClientChart.PerformCallback](https://docs.devexpress.com/AspNetMvc/js-MVCxClientChart.PerformCallback(data)) method. You can call it from the [PivotGridSettings](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.PivotGridSettings).[ClientSideEvents](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.PivotGridSettings.ClientSideEvents).[EndCallback](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPivotGrid.PivotGridClientSideEvents.EndCallback) event handler. It is also necessary to send information about the pivot control's state to the server side by calling the [MVCxClientPivotGrid.FillStateObject](https://docs.devexpress.com/AspNetMvc/js-MVCxClientPivotGrid.FillStateObject(obj)) method  from the chart's BeginCallback client-side event handler.

To check whether an update is necessary, handle the server-side [MvcPivotGridSettings.GridLayout](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.PivotGridSettings.GridLayout) event and pass this information to the client side using [PivotGridSettings.CustomJsProperties](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.PivotGridSettings.CustomJsProperties?p=netframework).
