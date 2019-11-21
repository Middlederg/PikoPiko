namespace PikoPiko.Forms
{
    partial class GameView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.Grill = new PikoPiko.Forms.RationPanel();
            this.PlayersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.Grill, 0, 0);
            this.MainTable.Controls.Add(this.PlayersPanel, 0, 1);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(1250, 1100);
            this.MainTable.TabIndex = 0;
            // 
            // Grill
            // 
            this.Grill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.Grill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grill.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.Grill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.Grill.Location = new System.Drawing.Point(20, 20);
            this.Grill.Margin = new System.Windows.Forms.Padding(20);
            this.Grill.Name = "Grill";
            this.Grill.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Grill.Size = new System.Drawing.Size(1210, 160);
            this.Grill.TabIndex = 0;
            // 
            // PlayersPanel
            // 
            this.PlayersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayersPanel.Location = new System.Drawing.Point(0, 200);
            this.PlayersPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PlayersPanel.Name = "PlayersPanel";
            this.PlayersPanel.Size = new System.Drawing.Size(1250, 900);
            this.PlayersPanel.TabIndex = 1;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 1100);
            this.Controls.Add(this.MainTable);
            this.Name = "GameView";
            this.Text = "GameView";
            this.MainTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private RationPanel Grill;
        private System.Windows.Forms.FlowLayoutPanel PlayersPanel;
    }
}