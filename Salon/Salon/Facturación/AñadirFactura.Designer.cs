﻿namespace Salon.Facturación
{
    partial class AñadirFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvDatosEmpleados = new DrakeUI.Framework.DrakeUIDataGridView();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.drakeUITextBox1 = new DrakeUI.Framework.DrakeUITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drakeUITextBox2 = new DrakeUI.Framework.DrakeUITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drakeUITextBox3 = new DrakeUI.Framework.DrakeUITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.drakeUITextBox4 = new DrakeUI.Framework.DrakeUITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Closeagregfactu = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.drakeUITextBox5 = new DrakeUI.Framework.DrakeUITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closeagregfactu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDatosEmpleados
            // 
            this.DgvDatosEmpleados.AllowUserToAddRows = false;
            this.DgvDatosEmpleados.AllowUserToDeleteRows = false;
            this.DgvDatosEmpleados.AllowUserToResizeColumns = false;
            this.DgvDatosEmpleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.DgvDatosEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DgvDatosEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDatosEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvDatosEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvDatosEmpleados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvDatosEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDatosEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvDatosEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DgvDatosEmpleados.ColumnHeadersHeight = 32;
            this.DgvDatosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDatosEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Empleado,
            this.Nombre,
            this.Cedula,
            this.Apellido,
            this.Total,
            this.Editar,
            this.borrar});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatosEmpleados.DefaultCellStyle = dataGridViewCellStyle18;
            this.DgvDatosEmpleados.EnableHeadersVisualStyles = false;
            this.DgvDatosEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DgvDatosEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.DgvDatosEmpleados.Location = new System.Drawing.Point(36, 277);
            this.DgvDatosEmpleados.Name = "DgvDatosEmpleados";
            this.DgvDatosEmpleados.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvDatosEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DgvDatosEmpleados.RowHeadersVisible = false;
            this.DgvDatosEmpleados.RowHeadersWidth = 25;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDatosEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DgvDatosEmpleados.RowTemplate.Height = 29;
            this.DgvDatosEmpleados.SelectedIndex = -1;
            this.DgvDatosEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatosEmpleados.ShowRect = false;
            this.DgvDatosEmpleados.Size = new System.Drawing.Size(726, 301);
            this.DgvDatosEmpleados.StripeOddColor = System.Drawing.Color.White;
            this.DgvDatosEmpleados.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DgvDatosEmpleados.StyleCustomMode = true;
            this.DgvDatosEmpleados.TabIndex = 59;
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_Empleado.DataPropertyName = "ID_Empleado";
            this.ID_Empleado.HeaderText = "ID";
            this.ID_Empleado.Name = "ID_Empleado";
            this.ID_Empleado.Visible = false;
            this.ID_Empleado.Width = 95;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.HeaderText = "Servicio";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 230;
            // 
            // Cedula
            // 
            this.Cedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cantidad";
            this.Cedula.Name = "Cedula";
            this.Cedula.Width = 130;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Pre.Uni";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 130;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 120;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.Width = 55;
            // 
            // borrar
            // 
            this.borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.borrar.HeaderText = "";
            this.borrar.Name = "borrar";
            this.borrar.Width = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Producto";
            // 
            // drakeUITextBox1
            // 
            this.drakeUITextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drakeUITextBox1.FillColor = System.Drawing.Color.White;
            this.drakeUITextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUITextBox1.Location = new System.Drawing.Point(34, 169);
            this.drakeUITextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUITextBox1.Maximum = 2147483647D;
            this.drakeUITextBox1.Minimum = -2147483648D;
            this.drakeUITextBox1.Name = "drakeUITextBox1";
            this.drakeUITextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.drakeUITextBox1.RectColor = System.Drawing.Color.Silver;
            this.drakeUITextBox1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox1.Size = new System.Drawing.Size(216, 29);
            this.drakeUITextBox1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITextBox1.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(535, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Total";
            // 
            // drakeUITextBox2
            // 
            this.drakeUITextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drakeUITextBox2.FillColor = System.Drawing.Color.White;
            this.drakeUITextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUITextBox2.Location = new System.Drawing.Point(582, 586);
            this.drakeUITextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUITextBox2.Maximum = 2147483647D;
            this.drakeUITextBox2.Minimum = -2147483648D;
            this.drakeUITextBox2.Name = "drakeUITextBox2";
            this.drakeUITextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.drakeUITextBox2.RectColor = System.Drawing.Color.Silver;
            this.drakeUITextBox2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox2.Size = new System.Drawing.Size(180, 29);
            this.drakeUITextBox2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITextBox2.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Vendedor";
            // 
            // drakeUITextBox3
            // 
            this.drakeUITextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drakeUITextBox3.FillColor = System.Drawing.Color.White;
            this.drakeUITextBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUITextBox3.Location = new System.Drawing.Point(34, 110);
            this.drakeUITextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUITextBox3.Maximum = 2147483647D;
            this.drakeUITextBox3.Minimum = -2147483648D;
            this.drakeUITextBox3.Name = "drakeUITextBox3";
            this.drakeUITextBox3.Padding = new System.Windows.Forms.Padding(5);
            this.drakeUITextBox3.RectColor = System.Drawing.Color.Silver;
            this.drakeUITextBox3.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox3.Size = new System.Drawing.Size(216, 29);
            this.drakeUITextBox3.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITextBox3.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(288, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 234;
            this.label4.Text = "Servicio";
            // 
            // drakeUITextBox4
            // 
            this.drakeUITextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drakeUITextBox4.FillColor = System.Drawing.Color.White;
            this.drakeUITextBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUITextBox4.Location = new System.Drawing.Point(284, 110);
            this.drakeUITextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUITextBox4.Maximum = 2147483647D;
            this.drakeUITextBox4.Minimum = -2147483648D;
            this.drakeUITextBox4.Name = "drakeUITextBox4";
            this.drakeUITextBox4.Padding = new System.Windows.Forms.Padding(5);
            this.drakeUITextBox4.RectColor = System.Drawing.Color.Silver;
            this.drakeUITextBox4.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox4.Size = new System.Drawing.Size(216, 29);
            this.drakeUITextBox4.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITextBox4.TabIndex = 233;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(283, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 232;
            this.label5.Text = "Cantidad";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Salon.Properties.Resources.icons8_factura_19;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(679, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 32);
            this.button4.TabIndex = 235;
            this.button4.Text = "       Facturar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Salon.Properties.Resources.icons8_clientes_19;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(399, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 32);
            this.button3.TabIndex = 230;
            this.button3.Text = "       Producto";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Salon.Properties.Resources.icons8_más_2_matemáticas_19;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(594, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 32);
            this.button2.TabIndex = 229;
            this.button2.Text = "      Insertar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Salon.Properties.Resources.icons8_maletín_19;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(503, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 228;
            this.button1.Text = "       Servicios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Closeagregfactu
            // 
            this.Closeagregfactu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closeagregfactu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Closeagregfactu.Image = global::Salon.Properties.Resources.icons8_multiplicar_23__2_;
            this.Closeagregfactu.Location = new System.Drawing.Point(807, 9);
            this.Closeagregfactu.Name = "Closeagregfactu";
            this.Closeagregfactu.Size = new System.Drawing.Size(28, 24);
            this.Closeagregfactu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Closeagregfactu.TabIndex = 238;
            this.Closeagregfactu.TabStop = false;
            this.Closeagregfactu.Click += new System.EventHandler(this.Closeagregfactu_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 237;
            this.label13.Text = "Nueva factura";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(842, 43);
            this.label12.TabIndex = 236;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(284, 169);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(216, 27);
            this.numericUpDown1.TabIndex = 239;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(530, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 241;
            this.label6.Tag = "f";
            this.label6.Text = "Fecha de emisión";
            // 
            // drakeUITextBox5
            // 
            this.drakeUITextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drakeUITextBox5.FillColor = System.Drawing.Color.White;
            this.drakeUITextBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUITextBox5.Location = new System.Drawing.Point(527, 110);
            this.drakeUITextBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUITextBox5.Maximum = 2147483647D;
            this.drakeUITextBox5.Minimum = -2147483648D;
            this.drakeUITextBox5.Name = "drakeUITextBox5";
            this.drakeUITextBox5.Padding = new System.Windows.Forms.Padding(5);
            this.drakeUITextBox5.RectColor = System.Drawing.Color.Silver;
            this.drakeUITextBox5.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox5.Size = new System.Drawing.Size(180, 29);
            this.drakeUITextBox5.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITextBox5.TabIndex = 240;
            // 
            // AñadirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 637);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.drakeUITextBox5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Closeagregfactu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drakeUITextBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drakeUITextBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drakeUITextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drakeUITextBox1);
            this.Controls.Add(this.DgvDatosEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AñadirFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AñadirFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closeagregfactu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DrakeUI.Framework.DrakeUIDataGridView DgvDatosEmpleados;
        private System.Windows.Forms.Label label2;
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox1;
        private System.Windows.Forms.Label label1;
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox2;
        private System.Windows.Forms.Label label3;
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox Closeagregfactu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrar;
    }
}