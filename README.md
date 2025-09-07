# level-based-styling-treeview-xamarin
This repository demonstrates how to apply level-based styling to nodes in the Xamarin.Forms SfTreeView control. It provides a sample implementation that customizes the appearance of tree nodes—such as font style, color, or background—based on their hierarchical level, enabling visually distinct and organized tree structures.

## Sample

### XAML
```xaml
<ContentPage.Resources>
        <ResourceDictionary>
            <local:TemplateSelector x:Key="Template"/>
        </ResourceDictionary>
    </ContentPage.Resources>
    <ContentPage.Content>
        <syncfusion:SfTreeView x:Name="treeView"
                               ChildPropertyName="SubFolder"
                               AutoExpandMode="AllNodesExpanded"
                               ExpanderWidth="0"
                               ItemsSource="{Binding Folders}"
                               ItemTemplate="{StaticResource Template}">
        </syncfusion:SfTreeView>
    </ContentPage.Content>
```

### TemplateSelector
```csharp
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
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for Xamarin](https://help.syncfusion.com/xamarin/system-requirements)

## Troubleshooting
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
