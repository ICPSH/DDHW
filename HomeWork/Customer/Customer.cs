
namespace HomeWork
{
    class Customer : IConvertToFile
    {
        public Customer(string Name, string PhoneNumer, string PassportData)
        {

            NameInfo = Name;
            PhoneNumberInfo = PhoneNumer;
            PassportDataInfo = PassportData;
        }

        public string NameInfo { get; set; }
        public string PhoneNumberInfo { get; set; }
        public string PassportDataInfo { get; set; }

        public string ToConsoleString()
        {
            return 
                $"Имя:{NameInfo}\n" +
                $"Номер телефона:{PhoneNumberInfo}\n" +
                $"Серия и номер паспорта:{PassportDataInfo}"; ;
        }

        public string ToFileString()
        {
            return string.Join(';', NameInfo, PhoneNumberInfo, PassportDataInfo);
        }

    }
}
