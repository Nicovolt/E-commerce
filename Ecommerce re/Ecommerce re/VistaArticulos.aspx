<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaArticulos.aspx.cs" Inherits="Ecommerce_re.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <asp:Repeater ID="repArticulos" runat="server" onitemcommand="repArticulos_ItemCommand">
        <ItemTemplate>
            <div class="col">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title"><%# Eval("Nombre") %> </h5>
                        <p class="card-text"><%# Eval("Descripcion") %> </p>
                        <p class="card-text"><strong>Precio: </strong>$<%# Eval("precio") %></p>
                        <div class="d-flex justify-content-between align-items-center mt-auto">
                           
                            <asp:Button ID="btnCarrito" runat="server" commandName="AgregarCarrito" commandargument='<%# Eval("IdArticulo") %>' Text="Agregar al carrito" CssClass="btn btn-success add-to-cart-btn"/>
                            <asp:Button ID="btnDetalle" runat="server" CommandName="VerDetalle" commandargument='<%# Eval("IdArticulo") %>' Text="Ver detalle" CssClass="btn btn-primary"/>
                          
                            
                            
                            

                         </div>
                    </div>
                </div>
            </div>



        </ItemTemplate>
    </asp:Repeater>

















</asp:Content>
