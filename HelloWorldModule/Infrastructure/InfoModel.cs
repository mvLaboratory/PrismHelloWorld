using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldModule
{
    public class InfoModel
    {
        public String Text { get; set; }

        public InfoModel(int index)
        {
            Text = "Info " + index;
        }

        public override String ToString()
        {
            return Text;
        }
    }
}
