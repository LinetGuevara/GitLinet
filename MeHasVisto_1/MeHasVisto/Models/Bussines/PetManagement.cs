using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Web;

namespace MeHasVisto.Models.Bussines
{
    public class PetManagement
    {
        public static void CreateThumbNail(
            string fileName, string filePath,
            int thumbWi, int thumbHi,
            bool maintainAspec)
        {
            //No hacer  nada si el tama;o
            //Original es mas peque;o que
            //el designado para la
            //vista previa(thumbnail)

            var originalFile = Path.Combine(filePath,
                fileName);
            var source = Image.FromFile(originalFile);
            if (source.Width <= thumbWi && //Nos pregunta si el tamaño de la imagen es mas chica en ancho y alto no hagas nada
                source.Height <= thumbHi)
                return;

              Bitmap thumbnail;
        try
    {
        int wi = thumbWi;
        int hi = thumbHi;
        if(maintainAspec)
    {
        //Mantener el aspecto a pesar
        //de los parametros de tamaño
        //de la vista previa
         wi =thumbWi;

        hi = (int)(source.Height *
            ((decimal)thumbWi / source.Width));
    }
    else
    {
       hi = thumbHi;
       wi =(int)(source.Width *
           ((decimal)thumbHi /source.Height));
    }

    thumbnail = new Bitmap(wi, hi);
    using(Graphics g = Graphics.FromImage(thumbnail))
    {
      g.InterpolationMode =
        InterpolationMode.HighQualityBicubic;
       g.FillRectangle(Brushes.Transparent,
        0, 0,
       wi,  hi);

    g.DrawImage(source, 0,0, wi, hi);
    }
    var thumbnailName = Path.Combine(filePath,
       "thumbnail_" + fileName);
    thumbnail.Save(thumbnailName);
    }
    catch
     {
     }
        }

    }
}