﻿namespace Salon.GastosFijos
{
    partial class GastoFijo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.drakeUITextBox1 = new DrakeUI.Framework.DrakeUITextBox();
            this.DgvDatosEmpleados = new DrakeUI.Framework.DrakeUIDataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarGastosFijos = new System.Windows.Forms.Button();
            this.Closemenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closemenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 224;
            this.label2.Text = "Gastos Fijos";
            // 
            // drakeUITextBox1
            // 
            this.drakeUITextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drakeUITextBox1.FillColor = System.Drawing.Color.White;
            this.drakeUITextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUITextBox1.Location = new System.Drawing.Point(58, 121);
            this.drakeUITextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUITextBox1.Maximum = 2147483647D;
            this.drakeUITextBox1.Minimum = -2147483648D;
            this.drakeUITextBox1.Name = "drakeUITextBox1";
            this.drakeUITextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.drakeUITextBox1.RectColor = System.Drawing.Color.Silver;
            this.drakeUITextBox1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox1.Size = new System.Drawing.Size(228, 29);
            this.drakeUITextBox1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITextBox1.TabIndex = 226;
            // 
            // DgvDatosEmpleados
            // 
            this.DgvDatosEmpleados.AllowUserToAddRows = false;
            this.DgvDatosEmpleados.AllowUserToDeleteRows = false;
            this.DgvDatosEmpleados.AllowUserToResizeColumns = false;
            this.DgvDatosEmpleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.DgvDatosEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DgvDatosEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDatosEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvDatosEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvDatosEmpleados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvDatosEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDatosEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvDatosEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvDatosEmpleados.ColumnHeadersHeight = 32;
            this.DgvDatosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDatosEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.ID_Empleado,
            this.Nombre,
            this.Descripcion,
            this.Monto,
            this.Fecha});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatosEmpleados.DefaultCellStyle = dataGridViewCellStyle13;
            this.DgvDatosEmpleados.EnableHeadersVisualStyles = false;
            this.DgvDatosEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DgvDatosEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.DgvDatosEmpleados.Location = new System.Drawing.Point(23, 167);
            this.DgvDatosEmpleados.Name = "DgvDatosEmpleados";
            this.DgvDatosEmpleados.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvDatosEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DgvDatosEmpleados.RowHeadersVisible = false;
            this.DgvDatosEmpleados.RowHeadersWidth = 25;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDatosEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DgvDatosEmpleados.RowTemplate.Height = 29;
            this.DgvDatosEmpleados.SelectedIndex = -1;
            this.DgvDatosEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatosEmpleados.ShowRect = false;
            this.DgvDatosEmpleados.Size = new System.Drawing.Size(1001, 354);
            this.DgvDatosEmpleados.StripeOddColor = System.Drawing.Color.White;
            this.DgvDatosEmpleados.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DgvDatosEmpleados.StyleCustomMode = true;
            this.DgvDatosEmpleados.TabIndex = 227;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Edit.Frozen = true;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.Width = 55;
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_Empleado.DataPropertyName = "ID_Empleado";
            this.ID_Empleado.Frozen = true;
            this.ID_Empleado.HeaderText = "ID";
            this.ID_Empleado.Name = "ID_Empleado";
            this.ID_Empleado.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 160;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 317;
            // 
            // Monto
            // 
            this.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Monto.Frozen = true;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Width = 200;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 200;
            // 
            // btnAgregarGastosFijos
            // 
            this.btnAgregarGastosFijos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarGastosFijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.btnAgregarGastosFijos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarGastosFijos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGastosFijos.ForeColor = System.Drawing.Color.White;
            this.btnAgregarGastosFijos.Image = global::Salon.Properties.Resources.icons8_más_2_matemáticas_23;
            this.btnAgregarGastosFijos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarGastosFijos.Location = new System.Drawing.Point(941, 118);
            this.btnAgregarGastosFijos.Name = "btnAgregarGastosFijos";
            this.btnAgregarGastosFijos.Size = new System.Drawing.Size(83, 32);
            this.btnAgregarGastosFijos.TabIndex = 228;
            this.btnAgregarGastosFijos.Text = "      Nuevo";
            this.btnAgregarGastosFijos.UseVisualStyleBackColor = false;
            this.btnAgregarGastosFijos.Click += new System.EventHandler(this.btnAgregarGastosFijos_Click);
            // 
            // Closemenu
            // 
            this.Closemenu.BackColor = System.Drawing.SystemColors.Control;
            this.Closemenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Closemenu.Image = global::Salon.Properties.Resources.icons8_búsqueda_22;
            this.Closemenu.Location = new System.Drawing.Point(23, 121);
            this.Closemenu.Name = "Closemenu";
            this.Closemenu.Size = new System.Drawing.Size(35, 29);
            this.Closemenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Closemenu.TabIndex = 225;
            this.Closemenu.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Salon.Properties.Resources.gastoFijoNegro;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.TabIndex = 223;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(-3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1054, 1);
            this.label1.TabIndex = 229;
            this.label1.Text = "label1";
            // 
            // GastoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarGastosFijos);
            this.Controls.Add(this.DgvDatosEmpleados);
            this.Controls.Add(this.drakeUITextBox1);
            this.Controls.Add(this.Closemenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GastoFijo";
            this.Text = "GastoFijo";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closemenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Closemenu;
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox1;
        private DrakeUI.Framework.DrakeUIDataGridView DgvDatosEmpleados;
        private System.Windows.Forms.Button btnAgregarGastosFijos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Label label1;
    }
}