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


namespace AlojamientosDavid
{
    public partial class AgregarModificarPago : Form
    {
        Gestion gestionar=new Gestion();
        private int idReserva;
        private int idPago;
        public AgregarModificarPago(int idRes,int idPag)
        {
            InitializeComponent();
            idReserva = idRes;
            idPago = idPag;
        }

        private void limpiar()
        {
            txtImporteMod.Clear();
            txtMetodoIns.Clear();
            txtMetodoMod.Clear();
        }

        private void AgregarModificarPago_Load(object sender, EventArgs e)
        {
            if (idPago == 0)
            {
                groupBoxModificar.Visible = false;
                try
                {
                    RESERVA reserva = gestionar.reservaConcreta(idReserva);
                    lblIdReservaIns.Text = idReserva.ToString();
                    lblImporteIns.Text=reserva.IMPORTE_ESTIMADO.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                groupBoxInsertar.Visible = false;
                lblIdPagoMod.Text = idPago.ToString();
                lblReservaMod.Text = idReserva.ToString();
                PAGO pago = gestionar.pagoConcreto(idPago);
                txtImporteMod.Text = pago.IMPORTE.ToString();
                txtMetodoMod.Text = pago.METODO_PAGO;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if(!(decimal.TryParse(lblImporteIns.Text, out decimal importe)))
            {
                MessageBox.Show("El importe da error");
                return;
            }
            try
            {
                gestionar.insertarPago(idReserva,importe,txtMetodoIns.Text);
                MessageBox.Show($"Se ha insertado correctamente el pago asociado a la reserva con id {idReserva}");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImporteMod.Text))
            {
                MessageBox.Show("El importe es obligatorio");
                return;
            }
            if (!(decimal.TryParse(txtImporteMod.Text, out decimal importe)))
            {
                MessageBox.Show("Introduce un importe válido");
                return;
            }
            try
            {
                gestionar.modificarPago(idPago, importe,DateTime.Now, txtMetodoMod.Text);
                MessageBox.Show($"Se ha modificado correctamente el pago asociado a la reserva con id {idReserva}");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
