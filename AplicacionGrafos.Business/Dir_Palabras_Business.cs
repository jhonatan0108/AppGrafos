using AplicacionGrafos.Model;
using AplicacionGrafos.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionGrafos.Business
{
    public class Dir_Palabras_Business
    {
        public bool Get_Palabra(string value, int cant)
        {
            Dir_Palabras_Transaction _trn = new Dir_Palabras_Transaction();
            Dir_Palabras_Model _pa = new Dir_Palabras_Model();
            bool pResp = false;
            try
            {
                _pa = _trn.GetPalabra(value.ToString().Trim(), cant);
                if (_pa.Palabra != null)
                    pResp = true;
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
            return pResp;
        }
    }
}
