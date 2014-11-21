namespace Rename
{
    partial class frmRename
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvFolders = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.fName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileExt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileLastModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewExt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtApp = new System.Windows.Forms.TextBox();
            this.txtRem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdRen = new System.Windows.Forms.Button();
            this.cmdM3u = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 381);
            this.panel1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvFiles);
            this.splitContainer2.Size = new System.Drawing.Size(1492, 381);
            this.splitContainer2.SplitterDistance = 777;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvFolders);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(777, 381);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.TabIndex = 3;
            // 
            // tvFolders
            // 
            this.tvFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFolders.Location = new System.Drawing.Point(0, 0);
            this.tvFolders.Name = "tvFolders";
            this.tvFolders.Size = new System.Drawing.Size(354, 381);
            this.tvFolders.TabIndex = 4;
            this.tvFolders.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFolders_NodeMouseClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fName,
            this.Type,
            this.LastModified});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(419, 381);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // fName
            // 
            this.fName.Text = "Name";
            this.fName.Width = 122;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 153;
            // 
            // LastModified
            // 
            this.LastModified.Text = "LastModified";
            this.LastModified.Width = 153;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.fileExt,
            this.fileLastModified,
            this.NewName,
            this.NewExt,
            this.ResultName});
            this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiles.Location = new System.Drawing.Point(0, 0);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.Size = new System.Drawing.Size(711, 381);
            this.dgvFiles.TabIndex = 4;
            this.dgvFiles.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellValueChanged);
            // 
            // fileName
            // 
            this.fileName.HeaderText = "Name";
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            // 
            // fileExt
            // 
            this.fileExt.HeaderText = "Ext";
            this.fileExt.Name = "fileExt";
            this.fileExt.ReadOnly = true;
            // 
            // fileLastModified
            // 
            this.fileLastModified.HeaderText = "Last Modified";
            this.fileLastModified.Name = "fileLastModified";
            this.fileLastModified.ReadOnly = true;
            // 
            // NewName
            // 
            this.NewName.HeaderText = "New Name";
            this.NewName.Name = "NewName";
            // 
            // NewExt
            // 
            this.NewExt.HeaderText = "New Ext";
            this.NewExt.Name = "NewExt";
            // 
            // ResultName
            // 
            this.ResultName.HeaderText = "Result Name";
            this.ResultName.Name = "ResultName";
            // 
            // cboFilter
            // 
            this.cboFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Location = new System.Drawing.Point(0, 412);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(271, 28);
            this.cboFilter.TabIndex = 5;
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(396, 417);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(180, 20);
            this.txtPre.TabIndex = 6;
            // 
            // txtApp
            // 
            this.txtApp.Location = new System.Drawing.Point(660, 417);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(180, 20);
            this.txtApp.TabIndex = 7;
            // 
            // txtRem
            // 
            this.txtRem.Location = new System.Drawing.Point(916, 417);
            this.txtRem.Name = "txtRem";
            this.txtRem.Size = new System.Drawing.Size(179, 20);
            this.txtRem.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prepend";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Append";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(863, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remove";
            // 
            // cmdRen
            // 
            this.cmdRen.Location = new System.Drawing.Point(381, 497);
            this.cmdRen.Name = "cmdRen";
            this.cmdRen.Size = new System.Drawing.Size(75, 23);
            this.cmdRen.TabIndex = 12;
            this.cmdRen.Text = "Rename";
            this.cmdRen.UseVisualStyleBackColor = true;
            // 
            // cmdM3u
            // 
            this.cmdM3u.Location = new System.Drawing.Point(67, 497);
            this.cmdM3u.Name = "cmdM3u";
            this.cmdM3u.Size = new System.Drawing.Size(86, 23);
            this.cmdM3u.TabIndex = 13;
            this.cmdM3u.Text = "Generate M3U";
            this.cmdM3u.UseVisualStyleBackColor = true;
            // 
            // frmRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 607);
            this.Controls.Add(this.cmdM3u);
            this.Controls.Add(this.cmdRen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRem);
            this.Controls.Add(this.txtApp);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.panel1);
            this.Name = "frmRename";
            this.Text = "Rename";
            this.Load += new System.EventHandler(this.frmRename_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        public System.Windows.Forms.TreeView tv() 
        {
            return tvFolders;
        }

        public System.Windows.Forms.ListView lv()
        {
            return listView1;
        }

        public System.Windows.Forms.ComboBox cbf(){
            return cboFilter;
        }

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvFolders;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader fName;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader LastModified;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileExt;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileLastModified;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewExt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultName;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.TextBox txtApp;
        private System.Windows.Forms.TextBox txtRem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdRen;
        private System.Windows.Forms.Button cmdM3u;
    }
}

