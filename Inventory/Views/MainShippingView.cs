using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Presenter;

namespace Inventory.Views
{
    public partial class MainShippingView : Form
    {
        private ShippmentPresenter presenter;
        public MainShippingView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimumSize = new Size(1000, 700);
            this.MaximumSize = new Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            MainShippingSKUTextBox.Multiline = true;

            presenter = new ShippmentPresenter(this);
            presenter.GetData();
        }

        public void PopulateView(DBDataObject dataObject)
        {
            dataGridView1.Rows.Clear();
            foreach (DataRow r in dataObject.data.Rows)
            {
                dataGridView1.Rows.Add(r["ItemId"].ToString(), r["Name"].ToString(), r["Quantity"].ToString(), r["DateTime"].ToString());
            }
        }

        private void MainShippingShipButton_Click(object sender, EventArgs e)
        {
            presenter.AddShipment(MainShippingSKUTextBox.Text, textBox1.Text);
        }
    }
}
