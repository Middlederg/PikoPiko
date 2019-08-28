namespace PikoPiko.Forms
{
    partial class PlayerPanel
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
            this.components = new System.ComponentModel.Container();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.Points = new PikoPiko.Forms.CustomIconButton();
            this.Tile = new PikoPiko.Forms.RationTile();
            this.NumberOfTiles = new PikoPiko.Forms.CustomIconButton();
            this.Help = new System.Windows.Forms.ToolTip(this.components);
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.Controls.Add(this.Points, 0, 1);
            this.MainTable.Controls.Add(this.Tile, 0, 0);
            this.MainTable.Controls.Add(this.NumberOfTiles, 1, 1);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainTable.Size = new System.Drawing.Size(180, 158);
            this.MainTable.TabIndex = 0;
            // 
            // Points
            // 
            this.Points.BackColor = System.Drawing.Color.Transparent;
            this.Points.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Points.FlatAppearance.BorderSize = 0;
            this.Points.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Points.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Points.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.Points.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.Points.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.Points.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.Points.IconSize = 32;
            this.Points.Location = new System.Drawing.Point(0, 108);
            this.Points.Margin = new System.Windows.Forms.Padding(0);
            this.Points.Name = "Points";
            this.Points.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Points.Rotation = 0D;
            this.Points.Size = new System.Drawing.Size(90, 50);
            this.Points.TabIndex = 2;
            this.Points.Text = "2";
            this.Points.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Points.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Help.SetToolTip(this.Points, "Points");
            this.Points.UseVisualStyleBackColor = false;
            // 
            // Tile
            // 
            this.Tile.Activable = false;
            this.Tile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.MainTable.SetColumnSpan(this.Tile, 2);
            this.Tile.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.Tile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.Tile.Location = new System.Drawing.Point(60, 4);
            this.Tile.Margin = new System.Windows.Forms.Padding(0);
            this.Tile.Name = "Tile";
            this.Tile.Padding = new System.Windows.Forms.Padding(2);
            this.Tile.RationValue = null;
            this.Tile.Size = new System.Drawing.Size(60, 100);
            this.Tile.TabIndex = 0;
            // 
            // NumberOfTiles
            // 
            this.NumberOfTiles.BackColor = System.Drawing.Color.Transparent;
            this.NumberOfTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumberOfTiles.FlatAppearance.BorderSize = 0;
            this.NumberOfTiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberOfTiles.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NumberOfTiles.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.NumberOfTiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.NumberOfTiles.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.NumberOfTiles.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.NumberOfTiles.IconSize = 32;
            this.NumberOfTiles.Location = new System.Drawing.Point(90, 108);
            this.NumberOfTiles.Margin = new System.Windows.Forms.Padding(0);
            this.NumberOfTiles.Name = "NumberOfTiles";
            this.NumberOfTiles.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.NumberOfTiles.Rotation = 0D;
            this.NumberOfTiles.Size = new System.Drawing.Size(90, 50);
            this.NumberOfTiles.TabIndex = 1;
            this.NumberOfTiles.Text = "1";
            this.NumberOfTiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NumberOfTiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Help.SetToolTip(this.NumberOfTiles, "Number of tiles");
            this.NumberOfTiles.UseVisualStyleBackColor = false;
            // 
            // PlayerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTable);
            this.Name = "PlayerPanel";
            this.Size = new System.Drawing.Size(180, 158);
            this.MainTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private RationTile Tile;
        private CustomIconButton NumberOfTiles;
        private CustomIconButton Points;
        private System.Windows.Forms.ToolTip Help;
    }
}
