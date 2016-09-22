<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="COMP229_F2016_Assignment1.Pages.Contact" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="row">
                <div class="col-md-offset-3 col-md-11">
                    <h1>Contact</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-md-offset-3 col-md-4">
                    <h3>Contact Information</h3>
                    <div class="containerDecoration">
                        Address:<br>
                        9 Crescent Place<br>
                        Toronto,ON M4C5L8<br>
                        <br>
                        Phone:<br>
                        647-447-3215<br>
                        <br>
                        Email:
                        <br>
                        mamun131@gmail.com<br>
                    </div>
                </div>
                <div class="col-md-5 col-md-7">
                    <h3>Keep Connected</h3>
                    <div class="containerDecoration">
                        Face Book:<br>
                        <a href="https://www.facebook.com/md.mamunur.rahman" target="_blank"><i class="fa fa-facebook fa-lg"></i>My Facebook</a><br>
                        <br>
                        Twitter:<br>
                        <a href="https://mobile.twitter.com/mamun_131" target="_blank"><i class="fa fa-linkedin fa-lg"></i>My Twitter</a><br>
                        <br>
                        Linkdin:<br>
                        <a href="https://www.linkedin.com/in/md-mamunur-rahman-31a6375?trk=nav_responsive_tab_profile_pic" target="_blank"><i class="fa fa-linkedin fa-lg"></i>My Linkedin</a><br>
                        <br>
                    </div>
                </div>
            </div>
            <br>
            <br>

            <div class="row">

                <div class="col-md-offset-3 col-md-8">

                    <h4>CONTACT ME SENDING MESSAGE BY BELOW FORM</h4>
                    <div class="containerDecoration">
                        <form id="contactForm" action="" role="form">

                            <div class="form-group">
                                <label for="firstName">First Name</label>
                                <input type="text" class="form-control" id="firstName" placeholder="Enter First Name" required>
                            </div>
                            <div class="form-group">
                                <label for="lastName">Last Name</label>
                                <input type="text" class="form-control" id="lastName" placeholder="Enter Last Name" required>
                            </div>
                            <div class="form-group">
                                <label for="email">Email</label>
                                <input type="email" class="form-control" id="email" placeholder="Enter Email" required>
                            </div>
                            <div class="form-group">
                                <label for="contactNumber">Contact Number</label>
                                <input type="tel" class="form-control" id="contactNumber" placeholder="Enter Contact Number" required>
                            </div>
                            <div class="form-group">
                                <label for="message">Your Message</label>
                                <textarea cols="3" rows="3" class="form-control" id="message" placeholder="Enter Your Message here..." required></textarea>
                            </div>

                            <div class="text-right">
                                <a id="cancelButton" href="../index.html" class="btn btn-warning">Cancel</a>
                                <button id="sendButton" class="btn btn-primary">Send</button>
                            </div>
                        </form>
                    </div>
                </div>

            </div>




        </div>
    </div>
    </div>
</asp:Content>
