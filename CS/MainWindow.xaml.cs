using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;

namespace SuperTipDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void superTipForStandardControlsXaml_Click(object sender, RoutedEventArgs e) {
            (new SuperTipFromXamlForStandardControls() { Owner = this }).Show();
        }
        private void superTipForStandardControlsCode_Click(object sender, RoutedEventArgs e) {
            (new SuperTipFromCodeForStandardControls() { Owner = this }).Show();
        }
        private void superTipForBarsXaml_Click(object sender, RoutedEventArgs e) {
            (new SuperTipFromXamlForBars() { Owner = this }).Show();
        }

        private void DeepBlue_Click(object sender, RoutedEventArgs e) {
            ThemeManager.ApplicationThemeName = "DeepBlue";
        }

        private void LightGray_Click(object sender, RoutedEventArgs e) {
            ThemeManager.ApplicationThemeName = "LightGray";
        }

        private void Office2007Black_Click(object sender, RoutedEventArgs e) {
            ThemeManager.ApplicationThemeName = "Office2007Black";
        }

        private void Office2007Blue_Click(object sender, RoutedEventArgs e) {
            ThemeManager.ApplicationThemeName = "Office2007Blue";
        }

        private void Office2007Silver_Click(object sender, RoutedEventArgs e) {
            ThemeManager.ApplicationThemeName = "Office2007Silver";
        }

        private void superTipForBarsCode_Click(object sender, RoutedEventArgs e) {
            (new SuperTipFromCodeForBars() { Owner = this }).Show();
        }

        private void superTipFromXamlForRibbon_Click(object sender, RoutedEventArgs e) {
            (new SuperTipForRibbonFromXaml() { Owner = this }).Show();
        }

        private void superTipFromCodeForRibbon_Click(object sender, RoutedEventArgs e) {
            (new SuperTipForRibbonFromCode() { Owner = this }).Show();
        }

        private void thRadioButton_Checked(object sender, RoutedEventArgs e) {
            RadioButton rb = e.OriginalSource as RadioButton;            
            if(rb == null) return;
            string themeName = rb.Content.ToString();
            ThemeManager.ApplicationThemeName = themeName;
        }
    }
}
