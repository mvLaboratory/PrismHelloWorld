using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldModule
{
    class InfoModel
    {
        public String Text { get; set; }

        public override String ToString()
        {
            return Text;
        }
    }
}
