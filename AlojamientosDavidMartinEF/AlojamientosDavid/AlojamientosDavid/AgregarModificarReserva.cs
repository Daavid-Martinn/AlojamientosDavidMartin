using CapaDatos;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace AlojamientosDavid
{
    public partial class AgregarModificarReserva : Form
    {
        Gestion gestionar = new Gestion();
        private int idReserva;
        List<string> estados = new List<string> { "Pendiente", "Confirmada", "Cancelada", "Finalizada" };
        public AgregarModificarReserva(int id)
        {
            InitializeComponent();
            idReserva = id;
        }
        private void limpiar()
        {
            //Limpiar txt
            txtCantIns.Text = "";
            txtCantMod.Text = "";
            txtFianzaIns.Text = "";
            txtFianzaMod.Text = "";
            txtImporteIns.Text = "";
            txtImporteMod.Text = "";

            //Limpiar fechas
            dtpEntradaIns.Value=DateTime.Now;
            dtpEntradaMod.Value=DateTime.Now;
            dtpSalidaIns.Value=DateTime.Now;
            dtpSalidaMod.Value=DateTime.Now;

            //Limpiar comboBox
            cboEstadoIns.Text = "";
            cbdEstadoMod.Text = "";
            cbdCategoria.Text = "";
            cbdCliente.Text = "";
            cbdEstablecimiento.Text = "";
            cbdUdAlojamiento.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarModificarReserva_Load(object sender, EventArgs e)
        {
            if (idReserva == 0)
            {
                groupBoxModificar.Visible = false;
                cbdCategoria.Items.AddRange(gestionar.devolverCategorias().ToArray());
                cbdCategoria.DisplayMember = "NOMBRE_CATEGORIA";
                cbdCliente.Items.AddRange(gestionar.devolverClientes().ToArray());
                cbdCliente.DisplayMember = "NOMBRE";                
                cboEstadoIns.Items.AddRange(estados.ToArray());
            }
            else
            {
                groupBoxInsertar.Visible = false;
                RESERVA reserva = gestionar.reservaConcreta(idReserva);
                lblId.Text = reserva.IDRESERVA.ToString();
                lblUd.Text = reserva.UNIDADES_ALOJAMIENTO.NOMBRE_UNIDAD;
                lblCliente.Text = reserva.CLIENTE.NOMBRE;
                cbdEstadoMod.Items.AddRange(estados.ToArray());
            }
          
        }

        private void cbdCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdCategoria != null)
            {               
                CATEGORIA categoriaSeleccionada = (CATEGORIA)cbdCategoria.SelectedItem;

                var Establecimiento = gestionar.devolverEstablecimientos().Where(est=>est.IDCATEGORIA==categoriaSeleccionada.IDCATEGORIA).ToList();

                cbdEstablecimiento.DataSource = Establecimiento;
                cbdEstablecimiento.DisplayMember = "NOMBRE_COMERCIAL";
            }
            
        }

        private void cbdEstablecimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbdEstablecimiento != null)
            {
                ESTABLECIMIENTO establecimientoSeleccionado=(ESTABLECIMIENTO)cbdEstablecimiento.SelectedItem;

                var UdAlojamiento = gestionar.devolverUnidadesEstablecimiento().Where(u=>u.IDESTABLECIMIENTO==establecimientoSeleccionado.IDESTABLECIMIENTO).ToList();

                cbdUdAlojamiento.DataSource= UdAlojamiento;
                cbdUdAlojamiento.DisplayMember = "NOMBRE_UNIDAD";
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String cantStr = txtCantIns.Text;
            String fianzaStr=txtFianzaIns.Text;
            String importeStr=txtImporteIns.Text;
            if(!(short.TryParse(cantStr,out short cant))|| !(decimal.TryParse(fianzaStr, out decimal fianza))|| !(decimal.TryParse(importeStr, out decimal importe)))
            {
                MessageBox.Show("Introduce datos validos porfa");
                return;
            }
            ESTABLECIMIENTO est = (ESTABLECIMIENTO)cbdEstablecimiento.SelectedItem;
            UNIDADES_ALOJAMIENTO ud = (UNIDADES_ALOJAMIENTO)cbdUdAlojamiento.SelectedItem;
            CLIENTE cliente=(CLIENTE)cbdCliente.SelectedItem;
            String estado = (String)cboEstadoIns.SelectedItem;
            if (est == null || ud == null || cliente == null || estado == null)
            {
                MessageBox.Show("Te has dejado elementos por seleccionar");
                return;
            }
            try
            {
                gestionar.insertarReserva(est.IDESTABLECIMIENTO, ud.NUMERO, cliente.IDCLIENTE, dtpEntradaIns.Value, dtpSalidaIns.Value, cant, fianza, importe);
                MessageBox.Show("Se ha insertado correctamente la nueva reserva");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            String cantStr = txtCantMod.Text;
            String fianzaStr = txtFianzaMod.Text;
            String importeStr = txtImporteMod.Text;
            if (!(short.TryParse(cantStr, out short cant)) || !(decimal.TryParse(fianzaStr, out decimal fianza)) || !(decimal.TryParse(importeStr, out decimal importe)))
            {
                MessageBox.Show("Introduce datos validos porfa");
                return;
            }
            String estado = (String)cbdEstadoMod.SelectedItem;
            if (estado == null)
            {
                MessageBox.Show("No has seleccionado estado");
                return;
            }
            try
            {
                gestionar.editarReserva(idReserva, dtpEntradaMod.Value, dtpSalidaMod.Value, cant, estado, fianza, importe);
                MessageBox.Show($"Se ha modificado correctamente la reserva con id {idReserva}");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
