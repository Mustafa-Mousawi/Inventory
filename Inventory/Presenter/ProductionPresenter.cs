using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxialPay.Windows.Libraries.General;
using Inventory.Views;

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
            string ShipmentQuery = "select A.ItemId, (select Name from Item where rowid=A.ItemId) AS Name, A.Quantity, A.DateTime from Shipping A";
            DBDataObject DataObject = Utility.ExecuteSelect(ShipmentQuery);
            
            productionView.PopulateView(DataObject);
        }
    }

}
