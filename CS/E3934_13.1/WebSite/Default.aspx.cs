using System;
using DevExpress.Web.ASPxGridView;

public partial class _Default : System.Web.UI.Page {
    private const int TextMaxLength = 10;

    protected void grid_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e) {
        if(e.Column.FieldName == "Description") {
            if(e.Value != null) {
                string cellValue = e.Value.ToString();
                if(cellValue.Length > TextMaxLength)
                    e.DisplayText = cellValue.Substring(0, TextMaxLength) + "...";
            }
        }
    }
    protected void grid_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e) {
        if(e.DataColumn.FieldName == "Description")
            if(e.CellValue != null)
                e.Cell.ToolTip = e.CellValue.ToString();
    }
}