using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gonj
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            MessageBox.Show(string.Join(" ", args.ToArray()));
        }
    }
}
