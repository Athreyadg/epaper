<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="WebApplication1.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">

            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-12">
                                <center>
                                <img width="150px" src="imgs/adminuser.png" />
                                </center>
                            </div>
                       </div>
                       <div class="row">
                           <div class="col-12">
                               <center>
                               <h3>Admin Login</h3>
                               </center>
                           </div>
                      </div>
                      
                        <div class="row">
                            <div class="col-12">
                                <center>
                                <hr />
                                </center>
                            </div>
                       </div>
                        
                        <div class="row">
                            <asp:Label Text="Admin ID" runat="server" />
                            <div class="form-group">

                                <asp:TextBox class="form-control" ID="TextBox1" runat="server" placeholder="abc@comp.abc"></asp:TextBox>

                            </div>
                        
                            <asp:Label Text="Password" runat="server" />
                            <div class="">
                                
                                <asp:TextBox class="form-control" ID="TextBox2" runat="server" TextMode="Password" placeholder="Password "></asp:TextBox>

                            </div>
                            <h4>    </h4>

                            <div class=" d-grid gap-2">
                                <asp:Button CssClass="btn btn-success btn-lg" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />

                            </div>

                            <h4>    </h4>

                            <%--<div class=" d-grid gap-2">
                               <a href="usersignup.aspx" class="btn btn-info btn-lg"><input class="btn btn-info btn-block btn-lg" id ="Button2" type="button" value="Sign-up" /></a>

                            </div>--%>


                       </div>
                        <br />
                        <a href="homepage.aspx">
                            << back to home
                        </a>
                        <br />
                        <br /><br /><br /><br /><br /><br /><br /><br />

                        
                    </div>
                </div>

               

            </div>

        </div>
    </div>

</asp:Content>
