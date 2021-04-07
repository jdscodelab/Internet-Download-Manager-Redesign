using System;
using System.Collections.Generic;
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

namespace InternetDownloadManagerRedesign.CustomControl
{
    /// <summary>
    /// Interaction logic for ListBoxItemCustom.xaml
    /// </summary>
    public partial class ListBoxItemCustom : UserControl
    {
        public ListBoxItemCustom()
        {
            InitializeComponent();
        }

        public PathGeometry IconData
        {
            get { return (PathGeometry)GetValue(IconDataProperty); }
            set { SetValue(IconDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconData.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconDataProperty =
            DependencyProperty.Register("IconData", typeof(PathGeometry), typeof(ListBoxItemCustom));



        public Brush IconColor
        {
            get { return (Brush)GetValue(IconColorProperty); }
            set { SetValue(IconColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconColorProperty =
            DependencyProperty.Register("IconColor", typeof(Brush), typeof(ListBoxItemCustom));



        public string FileName
        {
            get { return (string)GetValue(FileNameProperty); }
            set { SetValue(FileNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FileName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FileNameProperty =
            DependencyProperty.Register("FileName", typeof(string), typeof(ListBoxItemCustom));



        public string Queue
        {
            get { return (string)GetValue(QueueProperty); }
            set { SetValue(QueueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Queue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty QueueProperty =
            DependencyProperty.Register("Queue", typeof(string), typeof(ListBoxItemCustom));



        public string FileSize
        {
            get { return (string)GetValue(FileSizeProperty); }
            set { SetValue(FileSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FileSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FileSizeProperty =
            DependencyProperty.Register("FileSize", typeof(string), typeof(ListBoxItemCustom));



        public string Status
        {
            get { return (string)GetValue(StatusProperty); }
            set { SetValue(StatusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Status.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StatusProperty =
            DependencyProperty.Register("Status", typeof(string), typeof(ListBoxItemCustom));



        public string LastTry
        {
            get { return (string)GetValue(LastTryProperty); }
            set { SetValue(LastTryProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LastTry.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LastTryProperty =
            DependencyProperty.Register("LastTry", typeof(string), typeof(ListBoxItemCustom));


    }
}
