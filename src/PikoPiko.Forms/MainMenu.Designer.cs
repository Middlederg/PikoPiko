namespace PikoPiko.Forms
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.ExitButton = new PikoPiko.Forms.CustomIconButton();
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayersListBox = new System.Windows.Forms.ListBox();
            this.PlayButton = new PikoPiko.Forms.CustomIconButton();
            this.MainTitle = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddPlayer = new FontAwesome.Sharp.IconMenuItem();
            this.EditName = new FontAwesome.Sharp.IconMenuItem();
            this.RemovePlayer = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainTable.SuspendLayout();
            this.Flp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTitle)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(145)))), ((int)(((byte)(182)))));
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.ExitButton, 0, 2);
            this.MainTable.Controls.Add(this.Flp, 0, 1);
            this.MainTable.Controls.Add(this.MainTitle, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 3;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainTable.Size = new System.Drawing.Size(319, 450);
            this.MainTable.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(145)))), ((int)(((byte)(182)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ExitButton.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.IconSize = 30;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(184, 400);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Rotation = 0D;
            this.ExitButton.Size = new System.Drawing.Size(115, 35);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Flp
            // 
            this.Flp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Flp.Controls.Add(this.PlayersListBox);
            this.Flp.Controls.Add(this.PlayButton);
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Flp.Location = new System.Drawing.Point(20, 180);
            this.Flp.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.Flp.Name = "Flp";
            this.Flp.Padding = new System.Windows.Forms.Padding(20);
            this.Flp.Size = new System.Drawing.Size(279, 220);
            this.Flp.TabIndex = 0;
            // 
            // PlayersListBox
            // 
            this.PlayersListBox.FormattingEnabled = true;
            this.PlayersListBox.ItemHeight = 18;
            this.PlayersListBox.Location = new System.Drawing.Point(20, 20);
            this.PlayersListBox.Margin = new System.Windows.Forms.Padding(0);
            this.PlayersListBox.Name = "PlayersListBox";
            this.PlayersListBox.Size = new System.Drawing.Size(238, 130);
            this.PlayersListBox.TabIndex = 2;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(145)))), ((int)(((byte)(182)))));
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PlayButton.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.PlayButton.IconColor = System.Drawing.Color.White;
            this.PlayButton.IconSize = 30;
            this.PlayButton.Location = new System.Drawing.Point(20, 160);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Rotation = 0D;
            this.PlayButton.Size = new System.Drawing.Size(238, 39);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // MainTitle
            // 
            this.MainTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTitle.Location = new System.Drawing.Point(20, 20);
            this.MainTitle.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(279, 140);
            this.MainTitle.TabIndex = 1;
            this.MainTitle.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPlayer,
            this.EditName,
            this.toolStripSeparator1,
            this.RemovePlayer});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(181, 98);
            // 
            // AddPlayer
            // 
            this.AddPlayer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddPlayer.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddPlayer.IconColor = System.Drawing.Color.Black;
            this.AddPlayer.IconSize = 16;
            this.AddPlayer.Name = "AddPlayer";
            this.AddPlayer.Rotation = 0D;
            this.AddPlayer.Size = new System.Drawing.Size(180, 22);
            this.AddPlayer.Text = "Add player";
            this.AddPlayer.Click += new System.EventHandler(this.AddPlayer_Click);
            // 
            // EditName
            // 
            this.EditName.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EditName.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditName.IconColor = System.Drawing.Color.Black;
            this.EditName.IconSize = 16;
            this.EditName.Name = "EditName";
            this.EditName.Rotation = 0D;
            this.EditName.Size = new System.Drawing.Size(180, 22);
            this.EditName.Text = "Edit player name";
            this.EditName.Click += new System.EventHandler(this.EditName_Click);
            // 
            // RemovePlayer
            // 
            this.RemovePlayer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RemovePlayer.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.RemovePlayer.IconColor = System.Drawing.Color.Black;
            this.RemovePlayer.IconSize = 16;
            this.RemovePlayer.Name = "RemovePlayer";
            this.RemovePlayer.Rotation = 0D;
            this.RemovePlayer.Size = new System.Drawing.Size(180, 22);
            this.RemovePlayer.Text = "Remove player";
            this.RemovePlayer.Click += new System.EventHandler(this.RemovePlayer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.MainTable);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.MainTable.ResumeLayout(false);
            this.Flp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainTitle)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private CustomIconButton PlayButton;
        private System.Windows.Forms.FlowLayoutPanel Flp;
        private System.Windows.Forms.PictureBox MainTitle;
        private CustomIconButton ExitButton;
        private System.Windows.Forms.ListBox PlayersListBox;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private FontAwesome.Sharp.IconMenuItem AddPlayer;
        private FontAwesome.Sharp.IconMenuItem EditName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconMenuItem RemovePlayer;
    }
}