using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxialPay.Windows.Libraries.General;
using Inventory.Views;

namespace Inventory.Presenter
{
    class ReportPresenter
    {
        private MainReportView reportView;

        public ReportPresenter(MainReportView reportView)
        {
            this.reportView = reportView;
        }

        public void GetReport()
        {
            string ProductionQuery = "select SUM(Quantity) AS Quantity from Production";
            DBDataObject MainDataObject = Utility.ExecuteSelect(ProductionQuery);

            string ShipmentQuery = "select SUM(Quantity) AS Quantity from Shipping";
            DBDataObject ShipDataObject = Utility.ExecuteSelect(ShipmentQuery);
            
            reportView.PopulateData(ShipDataObject, MainDataObject);
        }
    }
}
