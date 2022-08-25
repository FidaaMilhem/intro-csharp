namespace Shapes
{
    
    internal class Program
    {
        static void PaintPrice(AbstractShape shape)
        {
            var priceForLiter = 1337.0;
            //var surface = shape.Area();
            //var vol = surface * 1e-4;
            //var price = vol * priceForLiter;
            //Console.WriteLine($"paint {shape.Name} will cost {price}");

            Console.WriteLine($"paint {shape.Name} - {shape.Dimension} will cost {shape.PaintVolume(0.01) * priceForLiter}");
        }

        static void Paint(List<AbstractShape> lst)
        {
            foreach (var shape in lst)
            {
                PaintPrice(shape);
            }
        }
        static void Paint(Dictionary<string, List<AbstractShape>> d)
        {
            Console.WriteLine("full catalog  -------------------------");
            foreach (var item in d.Keys)
            {
                Console.WriteLine($"{item} -------------------------");
                Paint(d[item]);
                /*
                foreach (var obj in d[item])
                {
                    Console.WriteLine($"a {obj.Name} with an area {obj.Area()}");
                }        */
            }
        }

        static void Blow(List<AbstractShape> lst, double factor = 2.5)
        {
            foreach(var shape in lst)
            {
                shape.ScaleArea(factor);
            }
        }

        static Dictionary<string, List<AbstractShape>> CreatDictionaryOfShapes(List<AbstractShape> lst)
        {
            Dictionary<string, List<AbstractShape>> catalog = new();

            foreach (var shape in lst)
            {
                string k = shape.Name;
                if (catalog.ContainsKey(k)) 
                { 
                    catalog[k].Add(shape); 
                }
                else 
                {
                  catalog.Add(k, new List<AbstractShape>() { shape });
                }                
            }
        
            return catalog;
        }

        static void Main(string[] args)
        {           
            var s = new Square(4);
            PaintPrice(s);

            var c = new Circle(4);
            PaintPrice(c);

            var r = new Ring(2,4);
            PaintPrice(r);

            var K = new Sphere(4);
            PaintPrice(K);

            Console.WriteLine("list paint -------------------------");
            var shapes = new List<AbstractShape>() { 
                new Circle(3), new Circle(4), new Circle(5), new Square(4), new Sphere(5), new Ring(3, 7) 
            };

            Paint(shapes);


            Console.WriteLine("blow and paint -------------------------");
            Blow(shapes, 2);
            Paint(shapes);

         

            Console.WriteLine("dict -------------------------");
            Dictionary<string, List<AbstractShape>> dict = CreatDictionaryOfShapes(shapes);
            Paint(dict["Circlular Shape"]);

            Paint(dict);
        }
    }
}