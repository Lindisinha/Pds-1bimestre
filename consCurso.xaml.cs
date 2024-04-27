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
    /// Lógica interna para consCurso.xaml
    /// </summary>
    public partial class consCurso : Window
    {
        public consCurso()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            telaInicial telaInicial = new telaInicial();
            this.Close();
            telaInicial.ShowDialog();
        }
    }
}
