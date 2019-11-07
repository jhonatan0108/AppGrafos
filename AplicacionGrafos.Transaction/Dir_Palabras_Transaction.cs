using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionGrafos.Model;
using AplicacionGrafos.Transaction.Data;

namespace AplicacionGrafos.Transaction
{
    public class Dir_Palabras_Transaction
    {
        public Dir_Palabras_Model GetPalabra(string value, int cant)
        {
            PalabrasEntities db = new PalabrasEntities();
            Dir_Palabras_Model pa = new Dir_Palabras_Model();
            try
            {
                var a = db.Dir_Palabras.Where(x => x.Palabra == value && x.Cant_Letras == cant).FirstOrDefault();
                if (a != null)
                {
                    pa.Id = a.id;
                    pa.Palabra = a.Palabra;
                    pa.Cant_Letras = a.Cant_Letras;
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message.ToString());
            }
            return pa;
        }
    }
}
