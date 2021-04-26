using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> pointers = new List<string>();
        List<string> Line = new List<string>();
        List<string> Alph = new List<string>();

        int pointerPosition = -1;

        public void Erase()
        {
            ButtonBack.Enabled = false;
            ButtonFront.Enabled = false;
            labelPointer.Text = "";
            Alph.Clear();
            Line.Clear();
        }
        private void CreatingLine() // создает ленту
        {
            labelPointer.Text = "";
            pointers.Clear();
            for (int i = 0; i < textBoxLine.TextLength; i++)
            {
                pointers.Add("—");
            }
        }
        private void RecoverPointer(bool left)//восстанавливает линию указателя после пойманного исключения
        {
            if (left)
            {
                pointerPosition++;
                pointers[pointerPosition] = "*";
                for (int i = 0; i < textBoxLine.TextLength; i++)
                {
                    labelPointer.Text += pointers[i];
                }
                return;
            }
            else
            {
                pointerPosition--;
                pointers[pointerPosition] = "*";
                for (int i = 0; i < textBoxLine.TextLength; i++)
                {
                    labelPointer.Text += pointers[i];
                }
                return;
            }
        }

        private void ButtonEnterLine_Click(object sender, EventArgs e)
        {
            int counter = 0;

            for (int i = 0; i < textBoxLine.TextLength; i++)
            {
                Line.Add(textBoxLine.Text[i].ToString());
            }

            for (int i = 0; i < textBoxAlph.TextLength; i++)
            {
                Alph.Add(textBoxAlph.Text[i].ToString());
            }

            for (int i = 0; i < textBoxLine.TextLength; i++)
            {
                if (!Alph.Contains(Line[i]))
                {
                    counter++;
                }
            }
         
            if (counter == 0 && textBoxLine.TextLength != 0 && Alph.Distinct().ToList().Count == Alph.Count)
            {
                pointerPosition = -1;
                CreatingLine();
                for (int i = 0; i < textBoxLine.TextLength; i++)
                {
                    labelPointer.Text += pointers[i];
                }
                ButtonBack.Enabled = true;
                ButtonFront.Enabled = true;
                CreateTable();
                Alph.Clear();
            }
            else if (counter != 0)
            {
                MessageBox.Show("Лента содержит символы, необъявленные в алфавите. Проверьте правильность ленты и уточните алфавит.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Erase();
            }
            else if (textBoxLine.TextLength == 0)
            {
                MessageBox.Show("Вы ввели пустую ленту. Укажите хотя бы одно значение",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Erase();
            }
            else if(Alph.Distinct().ToList().Count != Alph.Count)
            {
                MessageBox.Show("Алфавит содержит повторяющиеся элементы. Их необходимо удалить.",
                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Erase();
            }
            counter = 0;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            try
            {
                CreatingLine();
                pointerPosition--;
                pointers[pointerPosition] = "*";
                for (int i = 0; i < textBoxLine.TextLength; i++)
                {
                    labelPointer.Text += pointers[i];
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Указатель находится в крайнем левом положении.\nСдвиг левее невозможен", "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                RecoverPointer(true);

            }
        }

        private void ButtonFront_Click(object sender, EventArgs e)
        {
            try
            {
                CreatingLine();
                pointerPosition++;
                pointers[pointerPosition] = "*";
                for (int i = 0; i < textBoxLine.TextLength; i++)
                {
                    labelPointer.Text += pointers[i];
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Указатель находится в крайнем правом положении.\nСдвиг правее невозможен", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                RecoverPointer(false);
            }
        }

        public void CreateTable()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("zero", ""); dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns.Add("q1", "q1");
            for (int i = 0; i < Alph.Count; i++)
            {
                dataGridView1.Rows.Add(Alph[i]);
            }
        }
        private void ButtonAddColumns_Click(object sender, EventArgs e)
        {

        }
    }
}
