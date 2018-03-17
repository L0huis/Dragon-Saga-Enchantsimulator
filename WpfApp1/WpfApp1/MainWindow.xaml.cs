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
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    int height, width;
    WriteableBitmap writeableBitmap;
    //int counter = 0;


    private void ViewPort_Loaded(object sender, RoutedEventArgs e)
    {
      width = (int)this.ViewPortContainer.ActualWidth;
      height = (int)this.ViewPortContainer.ActualHeight;
      writeableBitmap = BitmapFactory.New(width, height);
      ViewPort.Source = writeableBitmap;
      parabola(1, 0, 0);

      //writeableBitmap.FillRectangle(0, 0, width, height, Color.FromRgb(0, 0, 0));
      //CompositionTarget.Rendering += CompositionTarget_Rendering;

    }

    Random random = new Random();

    //private void CompositionTarget_Rendering(object sender, EventArgs e)
    //{
    //    writeableBitmap.FillEllipseCentered(random.Next(width),
    //                                        random.Next(height), 
    //                                        3, 
    //                                        3, 
    //                                        Color.FromRgb(255, 255, 255));
    //    counter++;

    //    if (counter >= 600)
    //    {
    //        writeableBitmap.Clear();
    //        writeableBitmap.FillRectangle(0, 0, width, height, Color.FromRgb(0, 0, 0));
    //        counter = 0;
    //    }

    //}

    private void parabola(int a, int b, int c)
    {
      for (int x = 0; x <= width; x++)
      {
        int y = ((a * (x - width / 2)) * (x - width / 2) + b * (x - width / 2) + c) / -100;
        y += height / 2;
        if (y < height && y > 0)
        {
          writeableBitmap.SetPixel(x, y, Color.FromRgb(0, 0, 0));
        }
      }
    }
  }
}
