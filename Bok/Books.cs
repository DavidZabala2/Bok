using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bok
{
    class Books
    {

        string titel;
        string författare;
        int antalSidor;


        public Books()
        {
            
            
            

            Console.WriteLine("Vad är namnet på din bok? ");
            titel = Console.ReadLine();

            Console.WriteLine("Vem är författaren? ");
            författare = Console.ReadLine();

            Console.WriteLine("Hur många sidor har boken? ");
            antalSidor = Convert.ToInt32(Console.ReadLine());

        }
        public void skrivUt()
        {
            Console.WriteLine("Bokens titel är : " + titel + "\n Bokens författare är : " + författare + "\n Boken har : " + antalSidor + " sidor");
        }

    }
}
