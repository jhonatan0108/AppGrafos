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
            //validacion de campos
            if (string.IsNullOrEmpty(txt_Palab_Ini.Text.ToString())
                    || string.IsNullOrEmpty(txt_Palab_Fin.Text.ToString()))
            {
                MessageBox.Show("Debe informar todos los campos");
            }
            else
            {
                string _palabra1 = txt_Palab_Ini.Text.ToString();
                string _palabra2 = txt_Palab_Fin.Text.ToString();
                int val = int.Parse(combo_cantidad.SelectedItem.ToString().Substring(0, 2));

                //valido la cantidad de caracteres sea igual a la cantidad de caracteres de las palabras ingresadas.
                if (!(val != _palabra1.Length || val != _palabra2.Length))
                {
                    // Busco si las palabras ingresadas existen dentro de la base de datos.
                }
                else
                {
                    MessageBox.Show("la palabras ingresadas no tienen la longitud seleccionada [" + combo_cantidad.SelectedItem + "] . Por favor verificar ");
                }
            }
        }
    }
}
