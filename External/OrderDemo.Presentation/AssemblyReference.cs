using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Presentation;

public static class AssemblyReference
{
    // Referansı oluşturur
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}
