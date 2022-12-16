Imports System.Windows.Controls
Imports DevExpress.Xpf.Core

Namespace SuperTipDemo

    ''' <summary>
    ''' Interaction logic for SuperTipFromCodeForBars.xaml
    ''' </summary>
    Public Partial Class SuperTipFromCodeForBars
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
            Dim tip As SuperTip = New SuperTip()
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
            Me.bt.SuperTip = tip
        End Sub
    End Class
End Namespace
