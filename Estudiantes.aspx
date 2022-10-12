<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Estudiantes.aspx.cs" Inherits="pr_web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Formulario Empleados</h1>
    <asp:Label ID="lbl_carne" runat="server" Text="Carne" CssClass="badge" Font-Size="Small"></asp:Label>
    <asp:TextBox ID="txt_carne" runat="server" CssClass="form-control" placeholder="Eje: E001"></asp:TextBox>
    <asp:Label ID="lbl_nombres" runat="server" Text="Nombres" CssClass="badge" Font-Size="Small"></asp:Label>
    <asp:TextBox ID="txt_nombres" runat="server" CssClass="form-control" placeholder="Eje: Nombre1 Nombre2"></asp:TextBox>
    <asp:Label ID="lbl_apeillidosLabel1" runat="server" Text="Apellidos" CssClass="badge" Font-Size="Small"></asp:Label>
    <asp:TextBox ID="txt_apeillidos" runat="server" CssClass="form-control" placeholder="Eje: Apell1 Apell2"></asp:TextBox>
    <asp:Label ID="lbl_direccion" runat="server" Text="Direccion" CssClass="badge" Font-Size="Small"></asp:Label>
    <asp:TextBox ID="txt_direccion" runat="server" CssClass="form-control" placeholder="Eje: #Casa calle avenida lugar"></asp:TextBox>
    <asp:Label ID="lbl_telefono" runat="server" Text="Telefono" CssClass="badge" Font-Size="Small"></asp:Label>
    <asp:TextBox ID="txt_telefono" runat="server" CssClass="form-control" placeholder="Eje: 55552222" TextMode="Number"></asp:TextBox>
    <asp:Label ID="lbl_correo_electronico" runat="server" Text="Correo Electronico" CssClass="badge" Font-Size="Small"></asp:Label>
    <asp:TextBox ID="txt_correo_electronico" runat="server" CssClass="form-control" placeholder="Correo Electronico"></asp:TextBox>
    <asp:Label ID="lbl_tipo_sangre" runat="server" Text="Tipo sangre" CssClass="badge" Font-Size="Small"></asp:Label>
    <asp:DropDownList ID="drop_tipo_sangre" runat="server" CssClass="form-control"></asp:DropDownList>
    <asp:Label ID="lbl_fecha_nacimiento" runat="server" Text="Fecha Nacimiento" CssClass="badge" Font-Size="Small"></asp:Label>
    <asp:TextBox ID="txt_fecha_nacimiento" runat="server" CssClass="form-control" placeholder="yyyy-mm-dd" TextMode="Date"></asp:TextBox>
    <asp:Button ID="btn_crear" runat="server" Text="Crear" CssClass="btn btn-primary" OnClick="btn_crear_Click" />
    <asp:Button ID="btn_actualizar" runat="server" Text="Actualizar" CssClass="btn btn-success" />
    <asp:Button ID="btn_borrar" runat="server" Text="Borrar" CssClass="btn btn-danger" /> 
    <asp:Label ID="lbl_mensaje" runat="server" CssClass="badge" Font-Size="Small"></asp:Label>
    <asp:GridView ID="grid_estudiantes" runat="server" AutoGenerateColumns="False" CssClass="table-condensed" DataKeyNames="id,id_tipo_sangre">
        <Columns>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btn_select" runat="server" CausesValidation="False" CommandName="Select" Text="ver" CssClass="btn btn-info" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btn_borrar" runat="server" CausesValidation="False" CommandName="Delete" Text="Borrar" CssClass="btn btn-danger" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="carne" HeaderText="Carne" />
            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
            <asp:BoundField DataField="apeillidos" HeaderText="Apellidos" />
            <asp:BoundField DataField="direccion" HeaderText="Direccion" />
            <asp:BoundField DataField="telefono" HeaderText="Telefono" />
            <asp:BoundField DataField="correo_electronico" HeaderText="Correo Electronico" />
            <asp:BoundField DataField="tipo_sangre" HeaderText="Tipo Sangre" />
            <asp:BoundField DataField="fecha_nacimiento" HeaderText="Fecha Nacimiento" />
        </Columns>
    </asp:GridView>
</asp:Content>
