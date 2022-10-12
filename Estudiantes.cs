using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.IU.Web;

namespace Modelo
{
    
    public class Estudiantes{
        ConexionBD conectar;
        private DataTable drop_tipo_sangre(){
            DataTable tabla = new DataTable();
            conectar = new ConexionBD();
            conectar.AbrirConexion();
            string consulta = string.Format("select id_tipo_sangre as id,sangre from tipos_sangre;");
            MySqlDataAdapter query = new MySqlDataAdapter(consulta, conectar.conectar);
            query.Fill(tabla);
            conectar.CerrarConexion();
            return tabla;

        }
        private DataTable grid_estudiantes(){           
                DataTable tabla = new DataTable();
                conectar = new ConexionBD();
                conectar.AbrirConexion();
                string consulta = string.Format("SELECT e.id_estudiantes as id,e.carne,e.nombres,e.apeillidos,e.direccion,e.telefono,e.correo_electronico,t.sangre,e.fecha_nacimiento,e.id_tipo_sangre FROM estudiantes as e inner join tipos_sangre as t on e.id_tipo_sangre = t.id_tipo_sangre;");
                MySqlDataAdapter query = new MySqlDataAdapter(consulta, conectar.conectar);
                query.Fill(tabla);
                conectar.CerrarConexion();
                return tabla;
            }
public void drop_tipo_sangre (DropDownList drop){
            drop.ClearSelection();
            drop.Items.Clear();
            drop.AppendDataBoundItems = true;
            drop.Items.Add("<< Elige Tipo Sangre >>");
            drop.Items[0].Value = "0";
            drop.DataSource = drop_tipo_sangre();
            drop.DataTextField = "Tipo Sangre";
            drop.DataValueField = "id";
            drop.DataBind();

        }
            public void grid_estudiantes(GridView grid){ 
                grid.DataSource = grid_estudiantes();
                grid.DataBind();

            }
        public int crear(string carne, string nombres, string apeillidos, string direccion, string telefono, string correo_electronico, int id_tipo_sangre, string fecha_nacimiento, ){
            int no = 0;
            conectar = new ConexionBD();
            conectar.AbrirConexion();
            string consulta = string.Format("INSERT INTO estudiantes(carne,nombres,apeillidos,direccion,telefono,correo_electronico,id_tipo_sangre,fecha_nacimiento) VALUES('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}',);",carne,nombres,apeillidos,direccion,telefono,correo_electronico,id_tipo_sangre,fecha_nacimiento);
            MySqlCommand query = new MySqlCommand(consulta,conectar.conectar);
            query.Connection = conectar.conectar;
            no = query.ExecuteNonQuery();
            conectar.CerrarConexion();
            return no;

        } 
        public int actualizar(int id, string carne, string nombres, string apeillidos, string direccion, string telefono, string correo_electronico, int id_tipo_sangre, string fecha_nacimiento, )
        {
            int no = 0;
            conectar = new ConexionBD();
            conectar.AbrirConexion();
            string consulta = string.Format("update estudiantes set carne='{0}',nombres='{1}',apeillidos='{2}',direccion='{3}',telefono='{4}',correo_electronico='{5}',id_tipo_sangre={6},fecha_nacimiento='{7}' where id_estudiantes = {8};", carne, nombres, apeillidos, direccion, telefono, correo_electronico, id_tipo_sangre, fecha_nacimiento,id);
            MySqlCommand query = new MySqlCommand(consulta, conectar.conectar);
            query.Connection = conectar.conectar;
            no = query.ExecuteNonQuery();
            conectar.CerrarConexion();
            return no;

        }
        public int borrar(int id)
        {
            int no = 0;
            conectar = new ConexionBD();
            conectar.AbrirConexion();
            string consulta = string.Format("delete from estudiantes where id_estudiantes = {0};", id);
            MySqlCommand query = new MySqlCommand(consulta, conectar.conectar);
            query.Connection = conectar.conectar;
            no = query.ExecuteNonQuery();
            conectar.CerrarConexion();
            return no;

        }
    }
}
