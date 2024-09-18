using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend01B
{
    public record Course(string name, int credit);

    public record Faculty(string name, Course[] courses);
}
