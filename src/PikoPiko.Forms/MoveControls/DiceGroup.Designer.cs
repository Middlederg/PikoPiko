namespace PikoPiko.Forms
{
    partial class DiceGroup
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
            this.PlayButton = new PikoPiko.Forms.CustomIconButton();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.PlayButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainPanel.Location = new System.Drawing.Point(5, 5);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(315, 158);
            this.MainPanel.TabIndex = 0;
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(145)))), ((int)(((byte)(182)))));
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PlayButton.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.PlayButton.IconColor = System.Drawing.Color.White;
            this.PlayButton.IconSize = 30;
            this.PlayButton.Location = new System.Drawing.Point(125, 55);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(125, 55, 0, 0);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Rotation = 0D;
            this.PlayButton.Size = new System.Drawing.Size(80, 35);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // DiceGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "DiceGroup";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(325, 168);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private CustomIconButton PlayButton;
    }
}
