//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/CopyingfromtheClipboard.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Clipboard
{ 
   public   class Clipboard_2_CopyingfromtheClipboard:Form
    { 
       public   Clipboard_2_CopyingfromtheClipboard()
       {
            IDataObject iData = Clipboard.GetDataObject();

            if (iData.GetDataPresent(DataFormats.Text))
            {
                Console.WriteLine((String)iData.GetData(DataFormats.Text));
            }
            if (iData.GetDataPresent(DataFormats.Bitmap))
            {
                Image img = (Bitmap)iData.GetData(DataFormats.Bitmap);

            }

        }
    }
}
