<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# OBSOLETE - ASPxGridView - How to display a truncated text in a column


<p><strong>UPDATED:<br><br></strong>Starting with version v2015 vol 2 (v15.2), this functionality is available out of the box. Simply set the <strong>ASPxGridView.SettingsBehavior.AllowEllipsisInText</strong> / <strong>GridViewDataColumn.Settings.AllowEllipsisInText</strong> property to True to activate it. Please refer to the <a href="https://community.devexpress.com/blogs/aspnet/archive/2015/11/10/asp-net-grid-view-data-range-filter-adaptivity-and-more-coming-soon-in-v15-2.aspx">ASP.NET Grid View - Data Range Filter, Adaptivity and More (Coming soon in v15.2)</a> blog post and the <a href="http://demos.devexpress.com/ASPxGridViewDemos/Columns/TextEllipsis.aspx">Text Ellipsis</a> demo for more information.<br>If you have version v15.2+ available, consider using the built-in functionality instead of the approach detailed below.<br><br>This example demonstrates how to display a truncated text in <strong>ASPxGridView</strong> column and show a full value as the tool tip.<br>1) Handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_CustomColumnDisplayTexttopic"><u>ASPxGridView.CustomColumnDisplayText</u></a> event to truncate displayed text in DataCell via the <strong>e.DisplayText </strong>property;<br>2) Handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_HtmlDataCellPreparedtopic"><u>ASPxGridView.HtmlDataCellPrepared</u></a> event to set tool tips for the same DataCell via the <strong>e.Cell.ToolTip</strong> property.<br><br><strong>See Also:<br></strong><a href="https://www.devexpress.com/Support/Center/p/E3935">E3935: ASPxTreeList - How to display a truncated text in a column</a><br><a href="https://www.devexpress.com/Support/Center/p/E4898">ASPxGridView - How to display truncated text in a resizable column (using CSS)</a></p>

<br/>


