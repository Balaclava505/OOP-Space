using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMovement
{
    class InfoDictionary
    {
        public List<string> Keys = new List<string>();
        public List<object> Values = new List<object>();

        public void Add(string t1, object t2)
        {
            Keys.Add(t1);
            Values.Add(t2);
        }

        public void Clear()
        {
            Keys.Clear();
            Values.Clear();
        }
    }
}
