using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuerySyntax
{
    public class StringWithLength
    {
        public string Value { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Value, this.Length);
        }

    }
}
