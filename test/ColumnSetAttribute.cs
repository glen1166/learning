using System;

namespace test
{
    internal class ColumnSetAttribute : Attribute
    {
        public ColumnSetAttribute(string title, int order, int width)
        {
            this.Title = title;
            this.Order = order;
            this.Width = width;
        }

        public string Title { get; set; }

        public int Order { get; set; }

        public int Width { get; set; }

        public bool AutoWidth { get; set; }

        public EnumAlign Align { get; set; }
    }
}