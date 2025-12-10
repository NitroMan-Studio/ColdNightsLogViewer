using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ColdNightsLogViewer;

public class HighlightBackgroundConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        string line = value as string ?? "";

        if (line.Contains("[Error]"))
            return new SolidColorBrush(Color.FromRgb(255, 70, 70));

        if (line.Contains("[Warning]"))
            return new SolidColorBrush(Color.FromRgb(255, 245, 110));

        return Brushes.White;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}