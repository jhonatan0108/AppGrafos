using AplicacionGrafos.Business;
using AplicacionGrafos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionGrafos.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Btn_Accion_Click(object sender, EventArgs e)
        {
            #region Declaracion de Variables
            bool exitsP1 = false;
            bool exitsP2 = false;
            string _palabra1 = string.Empty;
            string _palabra2 = string.Empty;
            int val = 0;
            Dir_Palabras_Business _bll = new Dir_Palabras_Business();
            List<Dir_Palabras_Model> _ListPalabras = new List<Dir_Palabras_Model>();
            List<Dir_Palabras_Model> _ListPalabras2 = new List<Dir_Palabras_Model>();
            List<Dir_Palabras_Model> _result = new List<Dir_Palabras_Model>();
            #endregion

            //validacion de campos
            if (string.IsNullOrEmpty(txt_Palab_Ini.Text.ToString())
                    || string.IsNullOrEmpty(txt_Palab_Fin.Text.ToString()))
            {
                MessageBox.Show("Debe informar todos los campos");
            }
            else
            {
                try
                {
                    _palabra1 = txt_Palab_Ini.Text.ToString();
                    _palabra2 = txt_Palab_Fin.Text.ToString();
                    val = int.Parse(combo_cantidad.SelectedItem.ToString().Substring(0, 2));

                    //valido la cantidad de caracteres sea igual a la cantidad de caracteres de las palabras ingresadas.
                    if (!(val != _palabra1.Length || val != _palabra2.Length))
                    {
                        // Busco si las palabras ingresadas existen dentro de la base de datos.
                        #region Consulta de Palabras
                        exitsP1 = _bll.Get_Palabra(_palabra1, val);
                        exitsP2 = _bll.Get_Palabra(_palabra2, val);
                        #endregion
                        //Si existen las dos palabras empiezo a hacer la logica para evaluar las palabras
                        if (exitsP1 && exitsP2)
                        {
                            _ListPalabras = _ResultPalabras(_palabra1, _palabra2);
                            //recursividad
                            _ListPalabras2 = _ResultPalabras(_palabra2, _palabra1);
                            _result = _ListPalabras.Concat(_ListPalabras2).OrderBy(x => x.Id).ToList();
                            dataGridView1.DataSource = _result;
                            MessageBox.Show("Consultados Exitosamente.", "Exito!");
                        }
                        else
                        {
                            dataGridView1.DataSource = null;
                            MessageBox.Show("la palabras ingresadas No existen en el diccionario, Por favor verificar ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("la palabras ingresadas no tienen la longitud seleccionada [" + combo_cantidad.SelectedItem + "] . Por favor verificar ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private List<Dir_Palabras_Model> _ResultPalabras(string p1, string p2)
        {
            List<Dir_Palabras_Model> _listResult = new List<Dir_Palabras_Model>();
            Alfabeto_Model m = new Alfabeto_Model();
            Dir_Palabras_Business _bll = new Dir_Palabras_Business();
            //Recorro la palabra uno para empezar a reemplazar 
            try
            {
                string letra = string.Empty;
                string letra2 = string.Empty;
                bool isVocal = false;
                string pResult = string.Empty;

                for (int j = 0; j < p1.Length; j++)
                {
                    for (int k = j; k < p2.Length; k++)
                    {
                        letra = p1.Substring(j, 1);
                        letra2 = p2.Substring(k, 1);
                        isVocal = m.isVocal(letra);
                        if (!isVocal)
                        {
                            foreach (var item in m.Consonantes)
                            {
                                StringBuilder sb = new StringBuilder(p1);
                                sb[j] = char.Parse(item.ToString());
                                pResult = sb.ToString();

                                //Busco si la palabra tiene significado
                                if (_bll.Get_Palabra(pResult, pResult.Length))
                                {
                                    var checklist = _listResult.Where(x => x.Palabra == pResult).ToList();
                                    if (!(letra.Equals(letra2)) && checklist.Count == 0)
                                    {
                                        //agrego la palabra a lista resultante
                                        Dir_Palabras_Model ob = new Dir_Palabras_Model();
                                        ob.Cant_Letras = pResult.Length;
                                        ob.Id = j + 1;
                                        ob.Palabra = pResult.ToString().Trim();
                                        _listResult.Add(ob);
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (var item in m.Vocales)
                            {
                                StringBuilder sb = new StringBuilder(p1);
                                sb[j] = char.Parse(item.ToString());
                                pResult = sb.ToString();
                                if (pResult != p1)
                                {
                                    //Busco si la palabra tiene significado
                                    if (_bll.Get_Palabra(pResult, pResult.Length))
                                    {
                                        var checklist = _listResult.Where(x => x.Palabra == pResult).ToList();
                                        if (!(letra.Equals(letra2)) && checklist.Count == 0)
                                        {
                                            //agrego la palabra a lista resultante
                                            Dir_Palabras_Model ob = new Dir_Palabras_Model();
                                            ob.Cant_Letras = pResult.Length;
                                            ob.Id = j + 1;
                                            ob.Palabra = pResult.ToString().Trim();
                                            _listResult.Add(ob);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return _listResult;
            }
            catch
            {
                throw;
            }
        }
    }
}
