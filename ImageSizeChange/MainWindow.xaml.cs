using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualBasic.Devices;
namespace ImageSizeChange
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
            {
                System.Windows.MessageBox.Show("请选择一个根目录");
                return;
            }
            DirectoryInfo theFolder = new DirectoryInfo(this.textBox.Text);
            var pngfileInfo = theFolder.GetFiles("*.png", SearchOption.AllDirectories);
            var tiffileInfo = theFolder.GetFiles("*.tif", SearchOption.AllDirectories);
            if (pngfileInfo.Length == 0 && tiffileInfo.Length ==0)
            {
                System.Windows.MessageBox.Show("此目录下没有相应文件！");
                return;
            }
            for (int i = 0; i < pngfileInfo.Length; i++)
            {
                var bmp = (Bitmap)Image.FromFile(pngfileInfo[i].FullName);
                if (bmp.Width % 4 == 0 && bmp.Height % 4 == 0)//表示此图片长宽都是四的倍数
                {
                    bmp.Dispose();
                    continue;//此图片符合要求，处理下一张图片
                }
                else//如果此图片不满足长宽是四的倍数
                {
                    var newWidth = bmp.Width - bmp.Width % 4;
                    var newHeight = bmp.Height - bmp.Height % 4;
                    if (newWidth == 0)
                    {
                        newWidth = 4;
                    }
                    if (newHeight == 0)
                    {
                        newHeight = 4;
                    }
                    var newImageSize = new System.Drawing.Size(newWidth, newHeight);
                    var newImage = new Bitmap(bmp, newImageSize);
                    Console.WriteLine(textBox.Text + "\\" + pngfileInfo[i].Name);                    
                    newImage.Save(textBox.Text + "\\" + pngfileInfo[i].Name + "_tmp");
                    newImage.Dispose();
                    bmp.Dispose();
                    File.Delete(textBox.Text + "\\" + pngfileInfo[i].Name);
                    Computer MyComputer = new Computer();
                    MyComputer.FileSystem.RenameFile(textBox.Text + "\\" + pngfileInfo[i].Name + "_tmp", pngfileInfo[i].Name);
                }
            }
            for (int i = 0; i < tiffileInfo.Length; i++)
            {
                var bmp = (Bitmap)Image.FromFile(tiffileInfo[i].FullName);
                if (bmp.Width % 4 == 0 && bmp.Height % 4 == 0)//表示此图片长宽都是四的倍数
                {
                    bmp.Dispose();
                    continue;//此图片符合要求，处理下一张图片
                }
                else//如果此图片不满足长宽是四的倍数
                {
                    var newWidth = bmp.Width - bmp.Width % 4;
                    var newHeight = bmp.Height - bmp.Height % 4;
                    if (newWidth == 0)
                    {
                        newWidth = 4;
                    }
                    if (newHeight == 0)
                    {
                        newHeight = 4;
                    }
                    var newImageSize = new System.Drawing.Size(newWidth, newHeight);
                    var newImage = new Bitmap(bmp, newImageSize);
                    Console.WriteLine(textBox.Text + "\\" + tiffileInfo[i].Name);
                    newImage.Save(textBox.Text + "\\" + tiffileInfo[i].Name + "_tmp");
                    newImage.Dispose();
                    bmp.Dispose();
                    File.Delete(textBox.Text + "\\" + tiffileInfo[i].Name);
                    Computer MyComputer = new Computer();
                    MyComputer.FileSystem.RenameFile(textBox.Text + "\\" + tiffileInfo[i].Name + "_tmp", tiffileInfo[i].Name);
                }
            }
            System.Windows.MessageBox.Show("转换完成");
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog m_Dialog = new FolderBrowserDialog();
            DialogResult result = m_Dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            string m_Dir = m_Dialog.SelectedPath.Trim();
            this.textBox.Text = m_Dir;   
        }
    }
}
