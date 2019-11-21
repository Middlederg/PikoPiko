namespace PikoPiko.Forms
{
    partial class PlayerInfo
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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.NumberOfTiles = new PikoPiko.Forms.CustomIconButton();
            this.Points = new PikoPiko.Forms.CustomIconButton();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 3;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainTable.Controls.Add(this.NumberOfTiles, 1, 1);
            this.MainTable.Controls.Add(this.Points, 0, 1);
            this.MainTable.Controls.Add(this.WinnerLabel, 2, 1);
            this.MainTable.Controls.Add(this.NameLabel, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.Size = new System.Drawing.Size(383, 103);
            this.MainTable.TabIndex = 0;
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
            this.NumberOfTiles.Location = new System.Drawing.Point(127, 51);
            this.NumberOfTiles.Margin = new System.Windows.Forms.Padding(0);
            this.NumberOfTiles.Name = "NumberOfTiles";
            this.NumberOfTiles.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.NumberOfTiles.Rotation = 0D;
            this.NumberOfTiles.Size = new System.Drawing.Size(127, 52);
            this.NumberOfTiles.TabIndex = 5;
            this.NumberOfTiles.Text = "1";
            this.NumberOfTiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NumberOfTiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NumberOfTiles.UseVisualStyleBackColor = false;
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
            this.Points.Location = new System.Drawing.Point(0, 51);
            this.Points.Margin = new System.Windows.Forms.Padding(0);
            this.Points.Name = "Points";
            this.Points.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Points.Rotation = 0D;
            this.Points.Size = new System.Drawing.Size(127, 52);
            this.Points.TabIndex = 4;
            this.Points.Text = "2";
            this.Points.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Points.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Points.UseVisualStyleBackColor = false;
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinnerLabel.Location = new System.Drawing.Point(257, 51);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.WinnerLabel.Size = new System.Drawing.Size(123, 52);
            this.WinnerLabel.TabIndex = 2;
            this.WinnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameLabel
            // 
            this.MainTable.SetColumnSpan(this.NameLabel, 3);
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.NameLabel.Size = new System.Drawing.Size(377, 51);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "label1";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.MainTable);
            this.Name = "PlayerInfo";
            this.Size = new System.Drawing.Size(383, 103);
            this.MainTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Label WinnerLabel;
        private System.Windows.Forms.Label NameLabel;
        private CustomIconButton Points;
        private CustomIconButton NumberOfTiles;
    }
}
