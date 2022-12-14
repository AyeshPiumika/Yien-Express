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
    <link rel="stylesheet" href="	https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css">
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
      <input type="text" id="disabledTextInput" class="form-control" placeholder="Tracking Number"><br />
       <button type="submit" class="btn btn-primary">Submit</button>
    </div>
    </div>
    </div>
        <asp:GridView ID="GridView1" runat="server" Height="152px" Width="619px" BackColor="#FF9900" BorderColor="White" BorderStyle="Solid" ForeColor="White" style="margin-left: 410px">
        </asp:GridView>
       
    </form>
</body>
</html>
