<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Beehive.aspx.cs" Inherits="Beehive.Beehive" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<<<<<<< HEAD
<body style="width: 100%; margin: 0; padding: 0;" onload="getUsername()">

    <script>
        function getUsername() {
            if (document.getElementById("hiddenField").value === "readusername") {
                var name = prompt("Please enter your name", "");
                if (name != null && name != "") {
                    document.getElementById("hiddenField").value = name;
                }
            }
            document.getElementById("hiddenField").value = "sfdssdf";
        }
    </script>

    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
=======
<body>
    <form id="form1" runat="server">
>>>>>>> 8f1b4a4b5b7063c62f23724d58ee6d04623ed156
    <div align="center">
        <asp:Label ID="Label1" runat="server" Text="Beehive Card Game" Font-Names="Impact"
            Font-Size="24pt" ForeColor="#FF9900"></asp:Label>
    </div>
    <p />
    <p />
<<<<<<< HEAD
    <asp:Image ID="dancingBee1" runat="server" ImageUrl="~/resources/dancingbee.gif"
        Style="position: absolute; left: -50px; top: -100px; z-index: 1000;" Visible="False" />
    <asp:Image ID="dancingBee2" runat="server" ImageUrl="~/resources/dancingbee.gif"
        Style="position: absolute; left: 250px; top: -100px; z-index: 1000;" Visible="False" />
    <asp:Image ID="dancingBee3" runat="server" ImageUrl="~/resources/dancingbee.gif"
        Style="position: absolute; left: -50px; top: 200px; z-index: 1000;" Visible="False" />
    <asp:Image ID="dancingBee4" runat="server" ImageUrl="~/resources/dancingbee.gif"
        Style="position: absolute; left: 250px; top: 200px; z-index: 1000;" Visible="False" />
    <asp:Image ID="dancingBee5" runat="server" ImageUrl="~/resources/dancingbee.gif"
        Style="position: absolute; left: 550px; top: -100px; z-index: 1000;" Visible="False" />
    <asp:Image ID="dancingBee6" runat="server" ImageUrl="~/resources/dancingbee.gif"
        Style="position: absolute; left: 550px; top: 200px; z-index: 1000;" Visible="False" />
    <div style="width: 500px; border: 1px solid black; overflow: auto; position: relative;
        float: left">
        <div id="flowers" style="margin-right: auto; height: 250px; width: 500px; float: left;
            position: relative">
            <div>
                <asp:ImageButton Style="position: absolute; left: 8px; top: 8px;" ImageUrl="~/resources/cards_png/c1.png"
                    ID="flower1" runat="server" OnClick="Flower1_Click" ToolTip="Flower 1" />
                <asp:ImageButton Style="position: absolute; left: 108px; top: 8px;" ImageUrl="~/resources/cards_png/c4.png"
                    ID="flower2" runat="server" OnClick="Flower2_Click" ToolTip="Flower 2" />
                <asp:ImageButton Style="position: absolute; left: 208px; top: 8px;" ImageUrl="~/resources/cards_png/c6.png"
                    ID="flower3" runat="server" OnClick="Flower3_Click" ToolTip="Flower 3" />
            </div>
            <div>
                <asp:ImageButton Style="position: absolute; left: 8px; top: 108px;" ImageUrl="~/resources/cards_png/c1.png"
                    ID="flower4" runat="server" OnClick="Flower4_Click" ToolTip="Flower 4" />
                <asp:ImageButton Style="position: absolute; left: 108px; top: 108px;" ImageUrl="~/resources/cards_png/c4.png"
                    ID="flower5" runat="server" OnClick="Flower5_Click" ToolTip="Flower 5" />
                <asp:ImageButton Style="position: absolute; left: 208px; top: 108px;" ImageUrl="~/resources/cards_png/c6.png"
                    ID="flower6" runat="server" OnClick="Flower6_Click" ToolTip="Flower 6" />
            </div>
            <div style="position: absolute; left: 368px; top: 58px;">
                <asp:ImageButton ImageUrl="~/resources/cards_png/b2fv.png" ID="beehiveStack" runat="server"
=======
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
>>>>>>> 8f1b4a4b5b7063c62f23724d58ee6d04623ed156
                    OnClick="Beehive_Click" AlternateText="Beehive Stack" ToolTip="Beehive Stack" />
            </div>
        </div>
        <div style="float: left; width: 250px;">
<<<<<<< HEAD
            <asp:ImageButton ImageUrl="~/resources/cards_png/b1fv.png" ID="deck" runat="server"
                OnClick="Deck_Click" />
        </div>
        <div style="float: left;">
            <asp:Image ImageUrl="~/resources/cards_png/b1pl.png" ID="hide1" runat="server" />
        </div>
        <div style="float: left;">
            <asp:Image ImageUrl="~/resources/cards_png/b1pl.png" ID="hide2" runat="server" />
        </div>
        <div style="float: left;">
            <asp:ImageButton ImageUrl="~/resources/cards_png/b1fv.png" ID="workingStack" runat="server"
                OnClick="Working_Click" />
        </div>
    </div>
    <div>
        <asp:Button ID="reset" runat="server" Text="Reset Game" OnClick="reset_Click" Style="position: relative;
            left: 0px; top: 0px; z-index: 1001;" />
        <asp:HyperLink ID="rulesL" runat="server" NavigateUrl="http://cardgameheaven.com/single-player-games/beehive.html">Rules</asp:HyperLink>
    </div>
    <br />
    <div>
        &nbsp;Top times:
    </div>
    <asp:BulletedList ID="scoresList" runat="server" Style="float: left">
        <asp:ListItem>1. ExampleName: 235.25 seconds</asp:ListItem>
    </asp:BulletedList>
    <asp:Label ID="lbl1" runat="server" Text="Time of current game: " Style="padding-left: 50px;"></asp:Label>
    <asp:Label ID="timeLabel" runat="server" Text="Time:" Style="padding-left: 5px;"></asp:Label>
    <asp:TextBox ID="nameInput" runat="server" style="position: absolute; left: 5px; top: 550px; z-index: 1010;" Visible="False"></asp:TextBox>
    <asp:Button ID="nameSubmit" runat="server" Text="Submit Name" 
        style="position: absolute; left: 140px; top: 550px; z-index: 1010;" 
        Visible="False" onclick="nameSubmit_Click"/>
=======
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
>>>>>>> 8f1b4a4b5b7063c62f23724d58ee6d04623ed156
    </form>
</body>
</html>
