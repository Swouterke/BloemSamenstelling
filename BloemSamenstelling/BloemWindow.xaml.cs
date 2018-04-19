using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;

namespace BloemSamenstelling
{
    /// <summary>
    /// Interaction logic for BloemWindow.xaml
    /// </summary>
    public partial class BloemWindow : Window
    {
         public BloemWindow()
        {
            InitializeComponent();
            foreach (PropertyInfo info in typeof(Colors).GetProperties())
            {
                BrushConverter bc = new BrushConverter();
                SolidColorBrush theColor = (SolidColorBrush)bc.ConvertFromString(info.Name);
                Kleur color = new Kleur();
                color.Borstel = theColor;
                color.Naam = info.Name;
                color.Hex = theColor.ToString();
                color.Rood = theColor.Color.R;
                color.Groen = theColor.Color.G;
                color.Blauw = theColor.Color.B;
                cirkelsKleuren.Items.Add(color);
                cirkelKaderKleuren.Items.Add(color);
                rechthoekenKleuren.Items.Add(color);
                rechthoekKaderKleuren.Items.Add(color);
                if (color.Naam == "Black")
                {
                    cirkelsKleuren.SelectedItem = color;
                    cirkelKaderKleuren.SelectedItem = color;
                    rechthoekenKleuren.SelectedItem = color;
                    rechthoekKaderKleuren.SelectedItem = color;
                }
            }
        }

    }
}
