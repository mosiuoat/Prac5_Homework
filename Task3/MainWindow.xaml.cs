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

// add thinkLib using directive here
namespace Task3
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
		int Largest(int[]nums)
		{
			return -1;
		}
		int Smallest(int[] nums)
		{
			return -1;
		}
		double Power(double powBase, double powExponent)
		{
			return 0.0;
		}

		double Floor(double number)
		{
			return 0.0;
		}

		double Ceiling(double number)
		{
			return 0.0;
		}
		private void btntests_Click(object sender, RoutedEventArgs e)
		{
			Tester.TestEq(Smallest(new int[] { 11, 77, 111, 99, 102, 99 }), 11);
			Tester.TestEq(Smallest(new int[] { }), -1);
			Tester.TestEq(Smallest(new int[] { -12, 5, 20 }), -12);
			Tester.TestEq(Smallest(new int[] { 5 }), 5);
			Tester.TestEq(Smallest(null), -1);
			Tester.TestEq(Smallest(new int[] { 15, 8, 19, 20 }), 8);

			Tester.TestEq(Largest(new int[] { 119, 77, 27, 111, 29 }), 119);
			Tester.TestEq(Largest(new int[] { }), -1);
			Tester.TestEq(Largest(new int[] { 127, -2 }), 127);
			Tester.TestEq(Largest(new int[] { 101 }), 101);
			Tester.TestEq(Largest(null), -1);
			Tester.TestEq(Largest(new int[] { 192, 2929, 11, 222, 19 }), 2929);

			Tester.TestEq(Power(5, 2), Math.Pow(5, 2));
			Tester.TestEq(Power(2, 0), Math.Pow(2, 0));
			Tester.TestEq(Power(-2, 1), Math.Pow(-2, 1));
			Tester.TestEq(Power(12, 4), Math.Pow(12, 4));

			Tester.TestEq(Floor(7.03), Math.Floor(7.03));
			Tester.TestEq(Floor(7.64), Math.Floor(7.64));
			Tester.TestEq(Floor(0.12), Math.Floor(0.12));
			Tester.TestEq(Floor(-0.12), Math.Floor(-0.12));
			Tester.TestEq(Floor(-7.1), Math.Floor(-7.1));
			Tester.TestEq(Floor(-7.6), Math.Floor(-7.6));

			Tester.TestEq(Ceiling(7.03), Math.Ceiling(7.03));
			Tester.TestEq(Ceiling(7.64), Math.Ceiling(7.64));
			Tester.TestEq(Ceiling(0.12), Math.Ceiling(0.12));
			Tester.TestEq(Ceiling(-0.12), Math.Ceiling(-0.12));
			Tester.TestEq(Ceiling(-7.1), Math.Ceiling(-7.1));
			Tester.TestEq(Ceiling(-7.6), Math.Ceiling(-7.6));
		}
	}
}
