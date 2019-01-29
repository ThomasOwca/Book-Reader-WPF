using System;
using System.Collections.Generic;
using System.IO;
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

namespace Menu_Control
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string line;
        private string bookTitle;

        public MainWindow()
        {
            InitializeComponent();

            int count = 1;

            FileStream fileStream = new FileStream(@"C:\Users\Thomas\Documents\C# Resources\WPF Practice Code\Menu Control\Menu Control\BookFiles\MobyDick.txt", FileMode.Open);

            try
            {
                if (fileStream.CanRead)
                {
                    BufferedStream bufferedStream = new BufferedStream(fileStream);
                    StreamReader streamReader = new StreamReader(bufferedStream, System.Text.Encoding.Default);

                    // Read the file while the next line is not empty.
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        // This if statements will assign the first line read into the bookTitle string.
                        if (count == 1)
                            bookTitle = line;

                        bookTextBlock.Text += line;
                        bookTextBlock.Text += "\n";

                        count++;
                    }

                    bookTitleLabel.Content = bookTitle;
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            // This creates a confirmation message box with a yes or no option to confirm the intention to exit the app.
            MessageBoxResult messageBoxResult = 
                System.Windows.MessageBox.Show("Are you sure?", "Exit Application", System.Windows.MessageBoxButton.YesNo);

            if (messageBoxResult == MessageBoxResult.Yes)
                Environment.Exit(0);
        }

        private void OptionsAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This application demonstrates the use of a Menu Control in Windows Presentation Foundation (WPF)." +
                " \n\nDesigned using C# and XAML by Thomas Owca.");
        }

        private void OptionsBackgroundColorsDefault_Click(object sender, RoutedEventArgs e)
        {
            gridBackground.Background = Brushes.DarkBlue;
            bookTextBlock.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF2414A8"));
        }

        private void OptionsBackgroundColorsBlack_Click(object sender, RoutedEventArgs e)
        {
            gridBackground.Background = Brushes.Black;
            bookTextBlock.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF262626"));
        }

        private void OptionsBackgroundColorsRed_Click(object sender, RoutedEventArgs e)
        {
            gridBackground.Background = Brushes.Red;
            bookTextBlock.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFFF3B3B"));
        }

        private void OptionsBackgroundColorsLightBlue_Click(object sender, RoutedEventArgs e)
        {
            gridBackground.Background = Brushes.DeepSkyBlue;
            bookTextBlock.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF00A5EE"));
        }

        private void OptionsBackgroundColorsGreen_Click(object sender, RoutedEventArgs e)
        {
            gridBackground.Background = Brushes.LimeGreen;
            bookTextBlock.Background = Brushes.Green;
        }

        private void FileNew_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Menu Control.exe");
        }

        private void windowBackground_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Kills off any lingering processes the application might be responsible for in the background.
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void FileOpenMobyDick_Click(object sender, RoutedEventArgs e)
        {
            int count = 1;

            FileStream fileStream = new FileStream(@"C:\Users\Thomas\Documents\C# Resources\WPF Practice Code\Menu Control\Menu Control\BookFiles\MobyDick.txt", FileMode.Open);

            try
            {
                if (fileStream.CanRead)
                {
                    bookTextBlock.Text = null;
                    BufferedStream bufferedStream = new BufferedStream(fileStream);
                    StreamReader streamReader = new StreamReader(bufferedStream, System.Text.Encoding.Default);

                    // Read the file while the next line is not empty.
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        // This if statements will assign the first line read into the bookTitle string.
                        if (count == 1)
                            bookTitle = line;

                        bookTextBlock.Text += line;
                        bookTextBlock.Text += "\n";

                        count++;
                    }

                    bookTitleLabel.Content = bookTitle;
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FileNewATaleOfTwoCities_Click(object sender, RoutedEventArgs e)
        {
            int count = 1;

            FileStream fileStream = new FileStream(@"C:\Users\Thomas\Documents\C# Resources\WPF Practice Code\Menu Control\Menu Control\BookFiles\ATaleOfTwoCities.txt", FileMode.Open);

            try
            {
                if (fileStream.CanRead)
                {
                    bookTextBlock.Text = null;
                    BufferedStream bufferedStream = new BufferedStream(fileStream);
                    StreamReader streamReader = new StreamReader(bufferedStream, System.Text.Encoding.Default);

                    // Read the file while the next line is not empty.
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        // This if statements will assign the first line read into the bookTitle string.
                        if (count == 1)
                            bookTitle = line;

                        bookTextBlock.Text += line;
                        bookTextBlock.Text += "\n";

                        count++;
                    }

                    bookTitleLabel.Content = bookTitle;
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FileNewTheThreeMusketeers_Click(object sender, RoutedEventArgs e)
        {
            int count = 1;

            FileStream fileStream = new FileStream(@"C:\Users\Thomas\Documents\C# Resources\WPF Practice Code\Menu Control\Menu Control\BookFiles\TheThreeMusketeers.txt", FileMode.Open);

            try
            {
                if (fileStream.CanRead)
                {
                    bookTextBlock.Text = null;
                    BufferedStream bufferedStream = new BufferedStream(fileStream);
                    StreamReader streamReader = new StreamReader(bufferedStream, System.Text.Encoding.Default);

                    // Read the file while the next line is not empty.
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        // This if statements will assign the first line read into the bookTitle string.
                        if (count == 1)
                            bookTitle = line;

                        bookTextBlock.Text += line;
                        bookTextBlock.Text += "\n";

                        count++;
                    }

                    bookTitleLabel.Content = bookTitle;
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void IncreaseFontSize_Click(object sender, RoutedEventArgs e)
        {
            bookTextBlock.FontSize += 1;
        }

        private void DecreaseFontSize_Click(object sender, RoutedEventArgs e)
        {
            bookTextBlock.FontSize -= 1;
        }

        private void DefaultFont_Click(object sender, RoutedEventArgs e)
        {
            bookTextBlock.FontSize = 14;
            bookTextBlock.FontWeight = FontWeights.Normal;
        }
    }
}
