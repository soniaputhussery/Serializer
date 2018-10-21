using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public abstract class WriterInvoker
    {
        public abstract IWriter getWriter(string invocationType);
    }
}
