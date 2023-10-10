namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblPrimerElemento = new System.Windows.Forms.Label();
            this.LblSegundoElemento = new System.Windows.Forms.Label();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.LblOperacion = new System.Windows.Forms.Label();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.BtnCociente = new System.Windows.Forms.Button();
            this.TxtBxPrimerElemento = new System.Windows.Forms.TextBox();
            this.TxtBxSegundoElemento = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnPotencia = new System.Windows.Forms.Button();
            this.BtnRaiz = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAns = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnExtend = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPrimerElemento
            // 
            this.LblPrimerElemento.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPrimerElemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPrimerElemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblPrimerElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrimerElemento.ForeColor = System.Drawing.Color.Snow;
            this.LblPrimerElemento.Location = new System.Drawing.Point(12, 20);
            this.LblPrimerElemento.Name = "LblPrimerElemento";
            this.LblPrimerElemento.Size = new System.Drawing.Size(109, 49);
            this.LblPrimerElemento.TabIndex = 1;
            this.LblPrimerElemento.Text = "Primer Elemento";
            this.LblPrimerElemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSegundoElemento
            // 
            this.LblSegundoElemento.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblSegundoElemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSegundoElemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSegundoElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSegundoElemento.ForeColor = System.Drawing.Color.Snow;
            this.LblSegundoElemento.Location = new System.Drawing.Point(12, 77);
            this.LblSegundoElemento.Name = "LblSegundoElemento";
            this.LblSegundoElemento.Size = new System.Drawing.Size(109, 49);
            this.LblSegundoElemento.TabIndex = 2;
            this.LblSegundoElemento.Text = "Segundo Elemento";
            this.LblSegundoElemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRespuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRespuesta.ForeColor = System.Drawing.Color.Snow;
            this.LblRespuesta.Location = new System.Drawing.Point(12, 132);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(109, 49);
            this.LblRespuesta.TabIndex = 2;
            this.LblRespuesta.Text = "Respuesta";
            this.LblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblRespuesta.Click += new System.EventHandler(this.LblRespuesta_Click);
            // 
            // LblOperacion
            // 
            this.LblOperacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblOperacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOperacion.ForeColor = System.Drawing.Color.Snow;
            this.LblOperacion.Location = new System.Drawing.Point(170, 191);
            this.LblOperacion.Name = "LblOperacion";
            this.LblOperacion.Size = new System.Drawing.Size(97, 49);
            this.LblOperacion.TabIndex = 2;
            this.LblOperacion.Text = "Operación";
            this.LblOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblOperacion.Click += new System.EventHandler(this.LblRespuesta_Click);
            // 
            // BtnSuma
            // 
            this.BtnSuma.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuma.ForeColor = System.Drawing.Color.White;
            this.BtnSuma.Location = new System.Drawing.Point(170, 250);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(43, 40);
            this.BtnSuma.TabIndex = 3;
            this.BtnSuma.Text = "+";
            this.BtnSuma.UseVisualStyleBackColor = false;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // BtnResta
            // 
            this.BtnResta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnResta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResta.ForeColor = System.Drawing.Color.White;
            this.BtnResta.Location = new System.Drawing.Point(224, 250);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(43, 40);
            this.BtnResta.TabIndex = 3;
            this.BtnResta.Text = "-";
            this.BtnResta.UseVisualStyleBackColor = false;
            this.BtnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // BtnProducto
            // 
            this.BtnProducto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducto.ForeColor = System.Drawing.Color.White;
            this.BtnProducto.Location = new System.Drawing.Point(170, 296);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(43, 40);
            this.BtnProducto.TabIndex = 3;
            this.BtnProducto.Text = "x";
            this.BtnProducto.UseVisualStyleBackColor = false;
            this.BtnProducto.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnCociente
            // 
            this.BtnCociente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCociente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCociente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCociente.ForeColor = System.Drawing.Color.White;
            this.BtnCociente.Location = new System.Drawing.Point(224, 296);
            this.BtnCociente.Name = "BtnCociente";
            this.BtnCociente.Size = new System.Drawing.Size(43, 40);
            this.BtnCociente.TabIndex = 3;
            this.BtnCociente.Text = "/";
            this.BtnCociente.UseVisualStyleBackColor = false;
            this.BtnCociente.Click += new System.EventHandler(this.BtnCociente_Click);
            // 
            // TxtBxPrimerElemento
            // 
            this.TxtBxPrimerElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPrimerElemento.Location = new System.Drawing.Point(127, 27);
            this.TxtBxPrimerElemento.Name = "TxtBxPrimerElemento";
            this.TxtBxPrimerElemento.Size = new System.Drawing.Size(159, 31);
            this.TxtBxPrimerElemento.TabIndex = 4;
            this.TxtBxPrimerElemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtBxPrimerElemento.Click += new System.EventHandler(this.TxtBxPrimerElemento_Click);
            this.TxtBxPrimerElemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxPrimerElemento_KeyPress);
            this.TxtBxPrimerElemento.Leave += new System.EventHandler(this.TxtBxPrimerElemento_Leave);
            // 
            // TxtBxSegundoElemento
            // 
            this.TxtBxSegundoElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxSegundoElemento.Location = new System.Drawing.Point(127, 85);
            this.TxtBxSegundoElemento.Name = "TxtBxSegundoElemento";
            this.TxtBxSegundoElemento.Size = new System.Drawing.Size(159, 31);
            this.TxtBxSegundoElemento.TabIndex = 4;
            this.TxtBxSegundoElemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtBxSegundoElemento.Click += new System.EventHandler(this.TxtBxSegundoElemento_Click);
            this.TxtBxSegundoElemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxSegundoElemento_KeyPress);
            this.TxtBxSegundoElemento.Leave += new System.EventHandler(this.TxtBxSegundoElemento_Leave);
            // 
            // LblResultado
            // 
            this.LblResultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.ForeColor = System.Drawing.Color.Snow;
            this.LblResultado.Location = new System.Drawing.Point(127, 132);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(159, 49);
            this.LblResultado.TabIndex = 2;
            this.LblResultado.Text = " ";
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblResultado.Click += new System.EventHandler(this.LblRespuesta_Click);
            // 
            // BtnPotencia
            // 
            this.BtnPotencia.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPotencia.ForeColor = System.Drawing.Color.White;
            this.BtnPotencia.Location = new System.Drawing.Point(170, 342);
            this.BtnPotencia.Name = "BtnPotencia";
            this.BtnPotencia.Size = new System.Drawing.Size(43, 40);
            this.BtnPotencia.TabIndex = 6;
            this.BtnPotencia.Text = "^";
            this.BtnPotencia.UseVisualStyleBackColor = false;
            this.BtnPotencia.Click += new System.EventHandler(this.BtnPotencia_Click_1);
            // 
            // BtnRaiz
            // 
            this.BtnRaiz.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRaiz.ForeColor = System.Drawing.Color.White;
            this.BtnRaiz.Location = new System.Drawing.Point(224, 342);
            this.BtnRaiz.Name = "BtnRaiz";
            this.BtnRaiz.Size = new System.Drawing.Size(43, 40);
            this.BtnRaiz.TabIndex = 8;
            this.BtnRaiz.Text = "√";
            this.BtnRaiz.UseVisualStyleBackColor = false;
            this.BtnRaiz.Click += new System.EventHandler(this.BtnRaiz_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(170, 388);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(43, 40);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAns
            // 
            this.BtnAns.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAns.ForeColor = System.Drawing.Color.White;
            this.BtnAns.Location = new System.Drawing.Point(224, 388);
            this.BtnAns.Name = "BtnAns";
            this.BtnAns.Size = new System.Drawing.Size(43, 40);
            this.BtnAns.TabIndex = 10;
            this.BtnAns.Text = "Ans";
            this.BtnAns.UseVisualStyleBackColor = false;
            this.BtnAns.Click += new System.EventHandler(this.BtnAns_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSalir.Location = new System.Drawing.Point(12, 416);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(39, 27);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnExtend
            // 
            this.BtnExtend.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnExtend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExtend.ForeColor = System.Drawing.Color.White;
            this.BtnExtend.Location = new System.Drawing.Point(21, 370);
            this.BtnExtend.Name = "BtnExtend";
            this.BtnExtend.Size = new System.Drawing.Size(122, 40);
            this.BtnExtend.TabIndex = 17;
            this.BtnExtend.Text = "Extender";
            this.BtnExtend.UseVisualStyleBackColor = false;
            this.BtnExtend.Click += new System.EventHandler(this.BtnExtend_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Calculadora.Properties.Resources.Jake1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Calculadora.Properties.Resources.MarcaGG;
            this.pictureBox3.Location = new System.Drawing.Point(278, 425);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora.Properties.Resources.fondo;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 445);
            this.Controls.Add(this.BtnExtend);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAns);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnRaiz);
            this.Controls.Add(this.BtnPotencia);
            this.Controls.Add(this.TxtBxSegundoElemento);
            this.Controls.Add(this.TxtBxPrimerElemento);
            this.Controls.Add(this.BtnCociente);
            this.Controls.Add(this.BtnProducto);
            this.Controls.Add(this.BtnResta);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.LblOperacion);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.LblSegundoElemento);
            this.Controls.Add(this.LblPrimerElemento);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jake\'s Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblPrimerElemento;
        private System.Windows.Forms.Label LblSegundoElemento;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.Label LblOperacion;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnResta;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnCociente;
        private System.Windows.Forms.TextBox TxtBxPrimerElemento;
        private System.Windows.Forms.TextBox TxtBxSegundoElemento;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnPotencia;
        private System.Windows.Forms.Button BtnRaiz;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAns;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnExtend;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

