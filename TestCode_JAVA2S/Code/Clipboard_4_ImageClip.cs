//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ImageClip.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Clipboard
{ 
   public   class Clipboard_4_ImageClip:Form
    {
        MenuItem miCut, miCopy, miPaste, miDel;
        Image image;
        public   Clipboard_4_ImageClip()
       {


            Text = "Image Clip";

            MenuItem mi = new MenuItem("&Edit");
            mi.Popup += new EventHandler(MenuEditOnPopup);
            Menu.MenuItems.Add(mi);
            int index = Menu.MenuItems.Count - 1;

            miCut = new MenuItem("Cu&t");
            miCut.Click += new EventHandler(MenuEditCutOnClick);
            miCut.Shortcut = Shortcut.CtrlX;
            Menu.MenuItems[index].MenuItems.Add(miCut);

            miCopy = new MenuItem("&Copy");
            miCopy.Click += new EventHandler(MenuEditCopyOnClick);
            miCopy.Shortcut = Shortcut.CtrlC;
            Menu.MenuItems[index].MenuItems.Add(miCopy);

            miPaste = new MenuItem("&Paste");
            miPaste.Click += new EventHandler(MenuEditPasteOnClick);
            miPaste.Shortcut = Shortcut.CtrlV;
            Menu.MenuItems[index].MenuItems.Add(miPaste);

            miDel = new MenuItem("De&lete");
            miDel.Click += new EventHandler(MenuEditDelOnClick);
            miDel.Shortcut = Shortcut.Del;
            Menu.MenuItems[index].MenuItems.Add(miDel);
        }
        void MenuEditOnPopup(object obj, EventArgs ea)
        {
            miCut.Enabled = miCopy.Enabled = miDel.Enabled = image != null;
            IDataObject data = Clipboard.GetDataObject();
            miPaste.Enabled = data.GetDataPresent(typeof(Bitmap)) || data.GetDataPresent(typeof(Metafile));
        }
        void MenuEditCutOnClick(object obj, EventArgs ea)
        {
            MenuEditCopyOnClick(obj, ea);
            MenuEditDelOnClick(obj, ea);
        }
        void MenuEditCopyOnClick(object obj, EventArgs ea)
        {
            Clipboard.SetDataObject(image, true);
        }
        void MenuEditPasteOnClick(object obj, EventArgs ea)
        {
            IDataObject data = Clipboard.GetDataObject();

            if (data.GetDataPresent(typeof(Metafile)))
                image = (Image)data.GetData(typeof(Metafile));

            else if (data.GetDataPresent(typeof(Bitmap)))
                image = (Image)data.GetData(typeof(Bitmap));

            Invalidate();
        }
        void MenuEditDelOnClick(object obj, EventArgs ea)
        {
            image = null;
            Invalidate();
        }
    }
}
