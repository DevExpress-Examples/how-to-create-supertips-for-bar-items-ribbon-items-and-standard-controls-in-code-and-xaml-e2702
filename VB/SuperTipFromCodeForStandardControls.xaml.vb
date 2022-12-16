Imports System.Windows.Controls
Imports DevExpress.Xpf.Core

Namespace SuperTipDemo

    ''' <summary>
    ''' Interaction logic for SuperTipFromCodeForStandardControls.xaml
    ''' </summary>
    Public Partial Class SuperTipFromCodeForStandardControls
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
            Dim tip As SuperTip = New SuperTip()
            Dim tipControl As SuperTipControl = New SuperTipControl()
            tipControl.SuperTip = tip
            Dim header As SuperTipHeaderItem = New SuperTipHeaderItem()
            header.Content = "New"
            Dim item As SuperTipItem = New SuperTipItem()
            item.Content = "Create a new document"
            Dim item2 As SuperTipItem = New SuperTipItem()
            item2.Content = "Opens a new document in a new tab"
            tip.Items.Add(header)
            tip.Items.Add(item)
            tip.Items.Add(New SuperTipItemSeparator())
            tip.Items.Add(item2)
            Me.bt.ToolTip = tipControl
        End Sub
    End Class
End Namespace
