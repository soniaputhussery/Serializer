using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class WriterInvokerImplementation : WriterInvoker
    {
        public override IWriter getWriter(string invocationType)
        {
            switch(invocationType)
            {
                case "X": return new XmlWriter();
                case "H": return new HtmlWriter();
            }
            return null;
        }
    }
}
