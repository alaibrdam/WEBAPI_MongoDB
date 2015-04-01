<%@ Page Title="API Consumer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ApiConsumer.aspx.cs" Inherits="TwitterGateConsumer._ApiConsumer" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>This application reads 100 tweets from twitter #BBC, Insert them into a MongoDB and then extract 3 different statistics from MongoDB.
                </h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Select one opntion then click the button</h3>
    <ol class="round">
        <li >

            <div>

                <asp:DropDownList ID="ddlApi" runat="server" Height="30">
                    <asp:ListItem Value="api/getTweets">Read From Twitter</asp:ListItem>
                    <asp:ListItem Value="api/getTopFollowers">Get Top Five Orderd by Followers</asp:ListItem>
                    <asp:ListItem Value="api/getTopRetweets">Get Top Five Orderd by Retweets</asp:ListItem>
                    <asp:ListItem Value="api/getTopFavourite">Get Top Five Orderd by Favorite Count</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>

                <asp:Button ID="btnCallWEBApi" runat="server" Text="Call Web Api" OnClick="btnCallWEBApi_Click" />

            </div>
            <div>
                <asp:Label ID="lblNote" runat="server" Text=""></asp:Label>
            </div>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Text" ItemStyle-Width="500px" HeaderText="Text">
                        <ItemStyle Width="500px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="CreatedAt" ItemStyle-Width="150px" HeaderText="Post Data">
                        <ItemStyle Width="150px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="RetweetCount" ItemStyle-Width="20px" HeaderText="Retweets">
                        <ItemStyle Width="20px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="FavoriteCount" ItemStyle-Width="20px" HeaderText="Favorites">
                        <ItemStyle Width="20px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="FollowersCount" ItemStyle-Width="20px" HeaderText="Followers">
                        <ItemStyle Width="20px"></ItemStyle>
                    </asp:BoundField>
                    

                </Columns>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>

        </li>

    </ol>
</asp:Content>
