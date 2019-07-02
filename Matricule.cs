using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1._1
{
    public class Matricule
    {

        public static  List<int> matricule { get; set; }

        public static int Longueur()
        {
            int longeur = matricule.Count();
            return longeur;
        }

       
       
        
    }
}
