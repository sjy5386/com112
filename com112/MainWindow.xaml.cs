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

namespace com112
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Processor processor = new Processor();
            MainBoard mainBoard = new MainBoard();
            Memory memory = new Memory();
            Graphic graphic = new Graphic();
            Storage storage = new Storage();

            processorInformationTextBlock.Text = processor.ToString();
            mainBoardInformationTextBlock.Text = mainBoard.ToString();
            memoryInformationTextBlock.Text = memory.ToString();
            graphicInformationTextBlock.Text = graphic.ToString();
            storageInformationTextBlock.Text = storage.ToString();
        }
    }
}
