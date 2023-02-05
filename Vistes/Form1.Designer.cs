
namespace PersonesFB
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
            this.lstPersones = new System.Windows.Forms.ListBox();
            this.btnLoadPersonesObject = new System.Windows.Forms.Button();
            this.btnLoadPersonesArray = new System.Windows.Forms.Button();
            this.btnAfegirPersona = new System.Windows.Forms.Button();
            this.btnEditaPersona = new System.Windows.Forms.Button();
            this.btnEsborrarPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPersones
            // 
            this.lstPersones.FormattingEnabled = true;
            this.lstPersones.ItemHeight = 16;
            this.lstPersones.Location = new System.Drawing.Point(12, 12);
            this.lstPersones.Name = "lstPersones";
            this.lstPersones.Size = new System.Drawing.Size(246, 276);
            this.lstPersones.TabIndex = 0;
            this.lstPersones.DoubleClick += new System.EventHandler(this.lstPersones_DoubleClick);
            // 
            // btnLoadPersonesObject
            // 
            this.btnLoadPersonesObject.Location = new System.Drawing.Point(455, 12);
            this.btnLoadPersonesObject.Name = "btnLoadPersonesObject";
            this.btnLoadPersonesObject.Size = new System.Drawing.Size(187, 29);
            this.btnLoadPersonesObject.TabIndex = 1;
            this.btnLoadPersonesObject.Text = "Carrega PersonesObject";
            this.btnLoadPersonesObject.UseVisualStyleBackColor = true;
            this.btnLoadPersonesObject.Click += new System.EventHandler(this.btnLoadPersonesObject_Click);
            // 
            // btnLoadPersonesArray
            // 
            this.btnLoadPersonesArray.Location = new System.Drawing.Point(455, 47);
            this.btnLoadPersonesArray.Name = "btnLoadPersonesArray";
            this.btnLoadPersonesArray.Size = new System.Drawing.Size(187, 28);
            this.btnLoadPersonesArray.TabIndex = 2;
            this.btnLoadPersonesArray.Text = "Carrega PersonesArray";
            this.btnLoadPersonesArray.UseVisualStyleBackColor = true;
            this.btnLoadPersonesArray.Click += new System.EventHandler(this.btnLoadPersonesArray_Click);
            // 
            // btnAfegirPersona
            // 
            this.btnAfegirPersona.Location = new System.Drawing.Point(265, 13);
            this.btnAfegirPersona.Name = "btnAfegirPersona";
            this.btnAfegirPersona.Size = new System.Drawing.Size(144, 28);
            this.btnAfegirPersona.TabIndex = 3;
            this.btnAfegirPersona.Text = "Afegir Persona";
            this.btnAfegirPersona.UseVisualStyleBackColor = true;
            this.btnAfegirPersona.Click += new System.EventHandler(this.btnAfegirPersona_Click);
            // 
            // btnEditaPersona
            // 
            this.btnEditaPersona.Location = new System.Drawing.Point(265, 47);
            this.btnEditaPersona.Name = "btnEditaPersona";
            this.btnEditaPersona.Size = new System.Drawing.Size(144, 28);
            this.btnEditaPersona.TabIndex = 4;
            this.btnEditaPersona.Text = "Modificar Persona";
            this.btnEditaPersona.UseVisualStyleBackColor = true;
            this.btnEditaPersona.Click += new System.EventHandler(this.btnEditaPersona_Click);
            // 
            // btnEsborrarPersona
            // 
            this.btnEsborrarPersona.Location = new System.Drawing.Point(265, 81);
            this.btnEsborrarPersona.Name = "btnEsborrarPersona";
            this.btnEsborrarPersona.Size = new System.Drawing.Size(144, 28);
            this.btnEsborrarPersona.TabIndex = 5;
            this.btnEsborrarPersona.Text = "Esborrar Persona";
            this.btnEsborrarPersona.UseVisualStyleBackColor = true;
            this.btnEsborrarPersona.Click += new System.EventHandler(this.btnEsborrarPersona_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 313);
            this.Controls.Add(this.btnEsborrarPersona);
            this.Controls.Add(this.btnEditaPersona);
            this.Controls.Add(this.btnAfegirPersona);
            this.Controls.Add(this.btnLoadPersonesArray);
            this.Controls.Add(this.btnLoadPersonesObject);
            this.Controls.Add(this.lstPersones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPersones;
        private System.Windows.Forms.Button btnLoadPersonesObject;
        private System.Windows.Forms.Button btnLoadPersonesArray;
        private System.Windows.Forms.Button btnAfegirPersona;
        private System.Windows.Forms.Button btnEditaPersona;
        private System.Windows.Forms.Button btnEsborrarPersona;
    }
}

