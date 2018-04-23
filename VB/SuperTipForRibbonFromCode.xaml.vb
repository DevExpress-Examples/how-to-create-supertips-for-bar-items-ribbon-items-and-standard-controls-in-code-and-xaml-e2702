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
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core

Namespace SuperTipDemo
	''' <summary>
	''' Interaction logic for SuperTipForRibbonFromCode.xaml
	''' </summary>
	Partial Public Class SuperTipForRibbonFromCode
		Inherits DXWindow
		Public Sub New()
			InitializeComponent()

			Dim tip As New SuperTip()
			Dim header As New SuperTipHeaderItem()
			header.Content = "New"
			Dim item As New SuperTipItem()
			item.Content = "Create a new document"

			Dim item2 As New SuperTipItem()
			item2.Content = "Opens a new document in a new tab"

			tip.Items.Add(header)
			tip.Items.Add(item)
			tip.Items.Add(New SuperTipItemSeparator())
			tip.Items.Add(item2)

			bNew.SuperTip = tip
		End Sub
	End Class
End Namespace
