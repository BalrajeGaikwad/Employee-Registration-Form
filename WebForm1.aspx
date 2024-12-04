<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Employee_Registration_Form.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .row {
            align-items: baseline;
            padding-bottom: 5px;
        }

        .element {
            max-width: fit-content;
            margin-left: auto;
            margin-right: auto;
            /*border: solid;*/
            padding-inline: auto;
            padding-bottom: 5px;
            border-radius: 10px;
            padding-left: 5px;
            padding-right: 5px;
            background-color: antiquewhite;
            width: 700px;
        }

        .form1 {
            background-color: honeydew;
        }
        /*.view{
             max-width: fit-content;
        }*/
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="element">

            <div>
                <div>
                    <center>
                        <h1>
                            <asp:Label ID="Label1" runat="server" Text="Employee Registration Form"></asp:Label>
                        </h1>
                    </center>
                </div>
                <div class="row">

                    <asp:DropDownList ID="Mr_Mrs" runat="server">
                        <asp:ListItem>Mr</asp:ListItem>
                        <asp:ListItem>Mrs</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label2" runat="server" Text="First_Name :"></asp:Label>
                    <asp:TextBox ID="First_Name" runat="server"></asp:TextBox>
                    <asp:Label ID="Label3" runat="server" Text="Last_Name :"></asp:Label>
                    <asp:TextBox ID="Last_Name" runat="server"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Label ID="Label4" runat="server" Text="Email :"></asp:Label>
                    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                    <asp:Label ID="Label5" runat="server" Text="Contact"></asp:Label>
                    <asp:TextBox ID="Contact" runat="server"></asp:TextBox>
                    <asp:Label ID="Label6" runat="server" Text="DBO :"></asp:Label>
                    <asp:TextBox ID="DBO" runat="server" TextMode="Date"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Label ID="Label7" runat="server" Text="Country :"></asp:Label>
                    <asp:DropDownList ID="Country" runat="server">
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>UAE</asp:ListItem>
                        <asp:ListItem>Japan</asp:ListItem>
                        <asp:ListItem>Dubai</asp:ListItem>
                        <asp:ListItem>Pak</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label8" runat="server" Text="State :"></asp:Label>
                    <asp:DropDownList ID="State" runat="server">
                        <asp:ListItem>MH</asp:ListItem>
                        <asp:ListItem>RJ</asp:ListItem>
                        <asp:ListItem>HY</asp:ListItem>
                        <asp:ListItem>KA</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label9" runat="server" Text="City :"></asp:Label>
                    <asp:DropDownList ID="City" runat="server">
                        <asp:ListItem>Pune</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem>Delhi</asp:ListItem>
                        <asp:ListItem>Nashik</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="row">
                    <asp:Label ID="Label10" runat="server" Text="IdentityCard :"></asp:Label>
                    <asp:DropDownList ID="IdentityCard" runat="server" AutoPostBack="True" OnSelectedIndexChanged="IdentityCard_SelectedIndexChanged">
                        <asp:ListItem>Aadhar Card</asp:ListItem>
                        <asp:ListItem>Pan Card</asp:ListItem>
                        <asp:ListItem>Credit Card</asp:ListItem>
                    </asp:DropDownList>
                </div>

            </div>
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                <asp:Label ID="Label12" runat="server" Text="Identityno :"></asp:Label>
                <asp:TextBox ID="Identityno" runat="server"></asp:TextBox>
                <br />
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" Visible="False">
                <asp:Label ID="Label13" runat="server" Text="Credit_Card_Number :"></asp:Label>
                <asp:TextBox ID="Credit_Card_Number" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label14" runat="server" Text="Exp_Date :"></asp:Label>
                <asp:TextBox ID="Exp_Date" runat="server" TextMode="Date"></asp:TextBox>
                <br />
                <asp:Label ID="Label15" runat="server" Text="Holder_Name :"></asp:Label>
                <asp:TextBox ID="Holder_Name" runat="server"></asp:TextBox>
                <br />
                <br />
            </asp:Panel>
            <center>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                &nbsp;
                <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
                &nbsp;
                <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
                &nbsp;
                <asp:Button ID="Button4" runat="server" Text="Clear" OnClick="Button4_Click" />
            </center>
        </div>



        <hr />

        <div class="element">
            <h3>
                <center>
                    <asp:Label ID="Label16" runat="server" Text="Employee Information"></asp:Label></center>
            </h3>
            <div class="row">
                <asp:Label ID="Label17" runat="server" Text="Start_Date :"></asp:Label>
                <asp:TextBox ID="Start_Date" runat="server" TextMode="Date"></asp:TextBox>
                <asp:Label ID="Label18" runat="server" Text="End_Date :"></asp:Label>
                <asp:TextBox ID="End_Date" runat="server" TextMode="Date"></asp:TextBox>

                <asp:Label ID="Label19" runat="server" Text="Email :"></asp:Label>
                <asp:TextBox ID="em" runat="server"></asp:TextBox>
            </div>
            <br />
            <center>
                <asp:Button ID="Button5" runat="server" Text="Search" OnClick="Button5_Click" />
                &nbsp;<asp:Button ID="Button6" runat="server" Text="View Data" OnClick="Button6_Click" />
            </center>
        </div>

        <br />

        <asp:GridView CssClass="view" ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
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

    </form>
</body>
</html>
