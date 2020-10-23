namespace Parcial2_Lab2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCamisa = new System.Windows.Forms.RadioButton();
            this.rbtnPantalon = new System.Windows.Forms.RadioButton();
            this.checkMangacorta = new System.Windows.Forms.CheckBox();
            this.checkBermuda = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnStandard = new System.Windows.Forms.RadioButton();
            this.rbtnPremium = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcularPrecioFinal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBermuda);
            this.groupBox1.Controls.Add(this.checkMangacorta);
            this.groupBox1.Controls.Add(this.rbtnPantalon);
            this.groupBox1.Controls.Add(this.rbtnCamisa);
            this.groupBox1.Location = new System.Drawing.Point(207, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de prenda";
            // 
            // rbtnCamisa
            // 
            this.rbtnCamisa.AutoSize = true;
            this.rbtnCamisa.Location = new System.Drawing.Point(26, 20);
            this.rbtnCamisa.Name = "rbtnCamisa";
            this.rbtnCamisa.Size = new System.Drawing.Size(59, 17);
            this.rbtnCamisa.TabIndex = 0;
            this.rbtnCamisa.TabStop = true;
            this.rbtnCamisa.Text = "Camisa";
            this.rbtnCamisa.UseVisualStyleBackColor = true;
            this.rbtnCamisa.CheckedChanged += new System.EventHandler(this.rbtnCamisa_CheckedChanged);
            // 
            // rbtnPantalon
            // 
            this.rbtnPantalon.AutoSize = true;
            this.rbtnPantalon.Location = new System.Drawing.Point(26, 58);
            this.rbtnPantalon.Name = "rbtnPantalon";
            this.rbtnPantalon.Size = new System.Drawing.Size(67, 17);
            this.rbtnPantalon.TabIndex = 1;
            this.rbtnPantalon.TabStop = true;
            this.rbtnPantalon.Text = "Pantalón";
            this.rbtnPantalon.UseVisualStyleBackColor = true;
            this.rbtnPantalon.CheckedChanged += new System.EventHandler(this.rbtnPantalon_CheckedChanged);
            // 
            // checkMangacorta
            // 
            this.checkMangacorta.AutoSize = true;
            this.checkMangacorta.Location = new System.Drawing.Point(125, 20);
            this.checkMangacorta.Name = "checkMangacorta";
            this.checkMangacorta.Size = new System.Drawing.Size(86, 17);
            this.checkMangacorta.TabIndex = 2;
            this.checkMangacorta.Text = "Manga corta";
            this.checkMangacorta.UseVisualStyleBackColor = true;
            this.checkMangacorta.CheckedChanged += new System.EventHandler(this.checkMangacorta_CheckedChanged);
            // 
            // checkBermuda
            // 
            this.checkBermuda.AutoSize = true;
            this.checkBermuda.Enabled = false;
            this.checkBermuda.Location = new System.Drawing.Point(125, 59);
            this.checkBermuda.Name = "checkBermuda";
            this.checkBermuda.Size = new System.Drawing.Size(68, 17);
            this.checkBermuda.TabIndex = 3;
            this.checkBermuda.Text = "Bermuda";
            this.checkBermuda.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnPremium);
            this.groupBox2.Controls.Add(this.rbtnStandard);
            this.groupBox2.Location = new System.Drawing.Point(207, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de prenda";
            // 
            // rbtnStandard
            // 
            this.rbtnStandard.AutoSize = true;
            this.rbtnStandard.Checked = true;
            this.rbtnStandard.Location = new System.Drawing.Point(26, 28);
            this.rbtnStandard.Name = "rbtnStandard";
            this.rbtnStandard.Size = new System.Drawing.Size(68, 17);
            this.rbtnStandard.TabIndex = 0;
            this.rbtnStandard.TabStop = true;
            this.rbtnStandard.Text = "Standard";
            this.rbtnStandard.UseVisualStyleBackColor = true;
            // 
            // rbtnPremium
            // 
            this.rbtnPremium.AutoSize = true;
            this.rbtnPremium.Location = new System.Drawing.Point(125, 28);
            this.rbtnPremium.Name = "rbtnPremium";
            this.rbtnPremium.Size = new System.Drawing.Size(65, 17);
            this.rbtnPremium.TabIndex = 1;
            this.rbtnPremium.TabStop = true;
            this.rbtnPremium.Text = "Premium";
            this.rbtnPremium.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Location = new System.Drawing.Point(207, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(85, 55);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(6, 22);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(56, 20);
            this.txtPrecio.TabIndex = 0;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCantidad);
            this.groupBox4.Location = new System.Drawing.Point(354, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(79, 55);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(6, 22);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(56, 20);
            this.txtCantidad.TabIndex = 0;
            // 
            // btnCalcularPrecioFinal
            // 
            this.btnCalcularPrecioFinal.Enabled = false;
            this.btnCalcularPrecioFinal.Location = new System.Drawing.Point(207, 297);
            this.btnCalcularPrecioFinal.Name = "btnCalcularPrecioFinal";
            this.btnCalcularPrecioFinal.Size = new System.Drawing.Size(226, 43);
            this.btnCalcularPrecioFinal.TabIndex = 4;
            this.btnCalcularPrecioFinal.Text = "Calcular precio final";
            this.btnCalcularPrecioFinal.UseVisualStyleBackColor = true;
            this.btnCalcularPrecioFinal.Click += new System.EventHandler(this.btnCalcularPrecioFinal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ventas al por mayor Prad Bit brother";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularPrecioFinal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBermuda;
        private System.Windows.Forms.CheckBox checkMangacorta;
        private System.Windows.Forms.RadioButton rbtnPantalon;
        private System.Windows.Forms.RadioButton rbtnCamisa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnPremium;
        private System.Windows.Forms.RadioButton rbtnStandard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCalcularPrecioFinal;
        private System.Windows.Forms.Label label1;
    }
}

