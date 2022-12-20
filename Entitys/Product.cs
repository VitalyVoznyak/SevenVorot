namespace SevenVorot.Entitys
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string partition { get; set; }//автоматика? барьеры?
        public string article { get; set; }
        public float mass { get; set; }
        public float price { get; set; }

        public string[] otherSpecificationsName { get; set; }
        public int[] otherSpecificationsValue { get; set; }

    }
}
