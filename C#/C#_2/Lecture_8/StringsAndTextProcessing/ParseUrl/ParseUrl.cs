using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ParseUrl
{
    class ParseUrl
    {
        static void Main(string[] args)
        {
            //Write a program that parses an URL address given in the format:
            //and extracts from it the [protocol], [server] and [resource] elements. 
            //For example from the URL http://www.devbg.org/forum/index.php the following 
            //information should be extracted: [protocol] = "http"
            //[server] = "www.devbg.org"
            //[resource] = "/forum/index.php"
            string urlAddress = "ftps://www.devbg.org/forum/index.php";
            //Regex protocol = new Regex(@"^(?<proto>\w+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);//regex protocol
            //foreach (Match m in protocol.Matches(urlAddress))
            //    MessageBox.Show(m.Value);
            Uri uri = new Uri(urlAddress);
            Console.WriteLine(uri.Scheme);
            Console.WriteLine(uri.Host);
            Console.WriteLine(uri.AbsolutePath); 
        }
    }
}