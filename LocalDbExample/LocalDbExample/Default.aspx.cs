using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocalDbExample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            ACMEEntities db = new ACMEEntities();

            var customers = db.Customers;

            string result = "";

            foreach (var customer in customers)
            {
                result += "<p>" + customer.Name + "</p>";
            }
            */

            //resultLabel.Text = result;

            displayCustomers();
        }

        protected void customersGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void customersGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //e.CommandArgument

            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = customersGridView.Rows[index];

            var name = row.Cells[2].Text;
            var city = row.Cells[4].Text;
            var state = row.Cells[5].Text;

            resultLabel.Text = string.Format("{0}, {1}, {2}", name, city, state);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var newCustomer = new DTO.Customer();

            newCustomer.CustomerId = Guid.NewGuid();
            newCustomer.Name = nameTextBox.Text;
            newCustomer.Address = addressTextBox.Text;
            newCustomer.City = cityTextBox.Text;
            newCustomer.State = stateTextBox.Text;
            newCustomer.PostalCode = postalCodeTextBox.Text;
            newCustomer.Notes = notesTextBox.Text;

            try
            {
                Domain.CustomerManager.AddCustomer(newCustomer);

                nameTextBox.Text = "";
                addressTextBox.Text = "";
                cityTextBox.Text = "";
                stateTextBox.Text = "";
                postalCodeTextBox.Text = "";
                notesTextBox.Text = "";
            }
            catch (Exception ex)
            {
                resultLabel.Text = ex.Message;
            }

            displayCustomers();
        }


        private void displayCustomers()
        {
            var customers = Domain.CustomerManager.GetCustomers();

            customersGridView.DataSource = customers.ToList();
            customersGridView.DataBind();
        }

    }
}