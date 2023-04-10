// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Text.Json.Serialization;
using modul8_1302210057;

class program
{
    public static void Main(string[] args)
    {

        BankTransferConfig conf = new BankTransferConfig();




        string message1 = (conf.config.lang == "en") ?

        "Please insert the amount of money to transfer:" :

        "Masukkan jumlah uang yang akan di-transfer:";




        Console.WriteLine(message1);
        int transfer = int.Parse(Console.ReadLine());
        int biaya =0;
        if (transfer <= conf.config.transfer.treshold) {
            biaya = conf.config.transfer.lowfee;

        }
        else
        {
            biaya = conf.config.transfer.threshold;

        }
        int dibayar = biaya + transfer;
        message1 = (conf.config.lang == "en") ?

        "Transfer fee = "+dibayar+" and Total amound = " +biaya +" + "+ biaya:

        "BIaya Transfer = " + dibayar + "Dan total biaya = " + transfer + "+" + biaya;




        Console.WriteLine(message1);
         message1 = (conf.config.lang == "en") ?

        "Select transfer method" :

        "Pilih metode transfer";
           Console.WriteLine(message1 );
           Console.WriteLine("1. RTO\n");
           Console.WriteLine("2. SKN\n");
           Console.WriteLine("3. RTGS\n");
           Console.WriteLine("4. BI FAST\n");
        int angka;
        Console.ReadLine(angka);

        Console.WriteLine(message1);
        message1 = (conf.config.lang == "en") ?

       "Please type registriortion" +
       " :

       "Ketik <CONFIG7> untuk mengkonfirmasi transaksi";

        Console.WriteLine(message1);

        message1 = (conf.config.lang == "en") ?

"The transfer is completed" +" :


"Proses transfer berhasil";
        Console.WriteLine(message1 );

        if (transaksi == gagal)
        {
            message1 = (conf.config.lang == "en") ?

"The transfer is cancelled" + " :


"Transfer dibatalkan";
            Console.WriteLine(message1);
        }





        Console.WriteLine(message1);


    }
}

namespace modul8_1302210057
{
    internal class BankTransferConfig
    {
        public string lang { get; set; }
        public BankTransferConfig()
        {
            try
            {
                String configString = File.ReadAllText((@"F:\c#\belajar\modul8_1302210057\modul8_1302210057\bank_transfer_config.json"));

            }
            catch ()
            {

            }
        }
        

        public static void jsonString()
        {
            

            dynamic objectConfig = SByte.Parse(configString);

            Console.WriteLine(configString);

        }
        

    }
}