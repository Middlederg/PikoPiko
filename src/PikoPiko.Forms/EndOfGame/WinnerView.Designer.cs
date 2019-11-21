namespace PikoPiko.Forms
{
    partial class WinnerView
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
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.BackButton = new PikoPiko.Forms.CustomIconButton();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flp
            // 
            this.Flp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Flp.Location = new System.Drawing.Point(20, 20);
            this.Flp.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.Flp.Name = "Flp";
            this.Flp.Padding = new System.Windows.Forms.Padding(20);
            this.Flp.Size = new System.Drawing.Size(519, 746);
            this.Flp.TabIndex = 0;
            // 
            // MainTable
            // 
            this.MainTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(145)))), ((int)(((byte)(182)))));
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.Flp, 0, 0);
            this.MainTable.Controls.Add(this.BackButton, 0, 1);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainTable.Size = new System.Drawing.Size(559, 816);
            this.MainTable.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(145)))), ((int)(((byte)(182)))));
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BackButton.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.BackButton.IconColor = System.Drawing.Color.White;
            this.BackButton.IconSize = 30;
            this.BackButton.Location = new System.Drawing.Point(20, 766);
            this.BackButton.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Rotation = 0D;
            this.BackButton.Size = new System.Drawing.Size(120, 35);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // WinnerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 816);
            this.Controls.Add(this.MainTable);
            this.Name = "WinnerView";
            this.Text = "WinnerView";
            this.MainTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flp;
        private System.Windows.Forms.TableLayoutPanel MainTable;
        private CustomIconButton BackButton;
    }
}