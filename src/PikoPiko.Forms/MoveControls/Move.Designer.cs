namespace PikoPiko.Forms
{
    partial class Move
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
            this.MoveHeader = new PikoPiko.Forms.Header();
            this.ButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonRoll = new PikoPiko.Forms.CustomIconButton();
            this.ButtonStop = new PikoPiko.Forms.CustomIconButton();
            this.Lvw = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerInfo = new PikoPiko.Forms.PlayerPanel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.ToolTip(this.components);
            this.MainTable.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 3;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.MainTable.Controls.Add(this.MoveHeader, 0, 0);
            this.MainTable.Controls.Add(this.ButtonsPanel, 0, 2);
            this.MainTable.Controls.Add(this.Lvw, 1, 1);
            this.MainTable.Controls.Add(this.PlayerInfo, 2, 1);
            this.MainTable.Controls.Add(this.InfoLabel, 1, 2);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(5, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 3;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(570, 255);
            this.MainTable.TabIndex = 0;
            // 
            // MoveHeader
            // 
            this.MoveHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.MainTable.SetColumnSpan(this.MoveHeader, 3);
            this.MoveHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveHeader.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.MoveHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.MoveHeader.Location = new System.Drawing.Point(0, 0);
            this.MoveHeader.Margin = new System.Windows.Forms.Padding(0);
            this.MoveHeader.Name = "MoveHeader";
            this.MoveHeader.Size = new System.Drawing.Size(570, 35);
            this.MoveHeader.TabIndex = 1;
            this.MoveHeader.Title = "Your move";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.ButtonRoll);
            this.ButtonsPanel.Controls.Add(this.ButtonStop);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 213);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(325, 42);
            this.ButtonsPanel.TabIndex = 3;
            // 
            // ButtonRoll
            // 
            this.ButtonRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(145)))), ((int)(((byte)(182)))));
            this.ButtonRoll.FlatAppearance.BorderSize = 0;
            this.ButtonRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRoll.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonRoll.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonRoll.ForeColor = System.Drawing.Color.White;
            this.ButtonRoll.IconChar = FontAwesome.Sharp.IconChar.DiceD6;
            this.ButtonRoll.IconColor = System.Drawing.Color.White;
            this.ButtonRoll.IconSize = 30;
            this.ButtonRoll.Location = new System.Drawing.Point(0, 0);
            this.ButtonRoll.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.ButtonRoll.Name = "ButtonRoll";
            this.ButtonRoll.Rotation = 0D;
            this.ButtonRoll.Size = new System.Drawing.Size(180, 35);
            this.ButtonRoll.TabIndex = 2;
            this.ButtonRoll.Text = "Save and Roll";
            this.ButtonRoll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonRoll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonRoll.UseVisualStyleBackColor = false;
            this.ButtonRoll.Click += new System.EventHandler(this.ButtonRoll_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(145)))), ((int)(((byte)(182)))));
            this.ButtonStop.FlatAppearance.BorderSize = 0;
            this.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStop.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonStop.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonStop.ForeColor = System.Drawing.Color.White;
            this.ButtonStop.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ButtonStop.IconColor = System.Drawing.Color.White;
            this.ButtonStop.IconSize = 30;
            this.ButtonStop.Location = new System.Drawing.Point(200, 0);
            this.ButtonStop.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Rotation = 0D;
            this.ButtonStop.Size = new System.Drawing.Size(107, 35);
            this.ButtonStop.TabIndex = 3;
            this.ButtonStop.Text = "21";
            this.ButtonStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonStop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonStop.UseVisualStyleBackColor = false;
            this.ButtonStop.Click += new System.EventHandler(this.ButonStop_Click);
            // 
            // Lvw
            // 
            this.Lvw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.Lvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Lvw.Location = new System.Drawing.Point(325, 45);
            this.Lvw.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Lvw.MultiSelect = false;
            this.Lvw.Name = "Lvw";
            this.Lvw.Size = new System.Drawing.Size(87, 148);
            this.Lvw.TabIndex = 4;
            this.Lvw.UseCompatibleStateImageBehavior = false;
            this.Lvw.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Result";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 85;
            // 
            // PlayerInfo
            // 
            this.PlayerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.PlayerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerInfo.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.PlayerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.PlayerInfo.Location = new System.Drawing.Point(412, 45);
            this.PlayerInfo.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.PlayerInfo.Name = "PlayerInfo";
            this.MainTable.SetRowSpan(this.PlayerInfo, 2);
            this.PlayerInfo.Size = new System.Drawing.Size(158, 200);
            this.PlayerInfo.TabIndex = 5;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.InfoLabel.Location = new System.Drawing.Point(328, 203);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(81, 52);
            this.InfoLabel.TabIndex = 6;
            this.InfoLabel.Text = "Info";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTable);
            this.Name = "Move";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Size = new System.Drawing.Size(580, 260);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private Header MoveHeader;
        private CustomIconButton ButtonRoll;
        private System.Windows.Forms.FlowLayoutPanel ButtonsPanel;
        private CustomIconButton ButtonStop;
        private System.Windows.Forms.ToolTip Help;
        private System.Windows.Forms.ListView Lvw;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private PlayerPanel PlayerInfo;
        private System.Windows.Forms.Label InfoLabel;
    }
}
