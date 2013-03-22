using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtrAllEmailAddrFromTxt
{
    class ExtrAllEmailAddrFromTxt
    {
        static void Main(string[] args)
        {
            //Write a program for extracting all email addresses from given text. 
            //All substrings that match the format <identifier>@<host>…<domain> should be
            //recognized as emails.
            string text = @" River Wireless 10digitphonenumber@sms.3rivers.net ACS Wireless 10digitphonenumber@paging.acswireless.com" 
                +"Alltel 10digitphonenumber@message.alltel.com AT&T 10digitphonenumber@txt.att.net Bell Canada 10digitphonenumber@txt.bellmobility.ca"
            +"Bell Canada 10digitphonenumber@bellmobility.ca, Bell Mobility (Canada) 10digitphonenumber@txt.bell.ca";
            char[] c = new char[] { ' ', ',' };
            string[] allText = text.Split(c);
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                        + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                        + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            for (int i = 0; i < allText.Length; i++)
            {
                MatchCollection matches = Regex.Matches(allText[i], pattern);

                foreach (Match match in matches)
                {
                    foreach (Capture capture in match.Captures)
                    {
                        Console.WriteLine(capture.Value);
                    }
                }
            }
        }
    }
}