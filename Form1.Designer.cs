namespace Código_de_Barras_y_QR
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
            this.txtcajabarra = new System.Windows.Forms.TextBox();
            this.txtcajaqr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbarra = new System.Windows.Forms.Button();
            this.btnguardarbarra = new System.Windows.Forms.Button();
            this.imgbarra = new System.Windows.Forms.PictureBox();
            this.imgqr = new System.Windows.Forms.PictureBox();
            this.btnqr = new System.Windows.Forms.Button();
            this.btnguardarqr = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgbarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgqr)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcajabarra
            // 
            this.txtcajabarra.Location = new System.Drawing.Point(133, 54);
            this.txtcajabarra.Name = "txtcajabarra";
            this.txtcajabarra.Size = new System.Drawing.Size(100, 20);
            this.txtcajabarra.TabIndex = 0;
            // 
            // txtcajaqr
            // 
            this.txtcajaqr.Location = new System.Drawing.Point(441, 54);
            this.txtcajaqr.Name = "txtcajaqr";
            this.txtcajaqr.Size = new System.Drawing.Size(100, 20);
            this.txtcajaqr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código QR";
            // 
            // btnbarra
            // 
            this.btnbarra.Location = new System.Drawing.Point(133, 105);
            this.btnbarra.Name = "btnbarra";
            this.btnbarra.Size = new System.Drawing.Size(75, 23);
            this.btnbarra.TabIndex = 4;
            this.btnbarra.Text = "Generar";
            this.btnbarra.UseVisualStyleBackColor = true;
            this.btnbarra.Click += new System.EventHandler(this.btnbarra_Click);
            // 
            // btnguardarbarra
            // 
            this.btnguardarbarra.Location = new System.Drawing.Point(214, 105);
            this.btnguardarbarra.Name = "btnguardarbarra";
            this.btnguardarbarra.Size = new System.Drawing.Size(75, 23);
            this.btnguardarbarra.TabIndex = 5;
            this.btnguardarbarra.Text = "Guardar";
            this.btnguardarbarra.UseVisualStyleBackColor = true;
            this.btnguardarbarra.Click += new System.EventHandler(this.btnguardarbarra_Click);
            // 
            // imgbarra
            // 
            this.imgbarra.Location = new System.Drawing.Point(113, 161);
            this.imgbarra.Name = "imgbarra";
            this.imgbarra.Size = new System.Drawing.Size(200, 100);
            this.imgbarra.TabIndex = 6;
            this.imgbarra.TabStop = false;
            // 
            // imgqr
            // 
            this.imgqr.Location = new System.Drawing.Point(484, 189);
            this.imgqr.Name = "imgqr";
            this.imgqr.Size = new System.Drawing.Size(100, 100);
            this.imgqr.TabIndex = 7;
            this.imgqr.TabStop = false;
            // 
            // btnqr
            // 
            this.btnqr.Location = new System.Drawing.Point(441, 141);
            this.btnqr.Name = "btnqr";
            this.btnqr.Size = new System.Drawing.Size(75, 23);
            this.btnqr.TabIndex = 8;
            this.btnqr.Text = "Generar";
            this.btnqr.UseVisualStyleBackColor = true;
            this.btnqr.Click += new System.EventHandler(this.btnqr_Click);
            // 
            // btnguardarqr
            // 
            this.btnguardarqr.Location = new System.Drawing.Point(536, 141);
            this.btnguardarqr.Name = "btnguardarqr";
            this.btnguardarqr.Size = new System.Drawing.Size(75, 23);
            this.btnguardarqr.TabIndex = 9;
            this.btnguardarqr.Text = "Guardar";
            this.btnguardarqr.UseVisualStyleBackColor = true;
            this.btnguardarqr.Click += new System.EventHandler(this.btnguardarqr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnguardarqr);
            this.Controls.Add(this.btnqr);
            this.Controls.Add(this.imgqr);
            this.Controls.Add(this.imgbarra);
            this.Controls.Add(this.btnguardarbarra);
            this.Controls.Add(this.btnbarra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcajaqr);
            this.Controls.Add(this.txtcajabarra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgbarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgqr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcajabarra;
        private System.Windows.Forms.TextBox txtcajaqr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbarra;
        private System.Windows.Forms.Button btnguardarbarra;
        private System.Windows.Forms.PictureBox imgbarra;
        private System.Windows.Forms.PictureBox imgqr;
        private System.Windows.Forms.Button btnqr;
        private System.Windows.Forms.Button btnguardarqr;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

