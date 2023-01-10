using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;


namespace SevenVorot.Models
{
    public class Product
    {

        public int Id { get; set; }
        [MaybeNull]
        [MaxLength(500)]
        public string Name { get; set; }
        [MaybeNull]
        [MaxLength(50)]
        public string Partition { get; set; }//имя раздела (автоматика.. барьеры...)с большой буквы
        [MaybeNull]
        [MaxLength(500)]
        public string SecondPartition { get; set; }//имя 2 уровня раздела (автоматика.. барьеры...)с большой буквы
        [MaybeNull]
        [MaxLength(500)]
        public string ThridPartition { get; set; }//имя 3 уровня раздела (автоматика.. барьеры...)с большой буквы
        [MaybeNull]
        [MaxLength(500)]
        public string Article { get; set; }
        [MaybeNull]
        [MaxLength(500)]
        public string ImageName { get; set; }//имя файла картинки
        [MaybeNull]

        public float Price { get; set; }



    }
}
