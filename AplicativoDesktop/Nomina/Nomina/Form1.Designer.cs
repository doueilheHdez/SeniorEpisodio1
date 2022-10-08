namespace Nomina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pMovimiento = new System.Windows.Forms.Panel();
            this.rbtnEliminar = new System.Windows.Forms.RadioButton();
            this.rbtnModificar = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnExterno = new System.Windows.Forms.RadioButton();
            this.rbtnInterno = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnAuxiliar = new System.Windows.Forms.RadioButton();
            this.rbtnCargador = new System.Windows.Forms.RadioButton();
            this.rbtnChofer = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelarC = new System.Windows.Forms.Button();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCantidadEntregaC = new System.Windows.Forms.MaskedTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rbtnCubrioExternoC = new System.Windows.Forms.RadioButton();
            this.rbtnCubrioInternoC = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbtnCargadorC = new System.Windows.Forms.RadioButton();
            this.rbtnChoferC = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.cBoxCubrioTurnoC = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipoC = new System.Windows.Forms.TextBox();
            this.txtRolC = new System.Windows.Forms.TextBox();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.txtNumeroC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaC = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pMovimiento.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 392);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(533, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empleados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(422, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(329, 312);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 28);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pMovimiento);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(21, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 271);
            this.panel1.TabIndex = 0;
            // 
            // pMovimiento
            // 
            this.pMovimiento.Controls.Add(this.rbtnEliminar);
            this.pMovimiento.Controls.Add(this.rbtnModificar);
            this.pMovimiento.Controls.Add(this.label5);
            this.pMovimiento.Location = new System.Drawing.Point(39, 215);
            this.pMovimiento.Name = "pMovimiento";
            this.pMovimiento.Size = new System.Drawing.Size(351, 40);
            this.pMovimiento.TabIndex = 10;
            this.pMovimiento.Visible = false;
            // 
            // rbtnEliminar
            // 
            this.rbtnEliminar.AutoSize = true;
            this.rbtnEliminar.Location = new System.Drawing.Point(205, 8);
            this.rbtnEliminar.Name = "rbtnEliminar";
            this.rbtnEliminar.Size = new System.Drawing.Size(73, 20);
            this.rbtnEliminar.TabIndex = 12;
            this.rbtnEliminar.TabStop = true;
            this.rbtnEliminar.Text = "Eliminar";
            this.rbtnEliminar.UseVisualStyleBackColor = true;
            // 
            // rbtnModificar
            // 
            this.rbtnModificar.AutoSize = true;
            this.rbtnModificar.Location = new System.Drawing.Point(119, 8);
            this.rbtnModificar.Name = "rbtnModificar";
            this.rbtnModificar.Size = new System.Drawing.Size(80, 20);
            this.rbtnModificar.TabIndex = 11;
            this.rbtnModificar.TabStop = true;
            this.rbtnModificar.Text = "Modificar";
            this.rbtnModificar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Movimiento:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(411, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 28);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbtnExterno);
            this.panel3.Controls.Add(this.rbtnInterno);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(247, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 95);
            this.panel3.TabIndex = 5;
            // 
            // rbtnExterno
            // 
            this.rbtnExterno.AutoSize = true;
            this.rbtnExterno.Enabled = false;
            this.rbtnExterno.Location = new System.Drawing.Point(56, 37);
            this.rbtnExterno.Name = "rbtnExterno";
            this.rbtnExterno.Size = new System.Drawing.Size(70, 20);
            this.rbtnExterno.TabIndex = 3;
            this.rbtnExterno.TabStop = true;
            this.rbtnExterno.Text = "Externo";
            this.rbtnExterno.UseVisualStyleBackColor = true;
            // 
            // rbtnInterno
            // 
            this.rbtnInterno.AutoSize = true;
            this.rbtnInterno.Enabled = false;
            this.rbtnInterno.Location = new System.Drawing.Point(56, 14);
            this.rbtnInterno.Name = "rbtnInterno";
            this.rbtnInterno.Size = new System.Drawing.Size(65, 20);
            this.rbtnInterno.TabIndex = 2;
            this.rbtnInterno.TabStop = true;
            this.rbtnInterno.Text = "Interno";
            this.rbtnInterno.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbtnAuxiliar);
            this.panel2.Controls.Add(this.rbtnCargador);
            this.panel2.Controls.Add(this.rbtnChofer);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(39, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 95);
            this.panel2.TabIndex = 4;
            // 
            // rbtnAuxiliar
            // 
            this.rbtnAuxiliar.AutoSize = true;
            this.rbtnAuxiliar.Enabled = false;
            this.rbtnAuxiliar.Location = new System.Drawing.Point(63, 60);
            this.rbtnAuxiliar.Name = "rbtnAuxiliar";
            this.rbtnAuxiliar.Size = new System.Drawing.Size(68, 20);
            this.rbtnAuxiliar.TabIndex = 3;
            this.rbtnAuxiliar.TabStop = true;
            this.rbtnAuxiliar.Text = "Auxiliar";
            this.rbtnAuxiliar.UseVisualStyleBackColor = true;
            // 
            // rbtnCargador
            // 
            this.rbtnCargador.AutoSize = true;
            this.rbtnCargador.Enabled = false;
            this.rbtnCargador.Location = new System.Drawing.Point(63, 37);
            this.rbtnCargador.Name = "rbtnCargador";
            this.rbtnCargador.Size = new System.Drawing.Size(82, 20);
            this.rbtnCargador.TabIndex = 2;
            this.rbtnCargador.TabStop = true;
            this.rbtnCargador.Text = "Cargador";
            this.rbtnCargador.UseVisualStyleBackColor = true;
            // 
            // rbtnChofer
            // 
            this.rbtnChofer.AutoSize = true;
            this.rbtnChofer.Enabled = false;
            this.rbtnChofer.Location = new System.Drawing.Point(63, 14);
            this.rbtnChofer.Name = "rbtnChofer";
            this.rbtnChofer.Size = new System.Drawing.Size(64, 20);
            this.rbtnChofer.TabIndex = 1;
            this.rbtnChofer.TabStop = true;
            this.rbtnChofer.Text = "Chofer";
            this.rbtnChofer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rol:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(102, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(303, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(102, 29);
            this.txtNumero.MaxLength = 20;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(303, 22);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelarC);
            this.tabPage2.Controls.Add(this.btnGuardarC);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(533, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Captura de movientos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelarC
            // 
            this.btnCancelarC.Enabled = false;
            this.btnCancelarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarC.Location = new System.Drawing.Point(422, 312);
            this.btnCancelarC.Name = "btnCancelarC";
            this.btnCancelarC.Size = new System.Drawing.Size(83, 28);
            this.btnCancelarC.TabIndex = 11;
            this.btnCancelarC.Text = "Cancelar";
            this.btnCancelarC.UseVisualStyleBackColor = true;
            this.btnCancelarC.Click += new System.EventHandler(this.btnCancelarC_Click);
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.Enabled = false;
            this.btnGuardarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarC.Location = new System.Drawing.Point(329, 312);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(83, 28);
            this.btnGuardarC.TabIndex = 10;
            this.btnGuardarC.Text = "Guardar";
            this.btnGuardarC.UseVisualStyleBackColor = true;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtFechaC);
            this.panel4.Controls.Add(this.txtCantidadEntregaC);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.cBoxCubrioTurnoC);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtTipoC);
            this.panel4.Controls.Add(this.txtRolC);
            this.panel4.Controls.Add(this.btnBuscarC);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtNombreC);
            this.panel4.Controls.Add(this.txtNumeroC);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(21, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 287);
            this.panel4.TabIndex = 9;
            // 
            // txtCantidadEntregaC
            // 
            this.txtCantidadEntregaC.Enabled = false;
            this.txtCantidadEntregaC.Location = new System.Drawing.Point(373, 121);
            this.txtCantidadEntregaC.Mask = "99";
            this.txtCantidadEntregaC.Name = "txtCantidadEntregaC";
            this.txtCantidadEntregaC.Size = new System.Drawing.Size(39, 22);
            this.txtCantidadEntregaC.TabIndex = 21;
            this.txtCantidadEntregaC.ValidatingType = typeof(int);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rbtnCubrioExternoC);
            this.panel6.Controls.Add(this.rbtnCubrioInternoC);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(254, 188);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(158, 69);
            this.panel6.TabIndex = 19;
            // 
            // rbtnCubrioExternoC
            // 
            this.rbtnCubrioExternoC.AutoSize = true;
            this.rbtnCubrioExternoC.Enabled = false;
            this.rbtnCubrioExternoC.Location = new System.Drawing.Point(56, 37);
            this.rbtnCubrioExternoC.Name = "rbtnCubrioExternoC";
            this.rbtnCubrioExternoC.Size = new System.Drawing.Size(70, 20);
            this.rbtnCubrioExternoC.TabIndex = 3;
            this.rbtnCubrioExternoC.TabStop = true;
            this.rbtnCubrioExternoC.Text = "Externo";
            this.rbtnCubrioExternoC.UseVisualStyleBackColor = true;
            // 
            // rbtnCubrioInternoC
            // 
            this.rbtnCubrioInternoC.AutoSize = true;
            this.rbtnCubrioInternoC.Enabled = false;
            this.rbtnCubrioInternoC.Location = new System.Drawing.Point(56, 14);
            this.rbtnCubrioInternoC.Name = "rbtnCubrioInternoC";
            this.rbtnCubrioInternoC.Size = new System.Drawing.Size(65, 20);
            this.rbtnCubrioInternoC.TabIndex = 2;
            this.rbtnCubrioInternoC.TabStop = true;
            this.rbtnCubrioInternoC.Text = "Interno";
            this.rbtnCubrioInternoC.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tipo:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbtnCargadorC);
            this.panel5.Controls.Add(this.rbtnChoferC);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(39, 188);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(158, 69);
            this.panel5.TabIndex = 18;
            // 
            // rbtnCargadorC
            // 
            this.rbtnCargadorC.AutoSize = true;
            this.rbtnCargadorC.Enabled = false;
            this.rbtnCargadorC.Location = new System.Drawing.Point(63, 37);
            this.rbtnCargadorC.Name = "rbtnCargadorC";
            this.rbtnCargadorC.Size = new System.Drawing.Size(82, 20);
            this.rbtnCargadorC.TabIndex = 2;
            this.rbtnCargadorC.TabStop = true;
            this.rbtnCargadorC.Text = "Cargador";
            this.rbtnCargadorC.UseVisualStyleBackColor = true;
            // 
            // rbtnChoferC
            // 
            this.rbtnChoferC.AutoSize = true;
            this.rbtnChoferC.Enabled = false;
            this.rbtnChoferC.Location = new System.Drawing.Point(63, 14);
            this.rbtnChoferC.Name = "rbtnChoferC";
            this.rbtnChoferC.Size = new System.Drawing.Size(64, 20);
            this.rbtnChoferC.TabIndex = 1;
            this.rbtnChoferC.TabStop = true;
            this.rbtnChoferC.Text = "Chofer";
            this.rbtnChoferC.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Rol:";
            // 
            // cBoxCubrioTurnoC
            // 
            this.cBoxCubrioTurnoC.AutoSize = true;
            this.cBoxCubrioTurnoC.Enabled = false;
            this.cBoxCubrioTurnoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCubrioTurnoC.Location = new System.Drawing.Point(39, 162);
            this.cBoxCubrioTurnoC.Name = "cBoxCubrioTurnoC";
            this.cBoxCubrioTurnoC.Size = new System.Drawing.Size(109, 20);
            this.cBoxCubrioTurnoC.TabIndex = 13;
            this.cBoxCubrioTurnoC.Text = "Cubrio turno";
            this.cBoxCubrioTurnoC.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Cantidad de entrega";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha";
            // 
            // txtTipoC
            // 
            this.txtTipoC.Enabled = false;
            this.txtTipoC.Location = new System.Drawing.Point(284, 90);
            this.txtTipoC.Name = "txtTipoC";
            this.txtTipoC.Size = new System.Drawing.Size(129, 22);
            this.txtTipoC.TabIndex = 8;
            // 
            // txtRolC
            // 
            this.txtRolC.Enabled = false;
            this.txtRolC.Location = new System.Drawing.Point(102, 93);
            this.txtRolC.Name = "txtRolC";
            this.txtRolC.Size = new System.Drawing.Size(112, 22);
            this.txtRolC.TabIndex = 7;
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.Location = new System.Drawing.Point(418, 26);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(61, 28);
            this.btnBuscarC.TabIndex = 6;
            this.btnBuscarC.Text = "Buscar";
            this.btnBuscarC.UseVisualStyleBackColor = true;
            this.btnBuscarC.Click += new System.EventHandler(this.btnBuscarC_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(220, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tipo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rol:";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Enabled = false;
            this.txtNombreC.Location = new System.Drawing.Point(102, 61);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(311, 22);
            this.txtNombreC.TabIndex = 3;
            // 
            // txtNumeroC
            // 
            this.txtNumeroC.Location = new System.Drawing.Point(102, 29);
            this.txtNumeroC.MaxLength = 20;
            this.txtNumeroC.Name = "txtNumeroC";
            this.txtNumeroC.Size = new System.Drawing.Size(310, 22);
            this.txtNumeroC.TabIndex = 2;
            this.txtNumeroC.TextChanged += new System.EventHandler(this.txtNumeroC_TextChanged);
            this.txtNumeroC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroC_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Número:";
            // 
            // txtFechaC
            // 
            this.txtFechaC.CustomFormat = "dd/MM/yyyy";
            this.txtFechaC.Enabled = false;
            this.txtFechaC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaC.Location = new System.Drawing.Point(102, 122);
            this.txtFechaC.Name = "txtFechaC";
            this.txtFechaC.Size = new System.Drawing.Size(112, 22);
            this.txtFechaC.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(560, 413);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pMovimiento.ResumeLayout(false);
            this.pMovimiento.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnExterno;
        private System.Windows.Forms.RadioButton rbtnInterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnAuxiliar;
        private System.Windows.Forms.RadioButton rbtnCargador;
        private System.Windows.Forms.RadioButton rbtnChofer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pMovimiento;
        private System.Windows.Forms.RadioButton rbtnEliminar;
        private System.Windows.Forms.RadioButton rbtnModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCancelarC;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTipoC;
        private System.Windows.Forms.TextBox txtRolC;
        private System.Windows.Forms.Button btnBuscarC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.TextBox txtNumeroC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cBoxCubrioTurnoC;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rbtnCubrioExternoC;
        private System.Windows.Forms.RadioButton rbtnCubrioInternoC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbtnCargadorC;
        private System.Windows.Forms.RadioButton rbtnChoferC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtCantidadEntregaC;
        private System.Windows.Forms.DateTimePicker txtFechaC;
    }
}

