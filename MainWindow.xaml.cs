using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;

namespace ColdNightsLogViewer;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private string _currentPath;
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnOpen_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter = "Log files (*.log)|*.log";

        if (ofd.ShowDialog() == true)
        {
            TxtPath.Text = ofd.FileName;
            _currentPath = ofd.FileName;

            ListLogs.Items.Clear();

            foreach (var line in File.ReadLines(ofd.FileName))
            {
                if (PassesFilter(line) && PassesFilter(line))
                    ListLogs.Items.Add(line);
            }
        }
    }

    private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
    {
        if(e.Key == Key.Enter)
            ReloadLog();
    }

    private void TextSearch_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(TxtSearch.Text.Length == 0)
            ReloadLog();
    }

    private void FilterChanged(object sender, RoutedEventArgs e)
    {
        if (_currentPath != null)
            ReloadLog();
    }

    private void ReloadLog()
    {
        ListLogs.Items.Clear();
        
        foreach (var line in File.ReadLines(_currentPath))
        {
            if (PassesFilter(line) && PassesSearch(line))
                ListLogs.Items.Add(line);
        }
    }

    private bool PassesFilter(string line)
    {
        if (line.Contains("[Error]") && ChkErr.IsChecked == true)
            return true;
        if (line.Contains("[Warning]") && ChkWarn.IsChecked == true)
            return true;
        if (!line.Contains("[Error]") && !line.Contains("[Warning]") && ChkInfo.IsChecked == true)
            return true;

        return false;
    }

    private bool PassesSearch(string line)
    {
        if (string.IsNullOrWhiteSpace(TxtSearch.Text))
            return true;

        return line.Contains(TxtSearch.Text, StringComparison.OrdinalIgnoreCase);
    }
}