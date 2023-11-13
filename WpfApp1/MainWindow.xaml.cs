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

namespace HospitalExe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int sumOfRisks = 0;
        private void factorOneThreeFound(object sender, RoutedEventArgs e)
        {
            factorOneThree.IsChecked = true;
            sumOfRisks += 3;
        }
        private void factorOneFourFound(object sender, RoutedEventArgs e)
        {
            factorOneFour.IsChecked = true;
            sumOfRisks += 3;
        }

        private void factorOneSixFound(object sender, RoutedEventArgs e)
        {
            factorOneSix.IsChecked = true;
            sumOfRisks += 1;
        }

        private void factorOneOne_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 4;
        }

        private void factorOneTwo_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 3;
        }

        private void factorOneThree_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 3;
        }

        private void factorOneFour_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 3;
        }

        private void factorOneFive_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorOneSix_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorOneSeven_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorOneEightOne_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorOneEightTwo_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 2;
        }

        private void factorOneNine_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorOneTen_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorOneEleven_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorTwoOne_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factroTwoTwo_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorTwoThree_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorTwoFour_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 2;
        }

        private void factorTwoFive_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorTwoSix_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorTwoSeven_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorTwoEight_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorTwoNine_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorTwoTen_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorThreeOne_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 3;
        }

        private void factorThreeTwo_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 3;
        }

        private void factorThreeThree_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 4;
        }

        private void factorThreeFour_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }

        private void factorThreeFive_Checked(object sender, RoutedEventArgs e)
        {
            sumOfRisks += 1;
        }
        double weightValue;
        double heightValue;


        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(weight.Text, out weightValue) && double.TryParse(height.Text, out heightValue))
            {
                if (heightValue != 0)
                {
                    imt.Text = (weightValue / ((heightValue * heightValue) / 10000)).ToString();
                }
            }
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            if(sumOfRisks == 0 || sumOfRisks == 1) {
                recOne.Text = "Компрессионный трикотаж или эластическое бинтование конечностей";
                recTwo.Text = "Ранняя активизация после родов и адекватная гидратация.";
            } else if (sumOfRisks == 2)
            {
                recOne.Text = "Компрессионный трикотаж или эластическое бинтование конечностей";
                recTwo.Text = "Ранняя активизация после родов и адекватная гидратация";
                if(weightValue < 50)
                {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 20 мг. - 1 р/д подкожно в течение 10 дней после родов"; 
                } else if(weightValue >= 50 && weightValue <= 90) {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 40 мг. - 1 р / д подкожно в течение 10 дней после родов";
                } else if(weightValue >= 91 &&  weightValue <= 130)
                {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 60 мг. - 1 р/д подкожно в течение 10 дней после родов";
                } else if(weightValue <= 131 && weightValue >= 170)
                {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 80 мг. - 1 р/д подкожно в течение 10 дней после родов";
                } else if(weightValue > 170)
                {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 0,6 мг/кг - 1 р/д подкожно в течение 10 дней после родов";
                }
            } else if(sumOfRisks == 3)
            {
                recOne.Text = "Компрессионный трикотаж или эластическое бинтование конечностей";
                recTwo.Text = "Ранняя активизация после родов и адекватная гидратация.";
                if(weightValue < 50)
                {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 20 мг. - 1 р/д подкожно с 28-ой недели беременности до родов в течение 6 недель после родов";
                
                } else if(weightValue >= 50 && weightValue <= 90)
                {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 40 мг. - 1 р/д подкожно с 28-ой недели беременности до родов в течение 6 недель после родов";
                } else if (weightValue >= 91 && weightValue <= 130)
                {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 60 мг. - 1 р/д подкожно с 28-ой недели беременности до родов в течение 6 недель после родов";
                } else if(weightValue >= 131 && weightValue <= 170)
                {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 80 мг. - 1 р/д подкожно с 28-ой недели беременности до родов в течение 6 недель после родов";
                } else if (weightValue > 170) {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 0,6 мг/кг - 1 р/д подкожно с 28-ой недели беременности до родов в течение 6 недель после родов";
                }
            } else if(sumOfRisks == 4)
            {
                recOne.Text = "Компрессионный трикотаж или эластическое бинтование конечностей";
                recTwo.Text = "Ранняя активизация после родов и адекватная гидратация";
                if (weightValue < 50)
                {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 20 мг. - 1 р/д подкожно в течении всей беременности до конца родов и 6 недель послеродового периода";
                } else if (weightValue >= 50 && weightValue <= 90)
                {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 40 мг. - 1 р/д подкожно в течении всей беременности до конца родов и 6 недель послеродового периода";
                } else if(weightValue >= 91 && weightValue <= 130)
                {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 60 мг. - 1 р/д подкожно в течении всей беременности до конца родов и 6 недель послеродового периода";
                } else if (weightValue >= 131 && weightValue <= 170)
                {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 80 мг. - 1 р/д подкожно в течении всей беременности до конца родов и 6 недель послеродового периода";
                } else if(weightValue > 170)
                {
                    recThree.Text = "Назначение НМГ: Эноксапарин натрия в дозировке 0,6 мг/кг - 1 р/д подкожно в течении всей беременности до конца родов и 6 недель послеродового периода";
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            point.Text = sumOfRisks.ToString();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if(sumOfRisks == 0 || sumOfRisks == 1)
            {
                group.Text = "Низкий риск";
            } else if(sumOfRisks == 2)
            {
                group.Text = "Средний риск";
            } else if(sumOfRisks == 3 || sumOfRisks == 4)
            {
                group.Text = "Высокий риск";
            }
        }
    }
    }
    

