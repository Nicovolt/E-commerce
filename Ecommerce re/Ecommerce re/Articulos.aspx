<%@ Page Title="Gestión de Articulos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="Ecommerce_re.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="container mt-4">
    <div class="row justify-content-center">
        <!-- Columna principal -->
        <div class="col-lg-8 col-md-10 col-sm-12">
            <div class="card shadow">
                <div class="card-header bg-primary text-white">
                    <h3 class="mb-0">
                        <asp:Literal ID="ltlTitulo" runat="server" /></h3>
                </div>
                <div class="card-body">
                    <!-- Información básica -->
                    <div class="row mb-4">
                        <div class="col-md-6">
                            <div class="form-group mb-3">
                                <label for="txtNombre" class="form-label">Nombre del Articulo</label>
                                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                                
                            </div>

                            <div class="form-group mb-3">
                                <label for="ddlCategoria" class="form-label">Categoria</label>
                                <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="seleccione una ategoria" />
                                </asp:DropDownList>

                            </div>
                            <div>
                                <label for="ddlmarca" class="form-label">Marca</label>
                                <asp:DropDownList ID="ddlMarca" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="seleccione una marca" />
                                </asp:DropDownList>


                            </div>

                            <div class="form-group mb-3">
                                <label for="txtPrecio" class="form-label">Precio</label>
                                <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" TextMode="Number" step="0.01" placeholder="0.00">  </asp:TextBox>

                            </div>
                        </div>

                        <div class="col-md-6">
                            <div class="form-group mb-3">
                                <label for="txtDescripcion" class="form-label">Descripcion</label>
                                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="3" placeholder="Descripcion del articulo"></asp:TextBox>
                            </div>

                           

                            <div class="form-group mb-3">
                                <label for="txtStock" class="form-label">Stock</label>
                                <asp:TextBox ID="txtStock" runat="server" TextMode="Number" placeholder="0" CssClass="form-control"></asp:TextBox>
                               
                            </div>
                        </div>
                    </div>

                    

                    <!-- Botones de acción -->
                    <div class="row mt-4">
                        <div class="col-12 d-flex justify-content-end gap-2">
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-secondary" OnClick="btnCancelar_Click" CausesValidation="false" />

                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click"/>
             
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


 <style>
   
</style>






</asp:Content>
