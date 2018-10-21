using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public interface IWriter
    {
        void write(List<String> sourceFile, String targetFile);
    }
}
