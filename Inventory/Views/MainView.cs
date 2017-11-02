using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimumSize = new Size(1000, 700);
            this.MaximumSize = new Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            MainViewTableLayout.AutoSize = true;
        }

        private void MainViewStockButton_Click(object sender, EventArgs e)
        {
            MainStockView stockView = new MainStockView();
            stockView.ShowDialog();
        }

        private void MainViewShippingButton_Click(object sender, EventArgs e)
        {
            MainShippingView shippingView = new MainShippingView();
            shippingView.ShowDialog();
        }

        private void MainViewPeoductionButton_Click(object sender, EventArgs e)
        {
            MainProductionView productionView = new MainProductionView();
            productionView.ShowDialog();
        }

        private void MainViewReportButton_Click(object sender, EventArgs e)
        {
            MainReportView reportView = new MainReportView();
            reportView.ShowDialog();
        }
    }
}
