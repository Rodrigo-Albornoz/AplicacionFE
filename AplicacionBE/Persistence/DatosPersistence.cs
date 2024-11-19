using AplicacionBE.Entities;
using System;
using System.Data;
using System.IO;

namespace AplicacionBE.Persistence
{
    public class DatosPersistence
    {
        public DataTable DatosTable { get; set; } = new DataTable();

        public DatosPersistence()
        {
            DatosTable.TableName = "ListaDatos";
            //DatosTable.Columns.Add("Id", typeof(int));
            DatosTable.Columns.Add("Nombre");
            DatosTable.Columns.Add("Edad", typeof(int));
            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (File.Exists("Datos.xml"))
            {
                DatosTable.Clear(); // Limpiar la tabla antes de leer los datos
                DatosTable.ReadXml("Datos.xml");
            }
        }

        public void InsertarDatos(Datos datos)
        {
            //int id = NuevoId();

            DatosTable.Rows.Add(datos.Nombre, datos.Edad); // Agregar datos directamente

            DatosTable.WriteXml("Datos.xml");
        }

        //private int NuevoId()
        //{
        //    int nuevoId = 0;

        //    foreach (DataRow fila in DatosTable.Rows)
        //    {
        //        if (nuevoId < Convert.ToInt32(fila["Id"]))
        //        {
        //            nuevoId = Convert.ToInt32(fila["Id"]);
        //        }
        //    }

        //    nuevoId++;
        //    return nuevoId;
        //}

        //public Datos BuscarDatos(int id)
        //{
        //    Datos datos = null;

        //    foreach (DataRow fila in DatosTable.Rows)
        //    {
        //        if (Convert.ToInt32(fila["Id"]) == id)
        //        {
        //            datos = new Datos
        //            {
        //                Nombre = Convert.ToString(fila["Nombre"]),
        //                Edad = Convert.ToInt32(fila["Edad"])
        //            };
        //            break;
        //        }
        //    }

        //    return datos;
        //}
    }
}
