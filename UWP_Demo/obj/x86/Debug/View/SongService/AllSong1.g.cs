﻿#pragma checksum "C:\Users\Admin\source\repos\UWP_Demo\UWP_Demo\View\SongService\AllSong1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CAF5CC4BB0D1850032033B5ABB036131"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWP_Demo.View.SongService
{
    partial class AllSong1 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // View\SongService\AllSong1.xaml line 44
                {
                    this.MyMediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 3: // View\SongService\AllSong1.xaml line 32
                {
                    this.btnSignOut = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnSignOut).Click += this.BtnSignOut_Click;
                }
                break;
            case 4: // View\SongService\AllSong1.xaml line 34
                {
                    this.btnCreateMusic = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnCreateMusic).Click += this.BtnCreateMusic_Click;
                }
                break;
            case 5: // View\SongService\AllSong1.xaml line 36
                {
                    this.Previous = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Previous).Click += this.Previous_Click;
                }
                break;
            case 6: // View\SongService\AllSong1.xaml line 37
                {
                    this.PlayAndPause = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PlayAndPause).Click += this.PlayAndPause_Click;
                }
                break;
            case 7: // View\SongService\AllSong1.xaml line 38
                {
                    this.Next = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Next).Click += this.Next_Click;
                }
                break;
            case 8: // View\SongService\AllSong1.xaml line 41
                {
                    this.txtNowPlaying = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // View\SongService\AllSong1.xaml line 14
                {
                    this.ListViewSong = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 12: // View\SongService\AllSong1.xaml line 24
                {
                    global::Windows.UI.Xaml.Controls.SymbolIcon element12 = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)element12).DoubleTapped += this.UIElement_OnDoubleTapped;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

