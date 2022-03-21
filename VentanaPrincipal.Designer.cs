
namespace Pokedex_CSharp
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.izquierda = new System.Windows.Forms.Button();
            this.imagenPokemon = new System.Windows.Forms.PictureBox();
            this.derecha = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.masInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // izquierda
            // 
            this.izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izquierda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.izquierda.Location = new System.Drawing.Point(378, 392);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(86, 30);
            this.izquierda.TabIndex = 0;
            this.izquierda.Text = "<";
            this.izquierda.UseVisualStyleBackColor = true;
            this.izquierda.Click += new System.EventHandler(this.izquierda_Click);
            // 
            // imagenPokemon
            // 
            this.imagenPokemon.BackColor = System.Drawing.Color.White;
            this.imagenPokemon.Location = new System.Drawing.Point(78, 160);
            this.imagenPokemon.Name = "imagenPokemon";
            this.imagenPokemon.Size = new System.Drawing.Size(187, 127);
            this.imagenPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagenPokemon.TabIndex = 1;
            this.imagenPokemon.TabStop = false;
            this.imagenPokemon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // derecha
            // 
            this.derecha.BackColor = System.Drawing.Color.Transparent;
            this.derecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.derecha.Location = new System.Drawing.Point(480, 392);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(88, 30);
            this.derecha.TabIndex = 2;
            this.derecha.Text = ">";
            this.derecha.UseVisualStyleBackColor = false;
            this.derecha.Click += new System.EventHandler(this.derecha_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.Color.Transparent;
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nombrePokemon.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.nombrePokemon.Location = new System.Drawing.Point(391, 189);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(163, 38);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nombrePokemon.Click += new System.EventHandler(this.nombrePokemon_Click);
            // 
            // masInfo
            // 
            this.masInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masInfo.Location = new System.Drawing.Point(95, 379);
            this.masInfo.Name = "masInfo";
            this.masInfo.Size = new System.Drawing.Size(95, 56);
            this.masInfo.TabIndex = 6;
            this.masInfo.Text = "Más Info";
            this.masInfo.UseVisualStyleBackColor = true;
            this.masInfo.Click += new System.EventHandler(this.masInfo_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 482);
            this.Controls.Add(this.masInfo);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.imagenPokemon);
            this.Controls.Add(this.izquierda);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.PictureBox imagenPokemon;
        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Button masInfo;
        private System.Windows.Forms.Label nombrePokemon;
    }
}

