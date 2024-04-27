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

namespace pds_projeto_escola
{
    /// <summary>
    /// Lógica interna para ConectarConta.xaml
    /// </summary>
    public partial class ConectarConta : Window
    {
        public ConectarConta()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow cadastrarConta = new MainWindow();
            this.Close();
            cadastrarConta.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            telaInicial telaInicial = new telaInicial();
            this.Close();
            telaInicial.ShowDialog();
        }
    }
}
