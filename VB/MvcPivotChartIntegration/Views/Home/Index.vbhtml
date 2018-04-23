@Code ViewBag.Title = "Chart displays Pivot Grid data" End Code
<script>    
    function PivotEndCallback(s, e) {
        console.log(s.cpLayoutUpdated);
        if (s.cpLayoutUpdated) {
            Chart.PerformCallback();
        }
    }
    function ChartBeginCallback(s, e) {
        PivotGrid.FillStateObject(e.customArgs);
    }
</script>
<h2>Chart displays Pivot Grid data</h2>

@Html.Action("PivotGridPartial")

@Html.Action("ChartPartial")
