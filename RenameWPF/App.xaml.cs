using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using System.IO;


namespace RenameWPF
{

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        //// Register the private key to set the value
        //private static readonly DependencyPropertyKey ExpandedPropertyKey =
        //      DependencyProperty.RegisterReadOnly("Expanded",
        //      typeof(bool), typeof(App),
        //      new FrameworkPropertyMetadata(false));

        //// Register the public property to get the value
        //public static readonly DependencyProperty ExpandedProperty =
        //      ExpandedPropertyKey.DependencyProperty;    


        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Create the startup window


            MainWindow wnd = new MainWindow();
            // Do stuff here, e.g. to the window
            //wnd.Title = "Something else";
            // Show the window
            wnd.Show();
            wnd.my_app = this;

            //PopulateTreeView(wnd);

            lazyload(wnd);
        }

        private void lazyload(MainWindow wnd)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            //wnd.tv().Items.Add(CreateTreeItem(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));

            foreach (DriveInfo driveInfo in drives)
            wnd.tv().Items.Add(CreateTreeItem(driveInfo));
            

        }
        public TreeViewItem CreateTreeItem(object o)
        {
            TreeViewItem item = new TreeViewItem();
            item.Header = o.ToString();
            item.Tag = o;
            item.Items.Add("Loading...");
            return item;
        }

        public void Expanded(object sender, RoutedEventArgs e)
        {
            //Perform actions when the TreeViewItem is expanded
            TreeViewItem item = e.Source as TreeViewItem;
            if ((item.Items.Count == 1) && (item.Items[0] is string))
            {
                item.Items.Clear();

                DirectoryInfo expandedDir = null;
                if (item.Tag is DriveInfo)
                    expandedDir = (item.Tag as DriveInfo).RootDirectory;
                if (item.Tag is DirectoryInfo)
                    expandedDir = (item.Tag as DirectoryInfo);
                try
                {
                    foreach (DirectoryInfo subDir in expandedDir.GetDirectories())
                        item.Items.Add(CreateTreeItem(subDir));
                }
                catch { }
            }
        }

        private void PopulateTreeView(MainWindow wnd)
        {



            TreeViewItem rootNode;

            DirectoryInfo info = new DirectoryInfo(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)));
            if (info.Exists)
            {
                rootNode = new TreeViewItem();
                rootNode.Tag = info;
                rootNode.Header = info.Name;
                
                //rootNode.Items.Add(new Label() { Content = info.Name });
                
                GetDirectories(info.GetDirectories(), rootNode, false);
                try
                {
                    wnd.tv().Items.Add(rootNode);
                }
                catch (Exception e) { };
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs,
            TreeViewItem nodeToAddTo,
            bool AddContinuous)
        {
            TreeViewItem aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeViewItem();
                aNode.Tag = subDir;
                aNode.Header = subDir.Name;

                //if (subDir.Name.Contains("Stuff") || subDir.Name.Contains("Users"))
                //{
                //    AddContinuous = true;
                //}
                //else
                //{
                    AddContinuous = false;
                //}


                //if (subDir.Name.Contains("Stuff") || subDir.Name.Contains("Users") || AddContinuous == true)
                //{
                //    AddContinuous = true;
                    try
                    {
                        subSubDirs = subDir.GetDirectories();
                        //if (subSubDirs.Length != 0)
                        //{
                        //    GetDirectories(subSubDirs, aNode, AddContinuous);
                        //}
                        nodeToAddTo.Items.Add(aNode);
                        TreeViewItem uNode;
                        uNode = new TreeViewItem();
                        uNode.Tag = "*";
                        uNode.Header = "*";
                        aNode.Items.Add(uNode);

                    }
                    catch (Exception e) { };
                //}

            }
        }



    }
}
