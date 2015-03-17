using Novacode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Uno
    {

        public void Saving(string fileName, string salvar, string daysHere, string addMonday) {

            if (!File.Exists(fileName))
            {
                var doc1 = DocX.Create(fileName);
                doc1.Save();
            }

            // Create a document in memory:
            var doc = DocX.Load(fileName);
            string headlineText = daysHere + addMonday;

            // A formatting object for our headline:
            var headLineFormat = new Formatting();
            headLineFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            headLineFormat.Size = 18D;
            //headLineFormat.Position = 12;

            // A formatting object for our normal paragraph text:
            var paraFormat = new Formatting();
            paraFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            paraFormat.Size = 11D;

            // Insert the now text obejcts;
            doc.InsertParagraph(headlineText, false, headLineFormat);
            doc.InsertParagraph(salvar, false, paraFormat);

            // Save to the output directory:
            doc.Save();
        
        }

    }
}
