﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentSystem_1;

    public abstract class PDFDocument : Document
    {

        public string? Pages { get; protected set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "pages")
            {
                this.Pages = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("pages", this.Pages));
            base.SaveAllProperties(output);
        }
    }