using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Schema;
using Random = System.Random;

namespace Slot_Machine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            credits.Text = $"Credits: {userCredits}";
        }

        private int total = 0;

        public int userCredits = 1000;

        public int bet = 10;
        //Wheel 1
        public int wheel1val1 = 1;
        public int wheel1val2 = 2;
        public int wheel1Val3 = 3;
        public int wheel1val4 = 4;
        //Wheel 2
        public int wheel2val1 = 2;
        public int wheel2val2 = 3;
        public int wheel2Val3 = 4;
        public int wheel2val4 = 1;
        //Wheel 3
        public int wheel3val1 = 3;
        public int wheel3val2 = 4;
        public int wheel3Val3 = 1;
        public int wheel3val4 = 2;
        //Wheel 4
        public int wheel4val1 = 4;
        public int wheel4val2 = 1;
        public int wheel4Val3 = 2;
        public int wheel4val4 = 3;
        //Wheel 5
        public int wheel5val1 = 1;
        public int wheel5val2 = 2;
        public int wheel5Val3 = 3;
        public int wheel5val4 = 4;
        //Win Values
        public int wheel1;
        public int wheel2;
        public int wheel3;
        public int wheel4;
        public int wheel5;

        Random random = new Random();
        private async Task Spin()
        {
            if (userCredits >= bet)
            {
                userCredits -= bet;
                credits.Text = $"Credits: {userCredits}";
                for (int i = 0; i < 36; i++)
                {
                    //Spin Wheel 1
                    wheel1val1 = wheel1val2;
                    wheel1val2 = wheel1Val3;
                    wheel1Val3 = wheel1val4;
                    wheel1val4 = random.Next(1, 5);
                    _1_1.Source = (ImageSource) FindResource($"{wheel1val1}");
                    _1_2.Source = (ImageSource) FindResource($"{wheel1val2}");
                    _1_3.Source = (ImageSource) FindResource($"{wheel1Val3}");
                    _1_4.Source = (ImageSource) FindResource($"{wheel1val4}");
                    //Spin Wheel 2
                    wheel2val1 = wheel2val2;
                    wheel2val2 = wheel2Val3;
                    wheel2Val3 = wheel2val4;
                    wheel2val4 = random.Next(1, 5);
                    _2_1.Source = (ImageSource) FindResource($"{wheel2val1}");
                    _2_2.Source = (ImageSource) FindResource($"{wheel2val2}");
                    _2_3.Source = (ImageSource) FindResource($"{wheel2Val3}");
                    _2_4.Source = (ImageSource) FindResource($"{wheel2val4}");
                    //Spin Wheel 3
                    wheel3val1 = wheel3val2;
                    wheel3val2 = wheel3Val3;
                    wheel3Val3 = wheel3val4;
                    wheel3val4 = random.Next(1, 5);
                    _3_1.Source = (ImageSource) FindResource($"{wheel3val1}");
                    _3_2.Source = (ImageSource) FindResource($"{wheel3val2}");
                    _3_3.Source = (ImageSource) FindResource($"{wheel3Val3}");
                    _3_4.Source = (ImageSource) FindResource($"{wheel3val4}");
                    //Spin Wheel 4
                    wheel4val1 = wheel4val2;
                    wheel4val2 = wheel4Val3;
                    wheel4Val3 = wheel4val4;
                    wheel4val4 = random.Next(1, 5);
                    _4_1.Source = (ImageSource) FindResource($"{wheel4val1}");
                    _4_2.Source = (ImageSource) FindResource($"{wheel4val2}");
                    _4_3.Source = (ImageSource) FindResource($"{wheel4Val3}");
                    _4_4.Source = (ImageSource) FindResource($"{wheel4val4}");
                    //Spin Wheel 5
                    wheel5val1 = wheel5val2;
                    wheel5val2 = wheel5Val3;
                    wheel5Val3 = wheel5val4;
                    wheel5val4 = random.Next(1, 5);
                    _5_1.Source = (ImageSource) FindResource($"{wheel5val1}");
                    _5_2.Source = (ImageSource) FindResource($"{wheel5val2}");
                    _5_3.Source = (ImageSource) FindResource($"{wheel5Val3}");
                    _5_4.Source = (ImageSource) FindResource($"{wheel5val4}");
                    if (i <= 10)
                    {
                        await Task.Delay(100);
                    }

                    if (i <= 20 && i > 10)
                    {
                        await Task.Delay(200);
                    }

                    if (i <= 30 && i > 20)
                    {
                        await Task.Delay(300);
                    }

                    if (i <= 35 && i > 30)
                    {
                        await Task.Delay(400);
                    }

                    total = 0;
                    wheel1 = wheel1val2;
                    wheel2 = wheel2val2;
                    wheel3 = wheel3val2;
                    wheel4 = wheel4val2;
                    wheel5 = wheel5val2;
                }
                //Win Table
                //Single Win
                if (wheel1 == 1) total += 5;
                //Double Win
                if (wheel1 == 1 && wheel2 == 1) total += 10;
                if (wheel1 == 2 && wheel2 == 2) total += 12;
                if (wheel1 == 3 && wheel2 == 3) total += 14;
                if (wheel1 == 4 && wheel2 == 4) total += 16;
                //Triple Win
                if (wheel1 == 1 && wheel2 == 1 && wheel3 == 1) total += 20;
                if (wheel1 == 2 && wheel2 == 2 && wheel3 == 2) total += 24;
                if (wheel1 == 3 && wheel2 == 3 && wheel3 == 3) total += 28;
                if (wheel1 == 4 && wheel2 == 4 && wheel3 == 4) total += 32;
                //Quad Win
                if (wheel1 == 1 && wheel2 == 1 && wheel3 == 1 && wheel4 == 1) total += 30;
                if (wheel1 == 2 && wheel2 == 2 && wheel3 == 2 && wheel4 == 2) total += 40;
                if (wheel1 == 3 && wheel2 == 3 && wheel3 == 3 && wheel4 == 3) total += 50;
                if (wheel1 == 4 && wheel2 == 4 && wheel3 == 4 && wheel4 == 4) total += 75;
                //Quint Win
                if (wheel1 == 1 && wheel2 == 1 && wheel3 == 1 && wheel4 == 1 && wheel5 == 1) total += 50;
                if (wheel1 == 2 && wheel2 == 2 && wheel3 == 2 && wheel4 == 2 && wheel5 == 2) total += 70;
                if (wheel1 == 3 && wheel2 == 3 && wheel3 == 3 && wheel4 == 3 && wheel5 == 3) total += 90;
                if (wheel1 == 4 && wheel2 == 4 && wheel3 == 4 && wheel4 == 4 && wheel5 == 4) total += 125;

                userCredits += total;
                Win.Text = $"Win: {total}";
                credits.Text = $"Credits: {userCredits}";
            }
        }

        private async void SpinButton_Click(object sender, RoutedEventArgs e)
        {
           await Spin();
        }
    }
}
