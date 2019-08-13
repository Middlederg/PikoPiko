namespace PikoPiko.Forms
{
    partial class Dice
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Picture = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.Location = new System.Drawing.Point(2, 2);
            this.Picture.Margin = new System.Windows.Forms.Padding(0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(64, 64);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            this.Picture.Click += new System.EventHandler(this.Picture_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Picture);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(2);
            this.MainPanel.Size = new System.Drawing.Size(68, 68);
            this.MainPanel.TabIndex = 1;
            // 
            // Dice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "Dice";
            this.Size = new System.Drawing.Size(68, 68);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Panel MainPanel;
    }
}
