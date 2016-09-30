using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace parsingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string TagName = "v1.23.890";
            TagNameFormatCheck(TagName);
            Console.ReadLine();
        }

        public static string TagNameFormatCheck(string TagName)
        {
            Regex TagNamePattern = new Regex(@"^v[1-9]\.([0-9][0-9]\.)([0-9][0-9][0-9])$");

            Console.WriteLine("The tag name is " + TagName);
            Console.WriteLine("The tag name pattern is " + TagNamePattern);

            if (Regex.IsMatch(TagName, TagNamePattern.ToString()) && TagName != null)
            {
                //TagName = TagNamePattern.ToString();
                Console.WriteLine(TagName);
                return TagName;
            }

            else
            {
                string formatError = "NO MATCH";
                Console.WriteLine(formatError);
                return formatError;
            }

        }
    }
}