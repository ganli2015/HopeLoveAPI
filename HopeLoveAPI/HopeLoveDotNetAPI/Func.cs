using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace HopeLove
{
    public class Func
    {
//         [DllImport(@"E:\Artificial Intelligence\Project\HopeLoveAPI\UnitTest\bin\x86\Debug\HopeLoveAPI.dll")]
//         public static extern void DisposeBrain();
// 
//         [DllImport(@"E:\Artificial Intelligence\Project\HopeLoveAPI\UnitTest\bin\x86\Debug\HopeLoveAPI.dll", CharSet = CharSet.Ansi)]
//         static extern void InitializeBrain(IntPtr datadir);

        public static void InitializeBrain(string datadir=null)
        {
            APIManaged.Func.InitializeBrain(datadir);
        }

        public static List<string> WordSegment(string sentence)
        {
            List<string> res= APIManaged.Func.WordSegment(sentence).ToList();

            if(res==null)
            { return new List<string>(); }
            else
            {
                return res;
            }
        }

        public static void DisposeBrain()
        {
            APIManaged.Func.DisposeBrain();
        }
    }
}
