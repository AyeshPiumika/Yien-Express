<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientInterface.aspx.cs" Inherits="Yien_Express_Web_Page.ClientInterface" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
        .title{
            color:orange;
            font-size:250%;
            font-weight:700;
            text-align:center;
        }
        .input{
             padding-left:50px;
            padding-right:50px;
        }
    </style>
    <link rel="stylesheet" href="    https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div class="title">
            Yein Express
        </div>
    <div class="input">
        <div class="mb-3">
      <label for="disabledTextInput" class="form-label">Input Your Tracking ID :</label>
            <asp:TextBox ID="txtTrackingNumber" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
    </div>
    </div>
    </div>
        <asp:GridView ID="GridView1" runat="server" Height="152px" Width="619px" BackColor="#FF9900" BorderColor="White" BorderStyle="Solid" ForeColor="White" style="margin-left: 410px" AutoGenerateColumns="False" DataKeyNames="itemid" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Visible="False">
            <Columns>
                <asp:BoundField DataField="itemid" HeaderText="itemid" ReadOnly="True" SortExpression="itemid" />
                <asp:BoundField DataField="details" HeaderText="details" SortExpression="details" />
                <asp:BoundField DataField="rcontact" HeaderText="rcontact" SortExpression="rcontact" />
                <asp:BoundField DataField="raddress" HeaderText="raddress" SortExpression="raddress" />
                <asp:BoundField DataField="itemstatus" HeaderText="itemstatus" SortExpression="itemstatus" />
            </Columns>
        </asp:GridView>
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:db_Yien_ExpressConnectionString %>" SelectCommand="SELECT [itemid], [details], [rcontact], [raddress], [itemstatus] FROM [tbl_Items]"></asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server"></asp:Label>
       
    </form>
</body>
</html>
