using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;


namespace SevenVorot.Entitys
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string partition { get; set; }//имя раздела (автоматика.. барьеры...)
        public string article { get; set; }
        public string imageName { get; set; }//имя файла картинки
        public float price { get; set; }
        public string otherSpecificationsNamesJson { get; set; }//json файл содержащий массив имен доп характеристик
        public string otherSpecificationsValuesJson { get; set; }//json файл содержащий массив значений доп характеристик

        public string CreateJsonFromStrings(string[] strings)//делаем из полученного массива строк одну строку(нельза занести массив в базу)
        {
            return JsonSerializer.Serialize(strings);
        }

        [NotMapped]
        public string[] otherSpecificationsNameArray { get; set; }// массив ИМЕН доп характеристик
        [NotMapped]
        public string[] otherSpecificationsValueArray { get; set; }// массив ЗНАЧЕНИЙ доп характеристик

    }
}
