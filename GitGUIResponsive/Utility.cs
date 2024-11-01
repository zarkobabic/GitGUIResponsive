using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitGUIResponsive
{
    public static class Utility
    {
        public const int MESSAGE_SUCCESS = 0;
        public const int MESSAGE_ERROR = 1;

        public static void CreateMessageBox(string title, string message, int type)
        {
            if(type == 0) //SUCCESS
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //ERROR
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
