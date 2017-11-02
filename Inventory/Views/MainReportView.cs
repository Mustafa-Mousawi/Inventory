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
    public partial class MainReportView : Form
    {
        ReportPresenter presenter;
        public MainReportView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimumSize = new Size(1000, 700);
            this.MaximumSize = new Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            presenter = new ReportPresenter(this);
            presenter.GetReport();
        }

        public void PopulateData(DBDataObject Shipping, DBDataObject Production)
        {
            decimal ShippingTotal = 0;
            decimal ProductionTotal = 0;

            foreach (DataRow r in Shipping.data.Rows)
            {
                ShippingTotal += Decimal.Parse(r["Quantity"].ToString());
            }

            foreach (DataRow r in Production.data.Rows)
            {
                ProductionTotal += Decimal.Parse(r["Quantity"].ToString());
            }

            label4.Text = ProductionTotal.ToString();
            label5.Text = ShippingTotal.ToString();
            label6.Text = (ProductionTotal - ShippingTotal).ToString();
        }
    }
}
