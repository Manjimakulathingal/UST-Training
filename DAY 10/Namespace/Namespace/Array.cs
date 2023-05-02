using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace
{
    public class array
    {
        float[] arr = new float[] { 12.5f, 12.6f, 54.7f, 34.8f, 98.2f, 76.4f };
        public float this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

    }
}
