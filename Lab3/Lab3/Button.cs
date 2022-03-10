using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal abstract class Button
    {
        public abstract void Execute();
        public abstract void Cancel();
        public abstract void Name();
    }
}