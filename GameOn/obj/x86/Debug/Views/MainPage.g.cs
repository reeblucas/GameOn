﻿#pragma checksum "C:\Users\lucas\Documents\GameOn\GameOn\Views\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "45DEE2229CAB91FB7517DD5240A9ABCE12B3A71FCB0387F593214BB0428382A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameOn.Views
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MainPage.xaml line 9
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\MainPage.xaml line 25
                {
                    this.TodayTOne = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TodayTOne).Click += this.Task_Click;
                }
                break;
            case 4: // Views\MainPage.xaml line 26
                {
                    this.TodayTTwo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TodayTTwo).Click += this.Task_Click;
                }
                break;
            case 5: // Views\MainPage.xaml line 27
                {
                    this.TodayTThree = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TodayTThree).Click += this.Task_Click;
                }
                break;
            case 6: // Views\MainPage.xaml line 28
                {
                    this.TodayTFour = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TodayTFour).Click += this.Task_Click;
                }
                break;
            case 7: // Views\MainPage.xaml line 30
                {
                    this.TomorrowTOne = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TomorrowTOne).Click += this.Task_Click;
                }
                break;
            case 8: // Views\MainPage.xaml line 31
                {
                    this.TomorrowTTwo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TomorrowTTwo).Click += this.Task_Click;
                }
                break;
            case 9: // Views\MainPage.xaml line 32
                {
                    this.TomorrowTThree = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TomorrowTThree).Click += this.Task_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

