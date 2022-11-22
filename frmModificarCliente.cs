using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryBaldovinoIEFI
{
    public partial class frmModificarCliente : Form
    {
        public frmModificarCliente()
        {
            InitializeComponent();
        }

        private void frmModificarCliente_Load(object sender, EventArgs e)
        {
            clsBarrio CompletarLstBarrio = new clsBarrio();
            CompletarLstBarrio.llenarLst(lstBarrio);
            clsActividad CompletarLstAct = new clsActividad();
            CompletarLstAct.llenarLst(lstActividad);

        }
        private void verificacionBoton()
        {
            if (mskDNI.Text != "")
            {
                cmdConsultar.Enabled = true;
                cmdModificar.Enabled = true;
            }
            else
            {
                cmdConsultar.Enabled = false;
                cmdModificar.Enabled =false;
            }
        }
        private void verificacionBotones()
        {
            if (txtNombreYApellido.Text != "" && mskDNI.Text != "" && mskSaldo.Text != "" && lstBarrio.SelectedIndex >= 0 && lstActividad.SelectedIndex >= 0)
            {
                cmdModificar.Enabled = true;
            }
            else
            {
                cmdModificar.Enabled = false;
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreYApellido_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void mskSaldo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void mskDNI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void mskDNI_TextChanged(object sender, EventArgs e)
        {
            verificacionBoton();
        }

        private void mskSaldo_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            //Deshabilito los botones que no uso
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = true;
            
            //Habilito los txt, msk y lst
            txtNombreYApellido.ReadOnly = false;
            mskSaldo.ReadOnly = false;
            lstBarrio.Enabled = true;
            lstActividad.Enabled = true;
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Int32 DNI = Convert.ToInt32(mskDNI.Text);
            clsClientes Buscar = new clsClientes();
            Buscar.Buscar(DNI);

            if (Buscar.DniCliente != DNI)
            {
                MessageBox.Show("El deportista no se encuentra en la base de datos");
            }
            else
            {
                txtNombreYApellido.Text = Buscar.Nombre;
                mskSaldo.Text = Convert.ToString(Buscar.SaldoCliente);
                lstBarrio.SelectedValue = Convert.ToString(Buscar.BarrioCliente);
                lstActividad.SelectedValue = Convert.ToString(Buscar.ActividadCliente);
            }

            //habilito los botones
            cmdEliminar.Enabled = true;
            cmdModificar.Enabled = true;
            BloquearTxt();


        }
        private void BloquearTxt()
        {
            txtNombreYApellido.ReadOnly = true;
            mskSaldo.ReadOnly = true;
            lstBarrio.Enabled = false;
            lstActividad.Enabled = false;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            Int32 dniModificar = Convert.ToInt32(mskDNI.Text);

            clsClientes Modificar = new clsClientes();

            Modificar.DniCliente = Convert.ToInt32(mskDNI.Text);
            Modificar.Nombre = txtNombreYApellido.Text;
            Modificar.SaldoCliente = Convert.ToInt32(mskSaldo.Text);
            Modificar.ActividadCliente = Convert.ToInt32(lstActividad.SelectedValue);
            Modificar.BarrioCliente = Convert.ToInt32(lstBarrio.SelectedValue);

            Modificar.Modificar(dniModificar);
            MessageBox.Show("Datos guardados con exito");

            //Limpiar();
            txtNombreYApellido.Focus();
        }

        private void mskSaldo_ReadOnlyChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Int32 DNIeliminar = Convert.ToInt32(mskDNI.Text);

            clsClientes Eliminar = new clsClientes();

            Eliminar.Eliminar(DNIeliminar);
            MessageBox.Show("Datos borrados con éxito");

            //Limpiar();
        }
    }
}
