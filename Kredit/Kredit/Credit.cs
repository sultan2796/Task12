using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kredit
{
    public class Credit
    {

        public string creditName { get; set; }
        public string creditType { get; set; }
        public double creditInterest { get; set; }
        public double creditPaymentMonth { get; set; }
        public double creditValue { get; set; }
        public double creditLastMoney { get; set; }

        public double takeCredit(double creditValue)
        {
            this.creditValue = creditValue;
            creditLastMoney += creditValue;
            double creditPayment = (creditLastMoney / creditPaymentMonth);
            for (int i = 0; i < creditPaymentMonth; i++)
                creditLastMoney += (creditValue * (creditInterest - (i / 1000) + (((creditPayment / 1000) * creditPaymentMonth)) / 1000) - creditPayment * 0.7);
            return creditLastMoney = Math.Round(creditLastMoney, 2);
        }

        public Credit()
        {
            this.creditName = "Ehtiyac krediti";
            this.creditType = "Standart";
            this.creditInterest = 0.45;
            this.creditPaymentMonth = 7;
        }

        public void creditInfo()
        {
            Console.WriteLine("{0}\n < Kredit Bilgileriniz > \n{1}\n-> Kredit Adi: {2}\n-> Kredit Tipi: {3}\n-> Kredit Çektiyiniz Mebleq: {4} TL\n-> Kredit Faiz : % {5}   -> Kredi Vadesi: {6} Ay\n-> Ödenecek Tutar: {7} TL\n{8}",
                creditName, creditType, creditValue, (creditInterest * 100), creditPaymentMonth);
        }
    }

}
