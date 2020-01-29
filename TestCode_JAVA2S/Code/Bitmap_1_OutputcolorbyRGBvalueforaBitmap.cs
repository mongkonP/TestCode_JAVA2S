//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/OutputcolorbyRGBvalueforaBitmap.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Bitmap
{ 
   public   class Bitmap_1_OutputcolorbyRGBvalueforaBitmap:Form
    { 
       public   Bitmap_1_OutputcolorbyRGBvalueforaBitmap()
       {
            Image sample = new Bitmap("a.jpg");
            MemoryStream buf = new MemoryStream();
            sample.Save(buf, ImageFormat.Bmp);
            byte[] currentImage = buf.GetBuffer();

            int[] stats = new int[3];
            for (int i = 0; i < currentImage.Length;)
            {
                for (int j = 0; j < 3; j++)
                {
                    stats[j] += currentImage[i];
                    ++i;
                }
            }
            Console.WriteLine("Blue: " + stats[0]);
            Console.WriteLine("Green: " + stats[1]);
            Console.WriteLine("Red: " + stats[2]);
            if ((stats[0] > stats[1]) && (stats[0] > stats[2]))
                Console.WriteLine("This is a cold picture.");
            if ((stats[1] > stats[0]) && (stats[1] > stats[2]))
                Console.WriteLine("This is a summer picture.");
            if ((stats[2] > stats[0]) && (stats[2] > stats[1]))
                Console.WriteLine("This is a fiery picture.");

        }
    }
}
