using AxialPay.Windows.Libraries.General;
using Inventory.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string ShipmentQuery = "select A.ItemId, (select Name from Item where rowid=A.ItemId) AS Name, A.Quantity, A.DateTime from Production A";
            DBDataObject DataObject = Utility.ExecuteSelect(ShipmentQuery);

            shippingView.PopulateView(DataObject);
        }
    }
}
