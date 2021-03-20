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
        public int LineOneValOne;
        public int LineOneValTwo;
        public int LineOneValThree;
        public int LineOneValFour;
        public int LineOneValFive;
        public int LineTwoValOne;
        public int LineTwoValTwo;
        public int LineTwoValThree;
        public int LineTwoValFour;
        public int LineTwoValFive;

        Random random = new Random();
        public bool spinning = false;
        private async Task Spin()
        {
            if (spinning == false)
            {
                spinning = true;
                if (userCredits >= bet)
                {
                    userCredits -= bet;
                    credits.Text = $"Credits: {userCredits}";
                    for (int i = 0; i < 26; i++)
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

                        if (i <= 17 && i > 10)
                        {
                            await Task.Delay(200);
                        }

                        if (i <= 22 && i > 17)
                        {
                            await Task.Delay(300);
                        }

                        if (i <= 25 && i > 22)
                        {
                            await Task.Delay(400);
                        }

                        total = 0;
                        LineOneValOne = wheel1val2;
                        LineOneValTwo = wheel2val2;
                        LineOneValThree = wheel3val2;
                        LineOneValFour = wheel4val2;
                        LineOneValFive = wheel5val2;
                        LineTwoValOne = wheel1Val3;
                        LineTwoValTwo = wheel2Val3;
                        LineTwoValThree = wheel3Val3;
                        LineTwoValFour = wheel4Val3;
                        LineTwoValFive = wheel5Val3;
                    }

                    //Win Table Line 1
                    //Single Win
                    if (LineOneValOne == 1) total += 1;
                    //Double Win
                    if (LineOneValOne == 1 && LineOneValTwo == 1) total += 3;
                    if (LineOneValOne == 2 && LineOneValTwo == 2) total += 3;
                    if (LineOneValOne == 3 && LineOneValTwo == 3) total += 3;
                    if (LineOneValOne == 4 && LineOneValTwo == 4) total += 3;
                    //Triple Win
                    if (LineOneValOne == 1 && LineOneValTwo == 1 && LineOneValThree == 1) total += 7;
                    if (LineOneValOne == 2 && LineOneValTwo == 2 && LineOneValThree == 2) total += 7;
                    if (LineOneValOne == 3 && LineOneValTwo == 3 && LineOneValThree == 3) total += 7;
                    if (LineOneValOne == 4 && LineOneValTwo == 4 && LineOneValThree == 4) total += 7;
                    //Quad Win
                    if (LineOneValOne == 1 && LineOneValTwo == 1 && LineOneValThree == 1 && LineOneValFour == 1) total += 12;
                    if (LineOneValOne == 2 && LineOneValTwo == 2 && LineOneValThree == 2 && LineOneValFour == 2) total += 12;
                    if (LineOneValOne == 3 && LineOneValTwo == 3 && LineOneValThree == 3 && LineOneValFour == 3) total += 12;
                    if (LineOneValOne == 4 && LineOneValTwo == 4 && LineOneValThree == 4 && LineOneValFour == 4) total += 12;
                    //Quint Win
                    if (LineOneValOne == 1 && LineOneValTwo == 1 && LineOneValThree == 1 && LineOneValFour == 1 && LineOneValFive == 1) total += 30;
                    if (LineOneValOne == 2 && LineOneValTwo == 2 && LineOneValThree == 2 && LineOneValFour == 2 && LineOneValFive == 2) total += 30;
                    if (LineOneValOne == 3 && LineOneValTwo == 3 && LineOneValThree == 3 && LineOneValFour == 3 && LineOneValFive == 3) total += 30;
                    if (LineOneValOne == 4 && LineOneValTwo == 4 && LineOneValThree == 4 && LineOneValFour == 4 && LineOneValFive == 4) total += 30;

                    //Win Table Line 2
                    //Single Win
                    if (LineTwoValOne == 1) total += 1;
                    //Double Win
                    if (LineTwoValOne == 1 && LineTwoValTwo == 1) total += 3;
                    if (LineTwoValOne == 2 && LineTwoValTwo == 2) total += 3;
                    if (LineTwoValOne == 3 && LineTwoValTwo == 3) total += 3;
                    if (LineTwoValOne == 4 && LineTwoValTwo == 4) total += 3;
                    //Triple Win
                    if (LineTwoValOne == 1 && LineTwoValTwo == 1 && LineTwoValThree == 1) total += 7;
                    if (LineTwoValOne == 2 && LineTwoValTwo == 2 && LineTwoValThree == 2) total += 7;
                    if (LineTwoValOne == 3 && LineTwoValTwo == 3 && LineTwoValThree == 3) total += 7;
                    if (LineTwoValOne == 4 && LineTwoValTwo == 4 && LineTwoValThree == 4) total += 7;
                    //Quad Win
                    if (LineTwoValOne == 1 && LineTwoValTwo == 1 && LineTwoValThree == 1 && LineTwoValFour == 1) total += 12;
                    if (LineTwoValOne == 2 && LineTwoValTwo == 2 && LineTwoValThree == 2 && LineTwoValFour == 2) total += 12;
                    if (LineTwoValOne == 3 && LineTwoValTwo == 3 && LineTwoValThree == 3 && LineTwoValFour == 3) total += 12;
                    if (LineTwoValOne == 4 && LineTwoValTwo == 4 && LineTwoValThree == 4 && LineTwoValFour == 4) total += 12;
                    //Quint Win
                    if (LineTwoValOne == 1 && LineTwoValTwo == 1 && LineTwoValThree == 1 && LineTwoValFour == 1 && LineTwoValFive == 1) total += 30;
                    if (LineTwoValOne == 2 && LineTwoValTwo == 2 && LineTwoValThree == 2 && LineTwoValFour == 2 && LineTwoValFive == 2) total += 30;
                    if (LineTwoValOne == 3 && LineTwoValTwo == 3 && LineTwoValThree == 3 && LineTwoValFour == 3 && LineTwoValFive == 3) total += 30;
                    if (LineTwoValOne == 4 && LineTwoValTwo == 4 && LineTwoValThree == 4 && LineTwoValFour == 4 && LineTwoValFive == 4) total += 30;

                    //Jackpot Win
                    if (LineTwoValOne == LineTwoValTwo && LineTwoValOne == LineTwoValThree &&
                        LineTwoValOne == LineTwoValFour && LineTwoValOne == LineTwoValFive &&
                        LineTwoValOne == LineOneValOne && LineTwoValOne == LineOneValTwo &&
                        LineTwoValOne == LineOneValThree && LineTwoValOne == LineOneValFour &&
                        LineTwoValOne == LineOneValFive) total += 1000;


                    userCredits += total * bet;
                    Win.Text = $"Win: {total * bet}";
                    credits.Text = $"Credits: {userCredits}";
                    if (userCredits == 0)
                    {
                        bet = userCredits;
                        BetDisplay.Text = $"Bet: {bet}";
                        MessageBox.Show("You have run out of credits!");
                    }
                }
                spinning = false;
            }
        }

        private async void SpinButton_Click(object sender, RoutedEventArgs e)
        {
            await Spin();
        }

        private void Decrease_Click(object sender, RoutedEventArgs e)
        {
            if (spinning == false)
            {
                if (userCredits >= bet - 1)
                {
                    bet -= 1;
                    if (bet < 1)
                    {
                        bet = 1;
                    }

                    BetDisplay.Text = $"Bet: {bet}";
                }

                if (userCredits <= bet - 1)
                {
                    MessageBox.Show("Sorry you don't have enough credits for this!");
                    bet = userCredits;
                    BetDisplay.Text = $"Bet: {bet}";
                }
            }
        }

        private void Increase_Click(object sender, RoutedEventArgs e)
        {
            if (!spinning)
            {
                if (userCredits >= bet + 1)
                {
                    bet += 1;
                    BetDisplay.Text = $"Bet: {bet}";
                }

                if (userCredits < bet + 1)
                {
                    MessageBox.Show("Sorry you don't have enough credits for this!");
                }
            }
        }

        private void Plus10_Click(object sender, RoutedEventArgs e)
        {
            if (!spinning)
            {
                if (userCredits >= bet + 10)
                {
                    bet += 10;
                    BetDisplay.Text = $"Bet: {bet}";
                }

                if (userCredits <= bet + 10)
                {
                    MessageBox.Show("You do not have enough credits for this!");
                }
            }
        }

        private void Plus5_Click(object sender, RoutedEventArgs e)
        {
            if (!spinning)
            {
                if (userCredits >= bet + 5)
                {
                    bet += 5;
                    BetDisplay.Text = $"Bet: {bet}";
                }

                if (userCredits <= bet + 5)
                {
                    MessageBox.Show("You do not have enough credits for this!");
                }
            }
        }

        private void Minus10_Click(object sender, RoutedEventArgs e)
        {
            if (!spinning)
            {
                if (userCredits >= bet - 10)
                {
                    bet -= 10;
                    if (bet < 1)
                    {
                        bet = 1;
                    }

                    BetDisplay.Text = $"Bet: {bet}";
                }

                if (userCredits <= bet - 10)
                {
                    bet = userCredits;
                    MessageBox.Show("You do not have enough credits for this!");
                }
            }
        }

        private void Minus5_Click(object sender, RoutedEventArgs e)
        {
            if (!spinning)
            {
                if (userCredits >= bet - 5)
                {
                    bet -= 5;
                    if (bet < 1)
                    {
                        bet = 1;
                    }

                    BetDisplay.Text = $"Bet: {bet}";
                }

                if (userCredits <= bet - 5)
                {
                    bet = userCredits;
                    MessageBox.Show("You do not have enough credits for this!");
                }
            }
        }

        private void MaxBetButton_Click(object sender, RoutedEventArgs e)
        {
            if (!spinning)
            {
                if (userCredits > 0)
                {
                    bet = userCredits;
                    BetDisplay.Text = $"Bet: {bet}";
                }

                if (userCredits == 0)
                {
                    MessageBox.Show("You are out of credits!");
                }
            }
        }
    }
}
