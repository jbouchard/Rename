using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rename
{
    public partial class frmRename : Form
    {
        public frmRename()
        {
            InitializeComponent();
        }

        private void frmRename_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tvFolders_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            TreeNode newSelected = e.Node;
            listView1.Items.Clear();

            dgvFiles.Rows.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            


            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"), 
                     new ListViewItem.ListViewSubItem(item, 
						dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);

                dgvFiles.Rows.Add();
                dgvFiles.Rows[dgvFiles.RowCount - 1].Cells[0].Value = dir.Name;
                dgvFiles.Rows[dgvFiles.RowCount - 1].Cells[1].Value = "dir";                
                dgvFiles.Rows[dgvFiles.RowCount - 1].Cells[2].Value = dir.LastAccessTime.ToShortDateString();
                //dgvFiles.Rows[dgvFiles.RowCount].Cells[2].Value = dir.Name;
                dgvFiles.Rows[dgvFiles.RowCount - 1].Cells[dgvFiles.ColumnCount - 1].Value = dir.Name;

            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"), 
                     new ListViewItem.ListViewSubItem(item, 
						file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);

                dgvFiles.Rows.Add();
                dgvFiles.Rows[dgvFiles.RowCount - 1].Cells[0].Value = file.Name;
                dgvFiles.Rows[dgvFiles.RowCount - 1].Cells[1].Value = file.Extension.ToString();                
                dgvFiles.Rows[dgvFiles.RowCount - 1].Cells[2].Value = file.LastAccessTime.ToShortDateString();
                dgvFiles.Rows[dgvFiles.RowCount - 1].Cells[dgvFiles.ColumnCount - 1].Value = file.Name;


            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void dgvFiles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}
