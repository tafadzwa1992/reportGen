using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reportGen
{
    class Program
    {
        static void Main(string[] args)
        {

            string f;
            Console.Write("please enter 1 to record heits and 2 to record celcious");
            f = Console.ReadLine();
            if (f == "1")
            {
                Console.Write("Enter the farheits");
                farheits asdf = new farheits();
               // Console.Write("Enter the farheits");
                asdf.a = Convert.ToInt32(Console.ReadLine());
                celcious weert = asdf;
               Console.WriteLine(weert.b);
                Console.ReadKey();
                //heits = asdf;
            }
            else if(f == "2")
            {
                Console.Write("Enter the celcious");
                celcious asdf = new celcious();
                // Console.Write("Enter the farheits");
                asdf.b = Convert.ToInt32(Console.ReadLine());
                farheits weert = asdf;
                Console.WriteLine("Farheits of temp converted from celicious is" + weert.a);
                Console.ReadKey();
            }
            //from n in names.AsQueryable()
            //let total = n[1] + n[2] + n[3]
            //orderby total

        }
       public class farheits
        {
           public int a = 0;          
            public static implicit operator celcious(farheits heits)
            {
                celcious acc = new celcious();
                acc.b = (heits.a + 32) * 6 / 5;
                return acc;
               
            }

        }

        public class celcious
        {
           public int b = 0;
            public static implicit operator farheits(celcious ceils)
            {
                farheits ddd = new farheits();
                ddd.a = (ceils.b - 32) * 5 / 6;
                return ddd;
            }

        }

    }
}
