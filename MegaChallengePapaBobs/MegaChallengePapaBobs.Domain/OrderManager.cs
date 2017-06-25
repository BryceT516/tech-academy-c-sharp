using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaChallengePapaBobs.DTO;

namespace MegaChallengePapaBobs.Domain
{
    public class OrderManager
    {
        const decimal SMALL = 12M;
        const decimal MEDIUM = 14M;
        const decimal LARGE = 16M;
        const decimal THIN = 0M;
        const decimal REGULAR = 0M;
        const decimal THICK = 2M;
        const decimal SAUSAGE = 2M;
        const decimal PEPPERONI = 1.50M;
        const decimal ONIONS = 1M;
        const decimal GREENPEPPERS = 1M;

        public static List<DTO.PizzaOrder> GetOrders()
        {
            return Persistence.DataRepository.GetOrders();
        }

        public static decimal GetPizzaCost(PizzaOrder currentOrder)
        {
            decimal totalPrice = 0M;

            totalPrice += sizePrice(currentOrder);
            totalPrice += crustPrice(currentOrder);
            totalPrice += toppingsPrice(currentOrder);


            return totalPrice;
        }

        private static decimal toppingsPrice(PizzaOrder currentOrder)
        {
            decimal returnVal = 0;
            returnVal += (currentOrder.Sausage) ? SAUSAGE : 0M;
            returnVal += (currentOrder.Pepperoni) ? PEPPERONI : 0M;
            returnVal += (currentOrder.Onions) ? ONIONS : 0M;
            returnVal += (currentOrder.GreenPeppers) ? GREENPEPPERS : 0M;

            return returnVal;

        }

        private static decimal crustPrice(PizzaOrder currentOrder)
        {
            switch (currentOrder.Crust)
            {
                case "Thin":
                    return THIN;
                case "Regular":
                    return REGULAR;
                case "Thick":
                    return THICK;
                default:
                    break;
            }

            return 0M;
        }

        public static bool ValidateInput(PizzaOrder currentOrder, out string errorMessage)
        {
            errorMessage = "";

            string nameError = "";
            bool nameIsValid = false;
            string addressError = "";
            bool addressIsValid = false;
            string zipCodeError = "";
            bool zipCodeIsValid = false;
            string phoneError = "";
            bool phoneIsValid = false;

            nameIsValid = validateName(currentOrder.Name, out nameError);
            addressIsValid = validateAddress(currentOrder.Address, out addressError);
            zipCodeIsValid = validateZipCode(currentOrder.ZipCode, out zipCodeError);
            phoneIsValid = validatePhone(currentOrder.Phone, out phoneError);

            if(!(nameIsValid && addressIsValid && zipCodeIsValid && phoneIsValid))
            {
                errorMessage = nameError + addressError + zipCodeError + phoneError;
                return false;
            }

            return true;

        }

        private static bool validatePhone(string phone, out string phoneError)
        {
            phoneError = "";
            if(phone.Trim().Length == 0)
            {
                phoneError = "Please enter a phone number.<br />";
                return false;
            }
            else if(phone.Trim().Length < 10 || phone.Trim().Length > 10)
            {
                phoneError = "Please enter a valid ten digit phone number.<br />";
                return false;
            }
            return true;
        }

        private static bool validateZipCode(string zipCode, out string zipCodeError)
        {
            zipCodeError = "";
            if(zipCode.Trim().Length == 0)
            {
                zipCodeError = "Please enter a zip code.<br />";
                return false;
            }
            else if(zipCode.Trim().Length < 5)
            {
                zipCodeError = "Please enter a five digit zip code.<br />";
                return false;
            }
            return true;
        }

        private static bool validateAddress(string address, out string addressError)
        {
            addressError = "";
            if (address.Trim().Length == 0)
            {
                addressError = "Please enter a street address.<br />";
                return false;
            }

            return true;
        }

        private static bool validateName(string name, out string nameError)
        {
            nameError = "";
            if (name.Trim().Length == 0)
            {
                nameError = "Please enter a name for the order.<br />";
                return false;
            }

            return true;
        }

        private static decimal sizePrice(PizzaOrder currentOrder)
        {
            switch (currentOrder.Size)
            {
                case "Small":
                    return SMALL;
                case "Medium":
                    return MEDIUM;
                case "Large":
                    return LARGE;
                default:
                    break;
            }

            return 0M;
        }

        public static void SaveOrder(PizzaOrder currentOrder)
        {
            //Pass the data to the persistence layer.
            try
            {
                Persistence.DataRepository.SaveOrder(currentOrder);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void MarkOrderComplete(Guid orderId)
        {
            Persistence.DataRepository.MarkOrderCompleted(orderId);
        }
    }
}
