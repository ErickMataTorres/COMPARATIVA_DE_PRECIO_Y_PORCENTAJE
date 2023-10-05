using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ModernGUI_V3.Clases
{
    public class Conexion
    {
        //--------------------------------Dirección para conectar con Sql----------------------------------//
        static public SqlConnection conx = new SqlConnection(@"Data Source=A;Initial Catalog=LlantiRed;Integrated Security=Yes");
        //------------------------Para abrir conexión------------------------------//
        static public void Conectar()
        {
            conx.Open();
        }
        //------------------------Para cerrar conexión-----------------------------//
        static public void Desconectar()
        {
            conx.Close();
        }
        //------------------------------ComboBoxs-----------------------------//
        static public DataTable ConsultaComboBox(string tabla, string campos)
        {
            Conectar();
            DataTable t = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select " + campos + " from " + tabla, conx);
            da.Fill(t);
            Desconectar();
            return t;
        }
        //-----------------------------Para consultar maximo de un numero en Sql------------------------------------//
        static public int ConsultaMaximo(string tabla, string instruccionMax)
        {
            Conectar();
            SqlCommand command = new SqlCommand("Select " + instruccionMax + " from " + tabla, conx);
            int maximo = int.Parse(command.ExecuteScalar().ToString());
            Desconectar();
            return maximo;
        }
        //------------------------------Para consultar datos de Sql----------------------------------//
        static public DataTable ConsultaDatos(string tabla, string condicion, string modelo, string medida)
        {
            Conectar();
            DataTable t = new DataTable();
            //SqlCommand command = new SqlCommand("Select * from TablaLlantas where Modelo+Medida=" + (modelo + medida), conx);
            SqlDataAdapter da = new SqlDataAdapter("Select * from " + tabla + " where " + condicion + "=" + "'" + (modelo + medida) + "'", conx);
            da.Fill(t);
            Desconectar();
            return t;
        }
        //-------------------------------------Para hacer un buscar-------------------------------------//
        static public DataTable Buscar(string tabla, string campos, string orden, string filtro, string otraCondicion)
        {
            DataTable t = new DataTable();
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Select " + campos + " from " + tabla + " where " + orden + " like '%" + filtro + "%' " + otraCondicion + " order by " + orden, conx);
            da.Fill(t);
            Desconectar();
            return t;
        }
        //-----------------Para consultar datos de Sql con DataTable para DataGridViews--------------------//
        static public DataTable ConsultaDataGrid(string tabla, string campos)
        {
            DataTable t = new DataTable();
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Select " + campos + " from " + tabla, conx);
            da.Fill(t);
            Desconectar();
            return t;
        }
        //----------------------------------Para llantas-------------------------------------//
        //--------Para guardar una llanta--------//
        static public void GuardarLlanta(Clases.Llanta llanta)
        {
            SqlCommand command = new SqlCommand("spGuardarLlanta2", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Marca", llanta.Marca);
            command.Parameters.AddWithValue("@Modelo", llanta.Modelo);
            command.Parameters.AddWithValue("@Medida", llanta.Medida);
            command.Parameters.AddWithValue("@Precio", llanta.Precio);
            command.Parameters.AddWithValue("@Ecommerce", llanta.Ecommerce);
            //command.Parameters.AddWithValue("@IdProveedor", llanta.IdProveedor);
            //command.Parameters.AddWithValue("@IdCategoria", llanta.IdCategoria);
            //command.Parameters.AddWithValue("@IdGenero", llanta.IdGenero);
            Conectar();
            command.ExecuteNonQuery();
            Desconectar();
        }
        //-------Para eliminar una llanta-------//
        static public void EliminaLlanta(string modelo, string medida)
        {
            SqlCommand command = new SqlCommand("spEliminarLlanta2", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Modelo", modelo);
            command.Parameters.AddWithValue("@Medida", medida);
            Conectar();
            command.ExecuteNonQuery();
            Desconectar();
        }
        //-------------------------------Para proveedor----------------------------------//
        //----------Para guardar un proveedor----------//
        static public void GuardarProveedor(Clases.Proveedor proveedor)
        {
            SqlCommand command = new SqlCommand("spGuardarProveedor", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", proveedor.Id);
            command.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
            command.Parameters.AddWithValue("@Domicilio", proveedor.Domicilio);
            command.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
            command.Parameters.AddWithValue("@Correo", proveedor.Correo);
            Conectar();
            command.ExecuteNonQuery();
            Desconectar();
        }
        //---------Para eliminar un proveedor---------//
        static public void EliminaProveedor(int id)
        {
            SqlCommand command = new SqlCommand("spEliminarProveedor", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            Conectar();
            command.ExecuteNonQuery();
            Desconectar();
        }
        //---------------------------------------Para Marca------------------------------------//
        //-------------Para guardar una marca---------//
        static public void GuardarMarca(Clases.Marca marca)
        {
            SqlCommand command = new SqlCommand("spGuardarMarca", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", marca.Id);
            command.Parameters.AddWithValue("@Nombre", marca.Nombre);
            command.Parameters.AddWithValue("@Ecommerce", marca.Ecommerce);
            //command.Parameters.AddWithValue("@IdProveedor", marca.IdProveedor);
            Conectar();
            command.ExecuteNonQuery();
            Desconectar();
        }
        //-----------Para eliminar una marca--------//
        static public void EliminaMarca(int id)
        {
            SqlCommand command = new SqlCommand("spEliminarMarca", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            Conectar();
            command.ExecuteNonQuery();
            Desconectar();
        }
    }
}
