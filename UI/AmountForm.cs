using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class AmountForm : Form
    {
        public decimal Amount { get; set; }

        public AmountForm()
        {
            InitializeComponent();
            AmountNum.Value = 0;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Amount = Math.Abs(AmountNum.Value);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
