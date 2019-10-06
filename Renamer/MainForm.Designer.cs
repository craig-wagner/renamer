namespace Renamer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblFolder = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colRename = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colOldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(12, 15);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(39, 13);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "Folder:";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(57, 12);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(446, 20);
            this.txtFolder.TabIndex = 1;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(605, 12);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRename,
            this.colOldName,
            this.colNewName});
            this.dataGridView.Location = new System.Drawing.Point(15, 52);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(665, 318);
            this.dataGridView.TabIndex = 3;
            // 
            // colRename
            // 
            this.colRename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRename.DataPropertyName = "Rename";
            this.colRename.FalseValue = "false";
            this.colRename.HeaderText = "Rename?";
            this.colRename.Name = "colRename";
            this.colRename.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colRename.TrueValue = "true";
            this.colRename.Width = 80;
            // 
            // colOldName
            // 
            this.colOldName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colOldName.DataPropertyName = "OldName";
            this.colOldName.HeaderText = "Old Name";
            this.colOldName.Name = "colOldName";
            this.colOldName.ReadOnly = true;
            this.colOldName.Width = 79;
            // 
            // colNewName
            // 
            this.colNewName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNewName.DataPropertyName = "NewName";
            this.colNewName.HeaderText = "New Name";
            this.colNewName.Name = "colNewName";
            this.colNewName.ReadOnly = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Location = new System.Drawing.Point(509, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(26, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 382);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Renamer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRename;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNewName;
        private System.Windows.Forms.Button btnBrowse;
    }
}

