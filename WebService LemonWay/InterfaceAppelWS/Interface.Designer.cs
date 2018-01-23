using System.Numerics;
namespace InterfaceAppelWS
{
    partial class Interface
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFibonancci = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblXml = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnFibo = new System.Windows.Forms.Button();
            this.rtbXml = new System.Windows.Forms.RichTextBox();
            this.btnXml = new System.Windows.Forms.Button();
            this.lblFibo = new System.Windows.Forms.Label();
            this.lblJson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFibonancci
            // 
            this.btnFibonancci.Location = new System.Drawing.Point(12, 12);
            this.btnFibonancci.Name = "btnFibonancci";
            this.btnFibonancci.Size = new System.Drawing.Size(589, 23);
            this.btnFibonancci.TabIndex = 0;
            this.btnFibonancci.Text = "Compute Fibonancci(10)";
            this.btnFibonancci.UseVisualStyleBackColor = true;
            this.btnFibonancci.Click += new System.EventHandler(this.btnFibonancci_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblXml
            // 
            this.lblXml.AutoSize = true;
            this.lblXml.Location = new System.Drawing.Point(23, 178);
            this.lblXml.Name = "lblXml";
            this.lblXml.Size = new System.Drawing.Size(35, 13);
            this.lblXml.TabIndex = 2;
            this.lblXml.Text = "XML :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnFibo
            // 
            this.btnFibo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFibo.Location = new System.Drawing.Point(231, 75);
            this.btnFibo.Name = "btnFibo";
            this.btnFibo.Size = new System.Drawing.Size(112, 23);
            this.btnFibo.TabIndex = 4;
            this.btnFibo.Text = "Fibonacci";
            this.btnFibo.UseVisualStyleBackColor = true;
            this.btnFibo.Click += new System.EventHandler(this.btnFibo_Click);
            // 
            // rtbXml
            // 
            this.rtbXml.Location = new System.Drawing.Point(79, 119);
            this.rtbXml.Name = "rtbXml";
            this.rtbXml.Size = new System.Drawing.Size(143, 127);
            this.rtbXml.TabIndex = 5;
            this.rtbXml.Text = "";
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(231, 173);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(112, 23);
            this.btnXml.TabIndex = 6;
            this.btnXml.Text = "Convertir en Json";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // lblFibo
            // 
            this.lblFibo.AutoSize = true;
            this.lblFibo.Location = new System.Drawing.Point(349, 80);
            this.lblFibo.Name = "lblFibo";
            this.lblFibo.Size = new System.Drawing.Size(0, 13);
            this.lblFibo.TabIndex = 9;
            // 
            // lblJson
            // 
            this.lblJson.Location = new System.Drawing.Point(349, 119);
            this.lblJson.Name = "lblJson";
            this.lblJson.Size = new System.Drawing.Size(252, 127);
            this.lblJson.TabIndex = 10;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(613, 264);
            this.Controls.Add(this.lblJson);
            this.Controls.Add(this.lblFibo);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.rtbXml);
            this.Controls.Add(this.btnFibo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblXml);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnFibonancci);
            this.Name = "Interface";
            this.Text = "Lancer les WebServices";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFibonancci;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblXml;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnFibo;
        private System.Windows.Forms.RichTextBox rtbXml;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Label lblFibo;
        private System.Windows.Forms.Label lblJson;
    }
}

