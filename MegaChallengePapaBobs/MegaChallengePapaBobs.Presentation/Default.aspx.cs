using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengePapaBobs.Presentation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayTotalCost();
            
        }

        private void DisplayTotalCost()
        {
            DTO.PizzaOrder currentOrder = UpdateOrder();

            totalCostLabel.Text = string.Format("{0:C}", Domain.OrderManager.GetPizzaCost(currentOrder));

        }

        private DTO.PizzaOrder UpdateOrder()
        {
            DTO.PizzaOrder currentOrder = new DTO.PizzaOrder();

            currentOrder.OrderId = Guid.NewGuid();
            currentOrder.Size = sizeDropDownList.SelectedValue;
            currentOrder.Crust = crustDropDownList.SelectedValue;
            currentOrder.Sausage = (sausageCheckBox.Checked) ? true : false;
            currentOrder.Pepperoni = (pepperoniCheckBox.Checked) ? true : false;
            currentOrder.Onions = (onionsCheckBox.Checked) ? true : false;
            currentOrder.GreenPeppers = (greenPeppersCheckBox.Checked) ? true : false;

            currentOrder.Name = nameTextBox.Text;
            currentOrder.Address = addressTextBox.Text;
            currentOrder.ZipCode = zipCodeTextBox.Text;
            currentOrder.Phone = phoneTextBox.Text;
            currentOrder.PaymentType = (cashRadioButton.Checked) ? "Cash" : "Credit";
            currentOrder.Completed = false;

            currentOrder.TotalCost = Domain.OrderManager.GetPizzaCost(currentOrder);

            return currentOrder;

        }

        protected void placeOrderButton_Click(object sender, EventArgs e)
        {
            DTO.PizzaOrder currentOrder = UpdateOrder();
            //Validate the inputs
            string errorMessage = "";
            if(!Domain.OrderManager.ValidateInput(currentOrder, out errorMessage))
            {
                errorLabel.Text = errorMessage;
            }
            else
            {
                //Store the data
                try
                {
                    Domain.OrderManager.SaveOrder(currentOrder);
                }
                catch (Exception ex)
                {
                    errorLabel.Text = "Database connection failed - order was not saved.";
                    throw ex;
                }
                //Redirect to the success page
                Server.Transfer("OrderSuccess.aspx");

            }
            

        }
    }
}