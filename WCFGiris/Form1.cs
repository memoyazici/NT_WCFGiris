using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFGiris.ProductServiceReference;

namespace WCFGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductServiceClient client = new ProductServiceClient();
            //string str = client.DoWork();
            //MessageBox.Show(str);

            dataGrid.DataSource = client.ProductList();
        }
    }
}
