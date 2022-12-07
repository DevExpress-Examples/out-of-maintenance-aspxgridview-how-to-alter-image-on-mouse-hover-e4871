<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ASPxGridVIew.Default" %>

<%@ Register Assembly="DevExpress.XtraCharts.v15.1.Web, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dxchartsui" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>

	<script type="text/javascript">
		function OnImageInit(s, e, imageUrl, altImageUrl) {
			var el = s.GetMainElement();
			ASPxClientUtils.AttachEventToElement(el, 'mouseover', function (event) { el.src = altImageUrl; });
			ASPxClientUtils.AttachEventToElement(el, 'mouseout', function (event) { el.src = imageUrl; });
		}
	</script>
</head>
<body>
	<form id="form1" runat="server">
		<dx:ASPxGridView ID="ASPxGridView1" runat="server" ClientInstanceName="grid" AutoGenerateColumns="False">
			<Columns>
				<dx:GridViewDataColumn FieldName="ImageUrl" VisibleIndex="0">
					<DataItemTemplate>
						<dx:ASPxImage ID="ASPxImage1" ImageUrl='<%#Eval("ImageUrl")%>' runat="server" OnLoad="ASPxImage1_Load">
						</dx:ASPxImage>
					</DataItemTemplate>
				</dx:GridViewDataColumn>
				<dx:GridViewDataTextColumn FieldName="Description" ReadOnly="True" VisibleIndex="1">
				</dx:GridViewDataTextColumn>
			</Columns>
			<SettingsPager PageSize="2" />
		</dx:ASPxGridView>
	</form>
</body>
</html>
