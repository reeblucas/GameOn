﻿#pragma checksum "C:\Users\lucas\Documents\GameOn\GameOn\Views\CalendarPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ADC864967CA594F4E9F12D2036723D11BEB5CBC482290FD2D125CCA083E16F2E"
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
    partial class CalendarPage : 
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
            case 2: // Views\CalendarPage.xaml line 12
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\CalendarPage.xaml line 21
                {
                    this.Button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Button1).Click += this.Task_Click;
                }
                break;
            case 4: // Views\CalendarPage.xaml line 22
                {
                    this.Button2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 5: // Views\CalendarPage.xaml line 23
                {
                    this.Button3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6: // Views\CalendarPage.xaml line 24
                {
                    this.Button4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7: // Views\CalendarPage.xaml line 15
                {
                    this.Calendar = (global::Windows.UI.Xaml.Controls.CalendarView)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarView)this.Calendar).SelectedDatesChanged += this.Calender_DateChange;
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

