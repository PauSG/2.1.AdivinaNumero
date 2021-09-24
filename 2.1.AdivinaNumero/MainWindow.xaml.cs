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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int numero = 0;
        public MainWindow()
        {
            InitializeComponent();
            
            numero = rnd.Next(0, 101);
        }

        private void ComprobarNumero_click(object sender, RoutedEventArgs e)
        {
            if(int.Parse(TextoTextBox.Text) == numero) 
            {
                TextoTextBlock.Text = "Has acertado el numero!!";
            }
            else if(int.Parse(TextoTextBox.Text) > numero)
            {
                TextoTextBlock.Text = "Te has pasado!";
                TextoTextBox.Text = "";
            }
            else
            {
                TextoTextBlock.Text = "Te has quedado corto!";
                TextoTextBox.Text = "";//esta linea es para que se vacie el textbox para que el usuario entienda que se ha enviado el numero.
            }
            
        }

        private void Reiniciar_click(object sender, RoutedEventArgs e)
        {
            numero = rnd.Next(0, 101);
            TextoTextBlock.Text = "Adivina el número";

        }
    }
}
