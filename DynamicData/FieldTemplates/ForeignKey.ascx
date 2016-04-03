<%@ Control Language="C#" CodeBehind="ForeignKey.ascx.cs" Inherits="Golestane_Shohada.ForeignKeyField" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />

