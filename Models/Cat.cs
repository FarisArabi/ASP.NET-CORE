namespace firstProjectWebApi.Models
{
    public class Cat
    {
       
        public string Name { get; set; }
        public int Age;
        public string Type;

        public Cat(string Name)
        {
            this.Name = Name;
        }

    }
}