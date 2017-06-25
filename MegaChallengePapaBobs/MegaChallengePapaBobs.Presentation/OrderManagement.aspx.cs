using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengePapaBobs.Presentation
{
    public partial class OrderManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayOrders();
        }

        private void DisplayOrders()
        {
            ordersGridView.DataSource = Domain.OrderManager.GetOrders();
            ordersGridView.DataBind();

            for (int i = 0; i < ordersGridView.Columns.Count; i++)
            {
                
            } 
        }

        protected void ordersGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Retrieve the ROW CLICKED in the grid
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = ordersGridView.Rows[index];

            var orderId = Guid.Parse( row.Cells[1].Text);
            Domain.OrderManager.MarkOrderComplete(orderId);

            DisplayOrders();
        }

        protected void ordersGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ordersGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }
    }
}