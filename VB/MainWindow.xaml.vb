Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Core

Namespace SuperTipDemo

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub superTipForStandardControlsXaml_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call(New SuperTipFromXamlForStandardControls() With {.Owner = Me}).Show()
        End Sub

        Private Sub superTipForStandardControlsCode_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call(New SuperTipFromCodeForStandardControls() With {.Owner = Me}).Show()
        End Sub

        Private Sub superTipForBarsXaml_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call(New SuperTipFromXamlForBars() With {.Owner = Me}).Show()
        End Sub

        Private Sub DeepBlue_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ThemeManager.ApplicationThemeName = "DeepBlue"
        End Sub

        Private Sub LightGray_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ThemeManager.ApplicationThemeName = "LightGray"
        End Sub

        Private Sub Office2007Black_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ThemeManager.ApplicationThemeName = "Office2007Black"
        End Sub

        Private Sub Office2007Blue_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ThemeManager.ApplicationThemeName = "Office2007Blue"
        End Sub

        Private Sub Office2007Silver_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ThemeManager.ApplicationThemeName = "Office2007Silver"
        End Sub

        Private Sub superTipForBarsCode_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call(New SuperTipFromCodeForBars() With {.Owner = Me}).Show()
        End Sub

        Private Sub superTipFromXamlForRibbon_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call(New SuperTipForRibbonFromXaml() With {.Owner = Me}).Show()
        End Sub

        Private Sub superTipFromCodeForRibbon_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call(New SuperTipForRibbonFromCode() With {.Owner = Me}).Show()
        End Sub

        Private Sub thRadioButton_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim rb As RadioButton = TryCast(e.OriginalSource, RadioButton)
            If rb Is Nothing Then Return
            Dim themeName As String = rb.Content.ToString()
            ThemeManager.ApplicationThemeName = themeName
        End Sub
    End Class
End Namespace
