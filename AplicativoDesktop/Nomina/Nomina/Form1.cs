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

/*
--******************************************************                                                       
-- Proyecto:      Nomina
-- Responsable:   Daniel Oueilhe  
-- Fecha:         2020-10-08
-- Descripcion:   Interfas de usuario para Empleado(Registro, actualizacion, 
-- baja y movimiento de nomina)
-- ID:                                                                               
--******************************************************  
*/

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

            Buscar(long.Parse(txtNumero.Text.Trim()));
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

            // Obtener el ROL
            if (rbtnChofer.Checked)
                rol = rbtnChofer.Text;
            else if (rbtnCargador.Checked)
                rol = rbtnCargador.Text;
            else if (rbtnAuxiliar.Checked)
                rol = rbtnAuxiliar.Text;
            // Obtener el ROL
            if (rbtnInterno.Checked)
                tipo = rbtnInterno.Text;
            else if (rbtnExterno.Checked)
                tipo = rbtnExterno.Text;

            // Verifica si el Panel esta activo, para mostrar las opcion de Moficicar y eliminar
            if (pMovimiento.Visible)
            {
                if (rbtnModificar.Checked)
                    movimiento = rbtnModificar.Text;
                else if (rbtnEliminar.Checked)
                    movimiento = rbtnEliminar.Text;
            }
            else
                movimiento = "Nuevo";

            if (rol == "")
            {
                MessageBox.Show("Seleccion el rol", "Nomina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tipo == "")
            {
                MessageBox.Show("Seleccion el tipo", "Nomina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            empleados = new Empleados(long.Parse(txtNumero.Text), txtNombre.Text, rol, tipo, movimiento);

            // Interfas para almacenar informacion
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
        void Buscar(long numero)
        {
            Capa.Negocio.NominaEmpleados negocio = new Capa.Negocio.NominaEmpleados();
            Capa.Negocio.Empleados empleados = null;
            string msj = string.Empty;

            //Valida si existe empleado
            if (negocio.Buscar(numero, out empleados, out msj))
            {
                txtNombre.Enabled = false;
                pMovimiento.Visible = false;
                txtNumero.Enabled = true;
                txtNumero.Text = empleados.Numero.ToString();
                txtNombre.Text = empleados.Nombre;
                
                // Obtener el ROL
                if (empleados.Rol == rbtnChofer.Text)
                    rbtnChofer.Checked = true;
                else if (empleados.Rol == rbtnCargador.Text)
                    rbtnCargador.Checked = true;
                else if (empleados.Rol == rbtnAuxiliar.Text)
                    rbtnAuxiliar.Checked = true;

                // Obtener el TIPO
                if (empleados.Tipo == rbtnInterno.Text)
                    rbtnInterno.Checked = true;
                else if (empleados.Tipo == rbtnExterno.Text)
                    rbtnExterno.Checked = true;

                pMovimiento.Visible = true;
            }
            else
            {
                if (String.IsNullOrEmpty(msj))
                {
                    DialogResult dialogResult = MessageBox.Show("Número de empleado no existe, desea registralo", "Nomina", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show(msj, "Nomina", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    return;
                }
                pMovimiento.Visible = true;
            }
            txtNumero.Enabled = false;
            txtNombre.Enabled = true;
            rbtnChofer.Enabled = true;
            rbtnCargador.Enabled = true;
            rbtnAuxiliar.Enabled = true;
            rbtnInterno.Enabled = true;
            rbtnExterno.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnBuscar.Enabled = false;
        }
        void BuscarCaptura(long numero)
        {
            if (txtNumeroC.Text.Trim() == "")
            {
                MessageBox.Show("Capture el número", "Captura de movimiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Capa.Negocio.NominaEmpleados negocio = new Capa.Negocio.NominaEmpleados();
            Capa.Negocio.Empleados empleado = null;
            string msj = string.Empty;
            //Valida si existe empleado
            if (negocio.Buscar(numero, out empleado, out msj))
            {
                txtNumeroC.Enabled = true;
                txtNumeroC.Text = empleado.Numero.ToString();
                txtNombreC.Text = empleado.Nombre;
                txtRolC.Text = empleado.Rol;
                txtTipoC.Text = empleado.Tipo;
                txtFechaC.Text = String.Empty;
                txtCantidadEntregaC.Text = String.Empty;
                txtFechaC.Enabled = true;
                txtCantidadEntregaC.Enabled = true;
                cBoxCubrioTurnoC.Enabled = true;
                rbtnChoferC.Checked = false;
                rbtnCargadorC.Checked = false;
                rbtnCubrioInternoC.Checked = false;
                rbtnCubrioExternoC.Checked = false;
            }
            else
            {
                if (String.IsNullOrEmpty(msj))
                {
                    MessageBox.Show("Número de empleado no existe", "Nomina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show(msj, "Nomina", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    return;
                }

            }
            txtNombre.Enabled = true;
            rbtnChofer.Enabled = true;
            rbtnCargador.Enabled = true;
            rbtnAuxiliar.Enabled = true;
            rbtnInterno.Enabled = true;
            rbtnExterno.Enabled = true;
            pMovimiento.Visible = true;
            btnGuardarC.Enabled = true;
            btnCancelarC.Enabled = true;
            btnBuscarC.Enabled = false;
        }
        void LimpiarPanelEmpleado()
        {
            txtNumero.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtNumero.Enabled = true;
            txtNombre.Enabled = false;
            rbtnChofer.Checked = false;
            rbtnCargador.Checked = false;
            rbtnAuxiliar.Checked = false;
            rbtnInterno.Checked = false;
            rbtnExterno.Checked = false;
            rbtnChofer.Enabled = false;
            rbtnCargador.Enabled = false;
            rbtnAuxiliar.Enabled = false;
            rbtnInterno.Enabled = false;
            rbtnExterno.Enabled = false;
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
                Buscar(long.Parse(txtNumero.Text.Trim()));
                e.Handled = true;
            }
            else if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            txtNumeroC.Focus();
        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {

            BuscarCaptura(long.Parse(txtNumeroC.Text.Trim()));
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
            rbtnChoferC.Checked = false;
            rbtnCargadorC.Checked = false;
            rbtnCubrioExternoC.Checked = false;
            txtFechaC.Enabled = false;
            txtCantidadEntregaC.Enabled = false;
            cBoxCubrioTurnoC.Enabled = false;
            rbtnChoferC.Enabled = false;
            rbtnCargadorC.Enabled = false;
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

            //Obtener el ROL
            if (rbtnChoferC.Checked)
                rol = rbtnChoferC.Text;
            else if (rbtnCargadorC.Checked)
                rol = rbtnCargadorC.Text;

            //Obtener el TIPO
            if (rbtnCubrioInternoC.Checked)
                tipo = rbtnCubrioInternoC.Text;
            else if (rbtnCubrioExternoC.Checked)
                tipo = rbtnCubrioExternoC.Text;

            
            capturaMovimiento = new CapturaMovimiento(long.Parse(txtNumeroC.Text), txtFechaC.Text,
                        string.IsNullOrEmpty(txtCantidadEntregaC.Text.Trim()) ? 0 : Convert.ToInt32(txtCantidadEntregaC.Text.Trim()),
                        cBoxCubrioTurnoC.Checked,
                        cBoxCubrioTurnoC.Checked ? tipo : "",
                        cBoxCubrioTurnoC.Checked ? rol : "");
            
            string msj = string.Empty;

            //Inmterfaz para almacenar informacion
            if (!negocio.GuardarMovimiento(capturaMovimiento, msj))
            {
                if(string.IsNullOrEmpty(msj))
                MessageBox.Show("Error al guardar la información", "Captura de movimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(msj, "Captura de movimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Se guardo la información", "Captura de movimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarPanelCaptura();
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
                BuscarCaptura(long.Parse(txtNumeroC.Text.Trim()));
                e.Handled = true;
            }
            else if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
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

        private void txtNumeroC_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBoxCubrioTurnoC_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxCubrioTurnoC.Checked)
            {
                rbtnChoferC.Enabled = true;
                rbtnCargadorC.Enabled = true;
                rbtnCubrioInternoC.Enabled = true;
                rbtnCubrioExternoC.Enabled = true;
            }
            else
            {
                rbtnChoferC.Enabled = false;
                rbtnCargadorC.Enabled = false;
                rbtnCubrioInternoC.Enabled = false;
                rbtnCubrioExternoC.Enabled = false;
            }

        }
    }
}
