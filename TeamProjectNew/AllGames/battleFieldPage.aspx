<%@ Page Title="Battle Field" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="battleFieldPage.aspx.cs" Inherits="TeamProjectNew.battleFieldPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!--
    Mudrak Patel and Javid Niftaliyeve
    COMP229 Project
     -->

    <div class="battleFieldImageDiv"></div>

    <div class="battleFieldTextDivNew">Battlefield 1</div>

    <div class="battleFieldContentDiv">
        <asp:GridView ID="BattleFieldGridView" runat="server" AutoGenerateColumns="false"
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

    <div class="battleFieldTextDiv">Battlefield 1</div>

</asp:Content>
