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
using static System.Collections.Specialized.BitVector32;
using System.Collections;

namespace AlojamientosDavid
{
    public partial class FormConsultasGenerales : Form
    {
        Gestion gestionar= new Gestion();
        public FormConsultasGenerales()
        {
            InitializeComponent();
        }

        private void btnVover_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlojamientos_Click(object sender, EventArgs e)
        {
            
            dgv1.DataSource = gestionar.devolverEstablecimientos().Select(a => new
            {
                a.IDESTABLECIMIENTO,
                a.NOMBRE_COMERCIAL,
                a.DIRECCION,
                a.TELEFONO,
                a.EMAIL,
                Categoria=a.CATEGORIA.NOMBRE_CATEGORIA,
            }).ToList();
            lblTitulo.Text = "Estos son todos los establecimientos disponibles";
        }

        private void btnUnidades_Click(object sender, EventArgs e)
        {
            dgv1.DataSource=gestionar.devolverUnidadesEstablecimiento().Select(u => new
            {
                Establecimiento=u.ESTABLECIMIENTO.NOMBRE_COMERCIAL,
                u.NUMERO,
                u.NOMBRE_UNIDAD,
                Capacidad=u.CAPACIDAD_MAX,
                u.ESTADO,
                u.PRECIO_NOCHE,
                u.DESCRIPCION,
            }).ToList();
            lblTitulo.Text = "Estos son las unidades de alojamiento disponibles";
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = gestionar.devolverClientes().Select(c => new
            {
                c.IDCLIENTE,
                c.DNI_NIE,
                Nombre_Completo=c.NOMBRE+" "+c.APELLIDOS,
                c.TELEFONO,
                c.EMAIL,
            }).ToList();
            lblTitulo.Text = "Estos son todos los clientes registrados";
        }
    }
}
