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

namespace CalculateResistance
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cal_Click(object sender, RoutedEventArgs e)
        {
            RGet.Text = "";

            if (V1.Text!=""&&V2.Text!=""&&RSet.Text!="")
            {
                try
                {
                    double V1Value = Convert.ToDouble(V1.Text);
                    double V2Value = Convert.ToDouble(V2.Text);
                    double RSetValue = Convert.ToDouble(RSet.Text);

                    if(SelectFromTwo.SelectedIndex==0)
                    {
                        resultName.Text = "R2=";

                        double R2Value = RSetValue * V2Value / (V1Value - V2Value);
                        RGet.Text = Math.Round(R2Value, 1).ToString();
                    }
                    else if(SelectFromTwo.SelectedIndex==1)
                    {
                        resultName.Text = "R1=";

                        double R1Value = RSetValue * (V1Value - V2Value)  / V2Value;
                        RGet.Text = Math.Round(R1Value, 1).ToString();
                    }
                   
                }
                catch
                {
                    MessageBox.Show("输入错误！");
                }
            }
            else
            {
                MessageBox.Show("输入不得为空！");
            }
        }

        private void cal1_Click(object sender, RoutedEventArgs e)
        {
            RGet1.Text = "";
            RGet2.Text = "";

            if (V11.Text != "" && V21.Text != "" && V31.Text != "" && RSet1.Text != "")
            {
                try
                {
                    double V11Value = Convert.ToDouble(V11.Text);
                    double V21Value = Convert.ToDouble(V21.Text);
                    double V31Value = Convert.ToDouble(V31.Text);
                    double RSet1Value = Convert.ToDouble(RSet1.Text);

                    if(SelectFromThree.SelectedIndex==0)
                    {
                        resultName1.Text = "R2=";
                        resultName2.Text = "R3=";

                        double R21Value = (V21Value - V31Value) * RSet1Value / (V11Value - V21Value);
                        double R31Value = V31Value * RSet1Value / (V11Value - V21Value);
                        RGet1.Text = Math.Round(R21Value, 1).ToString();
                        RGet2.Text = Math.Round(R31Value, 1).ToString();

                    }
                    else if (SelectFromThree.SelectedIndex == 1)
                    {
                        resultName1.Text = "R1=";
                        resultName2.Text = "R3=";

                        double R11Value = (V11Value - V21Value) * RSet1Value / (V21Value - V31Value);
                        double R31Value = V31Value * RSet1Value / (V21Value - V31Value);
                        RGet1.Text = Math.Round(R11Value, 1).ToString();
                        RGet2.Text = Math.Round(R31Value, 1).ToString();

                    }
                    else if (SelectFromThree.SelectedIndex == 2)
                    {
                        resultName1.Text = "R1=";
                        resultName2.Text = "R2=";

                        double R11Value = (V11Value - V21Value) * RSet1Value / V31Value;
                        double R21Value = (V21Value - V31Value) * RSet1Value / V31Value;
                        RGet1.Text = Math.Round(R11Value, 1).ToString();
                        RGet2.Text = Math.Round(R21Value, 1).ToString();

                    }

                }
                catch
                {
                    MessageBox.Show("输入错误！");
                }
            }
            else
            {
                MessageBox.Show("输入不得为空！");
            }
        }


       
    }
}
