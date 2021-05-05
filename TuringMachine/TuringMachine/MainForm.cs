using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TuringMachine
{
    public partial class MainForm : Form
    {
        public static Line line = new Line();
        public MainForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            var f = new Empty(line);
            f.ShowDialog();
            for (int i = 0; i < line.countEmpty; i++)
            {
                textBoxLine.Text += "*";
            }
        }

        List<string> pointers = new List<string>();
        List<string> LineList = new List<string>();
        List<string> Alph = new List<string>();

        int pointerPosition = line.countEmpty - 1;

        public bool Сheck(string text)
        {
            for (int i = 0; i < line.countEmpty; i++)
            {
                if (text[i] != '*')
                {
                    return false;
                }
            }
            return true;
        }
        public void Erase()
        {
            ButtonBack.Enabled = false;
            ButtonFront.Enabled = false;
            textBoxPointer.Text = "";
            textBoxLine.Text = "";
            for (int i = 0; i < line.countEmpty; i++)
            {
                textBoxLine.Text += "*";
            }
            Alph.Clear();
            LineList.Clear();
        }
        private void CreatingLinePointer() // создает линию указателя
        {
            textBoxPointer.Text = "";
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
                    textBoxPointer.Text += pointers[i];
                }
                return;
            }
            else
            {
                pointerPosition--;
                pointers[pointerPosition] = "*";
                for (int i = 0; i < textBoxLine.TextLength; i++)
                {
                    textBoxPointer.Text += pointers[i];
                }
                return;
            }
        }

        private void ButtonEnterLine_Click(object sender, EventArgs e)
        {
            Alph.Clear();
            int counter = 0;
            for (int i = 0; i < line.countEmpty; i++)
            {
                textBoxLine.Text += "*";
            }
            for (int i = 0; i < textBoxLine.TextLength; i++)
            {
                LineList.Add(textBoxLine.Text[i].ToString());
            }

            for (int i = 0; i < textBoxAlph.TextLength; i++)
            {
                Alph.Add(textBoxAlph.Text[i].ToString());
            }

            for (int i = 0; i < textBoxLine.TextLength; i++)
            {
                if (!Alph.Contains(LineList[i]))
                {
                    counter++;
                }
            }

            if (counter == 0 && textBoxLine.TextLength != 0 && Alph.Distinct().ToList().Count == Alph.Count && Сheck(textBoxLine.Text))
            {
                pointerPosition = line.countEmpty - 1;
                CreatingLinePointer();
                for (int i = 0; i < textBoxLine.TextLength; i++)
                {
                    textBoxPointer.Text += pointers[i];
                }
                ButtonBack.Enabled = true;
                ButtonFront.Enabled = true;

                if (dataGridView1.RowCount == 0) CreateTable();
                else if (MessageBox.Show("Стереть таблицу?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes) CreateTable();

                ButtonEnterLine.Enabled = false;
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
            else if (Alph.Distinct().ToList().Count != Alph.Count)
            {
                MessageBox.Show("Алфавит содержит повторяющиеся элементы. Их необходимо удалить.",
                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Erase();
            }
            else if (!Сheck(textBoxLine.Text))
            {
                MessageBox.Show("Для корректной работы в начале ленты необходимо столько символо \"*\" (звёздочка), сколько вы указали изначально!",
                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Erase();
            }
            counter = 0;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            try
            {
                CreatingLinePointer();
                pointerPosition--;
                pointers[pointerPosition] = "*";
                for (int i = 0; i < textBoxLine.TextLength; i++)
                {
                    textBoxPointer.Text += pointers[i];
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
                CreatingLinePointer();
                pointerPosition++;
                pointers[pointerPosition] = "*";
                for (int i = 0; i < textBoxLine.TextLength; i++)
                {
                    textBoxPointer.Text += pointers[i];
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
            dataGridView1.Columns.Add("1", "q1");
            for (int i = 0; i < Alph.Count; i++)
            {
                dataGridView1.Rows.Add(Alph[i]);
            }
        }

        private void buttonEraseLine_Click(object sender, EventArgs e)
        {
            ButtonEnterLine.Enabled = true;
            textBoxLine.Text = "";
            for (int i = 0; i < line.countEmpty; i++)
            {
                textBoxLine.Text += "*";
            }
            textBoxPointer.Text = "";
            pointerPosition = line.countEmpty;
            LineList.Clear();
            for (int i = 0; i < textBoxLine.TextLength; i++)
            {
                LineList.Add(textBoxLine.Text[i].ToString());
            }
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var info = new InfoForm();
            info.ShowDialog();
        }

        public void UpdateLine()
        {
            textBoxLine.Text = "";
            for (int i = 0; i < LineList.Count; i++)
            {
                textBoxLine.Text += LineList[i];
            }
        }
        ProcessWorkingMachine work = new ProcessWorkingMachine();
        private void ButtonStep_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }

            if (work.NextColumn == null)
            {
                work.NextColumn = "1";
            }

            work.CurrentContentCell = LineList[pointerPosition];

            dataGridView1.Rows[Alph.IndexOf(work.CurrentContentCell)].Cells[int.Parse(work.NextColumn)].Style.BackColor = Color.GreenYellow;

            work.CurrentContentCell = LineList[pointerPosition];
            work.Command = (string)dataGridView1[work.NextColumn, Alph.IndexOf(work.CurrentContentCell)].Value;
            work.SplittedCommand = work.Command.Split(' ').ToList();

            work.NextColumn = work.SplittedCommand[0];
            work.Direction = work.SplittedCommand[1];
            work.ReplaceOnIt = work.SplittedCommand[2];
       
            LineList[pointerPosition] = work.ReplaceOnIt;
            UpdateLine();
            if (work.Direction == "R") ButtonFront_Click(null, null);
            else if (work.Direction == "L") ButtonBack_Click(null, null);
            else if (work.Direction == "H")
            {
                MessageBox.Show("всё");
                // ButtonStep.Enabled = false;
            }

        }

        private void ButtonAddColumns_Click(object sender, EventArgs e)
        {
            string nameNewColumn = dataGridView1.Columns[dataGridView1.Columns.Count - 1].Name;
            dataGridView1.Columns.Add((int.Parse(nameNewColumn) + 1).ToString(), "q" + (int.Parse(nameNewColumn) + 1).ToString());
        }

        private void ButtonDeleteColumns_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex > 1)
                dataGridView1.Columns.RemoveAt(dataGridView1.CurrentCell.ColumnIndex);
        }

    }
}
