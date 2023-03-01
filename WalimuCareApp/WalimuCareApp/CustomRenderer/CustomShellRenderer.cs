using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace WalimuCareApp.CustomRenderer
{
    public class CustomShellRenderer : Shell
    {

        private Command rattingBarCommand;

        public ICommand RattingBarCommand
        {
            get
            {
                if (rattingBarCommand == null)
                {
                    rattingBarCommand = new Command(rattingBar);
                }

                return rattingBarCommand;
            }
        }

        private void rattingBar()
        {
        }
    }
}
