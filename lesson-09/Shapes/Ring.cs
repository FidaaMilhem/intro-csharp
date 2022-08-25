using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Ring : AbstractShape
    {
        private double _inner;
        private double _outer;

        public Ring(double inner, double outer)
        {
            _inner = inner;
            _outer = outer;
        }

        public override string Name => "Ring Shape";
        public override string Dimension => "2D";

        public override double Area()
        {
            var inner = new Circle(_inner);
            var outer = new Circle(_outer);
            return outer.Area() - inner.Area();
        }

        public override void ScaleArea(double factor)
        {
            _inner = _inner*factor;
            _outer = _outer*factor; ;
        }
    }
}
