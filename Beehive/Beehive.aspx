<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Beehive.aspx.cs" Inherits="Beehive.Beehive" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <asp:Label ID="Label1" runat="server" Text="Beehive Card Game" Font-Names="Impact"
            Font-Size="24pt" ForeColor="#FF9900"></asp:Label>
    </div>
    <p />
    <p />
    <div style="width: 500px; border: 1px solid black; overflow: auto;position: relative">
        <div id="flowers" style="margin-right: auto; height: 250px; width: 500px; float: left;position: relative">
            <div>
                <asp:ImageButton Style="position:absolute;left:8px;top:8px;" ImageUrl="~/cards_png/c1.png"
                    ID="flower1" runat="server" OnClick="Flower1_Click" ToolTip="Flower 1" />
                <asp:ImageButton Style="position:absolute;left:108px;top:8px;" ImageUrl="~/cards_png/c4.png"
                    ID="flower2" runat="server" OnClick="Flower2_Click" ToolTip="Flower 2" />
                <asp:ImageButton Style="position:absolute;left:208px;top:8px;" ImageUrl="~/cards_png/c6.png"
                    ID="flower3" runat="server" OnClick="Flower3_Click" ToolTip="Flower 3" />
            </div>
            <div>
                <asp:ImageButton Style="position:absolute;left:8px;top:108px;" ImageUrl="~/cards_png/c1.png"
                    ID="flower4" runat="server" OnClick="Flower4_Click" ToolTip="Flower 4" />
                <asp:ImageButton Style="position:absolute;left:108px;top:108px;" ImageUrl="~/cards_png/c4.png"
                    ID="flower5" runat="server" OnClick="Flower5_Click" ToolTip="Flower 5" />
                <asp:ImageButton Style="position:absolute;left:208px;top:108px;" ImageUrl="~/cards_png/c6.png"
                    ID="flower6" runat="server" OnClick="Flower6_Click" ToolTip="Flower 6" />
            </div>
            <div style="position:absolute;left:368px;top:58px;">
                <asp:ImageButton ImageUrl="~/cards_png/b2fv.png" ID="beehiveStack" runat="server"
                    OnClick="Beehive_Click" AlternateText="Beehive Stack" ToolTip="Beehive Stack" />
            </div>
        </div>
        <div style="float: left; width: 250px;">
            <asp:ImageButton ImageUrl="~/cards_png/b1fv.png" ID="deck" runat="server" OnClick="Deck_Click" />
        </div>
        <div style="float: left;">
            <asp:Image ImageUrl="~/cards_png/b1pl.png" id = "hide1" runat="server" />
        </div>
        <div style="float: left;">
            <asp:Image ImageUrl="~/cards_png/b1pl.png" ID = "hide2" runat="server" />
        </div>
        <div style="float: left;">
            <asp:ImageButton ImageUrl="~/cards_png/b1fv.png" ID="workingStack" runat="server" OnClick="Working_Click" />
        </div>
    </div>
    <p />
        <asp:Button ID="reset" runat="server" Text="Reset Game" onclick="reset_Click" />
    <asp:HyperLink ID="HyperLink1" runat="server" 
        NavigateUrl="http://cardgameheaven.com/single-player-games/beehive.html">Rules</asp:HyperLink>
    </form>
</body>
</html>
