using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Anubhav.ImagrLib
{
    public sealed class Resize
    {
        public void GetThumbnail(Stream BigImageStream, bool IsDefaultSquare = false, int Height = 48, int Width = 64)
        {
            if (IsDefaultSquare)
            {
                Height = Width = 64;
            }

            Image thumb = Image.FromStream(BigImageStream, true, true);
            thumb.Save("C:\\image",ImageFormat.Png);
            

            

        }
    }
}
