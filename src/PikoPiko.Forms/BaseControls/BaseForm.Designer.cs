namespace PikoPiko.Forms
{
    partial class BaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.move1 = new PikoPiko.Forms.Move();
            this.customIconButton1 = new PikoPiko.Forms.CustomIconButton();
            this.customButton1 = new PikoPiko.Forms.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // move1
            // 
            this.move1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.move1.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.move1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.move1.Location = new System.Drawing.Point(52, 287);
            this.move1.Margin = new System.Windows.Forms.Padding(0);
            this.move1.Minimun = 0;
            this.move1.Name = "move1";
            this.move1.Size = new System.Drawing.Size(596, 252);
            this.move1.TabIndex = 4;
            // 
            // customIconButton1
            // 
            this.customIconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(76)))));
            this.customIconButton1.FlatAppearance.BorderSize = 0;
            this.customIconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customIconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.customIconButton1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.customIconButton1.ForeColor = System.Drawing.Color.White;
            this.customIconButton1.IconChar = FontAwesome.Sharp.IconChar.GlassMartini;
            this.customIconButton1.IconColor = System.Drawing.Color.White;
            this.customIconButton1.IconSize = 30;
            this.customIconButton1.Location = new System.Drawing.Point(551, 216);
            this.customIconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.customIconButton1.Name = "customIconButton1";
            this.customIconButton1.Rotation = 0D;
            this.customIconButton1.Size = new System.Drawing.Size(256, 35);
            this.customIconButton1.TabIndex = 3;
            this.customIconButton1.Text = "customIconButton1";
            this.customIconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customIconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customIconButton1.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(76)))));
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(551, 147);
            this.customButton1.Margin = new System.Windows.Forms.Padding(0);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(256, 35);
            this.customButton1.TabIndex = 2;
            this.customButton1.Text = "customButton1";
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(933, 622);
            this.Controls.Add(this.move1);
            this.Controls.Add(this.customIconButton1);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CustomButton customButton1;
        private CustomIconButton customIconButton1;
        private Move move1;
    }
}