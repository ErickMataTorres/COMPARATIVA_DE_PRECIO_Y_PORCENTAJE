using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ModernGUI_V3.Clases
{
    public class Marca
    {
        //-------------------Propiedades--------------------
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ecommerce { get; set; }
        //public int IdProveedor { get; set; }
        //---------------Constructor vacío--------------------
        public Marca()
        {
        }
        //-----------Constructor que recibe el parametro id que sirve para consultar datos----------------
        public Marca(int id)
        {
            Id = id;
            DataTable t = Clases.Conexion.ConsultaDatos(" TablaMarca ", "Id", Id.ToString(), "");
            if (t.Rows.Count > 0)//--------------Válida si existe algún renglón de la consulta hecha----------//
            {
                Nombre = t.Rows[0]["Nombre"].ToString();
                Ecommerce = t.Rows[0]["Ecommerce"].ToString();
                //IdProveedor = int.Parse(t.Rows[0]["IdProveedor"].ToString());
            }
            else
            {
                Id = -1;//--------Si no existe ningún reglón de la consulta hecha se le asigna un -1 al Id que sirve para válida si es una nueva marca o no------------//
            }
        }
    }
}
