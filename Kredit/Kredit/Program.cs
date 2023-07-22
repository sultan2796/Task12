using Kredit;
static void Main(string[] args)
{

    Credit manager = new Credit();
    manager.creditInfo();
    manager.takeCredit(7000);
    
    FarmerKredit mang = new FarmerKredit();
    mang.takeCredit(6789);
    mang.creditDisk();
    mang.creditInfo();
}