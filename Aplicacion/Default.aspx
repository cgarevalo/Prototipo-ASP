<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Aplicacion.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col">
            <label>Direcciones</label>
            <!-- Con DataKeyNames asignamos una dato clave, en este caso el Id de un objeto Auto, lo que pongamos tiene que ser igual a la property (Id y no ID, porque ID no existe en Dominio) -->
            <asp:GridView ID="dgvDirecciones" DataKeyNames="Id" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvDirecciones_SelectedIndexChanged" CssClass="table table-dark table-bordered" runat="server">
                <Columns>
                    <asp:BoundField HeaderText="Calle" DataField="Calle" />
                    <asp:BoundField HeaderText="Altura" DataField="Altura" />
                    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Acción" />
                </Columns>

            </asp:GridView>
            <div>
                <asp:Button ID="btnAgregar" CssClass="btn btn-primary" OnClick="btnAgregar_Click" runat="server" Text="Agregar" />
            </div>
        </div>
    </div>
</asp:Content>
