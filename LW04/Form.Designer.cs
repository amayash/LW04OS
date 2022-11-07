namespace LW04
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelCatalog = new System.Windows.Forms.Label();
            this.buttonCopyFile = new System.Windows.Forms.Button();
            this.textBoxCatalog = new System.Windows.Forms.TextBox();
            this.buttonCopyCatalog = new System.Windows.Forms.Button();
            this.buttonCatalog = new System.Windows.Forms.Button();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.buttonDeleteCatalog = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelCatalog);
            this.groupBox.Controls.Add(this.buttonCopyFile);
            this.groupBox.Controls.Add(this.textBoxCatalog);
            this.groupBox.Controls.Add(this.buttonCopyCatalog);
            this.groupBox.Controls.Add(this.buttonCatalog);
            this.groupBox.Controls.Add(this.buttonDeleteFile);
            this.groupBox.Controls.Add(this.buttonDeleteCatalog);
            this.groupBox.Controls.Add(this.buttonFile);
            this.groupBox.Controls.Add(this.labelFile);
            this.groupBox.Controls.Add(this.textBoxFile);
            this.groupBox.Controls.Add(this.treeView);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(258, 450);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "C:/";
            // 
            // labelCatalog
            // 
            this.labelCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCatalog.AutoSize = true;
            this.labelCatalog.Location = new System.Drawing.Point(12, 245);
            this.labelCatalog.Name = "labelCatalog";
            this.labelCatalog.Size = new System.Drawing.Size(50, 15);
            this.labelCatalog.TabIndex = 11;
            this.labelCatalog.Text = "Каталог";
            // 
            // buttonCopyFile
            // 
            this.buttonCopyFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCopyFile.Location = new System.Drawing.Point(12, 421);
            this.buttonCopyFile.Name = "buttonCopyFile";
            this.buttonCopyFile.Size = new System.Drawing.Size(240, 23);
            this.buttonCopyFile.TabIndex = 20;
            this.buttonCopyFile.Text = "Копировать";
            this.buttonCopyFile.UseVisualStyleBackColor = true;
            this.buttonCopyFile.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // textBoxCatalog
            // 
            this.textBoxCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCatalog.Location = new System.Drawing.Point(12, 263);
            this.textBoxCatalog.Name = "textBoxCatalog";
            this.textBoxCatalog.Size = new System.Drawing.Size(159, 23);
            this.textBoxCatalog.TabIndex = 12;
            // 
            // buttonCopyCatalog
            // 
            this.buttonCopyCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCopyCatalog.Location = new System.Drawing.Point(12, 319);
            this.buttonCopyCatalog.Name = "buttonCopyCatalog";
            this.buttonCopyCatalog.Size = new System.Drawing.Size(240, 23);
            this.buttonCopyCatalog.TabIndex = 19;
            this.buttonCopyCatalog.Text = "Копировать";
            this.buttonCopyCatalog.UseVisualStyleBackColor = true;
            this.buttonCopyCatalog.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonCatalog
            // 
            this.buttonCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCatalog.Location = new System.Drawing.Point(177, 263);
            this.buttonCatalog.Name = "buttonCatalog";
            this.buttonCatalog.Size = new System.Drawing.Size(75, 23);
            this.buttonCatalog.TabIndex = 13;
            this.buttonCatalog.Text = "Добавить";
            this.buttonCatalog.UseVisualStyleBackColor = true;
            this.buttonCatalog.Click += new System.EventHandler(this.buttonCatalog_Click);
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteFile.Location = new System.Drawing.Point(12, 392);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(240, 23);
            this.buttonDeleteFile.TabIndex = 18;
            this.buttonDeleteFile.Text = "Удалить";
            this.buttonDeleteFile.UseVisualStyleBackColor = true;
            this.buttonDeleteFile.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDeleteCatalog
            // 
            this.buttonDeleteCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteCatalog.Location = new System.Drawing.Point(12, 292);
            this.buttonDeleteCatalog.Name = "buttonDeleteCatalog";
            this.buttonDeleteCatalog.Size = new System.Drawing.Size(240, 23);
            this.buttonDeleteCatalog.TabIndex = 14;
            this.buttonDeleteCatalog.Text = "Удалить";
            this.buttonDeleteCatalog.UseVisualStyleBackColor = true;
            this.buttonDeleteCatalog.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFile.Location = new System.Drawing.Point(177, 363);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(75, 23);
            this.buttonFile.TabIndex = 17;
            this.buttonFile.Text = "Добавить";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // labelFile
            // 
            this.labelFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(12, 345);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(36, 15);
            this.labelFile.TabIndex = 15;
            this.labelFile.Text = "Файл";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFile.Location = new System.Drawing.Point(12, 363);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(159, 23);
            this.textBoxFile.TabIndex = 16;
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView.Location = new System.Drawing.Point(3, 19);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(252, 224);
            this.treeView.TabIndex = 0;
            this.treeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);
            this.treeView.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(258, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(542, 450);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox);
            this.Name = "Form";
            this.Text = "File system";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox;
        private TreeView treeView;
        private PictureBox pictureBox;
        private Label labelCatalog;
        private Button buttonCopyFile;
        private TextBox textBoxCatalog;
        private Button buttonCopyCatalog;
        private Button buttonCatalog;
        private Button buttonDeleteFile;
        private Button buttonDeleteCatalog;
        private Button buttonFile;
        private Label labelFile;
        private TextBox textBoxFile;
    }
}