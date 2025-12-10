using System.Windows;
using System.Windows.Controls;

namespace ColdNightsLogViewer;

public class LogStyleSelector : StyleSelector
{
    public Style? InfoStyle { get; set; }
    public Style? WarningStyle { get; set; }
    public Style? ErrorStyle { get; set; }

    public override Style SelectStyle(object item, DependencyObject container)
    {
        string line = item as string ?? "";
        
        if(line.Contains("[ERROR]") || line.Contains("[Error]"))
            return ErrorStyle;
        if(line.Contains("[WARNING]") || line.Contains("[Warning]"))
            return WarningStyle;
        
        return InfoStyle;
    }
}