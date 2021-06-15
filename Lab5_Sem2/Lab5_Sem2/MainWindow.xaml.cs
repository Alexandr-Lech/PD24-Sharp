using System.Windows;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ButtonsAdd gfb = new ButtonsAdd(textBox2);
            gfb.Draw(gridForButtons);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "")
            {
                comboBox.Items.Add(textBox.Text);
                textBox.Text = "";
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (comboBox.Items.Count != 0)
                comboBox.Items.RemoveAt(comboBox.Items.Count - 1);

        }
    }
    public class ButtonsAdd
    {
        private List<Button> Buttons = new List<Button>();
        private sbyte buttons = 16;
        private sbyte count = 0;
        private object Result;

        public ButtonsAdd(object Result)
        {
            for (int i = 0; i < buttons; i++)
            {
                Buttons.Add(new Button());

                Buttons[i].Content = (i + 1).ToString();

                Buttons[i].Width = 90;
                Buttons[i].Height = 30;
                Buttons[i].Click += btn_handler;


            }

            this.Result = (Result);
        }

        public void Draw(Grid getter)
        {
            sbyte x = 0, y = 0;

            for (int i = 0; i < buttons; i++)
            {
                Grid.SetColumn(Buttons[i], 0 + x);
                Grid.SetRow(Buttons[i], 0 + y);
                getter.Children.Add(Buttons[i]);

                x++;
                if ((i + 1) % 4 == 0)
                {
                    y++;
                    x = 0;
                }
            }

        }

        private void resetHidingButtons()
        {
            for (int i = 0; i < buttons; i++)
                if (Buttons[i].Visibility == Visibility.Hidden)
                    Buttons[i].Visibility = Visibility.Visible;
            count = 0;
        }

        private void btn_handler(object sender, EventArgs e)
        {
            if (count == (buttons - 1))
            {
                (Result as TextBox).Text = "Молодець!!!";
                resetHidingButtons();
            }
            else
                (Result as TextBox).Text = "";

            if ((sender as Button).Content.ToString() == (count + 1).ToString())
            {
                (sender as Button).Visibility = Visibility.Hidden;
                count++;
            }
            else
            {
                resetHidingButtons();
                count = 0;
            }
        }
    }
}