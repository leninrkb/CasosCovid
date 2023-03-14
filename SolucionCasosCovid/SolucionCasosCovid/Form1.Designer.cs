
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
            this.dateTimePicker_fechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.textBox_provincia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_digitador = new System.Windows.Forms.TextBox();
            this.textBox_centros_vacunacion = new System.Windows.Forms.TextBox();
            this.textBox_vacunados = new System.Windows.Forms.TextBox();
            this.textBox_fallecidos = new System.Windows.Forms.TextBox();
            this.textBox_casos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_datos = new System.Windows.Forms.DataGridView();
            this.notificacion = new System.Windows.Forms.FlowLayoutPanel();
            this.label_notificacion = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datos)).BeginInit();
            this.notificacion.SuspendLayout();
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
            this.button_guardar.Click += new System.EventHandler(this.Button_guardar_Click);
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
            this.panel1.Controls.Add(this.dateTimePicker_fechaRegistro);
            this.panel1.Controls.Add(this.textBox_provincia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_digitador);
            this.panel1.Controls.Add(this.textBox_centros_vacunacion);
            this.panel1.Controls.Add(this.textBox_vacunados);
            this.panel1.Controls.Add(this.textBox_fallecidos);
            this.panel1.Controls.Add(this.textBox_casos);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 497);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePicker_fechaRegistro
            // 
            this.dateTimePicker_fechaRegistro.Location = new System.Drawing.Point(16, 449);
            this.dateTimePicker_fechaRegistro.Name = "dateTimePicker_fechaRegistro";
            this.dateTimePicker_fechaRegistro.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_fechaRegistro.TabIndex = 15;
            // 
            // textBox_provincia
            // 
            this.textBox_provincia.Location = new System.Drawing.Point(16, 41);
            this.textBox_provincia.Name = "textBox_provincia";
            this.textBox_provincia.Size = new System.Drawing.Size(200, 22);
            this.textBox_provincia.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(14, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha de resgistro";
            // 
            // textBox_digitador
            // 
            this.textBox_digitador.Location = new System.Drawing.Point(16, 381);
            this.textBox_digitador.Name = "textBox_digitador";
            this.textBox_digitador.Size = new System.Drawing.Size(200, 22);
            this.textBox_digitador.TabIndex = 11;
            // 
            // textBox_centros_vacunacion
            // 
            this.textBox_centros_vacunacion.Location = new System.Drawing.Point(16, 316);
            this.textBox_centros_vacunacion.Name = "textBox_centros_vacunacion";
            this.textBox_centros_vacunacion.Size = new System.Drawing.Size(200, 22);
            this.textBox_centros_vacunacion.TabIndex = 10;
            // 
            // textBox_vacunados
            // 
            this.textBox_vacunados.Location = new System.Drawing.Point(16, 248);
            this.textBox_vacunados.Name = "textBox_vacunados";
            this.textBox_vacunados.Size = new System.Drawing.Size(200, 22);
            this.textBox_vacunados.TabIndex = 9;
            // 
            // textBox_fallecidos
            // 
            this.textBox_fallecidos.Location = new System.Drawing.Point(16, 179);
            this.textBox_fallecidos.Name = "textBox_fallecidos";
            this.textBox_fallecidos.Size = new System.Drawing.Size(200, 22);
            this.textBox_fallecidos.TabIndex = 8;
            // 
            // textBox_casos
            // 
            this.textBox_casos.Location = new System.Drawing.Point(16, 106);
            this.textBox_casos.Name = "textBox_casos";
            this.textBox_casos.Size = new System.Drawing.Size(200, 22);
            this.textBox_casos.TabIndex = 7;
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
            // dataGridView_datos
            // 
            this.dataGridView_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_datos.Location = new System.Drawing.Point(256, 80);
            this.dataGridView_datos.Name = "dataGridView_datos";
            this.dataGridView_datos.RowHeadersWidth = 51;
            this.dataGridView_datos.RowTemplate.Height = 24;
            this.dataGridView_datos.Size = new System.Drawing.Size(805, 497);
            this.dataGridView_datos.TabIndex = 3;
            // 
            // notificacion
            // 
            this.notificacion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.notificacion.Controls.Add(this.label_notificacion);
            this.notificacion.Location = new System.Drawing.Point(12, 54);
            this.notificacion.Name = "notificacion";
            this.notificacion.Size = new System.Drawing.Size(1049, 22);
            this.notificacion.TabIndex = 4;
            // 
            // label_notificacion
            // 
            this.label_notificacion.AutoSize = true;
            this.label_notificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notificacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_notificacion.Location = new System.Drawing.Point(3, 0);
            this.label_notificacion.Name = "label_notificacion";
            this.label_notificacion.Size = new System.Drawing.Size(75, 17);
            this.label_notificacion.TabIndex = 16;
            this.label_notificacion.Text = "Provincia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 589);
            this.Controls.Add(this.notificacion);
            this.Controls.Add(this.dataGridView_datos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datos)).EndInit();
            this.notificacion.ResumeLayout(false);
            this.notificacion.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox_fallecidos;
        private System.Windows.Forms.TextBox textBox_casos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_datos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_provincia;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaRegistro;
        private System.Windows.Forms.FlowLayoutPanel notificacion;
        private System.Windows.Forms.Label label_notificacion;
    }
}

