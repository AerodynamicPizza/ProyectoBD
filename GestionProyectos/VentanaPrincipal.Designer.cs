namespace GestionProyectos
{
    partial class VentanaPrincipal
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelSeleccionarProyecto = new System.Windows.Forms.Label();
            this.comboBoxProyectos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 282);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actividades";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registrar Actividad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ver Siguiente Actividad";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelSeleccionarProyecto
            // 
            this.labelSeleccionarProyecto.AutoSize = true;
            this.labelSeleccionarProyecto.Location = new System.Drawing.Point(12, 9);
            this.labelSeleccionarProyecto.Name = "labelSeleccionarProyecto";
            this.labelSeleccionarProyecto.Size = new System.Drawing.Size(108, 13);
            this.labelSeleccionarProyecto.TabIndex = 4;
            this.labelSeleccionarProyecto.Text = "Seleccionar Proyecto";
            // 
            // comboBoxProyectos
            // 
            this.comboBoxProyectos.FormattingEnabled = true;
            this.comboBoxProyectos.Location = new System.Drawing.Point(126, 6);
            this.comboBoxProyectos.Name = "comboBoxProyectos";
            this.comboBoxProyectos.Size = new System.Drawing.Size(216, 21);
            this.comboBoxProyectos.TabIndex = 5;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 351);
            this.Controls.Add(this.comboBoxProyectos);
            this.Controls.Add(this.labelSeleccionarProyecto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Name = "VentanaPrincipal";
            this.Text = "Gestionador de Actividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelSeleccionarProyecto;
        private System.Windows.Forms.ComboBox comboBoxProyectos;

    }
}

