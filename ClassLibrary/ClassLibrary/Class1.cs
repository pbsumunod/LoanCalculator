using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Class1
    {
        private string first, last, middle, email, type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Middle
        {
            get { return middle; }
            set { middle = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Last
        {
            get { return last; }
            set { last = value; }
        }

        public string First
        {
            get { return first; }
            set { first = value; }
        }

        private decimal tcp, downpayment, mortgage, insurance, lto, years, newdownpayment, total, amortization, month, permonth;

        public decimal Permonth
        {
            get { return permonth; }
            set { permonth = value; }
        }

        public decimal Amortization
        {
            get { return amortization; }
            set { amortization = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public decimal Newdownpayment
        {
            get { return newdownpayment; }
            set { newdownpayment = value; }
        }

        public decimal Years
        {
            get { return years; }
            set { years = value; }
        }

        public decimal Lto
        {
            get { return lto; }
            set { lto = value; }
        }

        public decimal Insurance
        {
            get { return insurance; }
            set { insurance = value; }
        }

        public decimal Mortgage
        {
            get { return mortgage; }
            set { mortgage = value; }
        }

        public decimal Downpayment
        {
            get { return downpayment; }
            set { downpayment = value; }
        }

        public decimal Tcp
        {
            get { return tcp; }
            set { tcp = value; }
        }

        public decimal ComputeTcp()
        {
            switch (type)
            {
                case "SUV":
                    tcp = 1500000.00M;
                    break;
                case "Van":
                    tcp = 890000.00M;
                    break;
                case "Sedan":
                    tcp = 680000.00M;
                    break;
            }
            tcp = tcp - (0.05M * tcp);
            return tcp;

        }
        public decimal ComputeDown()
        {
            {
                newdownpayment = downpayment / 100;
                downpayment = newdownpayment * tcp;
            }
            return downpayment;
        }
        public decimal ComputeMortgage()
        {
            {
                if (years <= 4)
                    mortgage = 35000.00M;
                else
                    mortgage = 0.00M;
            }
            return mortgage;
        }
        public decimal ComputeInsurance()
        {
            {
                if (years <= 4)
                    insurance = 30000.00M;
                else
                    insurance = 0.00M;
            }
            return insurance;
        }
        public decimal ComputeLTO()
        {
            {
                if (years <= 4)
                    lto = 8500.00M;
                else
                    lto = 00.00M;
            }
            return lto;
        }

        public decimal ComputeTotal()
        {
            {
                Total = tcp + mortgage + insurance + lto;

            }
            return Total;
        }
        public decimal ComputeMonthlyAmortization()
        {
            {
                amortization = total - downpayment;
                month = years * 12;
                Permonth = amortization / month;
            }
            return Permonth;
        }
    }
}
