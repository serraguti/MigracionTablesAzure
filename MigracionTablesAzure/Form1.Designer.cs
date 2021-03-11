
namespace MigracionTablesAzure
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
            this.botonmigrardatos = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonmigrardatos
            // 
            this.botonmigrardatos.Location = new System.Drawing.Point(124, 26);
            this.botonmigrardatos.Name = "botonmigrardatos";
            this.botonmigrardatos.Size = new System.Drawing.Size(228, 56);
            this.botonmigrardatos.TabIndex = 0;
            this.botonmigrardatos.Text = "Migrar datos";
            this.botonmigrardatos.UseVisualStyleBackColor = true;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(50, 138);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(115, 25);
            this.lblmensaje.TabIndex = 1;
            this.lblmensaje.Text = "lblmensaje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 238);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.botonmigrardatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonmigrardatos;
        private System.Windows.Forms.Label lblmensaje;
    }
}

