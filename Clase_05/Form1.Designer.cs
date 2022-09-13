
namespace Clase_05
{
    partial class Form1
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
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lbl_Inicio = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Aceptar.Location = new System.Drawing.Point(317, 206);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(173, 69);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.TextChanged += new System.EventHandler(this.btn_Aceptar_Click);
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            this.btn_Aceptar.MouseHover += new System.EventHandler(this.btn_Aceptar_MouseHover);
            // 
            // lbl_Inicio
            // 
            this.lbl_Inicio.AutoSize = true;
            this.lbl_Inicio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Inicio.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Inicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Inicio.Location = new System.Drawing.Point(273, 68);
            this.lbl_Inicio.Name = "lbl_Inicio";
            this.lbl_Inicio.Size = new System.Drawing.Size(311, 40);
            this.lbl_Inicio.TabIndex = 1;
            this.lbl_Inicio.Text = "Primer Windows Forms";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(288, 133);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "Ingrese su nombre";
            this.txt_nombre.Size = new System.Drawing.Size(253, 27);
            this.txt_nombre.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_Inicio);
            this.Controls.Add(this.btn_Aceptar);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label lbl_Inicio;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}

