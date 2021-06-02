using System;
using System.IO;
using System.Windows.Forms;

namespace lab4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Choose_Folder.Text = Application.StartupPath;
        }
        private void Button_Choose_Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FldDialog = new FolderBrowserDialog();
            FldDialog.Description = "Выберите папку для демонстрации работы диалога";
            FldDialog.SelectedPath = Application.StartupPath;

            if (FldDialog.ShowDialog() == DialogResult.OK)
            {
                Choose_Folder.Text = FldDialog.SelectedPath;
            }
        }
        private void Button_Choose_Open_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog FlDialog = new OpenFileDialog();
            FlDialog.InitialDirectory = Choose_Folder.Text;
            FlDialog.Filter = "Text files (*.txt)|*.txt";
            FlDialog.FilterIndex = 2;
            FlDialog.Title = "Выбор вашего файла";

            if (FlDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(FlDialog.OpenFile()))
                {
                    U_TextBox.Text = reader.ReadToEnd();
                }
                Choose_Open_File.Text = FlDialog.FileName;
            }
        }
        private void Button_Choose_Save_File_Click(object sender, EventArgs e)
        {
            SaveFileDialog FlDialog = new SaveFileDialog();
            FlDialog.InitialDirectory = Choose_Folder.Text;
            FlDialog.Filter = "Text files (*.txt)|*.txt";
            FlDialog.FilterIndex = 2;
            FlDialog.Title = "Выбор файла сохранения";
            if (FlDialog.ShowDialog() == DialogResult.OK)
            {
                if (FlDialog.FileName != null)
                {
                    using (StreamWriter writer = new StreamWriter(FlDialog.OpenFile())) {
                        writer.WriteLine(U_TextBox.Text);
                    }
                }
                Choose_Save_File.Text = FlDialog.FileName;
            }
        }

        private void Button_Calculate_Click(object sender, EventArgs e)
        {
            double X1 = 58, Q = 1;
            int N = 0;
            X.Text = Convert.ToString(X1);
            try
            {
                N = Convert.ToInt32(Term_Amount.Text);
                for (int i = 2; i <= N + 1; i++)
                {
                    Q += Math.Pow(-1, i + 1) * (Math.Pow(Math.Sin(X1), i) / i);
                }
                U_TextBox.Text = Convert.ToString(Q);
            }
            catch
            {
                MessageBox.Show("Количество слагаемых в правой части введено неверно!", "Ошибка параметров");
            }
        }
    }
}
