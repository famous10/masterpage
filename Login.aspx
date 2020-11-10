<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    login
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" Runat="Server">


    <h2>world famous Login Form</h2>

 <form action="/action_page" method="post">
  <div class="imgcontainer">
    <img src="images/boy.png" alt="boy" class="boy">
  </div>

  <div class="container">
    <label for="uname"><b></b></label>
      <asp:TextBox ID="txtuname" runat="server"  placeholder="Enter Username"  ></asp:TextBox>

      
       <label for="psw" ><b>


    
            </b></label>
      <asp:TextBox ID="txtpsw" runat="server"  placeholder="Enter Password" ></asp:TextBox>

        
   
    <div class="login">

            <asp:Button ID="Button1" runat="server"  class="login" Style="background-color:green; color:white"  Text="Button" OnClick="Button1_Click" Width="120px" Height="27px" />
 
            </div>
    <label>
      <input type="checkbox" checked="checked" name="remember"> Remember me
    </label>
  </div>

  <div class="containerW" style="background-color:black">
    <button type="button" class="cancelbtn">Cancel</button>
    <span class="psw">Forgot <a href="#">password?</a></span>
  </div>
</form>

</asp:Content>

