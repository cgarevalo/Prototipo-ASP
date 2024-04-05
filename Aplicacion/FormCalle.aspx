<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="FormCalle.aspx.cs" Inherits="Aplicacion.FormCalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-6">
        <div class="mb-3">
            <label for="txtId" class="form-label">ID</label>
            <asp:TextBox ID="txtId" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="txtCalle" class="form-label">Calle</label>
            <asp:TextBox ID="txtCalle" CssClass="form-control" runat="server"></asp:TextBox>           
        </div>
        <div class="mb-3">
            <label for="txtAltura" class="form-label">Altura</label>
            <asp:TextBox ID="txtAltura" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" ForeColor="Red" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" Text="Aceptar" />
            <asp:Button ID="btnModificar" Visible="false" CssClass="btn btn-primary" OnClick="btnModificar_Click" runat="server" Text="Modificar" />
            <asp:Button ID="btnEliminar" Visible="false" CssClass="btn btn-danger" OnClick="btnEliminar_Click" runat="server" Text="Eliminar" />
            <asp:Button ID="btnCancelar" CssClass="btn btn-secondary" OnClick="btnCancelar_Click" runat="server" Text="Cancelar" />
        </div>
    </div>
</asp:Content>
