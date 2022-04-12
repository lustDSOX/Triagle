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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mane_border.MouseLeftButtonDown += Mane_border_MouseLeftButtonDown;
    }

        private void Mane_border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void one_st_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Check(one_st.Text)) one_st.Text = "";
            Update();
        }

        private void two_st_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Check(two_st.Text)) two_st.Text = "";
            Update();
        }

        private void three_st_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Check(three_st.Text)) three_st.Text = "";
            Update();
        }

        private void Update()
        {
            if (one_st.Text == "" || two_st.Text == "" || three_st.Text == "") Otvet.Content = "";

            if(one_st.Text != "" & two_st.Text != "" & three_st.Text != "")
            {
                double a = Convert.ToDouble(one_st.Text);
                double b = Convert.ToDouble(two_st.Text);
                double c = Convert.ToDouble(three_st.Text);
                if (a+b>c & a+c>b & b+c>a)
                {
                    if (one_st.Text == two_st.Text || one_st.Text == three_st.Text || two_st.Text == three_st.Text) Otvet.Content = "Равнобедренный";
                    if (one_st.Text == two_st.Text & two_st.Text == three_st.Text) Otvet.Content = "Равносторонний";
                    if (one_st.Text != two_st.Text & one_st.Text != three_st.Text & two_st.Text != three_st.Text) Otvet.Content = "Разносторонний";
                }
                else
                {
                    Otvet.Content = "Такого треугольника не сущестует";
                }
            }
        }

        private bool Check(string text)
        {
            try
            {
                double a = Convert.ToDouble(text);
                return true;
            }
            catch (System.FormatException)
            {
                return false;
            }
        }


    }
}
