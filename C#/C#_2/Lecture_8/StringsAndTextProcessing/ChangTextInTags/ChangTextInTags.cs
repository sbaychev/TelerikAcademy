using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ChangTextInTags
{
    class ChangTextInTags
    {
        static void Main(string[] args)
        {
    //You are given a text. Write a program that changes the text in all regions surrounded
    //by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 
    //Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
    //Expected Result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

            string text = 
                "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            MatchCollection matches = Regex.Matches(text, @"<upcase>\s*(.+?)\s*</upcase>");
            StringBuilder sb = new StringBuilder();
            string temp = "";
            foreach (Match match in matches)
            {
                foreach (Capture capture in match.Captures)
                {
                    int tagLen = sb.Length;
                    sb.Append(text.Substring(tagLen, capture.Index - tagLen));
                    sb.Append(capture.Value.ToUpper());
                }
            }
            temp = sb.ToString();
            if (temp.Length < text.Length)
            {
                temp += text.Substring(temp.Length, text.Length - temp.Length);
            }
            string final = Regex.Replace(temp, @"<(.|\n)*?>", string.Empty);
            Console.WriteLine(final);
        }
    }
}