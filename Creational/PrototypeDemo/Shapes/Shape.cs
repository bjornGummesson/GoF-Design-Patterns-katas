using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDemo.Shapes
{
    public abstract class Shape : ICloneable
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public abstract void Draw();
        public object Clone()
        {
            var shape = (Shape)MemberwiseClone();
            return shape;
        }
    }
}
