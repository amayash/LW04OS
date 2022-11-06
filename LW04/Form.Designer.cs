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
            this.buttonCopyFile = new System.Windows.Forms.Button();
            this.buttonCopyCatalog = new System.Windows.Forms.Button();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonDeleteCatalog = new System.Windows.Forms.Button();
            this.buttonCatalog = new System.Windows.Forms.Button();
            this.textBoxCatalog = new System.Windows.Forms.TextBox();
            this.labelCatalog = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonCopyFile);
            this.groupBox.Controls.Add(this.buttonCopyCatalog);
            this.groupBox.Controls.Add(this.buttonDeleteFile);
            this.groupBox.Controls.Add(this.buttonFile);
            this.groupBox.Controls.Add(this.textBoxFile);
            this.groupBox.Controls.Add(this.labelFile);
            this.groupBox.Controls.Add(this.buttonDeleteCatalog);
            this.groupBox.Controls.Add(this.buttonCatalog);
            this.groupBox.Controls.Add(this.textBoxCatalog);
            this.groupBox.Controls.Add(this.labelCatalog);
            this.groupBox.Controls.Add(this.treeView);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 450);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "C:/";
            // 
            // buttonCopyFile
            // 
            this.buttonCopyFile.Location = new System.Drawing.Point(7, 370);
            this.buttonCopyFile.Name = "buttonCopyFile";
            this.buttonCopyFile.Size = new System.Drawing.Size(181, 23);
            this.buttonCopyFile.TabIndex = 10;
            this.buttonCopyFile.Text = "Копировать";
            this.buttonCopyFile.UseVisualStyleBackColor = true;
            this.buttonCopyFile.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonCopyCatalog
            // 
            this.buttonCopyCatalog.Location = new System.Drawing.Point(7, 268);
            this.buttonCopyCatalog.Name = "buttonCopyCatalog";
            this.buttonCopyCatalog.Size = new System.Drawing.Size(181, 23);
            this.buttonCopyCatalog.TabIndex = 9;
            this.buttonCopyCatalog.Text = "Копировать";
            this.buttonCopyCatalog.UseVisualStyleBackColor = true;
            this.buttonCopyCatalog.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.Location = new System.Drawing.Point(7, 341);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(181, 23);
            this.buttonDeleteFile.TabIndex = 8;
            this.buttonDeleteFile.Text = "Удалить";
            this.buttonDeleteFile.UseVisualStyleBackColor = true;
            this.buttonDeleteFile.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(113, 312);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(75, 23);
            this.buttonFile.TabIndex = 7;
            this.buttonFile.Text = "Добавить";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(7, 312);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(100, 23);
            this.textBoxFile.TabIndex = 6;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(7, 294);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(36, 15);
            this.labelFile.TabIndex = 5;
            this.labelFile.Text = "Файл";
            // 
            // buttonDeleteCatalog
            // 
            this.buttonDeleteCatalog.Location = new System.Drawing.Point(7, 241);
            this.buttonDeleteCatalog.Name = "buttonDeleteCatalog";
            this.buttonDeleteCatalog.Size = new System.Drawing.Size(181, 23);
            this.buttonDeleteCatalog.TabIndex = 4;
            this.buttonDeleteCatalog.Text = "Удалить";
            this.buttonDeleteCatalog.UseVisualStyleBackColor = true;
            this.buttonDeleteCatalog.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCatalog
            // 
            this.buttonCatalog.Location = new System.Drawing.Point(113, 212);
            this.buttonCatalog.Name = "buttonCatalog";
            this.buttonCatalog.Size = new System.Drawing.Size(75, 23);
            this.buttonCatalog.TabIndex = 3;
            this.buttonCatalog.Text = "Добавить";
            this.buttonCatalog.UseVisualStyleBackColor = true;
            this.buttonCatalog.Click += new System.EventHandler(this.buttonCatalog_Click);
            // 
            // textBoxCatalog
            // 
            this.textBoxCatalog.Location = new System.Drawing.Point(7, 212);
            this.textBoxCatalog.Name = "textBoxCatalog";
            this.textBoxCatalog.Size = new System.Drawing.Size(100, 23);
            this.textBoxCatalog.TabIndex = 2;
            // 
            // labelCatalog
            // 
            this.labelCatalog.AutoSize = true;
            this.labelCatalog.Location = new System.Drawing.Point(7, 194);
            this.labelCatalog.Name = "labelCatalog";
            this.labelCatalog.Size = new System.Drawing.Size(50, 15);
            this.labelCatalog.TabIndex = 1;
            this.labelCatalog.Text = "Каталог";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView.Location = new System.Drawing.Point(3, 19);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(194, 173);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(200, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(600, 450);
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
        private Button buttonDeleteFile;
        private Button buttonFile;
        private TextBox textBoxFile;
        private Label labelFile;
        private Button buttonDeleteCatalog;
        private Button buttonCatalog;
        private TextBox textBoxCatalog;
        private Label labelCatalog;
        private TreeView treeView;
        private PictureBox pictureBox;
        private Button buttonCopyFile;
        private Button buttonCopyCatalog;
    }
}