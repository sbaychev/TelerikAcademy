using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FromHTMLextrTitlBodWoutTags
{
    class FromHTMLextrTitlBodWoutTags
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from given HTML file its title (if available), 
            //and its body text without the HTML tags. 
                //<html>
                //<head><title>News</title></head>
                //<body><p><a href="http://academy.telerik.com">Telerik
                //Academy</a>aims to provide free real-world practical
                //training for young people who want to turn into
                //skillful .NET software engineers.</p></body>
                //</html>
            string text = "<html>"
                        + @"<head><title>News</title></head><body><p><a href=""http://academy.telerik. com"">Telerik"
                        +"Academy</a>aims to provide free real-world practical"
                        +"training for young people who want to turn into"
                        +"skillful .NET software engineers.</p></body>"
                        +"</html>";
            Match match = Regex.Match(text, @"<title>\s*(.+?)\s*</title>");
            if (match.Success)
	        {
                string final = Regex.Replace(match.Value.ToString(), @"<(.|\n)*?>", string.Empty);
                Console.WriteLine(final);
	        }
            else
            {
                Console.WriteLine("No title tag");
            }
                    
        }
    }
}