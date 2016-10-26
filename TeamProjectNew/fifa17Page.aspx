<%@ Page Title="Fifa 17" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="fifa17Page.aspx.cs" Inherits="TeamProjectNew.fifa17Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!--
    Mudrak Patel and Javid Niftaliyeve
    COMP229 Project
     -->

    <div class="fifaImageDiv"></div>

    <div class="fifaTextDivNew">Fifa 17</div>

    <div class="fifaContentDiv">
        <asp:GridView ID="fifa17GridView" runat="server" AutoGenerateColumns="false"
            CssClass="CounterStrikeGridView" DataKeyNames=""
            Visible="true"
            HeaderStyle-CssClass="CS_GRID_HEADER">
            <Columns>
                <asp:BoundField DataField="WEEK_NUMBER" HeaderText="WEEK" Visible="true" ItemStyle-CssClass="CS_WEEK_NUMBER" />
                <asp:BoundField DataField="TEAM_1_ID" HeaderText="TEAM 1" Visible="true" ItemStyle-CssClass="CS_TEAM_1_ID" />
                <asp:BoundField DataField="TEAM_1_Score" HeaderText="TEAM 1 SCORE" Visible="true" ItemStyle-CssClass="CS_TEAM_1_Score" />
                <asp:BoundField DataField="TEAM_2_Score" HeaderText="TEAM 2 SCORE" Visible="true" ItemStyle-CssClass="CS_TEAM_2_Score" />
                <asp:BoundField DataField="TEAM_2_ID" HeaderText="TEAM 2" Visible="true" ItemStyle-CssClass="TEAM_2_ID" />
                <asp:BoundField DataField="GAME_SPECTATORS" HeaderText="Aud." Visible="true" ItemStyle-CssClass="TEAM_2_Score" />
            </Columns>
        </asp:GridView>
    </div>

    <div class="fifaTextDiv">Fifa 17</div>



</asp:Content>
