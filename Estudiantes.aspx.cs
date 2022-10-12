using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace pr_web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Estudiantes estudiantes;
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                estudiantes = new Estudiantes();
                estudiantes.drop_tipo_sangre(drop_tipo_sangre);
                estudiantes.grid_estudiantes(grid_estudiantes);


            }

        }

        protected void btn_crear_Click(object sender, EventArgs e) {
            estudiantes = new Estudiantes();
            if (estudiantes.crear(txt_carne.Text, txt_nombres.Text, txt_apeillidos.Text, txt_direccion.Text, txt_telefono.Text, txt_correo_electronico.Text, drop_tipo_sangre.SelectedValue, txt_fecha_nacimiento.Text) > 0) {
                lbl_mensaje.Text = "Ingreso Exitoso...";
                estudiantes.grid_estudiantes(grid_estudiantes);
            }

        }


        protected void grid_estudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_carne.Text = grid_estudiantes.SelectedRow.Cells[2].Text;
            txt_nombres.Text = grid_estudiantes.SelectedRow.Cells[3].Text;
            txt_apeillidos.Text = grid_estudiantes.SelectedRow.Cells[4].Text;
            txt_direccion.Text = grid_estudiantes.SelectedRow.Cells[5].Text;
            txt_telefono.Text = grid_estudiantes.SelectedRow.Cells[6].Text;
            txt_correo_electronico.Text = grid_estudiantes.SelectedRow.Cells[7].Text;
            int indice = grid_estudiantes.SelectedRow.RowIndex;
            drop_tipo_sangre.SelectedValue = grid_estudiantes.DataKeys[indice].Values["id_tipo_sangre"].ToString();
            DateTime fecha_nacimiento = Convert.ToDateTime(grid_estudiantes.SelectedRow.Cells[9].Text);
            txt_fecha_nacimiento.Text = fecha_nacimiento.ToString("yyyy-MM-dd");

        }


        protected void grid_empleados_RowDeleting(object sender, GridViewDeletedEventArgs e)
        {
            estudiantes = new Estudiantes();
            if (estudiantes.borrar(Convert.ToInt32(e.Keys["id"])) > 0) 
            {
                lbl_mensaje.Text = "Borrado Exitoso...";
                estudiantes.grid_estudiantes(grid_estudiantes);
            }
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            estudiantes = new Estudiantes();
            if (estudiantes.actualizar(Convert.ToInt32(grid_estudiantes.SelectedValue) ,txt_carne.Text, txt_nombres.Text, txt_apeillidos.Text, txt_direccion.Text, txt_telefono.Text, txt_correo_electronico.Text, drop_tipo_sangre.SelectedValue, txt_fecha_nacimiento.Text) > 0) 
            {
                lbl_mensaje.Text = "Modificacion Exitosa...";
                estudiantes.grid_estudiantes(grid_estudiantes);
            }
        }
    }
}