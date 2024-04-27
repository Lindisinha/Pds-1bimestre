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
    /// Lógica interna para telaInicial.xaml
    /// </summary>
    public partial class telaInicial : Window
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cadsEscola cadsEscola = new cadsEscola();
            this.Close();
            cadsEscola.ShowDialog();  
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            cadsAluno cadsAluno = new cadsAluno();
            this.Close();
            cadsAluno.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            cadsCurso cadsCurso = new cadsCurso();
            this.Close();
            cadsCurso.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            cadsTurma cadsTurma = new cadsTurma();
            this.Close();
            cadsTurma.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            consEscola consEscola = new consEscola();
            this.Close();
            consEscola.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            consAlunos consAlunos = new consAlunos();
            this.Close();
            consAlunos.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            consCurso consCurso = new consCurso();
            this.Close();
            consCurso.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            consTurma consTurma = new consTurma();
            this.Close();
            consTurma.ShowDialog();
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MainWindow CadastroConta = new MainWindow();
            this.Close();
            CadastroConta.ShowDialog();
        }
    }
}
