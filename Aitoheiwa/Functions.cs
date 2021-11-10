using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aitoheiwa
{
    class Functions
    {
        public static OpenFileDialog openfiledialog = new OpenFileDialog
        {
            Filter = "Script File|*.txt;*.lua|All files (*.*)|*.*",//add txt,lua and all files filter
            FilterIndex = 1,//choose what filter will be the default
            RestoreDirectory = true,//restore the last used directory
            Title = "Reduxed Open File"//OpenFileDialog Tittle
        };//Initialize OpenFileDialog
    }
}
