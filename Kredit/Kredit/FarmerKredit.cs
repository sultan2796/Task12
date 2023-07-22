using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kredit
{
    public class FarmerKredit : Credit
    {
        public FarmerKredit()
        {
            this.creditName = "Ehtiyac Krediti";
            this.creditType = "Endirimli destek";
            this.creditInterest = 0.55;
            this.creditPaymentMonth = 55;
        }

        public void creditDisk()
        {
            Console.WriteLine(creditLastMoney = takeCredit(creditValue) - (creditValue * (creditPaymentMonth / 100) + (creditLastMoney * creditInterest * 3.5)));
        }
    }

}
