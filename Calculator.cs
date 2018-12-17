using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data;


namespace JSon
{

    delegate string Log();
    class Calculator
    {
        public string operations { get; set; }
        public string numbers { get; set; }
        Log b;
        private char[] cr = new char[200];
        
        public void Do()
        {
            for(int i=0;i<operations.Length;i++)
            {

                switch (operations[i])
                {
                    case '+':
                        {
                            b += Add;
                           Console.WriteLine(b());
                            break;
                        }
                    case '-':
                        {
                            b += Sub;
                            Console.WriteLine(b());
                            break;
                        }
                    case '/':
                        {
                            b += Div;
                            Console.WriteLine(b());
                            break;
                        }
                    case '*':
                        {
                            b += Multi;
                            Console.WriteLine(b());
                            break;
                        }
                    case ',':
                        {
                            break;
                        }
                }
            }
        }

        public string Add()
        {

            string str = "";
            for(int i=0;i<numbers.Length;i++)
            {
                cr[i] = numbers[i];
                if(cr[i] ==',')
                {
                    cr[i]='+';
                }
                str += cr[i];
            }
            var result = (int)new DataTable().Compute(str,null) ;
            return str+"= "+result;
        }

        public string Sub()
        {
            string str = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                cr[i] = numbers[i];
                if (cr[i] == ',')
                {
                    cr[i] = '-';
                }
                str += cr[i];
            }
            var result = (int)new DataTable().Compute(str, null);
            return str + "= " + result;
        }

        public string Div()
        {
            string str = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                cr[i] = numbers[i];
                if (cr[i] == ',')
                {
                    cr[i] = '/';
                }
                str += cr[i];
            }
            var result = (double)new DataTable().Compute(str, null);
            return str + "= " + result;
        }

    
        public string Multi()
        {
            string str = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                cr[i] = numbers[i];
                if (cr[i] == ',')
                {
                    cr[i] = '*';
                }
                str += cr[i];
            }
            int result = (int)new DataTable().Compute(str, null);
            return str + "= " + result;
        }   
    }
}
