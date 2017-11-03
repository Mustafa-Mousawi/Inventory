using AxialPay.Windows.Libraries.General;
using Inventory.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Presenter
{
    
    class ShippmentPresenter
    {
        private MainShippingView shippingView;

        public ShippmentPresenter(MainShippingView shippingView)
        {
            this.shippingView = shippingView;
        }

        public void GetData()
        {
            string ShipmentQuery = "select A.ItemId, (select Name from Item where rowid=A.ItemId) AS Name, A.Quantity, A.DateTime from Shipping A";
            DBDataObject DataObject = Utility.ExecuteSelect(ShipmentQuery);

            shippingView.PopulateView(DataObject);
        }

        public void AddShipment(string SKU, string Quantity)
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
                string query = "INSERT INTO Shipping (ItemId, Quantity, DateTime) VALUES ('" + rowid + "', '" + Quantity + "', '" + Utility.GetDateTimeNow() + "')";
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
