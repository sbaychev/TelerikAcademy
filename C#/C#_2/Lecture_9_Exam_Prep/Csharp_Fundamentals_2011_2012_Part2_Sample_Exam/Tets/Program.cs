using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Timwi.Temp
{
    static class Program
    {
        static void Main(string[] args)
        {
            var input = @"
/*
 * Line 1
 * Line 2
 * Line 3
*/

var url = ""http://stackoverflow.com""; // Stackoverflow website.";

            var list = new List<string>();
            var blockComments = @"/\*(.*?)\*/";
            var lineComments = @"//(.*?)(\r?\n|$)";
            var strings = @"""((\\[^\n]|[^""\n])*)""";
            var verbatimStrings = @"@(""[^""]*"")+";

            string noComments = Regex.Replace(input,
                blockComments + "|" + lineComments + "|" + strings + "|" + verbatimStrings,
                me =>
                {
                    if (me.Value.StartsWith("/*") || me.Value.StartsWith("//"))
                    {
                        // Put the contents of comments into the list
                        list.Add(me.Groups[1].Value + me.Groups[2].Value);
                        // Replace the comments with empty, i.e. remove them
                        return me.Value.StartsWith("//") ? me.Groups[3].Value : "";
                    }
                    // Keep the literal strings
                    return me.Value;
                },
                RegexOptions.Singleline);

            foreach (var comment in list)
                Console.WriteLine(comment);
            Console.WriteLine("--------------");
            Console.WriteLine(noComments);

            Console.ReadLine();
        }
    }
}