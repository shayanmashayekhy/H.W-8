namespace H.W08.user
{
    public class Person : person
    {
        public int ID { get; set; }
        public string? Name { get; set; }


        public void GetUser(int Id,string? _Name)
        {
            Name = _Name;
            ID = Id;

            person1(Id,_Name);
            person2(Id, _Name);
            person3(Id, _Name);
            person4(Id, _Name);
            person5(Id, _Name);
            regester(Id, _Name);

            void person1(int id,string? _Name)
            {
               _Name = "shayan";
                Id = 2345355;

            }
            void person2(int id, string? _Name)
            {
                _Name = "shayan";
                Id = 2345355;

            }
            void person3(int id, string? _Name)
            {
                _Name = "shayan";
                Id = 2345355;

            }
            void person4(int id, string? _Name)
            {
                _Name = "shayan";
                Id = 2345355;

            }
            void person5(int id, string? _Name)
            {
                _Name = "shayan";
                Id = 2345355;

            }







            void regester(int Id,string? _Name)
            {
                Console.WriteLine("please enter your id:");
                Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter your name:");
                _Name = Console.ReadLine();
            }
        }
        
    

    }




}
