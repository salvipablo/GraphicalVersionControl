using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GraphicalVersionControl
{
    /// <summary>
    /// Lógica de interacción para LoadVersionWindow.xaml
    /// </summary>
    public partial class LoadVersionWindow : Window
    {
        List<Descripciones> entradas;

        public LoadVersionWindow()
        {
            InitializeComponent();

            this.entradas = new List<Descripciones>();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int idProyect = int.Parse(txtIdProject.Text);

                addDescriptions(idProyect);

                cleanTextBoxes();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error no a cargado un numero correcto de proyecto: " + err.Message);
            }
        }

        private void addDescriptions(int id)
        {
            string vVersion = "";
            string vDescrip = "";
            Descripciones DescriptionVersion;

            int tot = gridComp.Children.Count;

            for (int i = 0; i < tot; i++)
            {
                if (gridComp.Children[i].GetType().Name.Equals("TextBox"))
                {
                    TextBox ss = (TextBox)gridComp.Children[i];
                    if ( i % 2 == 0 )
                    {
                        vVersion = ss.Text;
                    }
                    else
                    {
                        vDescrip = ss.Text;
                        if ( !vVersion.Equals("") && !vDescrip.Equals("") )
                        {
                            DescriptionVersion = new Descripciones(id, vVersion, vDescrip);
                            this.entradas.Add(DescriptionVersion);
                        }
                    }
                }
            }
        }

        private void cleanTextBoxes()
        {
            int tot = gridComp.Children.Count;

            for (int i = 0; i < tot; i++)
            {
                if (gridComp.Children[i].GetType().Name.Equals("TextBox"))
                {
                    TextBox ss = (TextBox)gridComp.Children[i];
                    ss.Text = "";
                }
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
            foreach ( Descripciones descrip in entradas )
            {
                MessageBox.Show("Numero de proyecto: " + descrip.getId() + ". Version: " + descrip.getVersion() + 
                    ". Descripcion: " + descrip.getDescripcion() + ".");
            }
            
        }
    }
}
