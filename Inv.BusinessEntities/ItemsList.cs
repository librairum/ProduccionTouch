using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inv.BusinessEntities
{
    public class ItemsList
    {
        public ItemsList()
        { }

        public ItemsList(string value, string text)
        {
            this.Value = value;
            this.Text = text;
        }

        public string Value { get; set; }
        public string Text { get; set; }
    }
}
