﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem_1
{
    public class TextDocument : Document
    {
        public string Charset { get; protected set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "charset")
            {
                this.Charset = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }          
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair <string, object>("charset", this.Charset));
            base.SaveAllProperties(output);
        }
    }
}