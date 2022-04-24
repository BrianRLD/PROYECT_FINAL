using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        String Usuario = "Brianamparo13@gmail.com";
        String Constraseña = "20210482";


        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ////ENLAZAR FORMULARIOS
            

            //////programar cajas de texto
            String User= txtUsuario.Text;
            String password= txtContraseña.Text;
            if (User.Equals(Usuario)) 
            {
                if (password.Equals(Constraseña))
                {
                    MessageBox.Show("ACCESO EXISTOSO AL SISTEMA");
                    Form1 formulario1 = new Form1();
                    formulario1.ShowDialog();
                }

                    
               else
                {
                MessageBox.Show("La contraseña es incorrecta");

                }
                }
                    
                    else
                    {
                        MessageBox.Show("no se reconoce Usuario");
                    }
                }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        }
  
   




