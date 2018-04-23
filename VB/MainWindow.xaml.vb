Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core

Namespace SuperTipDemo
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits DXWindow
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub superTipForStandardControlsXaml_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			CType(New SuperTipFromXamlForStandardControls() With {.Owner = Me}, SuperTipFromXamlForStandardControls).Show()
		End Sub
		Private Sub superTipForStandardControlsCode_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			CType(New SuperTipFromCodeForStandardControls() With {.Owner = Me}, SuperTipFromCodeForStandardControls).Show()
		End Sub
		Private Sub superTipForBarsXaml_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			CType(New SuperTipFromXamlForBars() With {.Owner = Me}, SuperTipFromXamlForBars).Show()
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
			CType(New SuperTipFromCodeForBars() With {.Owner = Me}, SuperTipFromCodeForBars).Show()
		End Sub

		Private Sub superTipFromXamlForRibbon_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			CType(New SuperTipForRibbonFromXaml() With {.Owner = Me}, SuperTipForRibbonFromXaml).Show()
		End Sub

		Private Sub superTipFromCodeForRibbon_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			CType(New SuperTipForRibbonFromCode() With {.Owner = Me}, SuperTipForRibbonFromCode).Show()
		End Sub

		Private Sub thRadioButton_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim rb As RadioButton = TryCast(e.OriginalSource, RadioButton)
			If rb Is Nothing Then
				Return
			End If
			Dim themeName As String = rb.Content.ToString()
			ThemeManager.ApplicationThemeName = themeName
		End Sub
	End Class
End Namespace
