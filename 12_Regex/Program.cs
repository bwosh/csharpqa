using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lines = new List<string>();

            //lines.Add("abc def hij");
            //lines.Add("abc def 1 hij");
            //lines.Add("abc def 1hij");
            //lines.Add("abc def 123 hij");
            //lines.Add("abc def 123 hij");

//            lines.Add("abc");
//            lines.Add("abc ");
//            lines.Add("abc sss");
//            lines.Add(" abc sss");
//            lines.Add("asa abc sss");
//            lines.Add("TAB asa\tabc sss");
//            lines.Add("asa abc ");
//            lines.Add("asa abc");
//            lines.Add("asa abca");
//            lines.Add("asa xabca");
//            lines.Add("asa xabc ddfd");

            lines.Add("123");
            lines.Add("4,5");
            lines.Add("4.5");
            lines.Add("coś 123 ds");
            lines.Add("coś 1,2 a");
            lines.Add("coś 1.2 a");
            lines.Add("mam lat 12");
            lines.Add("12 mam lat");
            lines.Add("12 34 56");
            lines.Add("12 ");
            lines.Add("Jakiś tekst. ");


            Console.WriteLine("Nazwisko:{1} Imie:{0} ", "Adam","Kowalski");

            // var pattern = "^abc\\s|^abs$|\\sabc\\s|\\sabc$";
            //var pattern = @"^abc\s|^abc$|\sabc\s|\sabc$";
            //var pattern = @"^((\S)*\s)*abc(\s(\S)*)*$";
            //var patternFormat = @"^((\S)*\s)*{0}(\s(\S)*)*$";
            //var pattern = string.Format(patternFormat, @"(\d)+([.,](\d)+)?");

            // (?<front>\d)+([.,](?<back>(\d)+))?

            var pattern = @"(\d){3}";

            lines.Where(line => Regex.IsMatch(line, pattern));

            foreach (var line in lines)
            {
                var matches = Regex.Matches(line, pattern);

                foreach (Match match in matches)
                {
                    Debug.WriteLine("["+line+"] Match:"+match.Value+" Potision:" + match.Index + " "+match.Length);
                }

            }


            Console.ReadLine();
            
        }
    }
}
