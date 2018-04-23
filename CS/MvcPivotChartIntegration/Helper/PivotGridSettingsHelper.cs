using DevExpress.Web.Mvc;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Helper {
    public class PivotGridSettingsHelper {
        public static void CustomizePivotGridSettings(PivotGridSettings settings)
        {
            settings.Name = "PivotGrid";
            settings.CallbackRouteValues = new { Controller = "Home", Action = "PivotGridPartial" };

            settings.OptionsChartDataSource.ProvideDataByColumns = false;
            settings.ClientSideEvents.EndCallback = "PivotEndCallback";
            
            settings.BeforeGetCallbackResult = (sender, e) => {
                MVCxPivotGrid pivot = (MVCxPivotGrid)sender;
                pivot.JSProperties["cpLayoutUpdated"] = false;
            };
            settings.GridLayout = (sender, e) => {
                MVCxPivotGrid pivot = (MVCxPivotGrid)sender;
                pivot.JSProperties["cpLayoutUpdated"] = true;
            };

            settings.Fields.Add(field =>
            {
                field.ID = "fieldDate";
                field.Area = PivotArea.ColumnArea;
                field.FieldName = "Date";
                field.GroupInterval = PivotGroupInterval.Date;
                field.Caption = "Date";
            });
            settings.Fields.Add(field =>
            {
                field.ID = "fieldName";
                field.Area = PivotArea.RowArea;
                field.FieldName = "Name";
                field.Caption = "Name";
            });
            settings.Fields.Add(field =>
            {
                field.ID = "fieldValue";
                field.Area = PivotArea.DataArea;
                field.FieldName = "Value";
                field.Caption = "Value";
            });
            
        }
        public static PivotGridSettings CreatePivotGridSettings() {
            PivotGridSettings settings = new PivotGridSettings();
            CustomizePivotGridSettings(settings);
            return settings;
        }
    }
}