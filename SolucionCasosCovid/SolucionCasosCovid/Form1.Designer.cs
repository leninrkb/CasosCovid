
namespace SolucionCasosCovid
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.button_nuevo = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_provincias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_casos = new System.Windows.Forms.TextBox();
            this.textBoxfallecidos = new System.Windows.Forms.TextBox();
            this.textBox_vacunados = new System.Windows.Forms.TextBox();
            this.textBox_centros_vacunacion = new System.Windows.Forms.TextBox();
            this.textBox_digitador = new System.Windows.Forms.TextBox();
            this.dataGridView_datos = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel1.Controls.Add(this.button_guardar);
            this.flowLayoutPanel1.Controls.Add(this.button_actualizar);
            this.flowLayoutPanel1.Controls.Add(this.button_nuevo);
            this.flowLayoutPanel1.Controls.Add(this.button_eliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1049, 39);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(3, 3);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 31);
            this.button_guardar.TabIndex = 0;
            this.button_guardar.Text = "guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(84, 3);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(85, 31);
            this.button_actualizar.TabIndex = 1;
            this.button_actualizar.Text = "actualizar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            // 
            // button_nuevo
            // 
            this.button_nuevo.Location = new System.Drawing.Point(175, 3);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(75, 31);
            this.button_nuevo.TabIndex = 2;
            this.button_nuevo.Text = "nuevo";
            this.button_nuevo.UseVisualStyleBackColor = true;
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(256, 3);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(75, 31);
            this.button_eliminar.TabIndex = 3;
            this.button_eliminar.Text = "eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.textBox_digitador);
            this.panel1.Controls.Add(this.textBox_centros_vacunacion);
            this.panel1.Controls.Add(this.textBox_vacunados);
            this.panel1.Controls.Add(this.textBoxfallecidos);
            this.panel1.Controls.Add(this.textBox_casos);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox_provincias);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 424);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provincia";
            // 
            // comboBox_provincias
            // 
            this.comboBox_provincias.FormattingEnabled = true;
            this.comboBox_provincias.Location = new System.Drawing.Point(16, 32);
            this.comboBox_provincias.Name = "comboBox_provincias";
            this.comboBox_provincias.Size = new System.Drawing.Size(200, 24);
            this.comboBox_provincias.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "# Casos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "# Fallecidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(13, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "# Vacunados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(13, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "# Centros de vacunacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(13, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Digitador";
            // 
            // textBox_casos
            // 
            this.textBox_casos.Location = new System.Drawing.Point(16, 106);
            this.textBox_casos.Name = "textBox_casos";
            this.textBox_casos.Size = new System.Drawing.Size(200, 22);
            this.textBox_casos.TabIndex = 7;
            // 
            // textBoxfallecidos
            // 
            this.textBoxfallecidos.Location = new System.Drawing.Point(16, 179);
            this.textBoxfallecidos.Name = "textBoxfallecidos";
            this.textBoxfallecidos.Size = new System.Drawing.Size(200, 22);
            this.textBoxfallecidos.TabIndex = 8;
            // 
            // textBox_vacunados
            // 
            this.textBox_vacunados.Location = new System.Drawing.Point(16, 248);
            this.textBox_vacunados.Name = "textBox_vacunados";
            this.textBox_vacunados.Size = new System.Drawing.Size(200, 22);
            this.textBox_vacunados.TabIndex = 9;
            // 
            // textBox_centros_vacunacion
            // 
            this.textBox_centros_vacunacion.Location = new System.Drawing.Point(16, 316);
            this.textBox_centros_vacunacion.Name = "textBox_centros_vacunacion";
            this.textBox_centros_vacunacion.Size = new System.Drawing.Size(200, 22);
            this.textBox_centros_vacunacion.TabIndex = 10;
            // 
            // textBox_digitador
            // 
            this.textBox_digitador.Location = new System.Drawing.Point(16, 381);
            this.textBox_digitador.Name = "textBox_digitador";
            this.textBox_digitador.Size = new System.Drawing.Size(200, 22);
            this.textBox_digitador.TabIndex = 11;
            // 
            // dataGridView_datos
            // 
            this.dataGridView_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_datos.Location = new System.Drawing.Point(256, 57);
            this.dataGridView_datos.Name = "dataGridView_datos";
            this.dataGridView_datos.RowHeadersWidth = 51;
            this.dataGridView_datos.RowTemplate.Height = 24;
            this.dataGridView_datos.Size = new System.Drawing.Size(805, 424);
            this.dataGridView_datos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 494);
            this.Controls.Add(this.dataGridView_datos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_digitador;
        private System.Windows.Forms.TextBox textBox_centros_vacunacion;
        private System.Windows.Forms.TextBox textBox_vacunados;
        private System.Windows.Forms.TextBox textBoxfallecidos;
        private System.Windows.Forms.TextBox textBox_casos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_provincias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_datos;
    }
}

