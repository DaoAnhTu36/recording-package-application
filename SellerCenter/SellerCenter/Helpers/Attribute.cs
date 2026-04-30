using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellerCenter.Helpers
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ScopedAttribute : Attribute
    { }

    [AttributeUsage(AttributeTargets.Class)]
    public class SingletonAttribute : Attribute
    { }

    [AttributeUsage(AttributeTargets.Class)]
    public class TransientAttribute : Attribute
    { }
}