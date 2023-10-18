namespace Aprobador
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
            this.LblMensaje = new System.Windows.Forms.Label();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.TxtBxNota = new System.Windows.Forms.TextBox();
            this.LblInstruction = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMensaje
            // 
            this.LblMensaje.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.Location = new System.Drawing.Point(12, 326);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(280, 43);
            this.LblMensaje.TabIndex = 17;
            this.LblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCheck
            // 
            this.BtnCheck.BackColor = System.Drawing.Color.Gray;
            this.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheck.Location = new System.Drawing.Point(17, 266);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(95, 31);
            this.BtnCheck.TabIndex = 16;
            this.BtnCheck.Text = "Chequear";
            this.BtnCheck.UseVisualStyleBackColor = false;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // TxtBxNota
            // 
            this.TxtBxNota.BackColor = System.Drawing.Color.Silver;
            this.TxtBxNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNota.Location = new System.Drawing.Point(17, 164);
            this.TxtBxNota.Name = "TxtBxNota";
            this.TxtBxNota.Size = new System.Drawing.Size(276, 83);
            this.TxtBxNota.TabIndex = 15;
            this.TxtBxNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblInstruction
            // 
            this.LblInstruction.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInstruction.Location = new System.Drawing.Point(13, 85);
            this.LblInstruction.Name = "LblInstruction";
            this.LblInstruction.Size = new System.Drawing.Size(280, 43);
            this.LblInstruction.TabIndex = 14;
            this.LblInstruction.Text = "Introduzca la nota a revisar";
            this.LblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Gray;
            this.Title.Image = ((System.Drawing.Image)(resources.GetObject("Title.Image")));
            this.Title.Location = new System.Drawing.Point(43, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(214, 47);
            this.Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Title.TabIndex = 12;
            this.Title.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Gray;
            this.LblTitle.Location = new System.Drawing.Point(-2, -8);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(308, 58);
            this.LblTitle.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(304, 387);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.TxtBxNota);
            this.Controls.Add(this.LblInstruction);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.LblTitle);
            this.Name = "Form1";
            this.Text = "Aprobador";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.TextBox TxtBxNota;
        private System.Windows.Forms.Label LblInstruction;
        private System.Windows.Forms.PictureBox Title;
        private System.Windows.Forms.Label LblTitle;
    }
}

