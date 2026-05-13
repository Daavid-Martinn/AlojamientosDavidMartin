using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using CapaDatos;

namespace AlojamientosDavid
{
    public partial class FormularioVerPagos : Form
    {
        Gestion gestionar=new Gestion();
        int filaSeleccionada = 0;
        private void cargarPagos()
        {
            dgv1.DataSource = gestionar.devolverPagos().Select(p => new
            {
                p.IDPAGO,
                Reserva=p.IDRESERVA,
                p.IMPORTE,
                p.FECHA_PAGO,
                p.METODO_PAGO,
            }).ToList();
        }
        public FormularioVerPagos()
        {
            InitializeComponent();
        }

        private void btnPagosTodas_Click(object sender, EventArgs e)
        {
            cargarPagos();
            lblTitulo.Text = "Estos son todos los pagos registrados";
        }

        private void btnVover_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string idTxt = txtFiltrar.Text;

            if (idTxt.Length == 0 || !(int.TryParse(idTxt, out int id)))
            {
                MessageBox.Show("Introduce un Id correcto");
                return;
            }
            try
            {
                PAGO pago = gestionar.pagoConcreto(id);
                dgv1.DataSource = new[]
                {
                    new
                    {
                        pago.IDPAGO,
                        pago.IDRESERVA,
                        pago.IMPORTE,
                        pago.FECHA_PAGO,
                        pago.METODO_PAGO,
                    }
                }.ToList();

                lblTitulo.Text = $"Este es el pago con id {id}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada == 0)
            {
                MessageBox.Show("No has seleccionado ningun pago de la lista");
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Seguro que quieres eliminar este pago?", "Confirmar", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No)
            {
                return;
            }
            if (gestionar.eliminarPago(filaSeleccionada))
            {
                MessageBox.Show($"El pago con id {filaSeleccionada} se ha eliminado correctamente");
                cargarPagos();
                filaSeleccionada = 0;
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar");
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgv1.Rows[e.RowIndex].Cells["IDPAGO"].Value != null)
                {
                    filaSeleccionada = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["IDPAGO"].Value);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada == 0)
            {
                MessageBox.Show("No has seleccionado ningun pago de la lista");
                return;
            }
            try
            {
                PAGO pagoElegido = gestionar.pagoConcreto(filaSeleccionada);
                AgregarModificarPago frm = new AgregarModificarPago(pagoElegido.IDRESERVA, filaSeleccionada);
                frm.ShowDialog();
                filaSeleccionada = 0;
                cargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
