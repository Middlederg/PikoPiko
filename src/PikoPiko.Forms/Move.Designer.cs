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
            this.DiceGroup = new PikoPiko.Forms.DiceGroup();
            this.MoveHeader = new PikoPiko.Forms.Header();
            this.ButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonRoll = new PikoPiko.Forms.CustomIconButton();
            this.ButonStop = new PikoPiko.Forms.CustomIconButton();
            this.Help = new System.Windows.Forms.ToolTip(this.components);
            this.MainTable.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.DiceGroup, 0, 1);
            this.MainTable.Controls.Add(this.MoveHeader, 0, 0);
            this.MainTable.Controls.Add(this.ButtonsPanel, 0, 2);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 3;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(463, 252);
            this.MainTable.TabIndex = 0;
            // 
            // DiceGroup
            // 
            this.DiceGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.DiceGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiceGroup.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.DiceGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.DiceGroup.Location = new System.Drawing.Point(0, 35);
            this.DiceGroup.Margin = new System.Windows.Forms.Padding(0);
            this.DiceGroup.Name = "DiceGroup";
            this.DiceGroup.Padding = new System.Windows.Forms.Padding(5);
            this.DiceGroup.Size = new System.Drawing.Size(290, 141);
            this.DiceGroup.TabIndex = 0;
            // 
            // MoveHeader
            // 
            this.MoveHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.MainTable.SetColumnSpan(this.MoveHeader, 2);
            this.MoveHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveHeader.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.MoveHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.MoveHeader.Location = new System.Drawing.Point(0, 0);
            this.MoveHeader.Margin = new System.Windows.Forms.Padding(0);
            this.MoveHeader.Name = "MoveHeader";
            this.MoveHeader.Size = new System.Drawing.Size(463, 35);
            this.MoveHeader.TabIndex = 1;
            this.MoveHeader.Title = "Your move";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.ButtonRoll);
            this.ButtonsPanel.Controls.Add(this.ButonStop);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 186);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(290, 66);
            this.ButtonsPanel.TabIndex = 3;
            // 
            // ButtonRoll
            // 
            this.ButtonRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(76)))));
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
            this.ButtonRoll.Size = new System.Drawing.Size(107, 35);
            this.ButtonRoll.TabIndex = 2;
            this.ButtonRoll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonRoll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonRoll.UseVisualStyleBackColor = false;
            this.ButtonRoll.Click += new System.EventHandler(this.ButtonRoll_Click);
            // 
            // ButonStop
            // 
            this.ButonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(76)))));
            this.ButonStop.FlatAppearance.BorderSize = 0;
            this.ButonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonStop.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButonStop.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.ButonStop.ForeColor = System.Drawing.Color.White;
            this.ButonStop.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ButonStop.IconColor = System.Drawing.Color.White;
            this.ButonStop.IconSize = 30;
            this.ButonStop.Location = new System.Drawing.Point(127, 0);
            this.ButonStop.Margin = new System.Windows.Forms.Padding(0);
            this.ButonStop.Name = "ButonStop";
            this.ButonStop.Rotation = 0D;
            this.ButonStop.Size = new System.Drawing.Size(107, 35);
            this.ButonStop.TabIndex = 3;
            this.ButonStop.Text = "21";
            this.ButonStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButonStop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButonStop.UseVisualStyleBackColor = false;
            this.ButonStop.Click += new System.EventHandler(this.ButonStop_Click);
            // 
            // Move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTable);
            this.Name = "Move";
            this.Size = new System.Drawing.Size(463, 252);
            this.MainTable.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private DiceGroup DiceGroup;
        private Header MoveHeader;
        private CustomIconButton ButtonRoll;
        private System.Windows.Forms.FlowLayoutPanel ButtonsPanel;
        private CustomIconButton ButonStop;
        private System.Windows.Forms.ToolTip Help;
    }
}
