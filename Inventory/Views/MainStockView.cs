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
    public partial class MainStockView : Form
    {
        private StockPresenter presenter;
        public MainStockView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimumSize = new Size(1000, 700);
            this.MaximumSize = new Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            //MainStockdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            presenter = new StockPresenter(this);
            presenter.getStockData();
        }

        public void PopulateGridView(DBDataObject dataObject)
        {
            foreach (DataRow r in dataObject.data.Rows)
            {
                string SQuantity = r["PQuantity"].ToString();
                string PQuantity = r["SQuantity"].ToString(); ;
                if (r["PQuantity"] == null || r["PQuantity"].ToString() == "")
                {
                    SQuantity = "0";
                }
                if (r["SQuantity"] == null || r["SQuantity"].ToString() == "")
                {
                    PQuantity = "0";
                }
                Decimal Instock = Decimal.Parse(SQuantity) - Decimal.Parse(PQuantity);
                MainStockdataGridView.Rows.Add(r["ItemId"].ToString(), r["Name"].ToString(), Instock);
            }
        }
    }
}
