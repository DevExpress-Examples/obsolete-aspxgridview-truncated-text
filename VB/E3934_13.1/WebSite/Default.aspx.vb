Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private Const TextMaxLength As Integer = 10

	Protected Sub grid_CustomColumnDisplayText(ByVal sender As Object, ByVal e As ASPxGridViewColumnDisplayTextEventArgs)
		If e.Column.FieldName = "Description" Then
			If e.Value IsNot Nothing Then
				Dim cellValue As String = e.Value.ToString()
				If cellValue.Length > TextMaxLength Then
					e.DisplayText = cellValue.Substring(0, TextMaxLength) & "..."
				End If
			End If
		End If
	End Sub
	Protected Sub grid_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As ASPxGridViewTableDataCellEventArgs)
		If e.DataColumn.FieldName = "Description" Then
			If e.CellValue IsNot Nothing Then
				e.Cell.ToolTip = e.CellValue.ToString()
			End If
		End If
	End Sub
End Class