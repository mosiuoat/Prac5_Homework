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

// add thinklib using directive here
namespace TASK4
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Turtle tess;
		public MainWindow()
		{
			InitializeComponent();

			// You can assume that the Turtle always start from the origin
			tess = new Turtle(canvas, 0, 0);
		}
		double calcDistance(Point p, Point q)
		{
			return 0.0;
		}
		double calcTotalDistance(FootprintCollection fps)
		{
			return 0.0;
		}
		void stamp(Turtle t)
		{
			t.Stamp();
		}

		void warpTo(Turtle t, Point p)
		{
			t.WarpTo(p.X, p.Y);
		}
		private void btnWarp_Click(object sender, RoutedEventArgs e)
		{
			// check first that something is entered in the text boxes
			if (txtXPos.Text.Length > 0 && txtYPos.Text.Length > 0)
			{
				double x = Convert.ToDouble(txtXPos.Text);
				double y = Convert.ToDouble(txtYPos.Text);

				Point p = new Point(x, y);
				warpTo(tess, p);
			}
			else
			{
				MessageBox.Show("Enter a value for the X and Y coorindates!!");
			}
		}

		private void btnStamp_Click(object sender, RoutedEventArgs e)
		{
			stamp(tess);
		}

		private void btnTest_Click(object sender, RoutedEventArgs e)
		{
			Turtle alex = new Turtle(canvas, 0, 0);
			alex.Visible = false;

			Point origin = new Point(0, 0);
			alex.WarpTo(100, 0);
			alex.Stamp();

			Point p = alex.Position;

			Tester.TestEq(calcDistance(origin, alex.Position), 100);

			alex.WarpTo(100, 100);
			alex.Stamp();

			Tester.TestEq(calcDistance(p, alex.Position), 100);
			Tester.TestEq(calcTotalDistance(alex.Footprints), 200);
			p = alex.Position;

			alex.WarpTo(50, 50);
			alex.Stamp();

			Tester.TestEq(calcDistance(p, alex.Position), 70.71, 0.001);
			Tester.TestEq(calcTotalDistance(alex.Footprints), 270.71, 0.001);
			p = alex.Position;

			alex.WarpTo(40, 130);
			alex.Stamp();

			Tester.TestEq(calcDistance(p, alex.Position), 80.62, 0.005);
			Tester.TestEq(calcTotalDistance(alex.Footprints), 351.33, 0.005);
		}
	}
}
