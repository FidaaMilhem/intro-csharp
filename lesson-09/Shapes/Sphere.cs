using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Sphere : AbstractShape
    {
        private double _radius;
        public Sphere(double radius)
        {
            _radius = radius;
        }

        public override string Name => "Sphere Shape";

        public override string Dimension => "3D";

        public override double Area()
        {
            var R  = new Circle(_radius);
            return 4*R.Area();
        }

        public override void ScaleArea(double factor)
        {
            _radius = _radius * factor;
        }
    }
}
