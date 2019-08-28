namespace PikoPiko.Forms
{
    partial class RationPanel
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
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.GrillHeader = new PikoPiko.Forms.Header();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 35);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(490, 257);
            this.MainPanel.TabIndex = 0;
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.MainPanel, 0, 1);
            this.MainTable.Controls.Add(this.GrillHeader, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(5, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(490, 292);
            this.MainTable.TabIndex = 1;
            // 
            // GrillHeader
            // 
            this.GrillHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillHeader.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.GrillHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.GrillHeader.Location = new System.Drawing.Point(0, 0);
            this.GrillHeader.Margin = new System.Windows.Forms.Padding(0);
            this.GrillHeader.Name = "GrillHeader";
            this.GrillHeader.Size = new System.Drawing.Size(490, 35);
            this.GrillHeader.TabIndex = 1;
            this.GrillHeader.Title = "Grill";
            // 
            // RationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTable);
            this.Name = "RationPanel";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Size = new System.Drawing.Size(500, 297);
            this.MainTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private System.Windows.Forms.TableLayoutPanel MainTable;
        private Header GrillHeader;
    }
}
