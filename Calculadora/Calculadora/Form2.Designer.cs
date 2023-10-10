namespace Calculadora
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtBxX = new System.Windows.Forms.TextBox();
            this.BtnSen = new System.Windows.Forms.Button();
            this.LblOperacion = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.LblX = new System.Windows.Forms.Label();
            this.BtnCos = new System.Windows.Forms.Button();
            this.BtnCtg = new System.Windows.Forms.Button();
            this.BtnTan = new System.Windows.Forms.Button();
            this.BntCsc = new System.Windows.Forms.Button();
            this.BtnSec = new System.Windows.Forms.Button();
            this.BtnArcos = new System.Windows.Forms.Button();
            this.BtnArcsen = new System.Windows.Forms.Button();
            this.BtnArcCtg = new System.Windows.Forms.Button();
            this.BtnArcTan = new System.Windows.Forms.Button();
            this.BtnArcCsc = new System.Windows.Forms.Button();
            this.BtnArcSec = new System.Windows.Forms.Button();
            this.BtnAns = new System.Windows.Forms.Button();
            this.RBtnGrados = new System.Windows.Forms.RadioButton();
            this.RBtnRadianes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnFactorial = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSalir.Location = new System.Drawing.Point(11, 306);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(39, 27);
            this.BtnSalir.TabIndex = 22;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtBxX
            // 
            this.TxtBxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxX.Location = new System.Drawing.Point(139, 15);
            this.TxtBxX.Name = "TxtBxX";
            this.TxtBxX.Size = new System.Drawing.Size(159, 31);
            this.TxtBxX.TabIndex = 20;
            this.TxtBxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtBxX.Click += new System.EventHandler(this.TxtBxX_Click);
            this.TxtBxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxX_KeyPress);
            this.TxtBxX.Leave += new System.EventHandler(this.TxtBxX_Leave);
            // 
            // BtnSen
            // 
            this.BtnSen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSen.ForeColor = System.Drawing.Color.White;
            this.BtnSen.Location = new System.Drawing.Point(139, 187);
            this.BtnSen.Name = "BtnSen";
            this.BtnSen.Size = new System.Drawing.Size(74, 40);
            this.BtnSen.TabIndex = 19;
            this.BtnSen.Text = "Sen(X)";
            this.BtnSen.UseVisualStyleBackColor = false;
            this.BtnSen.Click += new System.EventHandler(this.BtnSen_Click);
            // 
            // LblOperacion
            // 
            this.LblOperacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblOperacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOperacion.ForeColor = System.Drawing.Color.Snow;
            this.LblOperacion.Location = new System.Drawing.Point(139, 135);
            this.LblOperacion.Name = "LblOperacion";
            this.LblOperacion.Size = new System.Drawing.Size(159, 49);
            this.LblOperacion.TabIndex = 16;
            this.LblOperacion.Text = "Operación";
            this.LblOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblResultado
            // 
            this.LblResultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.ForeColor = System.Drawing.Color.Snow;
            this.LblResultado.Location = new System.Drawing.Point(139, 67);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(159, 49);
            this.LblResultado.TabIndex = 17;
            this.LblResultado.Text = " ";
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRespuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRespuesta.ForeColor = System.Drawing.Color.Snow;
            this.LblRespuesta.Location = new System.Drawing.Point(14, 67);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(109, 49);
            this.LblRespuesta.TabIndex = 18;
            this.LblRespuesta.Text = "Respuesta";
            this.LblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblX
            // 
            this.LblX.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblX.ForeColor = System.Drawing.Color.Snow;
            this.LblX.Location = new System.Drawing.Point(14, 8);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(109, 49);
            this.LblX.TabIndex = 15;
            this.LblX.Text = "X";
            this.LblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCos
            // 
            this.BtnCos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCos.ForeColor = System.Drawing.Color.White;
            this.BtnCos.Location = new System.Drawing.Point(224, 187);
            this.BtnCos.Name = "BtnCos";
            this.BtnCos.Size = new System.Drawing.Size(74, 40);
            this.BtnCos.TabIndex = 23;
            this.BtnCos.Text = "Cos(X)";
            this.BtnCos.UseVisualStyleBackColor = false;
            this.BtnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // BtnCtg
            // 
            this.BtnCtg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCtg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCtg.ForeColor = System.Drawing.Color.White;
            this.BtnCtg.Location = new System.Drawing.Point(224, 233);
            this.BtnCtg.Name = "BtnCtg";
            this.BtnCtg.Size = new System.Drawing.Size(74, 40);
            this.BtnCtg.TabIndex = 25;
            this.BtnCtg.Text = "Ctg(X)";
            this.BtnCtg.UseVisualStyleBackColor = false;
            this.BtnCtg.Click += new System.EventHandler(this.BtnCtg_Click);
            // 
            // BtnTan
            // 
            this.BtnTan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnTan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTan.ForeColor = System.Drawing.Color.White;
            this.BtnTan.Location = new System.Drawing.Point(139, 233);
            this.BtnTan.Name = "BtnTan";
            this.BtnTan.Size = new System.Drawing.Size(74, 40);
            this.BtnTan.TabIndex = 24;
            this.BtnTan.Text = "Tan(X)";
            this.BtnTan.UseVisualStyleBackColor = false;
            this.BtnTan.Click += new System.EventHandler(this.BtnTan_Click);
            // 
            // BntCsc
            // 
            this.BntCsc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BntCsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BntCsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntCsc.ForeColor = System.Drawing.Color.White;
            this.BntCsc.Location = new System.Drawing.Point(224, 279);
            this.BntCsc.Name = "BntCsc";
            this.BntCsc.Size = new System.Drawing.Size(74, 40);
            this.BntCsc.TabIndex = 27;
            this.BntCsc.Text = "Csc(X)";
            this.BntCsc.UseVisualStyleBackColor = false;
            this.BntCsc.Click += new System.EventHandler(this.BntCsc_Click);
            // 
            // BtnSec
            // 
            this.BtnSec.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSec.ForeColor = System.Drawing.Color.White;
            this.BtnSec.Location = new System.Drawing.Point(139, 279);
            this.BtnSec.Name = "BtnSec";
            this.BtnSec.Size = new System.Drawing.Size(74, 40);
            this.BtnSec.TabIndex = 26;
            this.BtnSec.Text = "Sec(X)";
            this.BtnSec.UseVisualStyleBackColor = false;
            this.BtnSec.Click += new System.EventHandler(this.BtnSec_Click);
            // 
            // BtnArcos
            // 
            this.BtnArcos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnArcos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnArcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArcos.ForeColor = System.Drawing.Color.White;
            this.BtnArcos.Location = new System.Drawing.Point(224, 325);
            this.BtnArcos.Name = "BtnArcos";
            this.BtnArcos.Size = new System.Drawing.Size(74, 40);
            this.BtnArcos.TabIndex = 29;
            this.BtnArcos.Text = "ArcCos(X)";
            this.BtnArcos.UseVisualStyleBackColor = false;
            this.BtnArcos.Click += new System.EventHandler(this.BtnArcos_Click);
            // 
            // BtnArcsen
            // 
            this.BtnArcsen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnArcsen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnArcsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArcsen.ForeColor = System.Drawing.Color.White;
            this.BtnArcsen.Location = new System.Drawing.Point(139, 325);
            this.BtnArcsen.Name = "BtnArcsen";
            this.BtnArcsen.Size = new System.Drawing.Size(74, 40);
            this.BtnArcsen.TabIndex = 28;
            this.BtnArcsen.Text = "ArcSen(X)";
            this.BtnArcsen.UseVisualStyleBackColor = false;
            this.BtnArcsen.Click += new System.EventHandler(this.BtnArcsen_Click);
            // 
            // BtnArcCtg
            // 
            this.BtnArcCtg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnArcCtg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnArcCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArcCtg.ForeColor = System.Drawing.Color.White;
            this.BtnArcCtg.Location = new System.Drawing.Point(224, 371);
            this.BtnArcCtg.Name = "BtnArcCtg";
            this.BtnArcCtg.Size = new System.Drawing.Size(74, 40);
            this.BtnArcCtg.TabIndex = 31;
            this.BtnArcCtg.Text = "ArcCtg(X)";
            this.BtnArcCtg.UseVisualStyleBackColor = false;
            this.BtnArcCtg.Click += new System.EventHandler(this.BtnArcCtg_Click);
            // 
            // BtnArcTan
            // 
            this.BtnArcTan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnArcTan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnArcTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArcTan.ForeColor = System.Drawing.Color.White;
            this.BtnArcTan.Location = new System.Drawing.Point(139, 371);
            this.BtnArcTan.Name = "BtnArcTan";
            this.BtnArcTan.Size = new System.Drawing.Size(74, 40);
            this.BtnArcTan.TabIndex = 30;
            this.BtnArcTan.Text = "ArcTan(X)";
            this.BtnArcTan.UseVisualStyleBackColor = false;
            this.BtnArcTan.Click += new System.EventHandler(this.BtnArcTan_Click);
            // 
            // BtnArcCsc
            // 
            this.BtnArcCsc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnArcCsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnArcCsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArcCsc.ForeColor = System.Drawing.Color.White;
            this.BtnArcCsc.Location = new System.Drawing.Point(224, 417);
            this.BtnArcCsc.Name = "BtnArcCsc";
            this.BtnArcCsc.Size = new System.Drawing.Size(74, 40);
            this.BtnArcCsc.TabIndex = 33;
            this.BtnArcCsc.Text = "ArcCsc(X)";
            this.BtnArcCsc.UseVisualStyleBackColor = false;
            this.BtnArcCsc.Click += new System.EventHandler(this.BtnArcCsc_Click);
            // 
            // BtnArcSec
            // 
            this.BtnArcSec.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnArcSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnArcSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArcSec.ForeColor = System.Drawing.Color.White;
            this.BtnArcSec.Location = new System.Drawing.Point(139, 417);
            this.BtnArcSec.Name = "BtnArcSec";
            this.BtnArcSec.Size = new System.Drawing.Size(74, 40);
            this.BtnArcSec.TabIndex = 32;
            this.BtnArcSec.Text = "ArcSec(X)";
            this.BtnArcSec.UseVisualStyleBackColor = false;
            this.BtnArcSec.Click += new System.EventHandler(this.BtnArcSec_Click);
            // 
            // BtnAns
            // 
            this.BtnAns.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAns.ForeColor = System.Drawing.Color.White;
            this.BtnAns.Location = new System.Drawing.Point(11, 214);
            this.BtnAns.Name = "BtnAns";
            this.BtnAns.Size = new System.Drawing.Size(100, 40);
            this.BtnAns.TabIndex = 35;
            this.BtnAns.Text = "Ans";
            this.BtnAns.UseVisualStyleBackColor = false;
            this.BtnAns.Click += new System.EventHandler(this.BtnAns_Click);
            // 
            // RBtnGrados
            // 
            this.RBtnGrados.AutoSize = true;
            this.RBtnGrados.Checked = true;
            this.RBtnGrados.Location = new System.Drawing.Point(1, 20);
            this.RBtnGrados.Name = "RBtnGrados";
            this.RBtnGrados.Size = new System.Drawing.Size(77, 20);
            this.RBtnGrados.TabIndex = 0;
            this.RBtnGrados.TabStop = true;
            this.RBtnGrados.Text = "Grados";
            this.RBtnGrados.UseVisualStyleBackColor = true;
            // 
            // RBtnRadianes
            // 
            this.RBtnRadianes.AutoSize = true;
            this.RBtnRadianes.Location = new System.Drawing.Point(1, 44);
            this.RBtnRadianes.Name = "RBtnRadianes";
            this.RBtnRadianes.Size = new System.Drawing.Size(93, 20);
            this.RBtnRadianes.TabIndex = 1;
            this.RBtnRadianes.Text = "Radianes";
            this.RBtnRadianes.UseVisualStyleBackColor = true;
            this.RBtnRadianes.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RBtnRadianes);
            this.groupBox1.Controls.Add(this.RBtnGrados);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 72);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unidad";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnClear.Location = new System.Drawing.Point(72, 306);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(39, 27);
            this.BtnClear.TabIndex = 39;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnFactorial
            // 
            this.BtnFactorial.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFactorial.ForeColor = System.Drawing.Color.White;
            this.BtnFactorial.Location = new System.Drawing.Point(11, 260);
            this.BtnFactorial.Name = "BtnFactorial";
            this.BtnFactorial.Size = new System.Drawing.Size(100, 40);
            this.BtnFactorial.TabIndex = 40;
            this.BtnFactorial.Text = "X!";
            this.BtnFactorial.UseVisualStyleBackColor = false;
            this.BtnFactorial.Click += new System.EventHandler(this.BtnFactorial_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Calculadora.Properties.Resources.MarcaGG2;
            this.pictureBox3.Location = new System.Drawing.Point(278, 463);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Calculadora.Properties.Resources.Finn;
            this.pictureBox2.Location = new System.Drawing.Point(2, 344);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora.Properties.Resources.fondo2;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 489);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 483);
            this.Controls.Add(this.BtnFactorial);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnAns);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnArcCsc);
            this.Controls.Add(this.BtnArcSec);
            this.Controls.Add(this.BtnArcCtg);
            this.Controls.Add(this.BtnArcTan);
            this.Controls.Add(this.BtnArcos);
            this.Controls.Add(this.BtnArcsen);
            this.Controls.Add(this.BntCsc);
            this.Controls.Add(this.BtnSec);
            this.Controls.Add(this.BtnCtg);
            this.Controls.Add(this.BtnTan);
            this.Controls.Add(this.BtnCos);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtBxX);
            this.Controls.Add(this.BtnSen);
            this.Controls.Add(this.LblOperacion);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.LblX);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Finn\'s Extension";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtBxX;
        private System.Windows.Forms.Button BtnSen;
        private System.Windows.Forms.Label LblOperacion;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.Button BtnCos;
        private System.Windows.Forms.Button BtnCtg;
        private System.Windows.Forms.Button BtnTan;
        private System.Windows.Forms.Button BntCsc;
        private System.Windows.Forms.Button BtnSec;
        private System.Windows.Forms.Button BtnArcos;
        private System.Windows.Forms.Button BtnArcsen;
        private System.Windows.Forms.Button BtnArcCtg;
        private System.Windows.Forms.Button BtnArcTan;
        private System.Windows.Forms.Button BtnArcCsc;
        private System.Windows.Forms.Button BtnArcSec;
        private System.Windows.Forms.Button BtnAns;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RBtnGrados;
        private System.Windows.Forms.RadioButton RBtnRadianes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnFactorial;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}