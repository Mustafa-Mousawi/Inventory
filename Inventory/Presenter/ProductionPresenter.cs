using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxialPay.Windows.Libraries.General;
using Inventory.Views;
using System.Data;
using System.Windows.Forms;

namespace Inventory.Presenter
{
    class ProductionPresenter
    {
        private MainProductionView productionView;

        public ProductionPresenter(MainProductionView productionView)
        {
            this.productionView = productionView;
        }

        public void GetData()
        {
            string ShipmentQuery = "select A.ItemId, (select Name from Item where rowid=A.ItemId) AS Name, A.Quantity, A.DateTime from Production A";
            DBDataObject DataObject = Utility.ExecuteSelect(ShipmentQuery);
            
            productionView.PopulateView(DataObject);
        }

        public void AddProduction(string SKU, string Quantity)
        {
            try
            {
                string ItemQuery = "select rowid from Item where SKU='" + SKU + "'";
                DBDataObject DataObject = Utility.ExecuteSelect(ItemQuery);
                string rowid = "";
                foreach (DataRow r in DataObject.data.Rows)
                {
                    rowid = r["rowid"].ToString();
                }
                //INSERT INTO table_name (column1, column2, column3, ...) VALUES (value1, value2, value3, ...);
                string query = "INSERT INTO Production (ItemId, Quantity, DateTime) VALUES ('" + rowid + "', '" + Quantity + "', '" + Utility.GetDateTimeNow() + "')";
                DBDataObject Dataobject = Utility.ExecuteInsert(query);
                GetData();
            }
            catch
            {
                MessageBox.Show("Cant Find Fields");

            }
        }
    }

}
