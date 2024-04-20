using System.Collections.Generic;
using System.Numerics;
using modul8_1302220024;

internal class Program
{
    private static void Main(String[] args)
    {
        int biaya_tf = 0;
        int nominal_tf = 0;
        UIConfig uiConfig = new UIConfig();
        if (UIConfig.config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer:");
            Console.WriteLine("Transfer fee = " , "<biaya_tf>", " and Total amount = " , "<nominal_tf + biaya_tf>");
        } else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer");
            Console.WriteLine("Biaya transfer = ", "<biaya_tf>", " dan total biaya = ", "<nominal_tf + biaya_tf>");
        }
    }
}