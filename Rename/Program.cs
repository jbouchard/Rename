using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Rename
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool appdone;

            appdone = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmCtrl formCtrl = new frmCtrl();
            //Application.Run(formRename);
            while (appdone == false) 
            {
                Application.DoEvents();
            }
        }
    }

    public class frmCtrl 
    {
        public frmRename formRename; 

        public frmCtrl() 
        { 
        formRename = new frmRename();
        formRename.Show();
        //Application.Run(formRename);
        formRename.Visible = false;
        PopulateFilter();
        PopulateTreeView();
            //ListDirectory(formRename.tv(),Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)));
        formRename.Visible = true;
        }


        private void PopulateFilter()
        { 
            formRename.cbf().Items.Add("hi");
            formRename.cbf().Items.Add("mp3|rtf|txt");
        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)));
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                try
                {
                    formRename.tv().Nodes.Add(rootNode);
                }catch( Exception e){};
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                try
                {
                    subSubDirs = subDir.GetDirectories();
                    if (subSubDirs.Length != 0)
                    {
                        GetDirectories(subSubDirs, aNode);
                    }
                    nodeToAddTo.Nodes.Add(aNode);
                }
                catch (Exception e) { };
            }
        }
    }


}
