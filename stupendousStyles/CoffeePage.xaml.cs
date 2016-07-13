using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace stupendousStyles
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        string[] coffeeMixArray = new string[3];

        public CoffeePage()
        {
            this.InitializeComponent();
            coffeeMixName.Text = "Coffee:";
            
        }

        private void roastNone_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ToggleMenuFlyoutItem selectedItemFlyout = sender as ToggleMenuFlyoutItem;
            if (!selectedItemFlyout.IsChecked)
            {
                coffeeMixArray[0] = "";                
            } else
            {
                coffeeMixArray[0] = selectedItemFlyout.Text;
            }
            
            coffeeMixName.Text = @"Coffee: " + string.Join("+",coffeeMixArray);
        }

        private void roastDark_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ToggleMenuFlyoutItem selectedItemFlyout = sender as ToggleMenuFlyoutItem;
            coffeeMixArray[0] = selectedItemFlyout.Text;
            coffeeMixName.Text = @"Coffee: " + string.Join("+", coffeeMixArray);
        }

        private void roastMedium_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ToggleMenuFlyoutItem selectedItemFlyout = sender as ToggleMenuFlyoutItem;
            coffeeMixArray[0] = selectedItemFlyout.Text;
            coffeeMixName.Text = @"Coffee: " + string.Join("+", coffeeMixArray);
        }

        private void sweetenerNone_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ToggleMenuFlyoutItem selectedItemFlyout = sender as ToggleMenuFlyoutItem;
            coffeeMixArray[1] = selectedItemFlyout.Text;
            coffeeMixName.Text = @"Coffee: " + string.Join("+", coffeeMixArray);
        }

        private void sweetenerSugar_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ToggleMenuFlyoutItem selectedItemFlyout = sender as ToggleMenuFlyoutItem;
            coffeeMixArray[1] = selectedItemFlyout.Text;
            coffeeMixName.Text = @"Coffee: " + string.Join("+", coffeeMixArray);
        }

        private void creamNone_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ToggleMenuFlyoutItem selectedItemFlyout = sender as ToggleMenuFlyoutItem;
            coffeeMixArray[2] = selectedItemFlyout.Text;
            coffeeMixName.Text = @"Coffee: " + string.Join("+", coffeeMixArray);
        }

        private void cream2PercentMilk_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ToggleMenuFlyoutItem selectedItemFlyout = sender as ToggleMenuFlyoutItem;
            coffeeMixArray[2] = selectedItemFlyout.Text;
            coffeeMixName.Text = @"Coffee: " + string.Join("+", coffeeMixArray);
        }

        private void creamwholeMilk_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ToggleMenuFlyoutItem selectedItemFlyout = sender as ToggleMenuFlyoutItem;
            coffeeMixArray[2] = selectedItemFlyout.Text;
            coffeeMixName.Text = @"Coffee: " + string.Join("+", coffeeMixArray);
        }
    }
}
