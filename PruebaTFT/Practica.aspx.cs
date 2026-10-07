using System;
using System.Data.OleDb;
using System.Web.UI;

namespace PruebaTFT
{
    public partial class Practica : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            lblMensaje.Text = "Hola " + nombre;
        }

        protected void btnVerPersonas_Click(object sender, EventArgs e)
        {
            string ruta = Server.MapPath("~/App_Data/PruebaTFT.accdb");

            string conexion =
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta;

            using (OleDbConnection con = new OleDbConnection(conexion))
            {
                con.Open();

                string consulta = "SELECT Nombre FROM Personas";

                OleDbCommand comando = new OleDbCommand(consulta, con);
                OleDbDataReader lector = comando.ExecuteReader();

                lblPersonas.Text = "";

                while (lector.Read())
                {
                    lblPersonas.Text += lector["Nombre"].ToString() + "<br />";
                }
            }
        }

        protected void btnGuardarPersona_Click(object sender, EventArgs e)
        {
            string nombre = txtNuevaPersona.Text;

            string ruta = Server.MapPath("~/App_Data/PruebaTFT.accdb");

            string conexion =
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta;

            using (OleDbConnection con = new OleDbConnection(conexion))
            {
                con.Open();

                string consulta = "INSERT INTO Personas (Nombre) VALUES (?)";

                OleDbCommand comando = new OleDbCommand(consulta, con);
                comando.Parameters.AddWithValue("@Nombre", nombre);

                comando.ExecuteNonQuery();
            }

            lblGuardado.Text = "Persona guardada correctamente";
        }
    }
}