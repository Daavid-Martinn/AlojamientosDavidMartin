using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BuscarServidor;
using System.Runtime.Remoting.Messaging;

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

        public List<CLIENTE>devolverClientes(){
            return gestionar.CLIENTES.OrderBy(cl=>cl.NOMBRE).ToList();
            }
        public List<ESTABLECIMIENTO> devolverEstablecimientos()
        {
            return gestionar.ESTABLECIMIENTOS.ToList();
        }
        public List<UNIDADES_ALOJAMIENTO> devolverUnidadesEstablecimiento()
        {
            return gestionar.UNIDADES_ALOJAMIENTO.ToList();
        }
        public List<RESERVA> devolverReservas()
        {
            return gestionar.RESERVAS.ToList();
        }
        public RESERVA reservaConcreta(int id)
        {
            return gestionar.RESERVAS.Find(id);
        }
        public List<PAGO> devolverPagos()
        {
            return gestionar.PAGOS.ToList();
        }
        public PAGO pagoConcreto(int id)
        {
            return gestionar.PAGOS.Find(id);
        }
        public void editarReserva(int id, DateTime fechaEntrada, DateTime fechaSalida, int cantidadPersonas, string estado, decimal? fianza, decimal importeEstimado)
        {

        }
        public void eliminarReserva(int id)
        {

        }
        public void insertarReserva(int idEstablecimiento,int idNumeroUnidad,int idCliente,DateTime fechaEntrada,DateTime fechaSalida,int CantidadPersonas,decimal? fianza,decimal ImporteEstimado)
        {

        }
        public void eliminarPago(int id)
        {

        }
        public void modificarPago(int idPago,decimal importe,DateTime? fechaPago,string metodoPago)
        {

        }
        public void insertarPago(int idReserva, decimal importe, DateTime? FechaPago, string MetodoPago)
        {

        }


    }
}
