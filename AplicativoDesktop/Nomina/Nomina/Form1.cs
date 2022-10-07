using Nomina.Capa.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumero.Focus();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Buscar(txtNumero.Text.Trim());
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text.Trim() == "")
            {
                MessageBox.Show("Capture el número", "Nomina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Capa.Negocio.NominaEmpleados negocio = new Capa.Negocio.NominaEmpleados();
            Capa.Negocio.Empleados empleados = null;

            string rol = string.Empty;
            string tipo = string.Empty;
            string movimiento = string.Empty;

            if (rbtnChofer.Checked)
                rol = rbtnChofer.Text;
            else if (rbtnCargador.Checked)
                rol = rbtnCargador.Text;
            else if (rbtnAuxiliar.Checked)
                rol = rbtnAuxiliar.Text;

            if (rbtnChofer.Checked)
                tipo = rbtnChofer.Text;
            else if (rbtnCargador.Checked)
                tipo = rbtnCargador.Text;

            if (pMovimiento.Visible)
            {
                if (rbtnModificar.Checked)
                    movimiento = rbtnModificar.Text;
                else if (rbtnEliminar.Checked)
                    movimiento = rbtnEliminar.Text;
            }
            else
                movimiento = "NUEVO";

            empleados = new Empleados(txtNumero.Text, txtNombre.Text, "Cargador", "Interno", movimiento);

            if (!negocio.GuardarEmpleado(empleados))
            {
                MessageBox.Show("Error al guardar la información", "Nomina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Se guardo la información", "Nomina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarPanelEmpleado();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPanelEmpleado();
        }
        void Buscar(string numero)
        {
            Capa.Negocio.NominaEmpleados negocio = new Capa.Negocio.NominaEmpleados();
            Capa.Negocio.Empleados empleados = null;

            if (negocio.Buscar(numero, out empleados))
            {
                txtNombre.Enabled = false;
                pMovimiento.Visible = false;
                txtNumero.Enabled = true;
                txtNumero.Text = empleados.Numero;
                txtNombre.Text = empleados.Nombre;

                if (empleados.Rol == rbtnChofer.Text)
                    rbtnChofer.Checked = true;
                else if (empleados.Rol == rbtnCargador.Text)
                    rbtnCargador.Checked = true;
                else if (empleados.Rol == rbtnAuxiliar.Text)
                    rbtnCargador.Checked = true;

                if (empleados.Tipo == rbtnInterno.Text)
                    rbtnInterno.Checked = true;
                else if (empleados.Tipo == rbtnExterno.Text)
                    rbtnExterno.Checked = true;
            }
            else
            {
                txtNumero.Enabled = true;
                pMovimiento.Visible = false;
            }
            txtNombre.Enabled = true;
            rbtnChofer.Enabled = true;
            rbtnCargador.Enabled = true;
            rbtnAuxiliar.Enabled = true;
            rbtnInterno.Enabled = true;
            rbtnExterno.Enabled = true;
            pMovimiento.Visible = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnBuscar.Enabled = false;
        }
        void BuscarCaptura(string numero)
        {
            if (txtNumeroC.Text.Trim() == "")
            {
                MessageBox.Show("Capture el número", "Captura de movimiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Capa.Negocio.NominaEmpleados negocio = new Capa.Negocio.NominaEmpleados();
            Capa.Negocio.Empleados empleado = null;

            if (negocio.Buscar(numero, out empleado))
            {
                txtNumeroC.Enabled = true;
                txtNumeroC.Text = empleado.Numero;
                txtNombreC.Text = empleado.Nombre;
                txtRolC.Text = empleado.Rol;
                txtTipoC.Text = empleado.Tipo;
                txtFechaC.Text = String.Empty;
                txtCantidadEntregaC.Text = String.Empty;
                txtFechaC.Enabled = true;
                txtCantidadEntregaC.Enabled = true;
                cBoxCubrioTurnoC.Enabled = true;
                rbtnCubrioInternoC.Enabled = true;
                rbtnCubrioExternoC.Enabled = true;
                rbtnCubrioInternoC.Checked = false;
                rbtnCubrioExternoC.Checked = false;
            }
            else
            {
                MessageBox.Show("No existe el numero de empleado", "Nomina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtNombre.Enabled = true;
            rbtnChofer.Enabled = true;
            rbtnCargador.Enabled = true;
            rbtnAuxiliar.Enabled = true;
            rbtnInterno.Enabled = true;
            rbtnExterno.Enabled = true;
            pMovimiento.Visible = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnBuscar.Enabled = false;
        }
        void LimpiarPanelEmpleado()
        {
            txtNumero.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtNumero.Enabled = true;
            txtNombre.Enabled = false;
            rbtnChofer.Checked = false;
            rbtnCargador.Checked = false;
            rbtnCargador.Checked = false;
            rbtnInterno.Checked = false;
            rbtnExterno.Checked = false;
            rbtnChofer.Enabled = false;
            rbtnCargador.Enabled = false;
            rbtnCargador.Enabled = false;
            rbtnInterno.Enabled = false;
            rbtnExterno.Enabled = false;
            rbtnModificar.Enabled = false;
            rbtnEliminar.Enabled = false;
            pMovimiento.Visible = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtNumero.Focus();
            btnBuscar.Enabled = true;
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                Buscar(txtNumero.Text.Trim());
                e.Handled = true;
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            txtNumeroC.Focus();
        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {

            BuscarCaptura(txtNumeroC.Text.Trim());
        }

        void LimpiarPanelCaptura()
        {
            txtNumeroC.Text = String.Empty;
            txtNombreC.Text = String.Empty;
            txtRolC.Text = String.Empty;
            txtTipoC.Text = String.Empty;
            txtFechaC.Text = String.Empty;
            txtCantidadEntregaC.Text = String.Empty;
            cBoxCubrioTurnoC.Checked = false;
            rbtnCubrioInternoC.Checked = false;
            rbtnCubrioExternoC.Checked = false;
            txtFechaC.Enabled = false;
            txtCantidadEntregaC.Enabled = false;
            cBoxCubrioTurnoC.Enabled = false;
            rbtnCubrioInternoC.Enabled = false;
            rbtnCubrioExternoC.Enabled = false;
            btnGuardarC.Enabled = false;
            btnCancelarC.Enabled = false;
            txtNumeroC.Focus();
            btnBuscarC.Enabled = true;
        }
        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            Capa.Negocio.NominaEmpleados negocio = new Capa.Negocio.NominaEmpleados();
            Capa.Negocio.CapturaMovimiento capturaMovimiento = null;

            if (txtFechaC.Text.Trim() == "")
            {
                MessageBox.Show("Capture la fecha", "Nomina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rol = string.Empty;
            string tipo = string.Empty;

            if (rbtnChoferC.Checked)
                rol = rbtnChoferC.Text;
            else if (rbtnCargadorC.Checked)
                rol = rbtnCargadorC.Text;

            if (rbtnChoferC.Checked)
                tipo = rbtnChoferC.Text;
            else if (rbtnCargadorC.Checked)
                tipo = rbtnCargadorC.Text;


            capturaMovimiento = new CapturaMovimiento(txtNumeroC.Text, txtFechaC.Text,
                        string.IsNullOrEmpty(txtCantidadEntregaC.Text.Trim()) ? 0 : Convert.ToInt32(txtCantidadEntregaC.Text.Trim()),
                        cBoxCubrioTurnoC.Checked,
                        cBoxCubrioTurnoC.Checked ? tipo : "",
                        cBoxCubrioTurnoC.Checked ? rol : "");

            if (!negocio.GuardarMovimiento(capturaMovimiento))
            {
                MessageBox.Show("Error al guardar la información", "Captura de movimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Se guardo la información", "Captura de movimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarPanelEmpleado();
            }
        }

        private void btnCancelarC_Click(object sender, EventArgs e)
        {
            LimpiarPanelCaptura();
        }

        private void txtNumeroC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                BuscarCaptura(txtNumero.Text.Trim());
                e.Handled = true;
            }
        }

        private void txtCantidadEntregaC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadEntregaC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
