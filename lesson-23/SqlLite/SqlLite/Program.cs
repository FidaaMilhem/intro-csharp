namespace SqlLite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            using (var db = new StuffDb())
            {
                var rami = new Person()
                {
                    Name = "Fiaa",
                    EMail = "fda@net.com",
                    Phone = "0555555",
                    Twiter = "@fdaa"
                };

                db.Persons.Add(rami);
                db.SaveChanges();

                var drill = new Gadget()
                {
                    IsElectric = true,
                    Name = "Dentsit Drill",
                    Description = "torture people dentists",
                    Person = rami
                };
                var d9 = new Gadget()
                {
                    IsElectric = false,
                    Name = "Cat D9",
                    Description = "Move Arara east",
                    Person = rami
                };

                db.Gadgets.Add(drill);
                db.Gadgets.Add(d9);
                db.SaveChanges();
            }
        }
    }
}