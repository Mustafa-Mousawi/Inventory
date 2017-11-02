using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxialPay.Windows.Libraries.General;
using Inventory.Views;

namespace Inventory.Presenter
{
    class StockPresenter
    {
        private MainStockView stockView;

        public StockPresenter(MainStockView stockView)
        {
            this.stockView = stockView;
        }

        public void getStockData()
        {
            string query = "select * from [Item]";
            DBDataObject ItemdataObject = Utility.ExecuteSelect(query);

            string ProductionQuery = "select A.ItemId, (select SUM(Quantity) from Shipping where ItemId=A.ItemId) As SQuantity, (select Name from Item where rowid=A.ItemId) AS Name, SUM(A.Quantity) AS PQuantity from Production A GROUP BY A.ItemId";
            DBDataObject MainDataObject = Utility.ExecuteSelect(ProductionQuery);

            stockView.PopulateGridView(MainDataObject);
        }
    }
}
