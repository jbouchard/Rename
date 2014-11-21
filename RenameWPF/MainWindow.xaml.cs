using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using RenameWPF;
using System.ComponentModel;
using System.Dynamic;

namespace RenameWPF
{
    //public partial class cTreeView : TreeView
    //{
    //    private string strfullPath;
    //    public string fullPath
    //    {
    //        get
    //        {
    //            return strfullPath;
    //        }
    //        set
    //        {
    //            strfullPath = value;
    //        }
    //    }
    //}

    //public partial class cTreeViewItem : TreeViewItem
    //{
    //    private string strfullPath;
    //    public string fullPath
    //    {
    //        get
    //        {
    //            return strfullPath;
    //        }
    //        set
    //        {
    //            strfullPath = value;
    //        }
    //    }
    //}


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public App my_app;
        private ObservableCollection<gvItem> _files = new ObservableCollection<gvItem>();
        //public static readonly DependencyProperty FontWeight = DependencyProperty.Register("FontWeight", typeof(string), typeof(MainWindow), new PropertyMetadata("Bold"));
        public Style dgColStyle = new Style();
        //private IList<gvItem> _files2 = new IList<gvItem>();
        public class gvItem 
        {
            //public gvItem()
            //{ 
            // var propertyDescriptor = new List<PropertyDescriptor>
             
            //}
            public string fname {set; get;}
            public string ext { set; get; }
            public DateTime lastmodified { set; get; }
            public string newfname { set; get; }
            public string newext { set; get; }
            public string resfname { set; get; }
        }

        public MainWindow()
        {
            InitializeComponent();

            dgColStyle.Setters.Add(new Setter(System.Windows.Controls.Control.FontWeightProperty, "Bold"));

            //dgColStyle.Setters.Add(new Setter(new DependencyProperty(),
        }

        public TreeView tv()
        {
            return this.tvFolders;
        }

        public void tvClick(object sender, RoutedEvent e)
        { }


        public void Expanded(object sender, RoutedEventArgs e)
        {
            //Perform actions when the TreeViewItem is expanded
            TreeViewItem item = e.Source as TreeViewItem;
            if ((item.Items[0] is string))
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
                    {
                        try
                        {
                            item.Items.Add(my_app.CreateTreeItem(subDir));
                        }
                        catch { }

                    }
                }
                catch { }
            }
        }

        //private void tvFolders_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        //{
        //    //System.Diagnostics.Debug.Print ( e.ToString());

        //    var tree = sender as TreeView;

        //    // ... Determine type of SelectedItem.
        //    if (tree.SelectedItem is TreeViewItem)
        //    {
        //        // ... Handle a TreeViewItem.
        //        var item = tree.SelectedItem as TreeViewItem;
        //        System.Diagnostics.Debug.Print("Selected header: " + item.Header.ToString());
        //    }
        //    else if (tree.SelectedItem is string)
        //    {
        //        // ... Handle a string.
        //        System.Diagnostics.Debug.Print ("Selected: " + tree.SelectedItem.ToString());
        //    }


        //    TreeView tree = (TreeView)sender;
        //    TreeViewItem temp = ((TreeViewItem)tree.SelectedItem);

        //    if (temp == null)
        //        return;

        //    SelectedItemFullPath = "";
        //}


        public string SelectedItemFullPath { get; set; }

        private void tvFolders_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeView tree = (TreeView)sender;
            TreeViewItem temp = ((TreeViewItem)tree.SelectedItem);

            if (temp == null)
                return;

            SelectedItemFullPath = "";
            string temp1 = "";
            string temp2 = "";

            while (true)
            {
                temp1 = temp.Header.ToString();
                if (temp1.Contains(@"\"))
                {
                    temp2 = "";
                }

                SelectedItemFullPath = temp1 + temp2 + SelectedItemFullPath;

                if (temp.Parent.GetType().Equals(typeof(TreeView)))
                {
                    break;
                }

                temp = ((TreeViewItem)temp.Parent);
                temp2 = @"\";
            }

            //now show user the full selected path
            MessageBox.Show(SelectedItemFullPath);
            load_files(SelectedItemFullPath);
        }

        public void load_Columns()
        {



            dgFiles.Columns.Clear();


                        dgFiles.AutoGenerateColumns = false;
            dgFiles.Columns.Clear();
            


            for (int i = 1; i <= 6; ++i)
            {
                var column = new DataGridTextColumn();
                //var col1 = new DataGridColumn();
                

                switch (i)
                {
                    case 1:
                        column.Header = "Name";
                        column.Binding = new Binding(column.Header.ToString());
                        //column.FontStyle = new 
                        dgFiles.Columns.Add(column);
                        break;
                    case 2:
                        column.Header = "Ext";
                        column.Binding = new Binding(column.Header.ToString());
                        dgFiles.Columns.Add(column);
                        break;
                    case 3:
                        column.Header = "Last Modified";
                        column.Binding = new Binding(column.Header.ToString());
                        dgFiles.Columns.Add(column);
                        break;
                    case 4:
                        column.Header = "New Name";
                        column.Binding = new Binding(column.Header.ToString());
                        dgFiles.Columns.Add(column);
                        break;
                    case 5:
                        column.Header = "New Ext";
                        column.Binding = new Binding(column.Header.ToString());
                        dgFiles.Columns.Add(column);
                        break;
                    case 6:
                        column.Header = "Result Name";
                        column.Binding = new Binding(column.Header.ToString());
                        dgFiles.Columns.Add(column);
                        break;


                    default:
                        break;
                }
            }

        }

        public void load_files(string dir)
        {

            dgFiles.DataContext = null;
            _files.Clear();
            //dgFiles.Items.Clear();
            dgFiles.Items.Refresh();
            //load_Columns();


            //FileInfo fclass;
            DirectoryInfo dirInfo = new DirectoryInfo(dir);
            //List<gvItem> files = new List<gvItem>();
            FileInfo[] info = dirInfo.GetFiles("*.*");
            foreach (FileInfo f in info)
            {
                System.Diagnostics.Debug.Print(f.Name);
                gvItem cfile = new gvItem();

                cfile.fname = f.Name.ToString();
                cfile.ext = f.Extension.ToString();
                cfile.lastmodified = f.LastWriteTime;
                cfile.newfname = f.Name.ToString();
                cfile.newext = f.Extension.ToString();
                cfile.resfname = cfile.newfname + "." + cfile.newext;
                _files.Add(cfile);
                //.Add(cfile);

                //dgFiles.Items.Add(new DataGridRow());
                //fclass = new FileInfo();
                //fclass.Name = f.Name;
                //fclass.length = Convert.ToUInt32(f.Length);
                //fclass.DirectoryName = f.DirectoryName;
                //fclass.FullName = f.FullName;
                //fclass.Extension = f.Extension;
                //obcinfo.Add(fclass);
            }

            //dgFiles.ItemsSource = files;
            //dgFiles.DataContext = _files;
            dgFiles.DataContext = _files;
            

        }




    }
}
