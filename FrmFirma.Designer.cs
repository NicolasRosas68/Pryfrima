namespace Pryfrima
{
    partial class FrmFirma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            chkAmarillo = new RadioButton();
            chkNegro = new RadioButton();
            chkAzul = new RadioButton();
            chkRojo = new RadioButton();
            cmdBorrar = new Button();
            cmdGuardar = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAmarillo);
            groupBox1.Controls.Add(chkNegro);
            groupBox1.Controls.Add(chkAzul);
            groupBox1.Controls.Add(chkRojo);
            groupBox1.Location = new Point(657, 149);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(104, 169);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "COLOR";
            // 
            // chkAmarillo
            // 
            chkAmarillo.AutoSize = true;
            chkAmarillo.Location = new Point(7, 130);
            chkAmarillo.Margin = new Padding(3, 4, 3, 4);
            chkAmarillo.Name = "chkAmarillo";
            chkAmarillo.Size = new Size(100, 24);
            chkAmarillo.TabIndex = 1;
            chkAmarillo.Text = "AMARILLO";
            chkAmarillo.UseVisualStyleBackColor = true;
            // 
            // chkNegro
            // 
            chkNegro.AutoSize = true;
            chkNegro.Checked = true;
            chkNegro.Location = new Point(7, 97);
            chkNegro.Margin = new Padding(3, 4, 3, 4);
            chkNegro.Name = "chkNegro";
            chkNegro.Size = new Size(79, 24);
            chkNegro.TabIndex = 1;
            chkNegro.TabStop = true;
            chkNegro.Text = "NEGRO";
            chkNegro.UseVisualStyleBackColor = true;
            // 
            // chkAzul
            // 
            chkAzul.AutoSize = true;
            chkAzul.Location = new Point(7, 64);
            chkAzul.Margin = new Padding(3, 4, 3, 4);
            chkAzul.Name = "chkAzul";
            chkAzul.Size = new Size(66, 24);
            chkAzul.TabIndex = 1;
            chkAzul.Text = "AZUL";
            chkAzul.UseVisualStyleBackColor = true;
            // 
            // chkRojo
            // 
            chkRojo.AutoSize = true;
            chkRojo.Location = new Point(7, 30);
            chkRojo.Margin = new Padding(3, 4, 3, 4);
            chkRojo.Name = "chkRojo";
            chkRojo.Size = new Size(66, 24);
            chkRojo.TabIndex = 1;
            chkRojo.Text = "ROJO";
            chkRojo.UseVisualStyleBackColor = true;
            // 
            // cmdBorrar
            // 
            cmdBorrar.Location = new Point(660, 72);
            cmdBorrar.Margin = new Padding(3, 4, 3, 4);
            cmdBorrar.Name = "cmdBorrar";
            cmdBorrar.Size = new Size(94, 47);
            cmdBorrar.TabIndex = 6;
            cmdBorrar.Text = "BORRAR";
            cmdBorrar.UseVisualStyleBackColor = true;
            cmdBorrar.Click += cmdBorrar_Click;
            // 
            // cmdGuardar
            // 
            cmdGuardar.Location = new Point(660, 17);
            cmdGuardar.Margin = new Padding(3, 4, 3, 4);
            cmdGuardar.Name = "cmdGuardar";
            cmdGuardar.Size = new Size(94, 47);
            cmdGuardar.TabIndex = 5;
            cmdGuardar.Text = "GUARDAR";
            cmdGuardar.UseVisualStyleBackColor = true;
            cmdGuardar.Click += cmdGuardar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Location = new Point(39, 17);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(608, 417);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // FrmFirma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(cmdBorrar);
            Controls.Add(cmdGuardar);
            Controls.Add(pictureBox1);
            Name = "FrmFirma";
            Text = "Form1";
            Load += FrmFirma_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton chkAmarillo;
        private RadioButton chkNegro;
        private RadioButton chkAzul;
        private RadioButton chkRojo;
        private Button cmdBorrar;
        private Button cmdGuardar;
        private PictureBox pictureBox1;
    }
}