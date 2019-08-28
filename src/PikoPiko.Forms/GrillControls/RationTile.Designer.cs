namespace PikoPiko.Forms
{
    partial class RationTile
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
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Separator = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.Controls.Add(this.Picture, 0, 2);
            this.MainPanel.Controls.Add(this.Separator, 0, 1);
            this.MainPanel.Controls.Add(this.NumberLabel, 0, 0);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(2, 2);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 3;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainPanel.Size = new System.Drawing.Size(56, 96);
            this.MainPanel.TabIndex = 0;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.White;
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.Location = new System.Drawing.Point(2, 39);
            this.Picture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(52, 55);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 2;
            this.Picture.TabStop = false;
            this.Picture.Click += new System.EventHandler(this.TileClick);
            // 
            // Separator
            // 
            this.Separator.AutoSize = true;
            this.Separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.Separator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Separator.Location = new System.Drawing.Point(3, 37);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(50, 2);
            this.Separator.TabIndex = 0;
            this.Separator.Click += new System.EventHandler(this.TileClick);
            // 
            // NumberLabel
            // 
            this.NumberLabel.BackColor = System.Drawing.Color.White;
            this.NumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumberLabel.Font = new System.Drawing.Font("Impact", 22F);
            this.NumberLabel.Location = new System.Drawing.Point(2, 2);
            this.NumberLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.NumberLabel.Size = new System.Drawing.Size(52, 35);
            this.NumberLabel.TabIndex = 1;
            this.NumberLabel.Text = "21";
            this.NumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumberLabel.Click += new System.EventHandler(this.TileClick);
            // 
            // RationTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "RationTile";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(60, 100);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.Label Separator;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.PictureBox Picture;
    }
}
