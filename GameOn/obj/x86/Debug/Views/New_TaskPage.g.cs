﻿#pragma checksum "C:\Users\User\Source\Repos\reeblucas\GameOn\GameOn\Views\New_TaskPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7E41E49C6B8A1F52B1877A7EA80CDCF39A24DC91B3ABC34037DA1F476C3A7603"
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
    partial class New_TaskPage : 
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
            case 2: // Views\New_TaskPage.xaml line 10
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\New_TaskPage.xaml line 45
                {
                    this.ColorPicker = (global::Windows.UI.Xaml.Controls.ColorPicker)(target);
                }
                break;
            case 4: // Views\New_TaskPage.xaml line 46
                {
                    this.ColorDoneButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ColorDoneButton).Click += this.ColorDoneButton_Click;
                }
                break;
            case 5: // Views\New_TaskPage.xaml line 13
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.Save_Click;
                }
                break;
            case 6: // Views\New_TaskPage.xaml line 14
                {
                    this.TaskName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Views\New_TaskPage.xaml line 22
                {
                    this.TaskTime = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 8: // Views\New_TaskPage.xaml line 24
                {
                    this.TaskDate = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 9: // Views\New_TaskPage.xaml line 41
                {
                    this.TaskNotes = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // Views\New_TaskPage.xaml line 43
                {
                    this.ColorButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ColorButton).Click += this.Button_Click;
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

