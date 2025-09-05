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
Visual Studio 2017 or Visual Studio for Mac.
Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.
