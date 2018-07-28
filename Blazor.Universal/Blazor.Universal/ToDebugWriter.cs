using System.Diagnostics;
using System.IO;

namespace Blazor.Universal
{
    public class ToDebugWriter : StringWriter
    {
        public override void WriteLine(string value)
        {
            Debug.WriteLine(value);
            base.WriteLine(value);
        }
    }
}