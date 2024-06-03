using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookBook.ViewModels;

namespace CookBook.CustomUserControls
{
    public partial class CustomListBox : UserControl
    {
        public CustomListBox()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<ListBoxItemVM> dataSource)
        {
            CustomLbx.DataSource = dataSource;
        }
    }
}
