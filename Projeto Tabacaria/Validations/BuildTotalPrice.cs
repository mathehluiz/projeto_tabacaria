

namespace Projeto_Tabacaria.Validations
{
    public class BuildTotalPrice
    {
        public string? TxtSubtotal { get; private set; }
        public string? TxtDiscount { get; private set; }


        public double SumPrice(string? txtSubtotal, string? txtdiscount)
        {
            char[] amount = { 'R', '$' };
            string outAmount = txtSubtotal.TrimStart(amount);
            string outAmountDiscount = txtdiscount.TrimStart(amount);

            if (CheckNullOrNotNumeric(outAmount) && CheckNullOrNotNumeric(txtdiscount))
            {
                double price = Convert.ToDouble(outAmount) - Convert.ToDouble(outAmountDiscount);
                return price;
            }
            else 
            {
                return -12345;
            }
        }

        public bool CheckNullOrNotNumeric(string testing)
        {
            double parsedValue;
            if (string.IsNullOrEmpty(testing))
            {
                return false;
            } else if (string.IsNullOrWhiteSpace(testing)) {
                return false;
            } else if (!double.TryParse(testing, out parsedValue))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string SumTotalValue(string? txtSubtotal, string? txtdiscount)
        {
            char[] amount = { 'R', '$' };
            string outAmount = txtSubtotal.TrimStart(amount);
            outAmount.Replace(",", ".");
            string outAmountDiscount = txtdiscount.TrimStart(amount);

            if (CheckNullOrNotNumeric(outAmount) && CheckNullOrNotNumeric(txtdiscount))
            {
                double price = Convert.ToDouble(outAmount) + Convert.ToDouble(outAmountDiscount);
                return price.ToString();
            }
            else
            {
                string error = "-12345";
                return error;
            }
        }

        public string DimTotalValue(string? txtSubtotal, string? txtdiscount)
        {
            char[] amount = { 'R', '$' };
            string outAmount = txtSubtotal.TrimStart(amount);
            outAmount.Replace(",", ".");
            string outAmountDiscount = txtdiscount.TrimStart(amount);

            if (CheckNullOrNotNumeric(outAmount) && CheckNullOrNotNumeric(txtdiscount))
            {
                double price = Convert.ToDouble(outAmount) - Convert.ToDouble(outAmountDiscount);
                return price.ToString();
            }
            else
            {
                string error = "-12345";
                return error;
            }
        }
    }
    
}
