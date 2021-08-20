<%@ Page Title="Search Papers" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewbooks.aspx.cs" Inherits="WebApplication3.viewbooks" Async="true" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div class="col-md-4 mx-auto">
        
        <div class="form-group">
            <br />
            <br />
            <h5>Search for papers here: </h5>
            <div class="input-group">
                 
                <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder=""></asp:TextBox>
                <asp:Button ID="Button1" class="btn  btn-block btn-success" runat="server" Text="Search" OnClick="Button1_Click" />
            </div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <br />
        <br />
    </div>

    <div class="content col-10 align-self-auto mx-auto">

        <hr />
        <div class="row">
            <h4>
                <% for (int i=0;i <links.Count;i++){%>
                <a class="accordion-body  card"   href="<%= links[i] %>">
               
                    <%= titles[i] %>

                </a> 

                <p>

                </p>
            
            <br /> <br />
            <%}%>
            </h4>
        </div>

    </div>



</asp:Content>
