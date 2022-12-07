Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports DevExpress.XtraCharts.Web
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace ASPxGridVIew
	Partial Public Class [Default]
		Inherits System.Web.UI.Page
		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			ASPxGridView1.DataSource = DataHelper.GenerateData()
			ASPxGridView1.DataBind()
		End Sub

		Protected Sub ASPxImage1_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim image As ASPxImage = CType(sender, ASPxImage)
			Dim c As GridViewDataItemTemplateContainer = CType(image.NamingContainer, GridViewDataItemTemplateContainer)
			Dim imageUrl As String = DataBinder.Eval(c.DataItem, "ImageUrl").ToString()
			Dim altImageUrl As String = DataBinder.Eval(c.DataItem, "AltImageUrl").ToString()
			image.ClientSideEvents.Init = String.Format("function(s, e) {{ OnImageInit(s, e, '{0}', '{1}'); }}", imageUrl, altImageUrl)
		End Sub
	End Class
End Namespace