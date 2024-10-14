using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace m5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Открытие файла с использованием StreamReader для чтения обычного текста
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Сохранение файла с использованием StreamWriter для записи обычного текста
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write(richTextBox1.Text);
                }
            }
        }
    }


}
