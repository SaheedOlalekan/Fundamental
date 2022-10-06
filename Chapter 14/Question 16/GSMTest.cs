namespace Question_16
{
    internal class GSMTest
    { internal void Create()
        {
            GSM gsm1 = new GSM();
            GSM gsm2 = new GSM("Infinix W23");
            GSM gsm3 = new GSM("Dangote Group Of Company", "iPhone 13");
            GSM gsm4 = new GSM(250000, "Ajanlekoko");
            GSM gsm5 = new GSM(5000000, "Mr Ayeole", "iPhone s");
            GSM gsm6 = new GSM("Nokia3310", "Federal Goverment Of Nigeria", "General Muhammad Bukhari", 2500);

            System.Object[] arrayOfGSM = { gsm1, gsm2, gsm3, gsm4, gsm5, gsm6 };
            for (int i = 0; i < arrayOfGSM.Length; i++)
            {
                System.Console.Write(arrayOfGSM[i].ToString());
                System.Console.WriteLine("\n");
            }
        }
    }
}
