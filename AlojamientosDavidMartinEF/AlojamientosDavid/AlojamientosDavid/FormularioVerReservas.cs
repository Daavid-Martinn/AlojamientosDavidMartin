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
    public partial class FormularioVerReservas : Form
    {
        Gestion gestionar = new Gestion();
        int filaSeleccionada=0;
        public FormularioVerReservas()
        {
            InitializeComponent();
        }

        private void cargarReservas()
        {
            dgv1.DataSource = gestionar.devolverReservas().Select(r => new
            {
                r.IDRESERVA,
                Establecimiento = r.UNIDADES_ALOJAMIENTO.ESTABLECIMIENTO.NOMBRE_COMERCIAL,
                Unidad_Alojamiento = r.UNIDADES_ALOJAMIENTO.NOMBRE_UNIDAD,
                Cliente = r.CLIENTE.NOMBRE + " " + r.CLIENTE.APELLIDOS,
                r.FECHA_CREACION,
                r.FECHA_ENTRADA,
                r.FECHA_SALIDA,
                r.CANTIDAD_PERSONAS,
                r.ESTADO_RESERVA,
                Fianza = r.FIANZA ?? 0,
                r.IMPORTE_ESTIMADO,
            }).ToList();
        }

        private void FormularioVerReservas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReservasTodas_Click(object sender, EventArgs e)
        {
            cargarReservas();
            lblTitulo.Text = "Estos son las reservas registradas actualmente";
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
                RESERVA reserva = gestionar.reservaConcreta(id);
                dgv1.DataSource = new[]
                {
                    new
                    {
                        reserva.IDRESERVA,
                        Establecimiento = reserva.UNIDADES_ALOJAMIENTO.ESTABLECIMIENTO.NOMBRE_COMERCIAL,
                        Unidad_Alojamiento = reserva.UNIDADES_ALOJAMIENTO.NOMBRE_UNIDAD ?? "Sin nombre",
                        Cliente = reserva.CLIENTE.NOMBRE + " " + reserva.CLIENTE.APELLIDOS,
                        reserva.FECHA_CREACION,
                        reserva.FECHA_ENTRADA,
                        reserva.FECHA_SALIDA,
                        reserva.CANTIDAD_PERSONAS,
                        reserva.ESTADO_RESERVA,
                        Fianza = reserva.FIANZA ?? 0,
                        reserva.IMPORTE_ESTIMADO,
                    }
                }.ToList();

            lblTitulo.Text = "Esta es la reserva encontrada";
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
                MessageBox.Show("No has seleccionado ningun elemento de la lista");
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Seguro que quieres eliminar la reserva?","Confirmar", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No)
            {
                return;
            }
            if (gestionar.eliminarReserva(filaSeleccionada))
            {
                MessageBox.Show($"La reserva con id {filaSeleccionada} se elimino correctamente");
                cargarReservas();
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
                if (dgv1.Rows[e.RowIndex].Cells["IDRESERVA"].Value != null)
                {
                    filaSeleccionada = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["IDRESERVA"].Value);
                }
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            AgregarModificarReserva frm = new AgregarModificarReserva(0);
            frm.ShowDialog();
            cargarReservas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada == 0)
            {
                MessageBox.Show("No has seleccionado ningun elemento de la lista");
                return;
            }
            AgregarModificarReserva frm = new AgregarModificarReserva(filaSeleccionada);
            frm.ShowDialog();
            filaSeleccionada = 0;
            cargarReservas();

        }
    }
}
