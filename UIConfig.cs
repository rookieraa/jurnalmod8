using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace modul8_1302220024
{
    internal class UIConfig
    {
        public BankTransferConfig config;
        public const String filePath = @"D:\\KPL\\jurnalmod08\\bank_transfer_config.json";

        public UIConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

        private BankTransferConfig ReadConfigFile()
        {
            String bank_transfer_config_JsonData = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<BankTransferConfig>(bank_transfer_config_JsonData);
            return config;
        }

        public void SetDefault()
        {
            Transfer transfer = new Transfer(25000000, 6500, 15000);
            List<string> methods = new List<string>() { "RTO (real-time)”, “SKN”, “RTGS”, “BI FAST" };
            Confirmation confirmation = new Confirmation("yes", "ya");
            config = new BankTransferConfig("en", transfer, methods, confirmation);
        }

        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
