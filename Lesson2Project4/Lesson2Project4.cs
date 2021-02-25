using System;

namespace Lesson2Project4
{
    class Lesson2Project4
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            string company = "Компания";
            long index = 614015;
            int home = 25;
            string address = $"{index}, Пермский край, г. Пермь, ул. Ленина {home}";
            long inn = 5902034504;
            string shopList = "Конфеты \"Алёнка\"";
            double sumShop = 150;
            double nds = 0.2;
            double sumGet = 200;


            Console.WriteLine
($@"
    КАССОВЫЙ ЧЕК
    ООО {company}
    ИНН {inn}
Место расчётов: {address};

Наименования:
{shopList}
Товар:
1*{sumShop} ={sumShop, 10}
НДС {nds,2:p1}{sumShop*nds, 8}
ИТОГ{sumShop, 13}

НАЛИЧНЫМИ{sumGet, 8}
СДАЧА{sumGet-sumShop, 12}
");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
