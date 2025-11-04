<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SpaceEditMailQuotas.ascx.cs" Inherits="SolidCP.Portal.SpaceEditMailQuotas" %>
<%@ Register Src="UserControls/CalendarControl.ascx" TagName="CalendarControl" TagPrefix="scp" %>

<div class="panel-body form-horizontal">
    <asp:Label ID="lblMessage" runat="server" CssClass="NormalBold" ForeColor="red"></asp:Label>

    <asp:GridView ID="quotasGrid" runat="server"
        AutoGenerateColumns="False"
        DataKeyNames="ID"
        OnRowEditing="GridRowEditing"
        OnRowCancelingEdit="GridRowCancelingEdit"
        OnRowUpdating="GridRowUpdating"
        CssClass="table table-bordered"
        CssSelectorClass="NormalGridView">
        <Columns>
            <%--<asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" />--%>
            <asp:BoundField DataField="MaxAccounts" HeaderText="Max Accounts" />
            <asp:BoundField DataField="DomainName" HeaderText="Domain" ReadOnly="true" />
            <asp:CommandField ShowEditButton="True" />
        </Columns>
    </asp:GridView>

</div>
