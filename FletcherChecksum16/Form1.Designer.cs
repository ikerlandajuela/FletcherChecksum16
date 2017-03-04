namespace FletcherChecksum16
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
            this.txtTrmHex = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuitApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCRC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTrmHex
            // 
            this.txtTrmHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrmHex.Location = new System.Drawing.Point(13, 30);
            this.txtTrmHex.MaxLength = 8;
            this.txtTrmHex.Name = "txtTrmHex";
            this.txtTrmHex.Size = new System.Drawing.Size(100, 20);
            this.txtTrmHex.TabIndex = 0;
            this.txtTrmHex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTrmHex_KeyDown);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(123, 24);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 26);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(277, 24);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Limpiar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuitApp
            // 
            this.btnQuitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitApp.Location = new System.Drawing.Point(357, 24);
            this.btnQuitApp.Name = "btnQuitApp";
            this.btnQuitApp.Size = new System.Drawing.Size(75, 26);
            this.btnQuitApp.TabIndex = 4;
            this.btnQuitApp.Text = "&Salir";
            this.btnQuitApp.UseVisualStyleBackColor = true;
            this.btnQuitApp.Click += new System.EventHandler(this.btnQuitApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trama hexadecimal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Checksum:";
            // 
            // txtCRC
            // 
            this.txtCRC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCRC.Location = new System.Drawing.Point(210, 29);
            this.txtCRC.Name = "txtCRC";
            this.txtCRC.ReadOnly = true;
            this.txtCRC.Size = new System.Drawing.Size(50, 20);
            this.txtCRC.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 58);
            this.Controls.Add(this.txtCRC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitApp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTrmHex);
            this.Name = "Form1";
            this.Text = "Fletcher\'s Checksum 16-bit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTrmHex;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuitApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCRC;
    }
}

