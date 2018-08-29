namespace firstProjectWebApi.Models
{
    public class Cat
    {
       
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public Cat (string name , int age , string type)
        {
            this.Name = name;
            this.Age = age;
            this.Type = type;
        }
    }
}