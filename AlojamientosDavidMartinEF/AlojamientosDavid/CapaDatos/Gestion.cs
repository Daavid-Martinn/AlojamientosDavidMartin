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

        //Consultas mas complejas
        public void editarReserva(int id, DateTime fechaEntrada, DateTime fechaSalida, int cantidadPersonas, string estado, decimal? fianza, decimal importeEstimado)
        {

        }
        public Boolean eliminarReserva(int id)
        {
            var reserva = gestionar.RESERVAS.Find(id);

            if (reserva != null)
            {
                var pago = gestionar.PAGOS
                    .FirstOrDefault(p => p.IDRESERVA == id);

                if (pago != null)
                {
                    gestionar.PAGOS.Remove(pago);
                }

                gestionar.RESERVAS.Remove(reserva);

                gestionar.SaveChanges();
                return true;
            }
            return false;
        }
        public void insertarReserva(short idEstablecimiento,short idNumeroUnidad,int idCliente,DateTime fechaEntrada,DateTime fechaSalida,short CantidadPersonas,decimal? fianza,decimal ImporteEstimado)
        {
            //comprobar que el cliente existe
            var cliente= gestionar.CLIENTES.Find(idCliente);
            if (cliente == null)
            {
                throw new Exception("El cliente seleccionado no existe");
            }

            //comprobar que el establecimiento existe
            var establecimiento =gestionar.ESTABLECIMIENTOS.Find(idEstablecimiento);
            if (establecimiento == null)
            {
                throw new Exception("El establecimiento seleccionado no existe");
            }

            //comprobar que la unidad de alojamiento existe dentor de ese alojamiento
            var unidadAlojamiento=gestionar.UNIDADES_ALOJAMIENTO.FirstOrDefault(u=>u.IDESTABLECIMIENTO==idEstablecimiento&&u.NUMERO==idNumeroUnidad);
            if (unidadAlojamiento == null)
            {
                throw new Exception("No existe esa unidad de alojamiento en ese establecimiento");
            }

            //Comprobaciones de fechas y numers negativos
            if (fechaSalida <= fechaEntrada)
            {
                throw new Exception("La fecha de salida debe ser posterior a la de entrada");
            }
            if (CantidadPersonas<=0)
            {
                throw new Exception("El numero de personas no puede ser inferior a 0");
            }
            if (fianza != null && fianza < 0)
            {
                throw new Exception("La fianza no puede ser inferior a 0");
            }
            if (ImporteEstimado < 0)
            {
                throw new Exception("El importe no puede ser inferior a 0");
            }
            //comprobar que no exista ya otra reserva para esa misma unidad en fechas incompatibles
            var yaExisteReserva=gestionar.RESERVAS.Any(r=>r.IDESTABLECIMIENTO==idEstablecimiento&&r.NUMERO_UNIDAD==idNumeroUnidad&&((r.FECHA_ENTRADA<fechaEntrada&&fechaEntrada<r.FECHA_SALIDA)||r.FECHA_ENTRADA<fechaSalida&&fechaSalida<r.FECHA_SALIDA));
            if (yaExisteReserva)
            {
                throw new Exception("Ya existe una reserva en esas fechas");
            }
            RESERVA res = new RESERVA()
            {
                IDESTABLECIMIENTO = idEstablecimiento,
                NUMERO_UNIDAD=idNumeroUnidad,
                IDCLIENTE=idCliente,
                FECHA_CREACION= DateTime.Now,
                FECHA_ENTRADA=fechaEntrada,
                FECHA_SALIDA=fechaSalida,
                CANTIDAD_PERSONAS=CantidadPersonas,
                ESTADO_RESERVA="Pendiente",
                FIANZA = fianza,
                IMPORTE_ESTIMADO=ImporteEstimado,

            };
            gestionar.RESERVAS.Add(res);
            gestionar.SaveChanges();
        }
        public Boolean eliminarPago(int id)
        {
            var pago=gestionar.PAGOS.Find(id);
            if(pago != null)
            {
                gestionar.PAGOS.Remove(pago);
                gestionar.SaveChanges();
                return true;
            }
            return false;
        }
        public void modificarPago(int idPago,decimal importe,DateTime? fechaPago,string metodoPago)
        {

        }
        public void insertarPago(int idReserva, decimal importe, string MetodoPago)
        {
            //Comprobaciones de si la reserva existe, si se puede pegar y si aun no ha sido pagada
            var reserva = gestionar.RESERVAS.Find(idReserva);

            if (reserva == null)
            {
                throw new Exception("La reserva no existe");
            }
            if (reserva.ESTADO_RESERVA == "Cancelada")
            {
                throw new Exception("No se puede pagar una reserva cancelada");
            }
            if (reserva.ESTADO_RESERVA == "Finalizada")
            {
                throw new Exception("No se puede pagar una reserva finalizada");
            }
            var existePago = gestionar.PAGOS.Any(p => p.IDRESERVA == idReserva);
            if (existePago)
            {
                throw new Exception("Esa reserva ya ha sido pagada");
            }

            //Comprobaciones de nulos y datos validos
            if (importe <= 0)
            {
                throw new Exception("El importe no puede ser negativo");
            }
            if (string.IsNullOrWhiteSpace(MetodoPago))
            {
                throw new Exception("El metodo de pago no puede estar vacio");
            }
            
            PAGO pago = new PAGO()
            { 
                IDRESERVA = idReserva,
                IMPORTE=importe,
                FECHA_PAGO=DateTime.Now,
                METODO_PAGO=MetodoPago
            };
            gestionar.PAGOS.Add(pago);
            gestionar.SaveChanges();
        }


    }
}
