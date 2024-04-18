namespace TotalCommanderClone
{
    partial class Form1
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
        private System.Windows.Forms.Button btnBack;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.listViewSource = new System.Windows.Forms.ListView();
            this.listViewDestination = new System.Windows.Forms.ListView();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAttributes = new System.Windows.Forms.Button();
            this.btnDiskInfo = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSource
            // 
            this.listViewSource.Location = new System.Drawing.Point(12, 12);
            this.listViewSource.Name = "listViewSource";
            this.listViewSource.Size = new System.Drawing.Size(350, 400);
            this.listViewSource.TabIndex = 0;
            this.listViewSource.UseCompatibleStateImageBehavior = false;
            this.listViewSource.DoubleClick += new System.EventHandler(this.listViewSource_DoubleClick);
            // 
            // listViewDestination
            // 
            this.listViewDestination.Location = new System.Drawing.Point(388, 12);
            this.listViewDestination.Name = "listViewDestination";
            this.listViewDestination.Size = new System.Drawing.Size(350, 400);
            this.listViewDestination.TabIndex = 1;
            this.listViewDestination.UseCompatibleStateImageBehavior = false;
            this.listViewDestination.DoubleClick += new System.EventHandler(this.listViewDestination_DoubleClick);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(12, 431);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(108, 431);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(204, 431);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 4;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Location = new System.Drawing.Point(300, 431);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(105, 23);
            this.btnCreateDirectory.TabIndex = 5;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(411, 431);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAttributes
            // 
            this.btnAttributes.Location = new System.Drawing.Point(507, 431);
            this.btnAttributes.Name = "btnAttributes";
            this.btnAttributes.Size = new System.Drawing.Size(75, 23);
            this.btnAttributes.TabIndex = 7;
            this.btnAttributes.Text = "Attributes";
            this.btnAttributes.UseVisualStyleBackColor = true;
            this.btnAttributes.Click += new System.EventHandler(this.btnAttributes_Click);
            // 
            // btnDiskInfo
            // 
            this.btnDiskInfo.Location = new System.Drawing.Point(603, 431);
            this.btnDiskInfo.Name = "btnDiskInfo";
            this.btnDiskInfo.Size = new System.Drawing.Size(75, 23);
            this.btnDiskInfo.TabIndex = 8;
            this.btnDiskInfo.Text = "Disk Info";
            this.btnDiskInfo.UseVisualStyleBackColor = true;
            this.btnDiskInfo.Click += new System.EventHandler(this.btnDiskInfo_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(699, 431);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);



            this.btnBack.Location = new System.Drawing.Point(700, 431); // Ustawiamy lokalizację przycisku
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click); // Dodajemy zdarzenie Click
            this.Controls.Add(this.btnBack); // Dodajemy przycisk do kontrolki formularza
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnDiskInfo);
            this.Controls.Add(this.btnAttributes);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.listViewDestination);
            this.Controls.Add(this.listViewSource);
            this.Name = "Form1";
            this.Text = "Total Commander Clone";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSource;
        private System.Windows.Forms.ListView listViewDestination;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAttributes;
        private System.Windows.Forms.Button btnDiskInfo;
        private System.Windows.Forms.Button btnPreview;
    }
}
