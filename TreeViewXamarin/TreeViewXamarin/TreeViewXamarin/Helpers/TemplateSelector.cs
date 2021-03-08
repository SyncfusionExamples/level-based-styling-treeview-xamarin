using Syncfusion.TreeView.Engine;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Styling
{
    public class TemplateSelector : DataTemplateSelector
    {
        public DataTemplate HeaderTemplate { get; set; }
        public DataTemplate ChildTemplate { get; set; }
        public TemplateSelector()
        {
            this.HeaderTemplate = new DataTemplate(typeof(HeaderTemplate));
            this.ChildTemplate = new DataTemplate(typeof(ChildTemplate));
        }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var treeviewNode = item as TreeViewNode;
            if (treeviewNode == null)
                return null;
            if (treeviewNode.Level == 0)
                return HeaderTemplate;
            else
                return ChildTemplate;
        }
    }
}
