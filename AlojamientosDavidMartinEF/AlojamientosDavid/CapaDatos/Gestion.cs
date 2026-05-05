using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BuscarServidor;

namespace CapaDatos
{
    public class Gestion
    {
        private AlojamientosDavidMartinEntities gestionar;
        public Gestion()
        {
            // Modificamos el servidor, indicando el nombre del modelo creado, así como de la base de datos con la que queremos conectar 
            string servidor = MiServidor.Servidor(out string errores);
            string modelo = "res://*/ModelAlojamientos.csdl|res://*/ModelAlojamientos.ssdl|res://*/ModelAlojamientos.msl"; // Nombre del Modelo concreto de nuestra base de datos 
            string baseDatos = "AlojamientosDavidMartin"; // Nombre de la base de datos 
            string cadenaConexion = $@"metadata={modelo};provider=System.Data.SqlClient;provider connection string=""data source={servidor};initial catalog={baseDatos};integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework""";
            gestionar = new AlojamientosDavidMartinEntities(cadenaConexion); // Modificar el constructor de EstadoEntities y los nombres de la Base de datos, modelo, …
        }
        //Al crear los modelos en entities me he equivocado y les he puesto de nombre ModelEstado como en el ejercicio anterior, lo digo porque puede haber confusion
    }
}
