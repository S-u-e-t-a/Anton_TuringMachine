using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TuringMachine
{
    public partial class MainForm : Form
    {
        public static ProcessWorkingMachine work = new ProcessWorkingMachine();
        private List<string> pointers = new List<string>();
        private List<string> LineList = new List<string>();
        private List<string> Alph = new List<string>();
        private int pointerPosition = work.CountEmpty - 1;

        public MainForm()
        {
            InitializeComponent();
            MaximizeBox = false;

            if (Settings.Default.Show == true)
            {
                InfoToolStripMenuItem_Click(null, null);
                ShowInfoOnStartToolStripMenuItem.Checked = true;
            }
            else ShowInfoOnStartToolStripMenuItem.Checked = false;

            var f = new Empty(work);
            f.ShowDialog();

            if (work.CountEmpty == 0) work.CountEmpty = 1;
            for (int i = 0; i < work.CountEmpty; i++)
            {
                textBoxLine.Text += "*";
            }
        }

        public bool Сheck(string text)
        {
            for (int i = 0; i < work.CountEmpty; i++)
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
            for (int i = 0; i < work.CountEmpty; i++)
            {
                textBoxLine.Text += "*";
            }
            Alph.Clear();
            LineList.Clear();
        }
        private void CreatingLinePointer() // создает полосу указателя
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

        private void ButtonEnterLine_Click(object sender, EventArgs e) // создание ленты 
        {
            Alph.Clear();
            int counter = 0;
            for (int i = 0; i < work.CountEmpty; i++) // добавление пустого пространства в конец ленты
            {
                textBoxLine.Text += "*";
            }
            for (int i = 0; i < textBoxLine.TextLength; i++) // формирование листа ленты
            {
                LineList.Add(textBoxLine.Text[i].ToString());
            }

            for (int i = 0; i < textBoxAlph.TextLength; i++) // алфавит лист
            {
                Alph.Add(textBoxAlph.Text[i].ToString());
            }

            for (int i = 0; i < textBoxLine.TextLength; i++) // проверка на вхождение символов ленты в алфавит
            {
                if (!Alph.Contains(LineList[i]))
                {
                    counter++;
                }
            }

            if (counter == 0 && textBoxLine.TextLength != 0 && Alph.Distinct().ToList().Count == Alph.Count && Сheck(textBoxLine.Text))
            { // если лента не содержит иных символов, лента не пуста, алфавит не содержит повторов, лента содержит установленные пустые ячейки, то
                pointerPosition = work.CountEmpty - 1; // позиция указателя на линии слева он первого
                CreatingLinePointer(); // создение полосы указателя
                for (int i = 0; i < textBoxLine.TextLength; i++)
                {
                    textBoxPointer.Text += pointers[i]; //вывод полосы указателя
                }
                ButtonBack.Enabled = true; // разблок кнопок управления
                ButtonFront.Enabled = true;

                if (dataGridView1.RowCount == 0) CreateTable(); // если таблица не создана ранее, то создаём
                else if (MessageBox.Show("Стереть таблицу?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes) CreateTable(); // пересоздаем по желанию

                ButtonEnterLine.Enabled = false; // блок кнопки создать

                ButtonAddColumns.Enabled = true; // разблок управления таблицей
                ButtonDeleteColumns.Enabled = true;
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

        private void ButtonBack_Click(object sender, EventArgs e) // перемещение указателя по полосе влево (назад)
        {
            try
            {
                CreatingLinePointer();// пересоздание полосы указателя
                pointerPosition--; // сдвиг влево
                pointers[pointerPosition] = "*"; // перемещение указателя
                for (int i = 0; i < textBoxLine.TextLength; i++)
                {
                    textBoxPointer.Text += pointers[i]; // вывод в текстбокс
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

        private void ButtonFront_Click(object sender, EventArgs e)// перемещение указателя по полосе вправо (вперед)
        {
            try
            {
                CreatingLinePointer();// пересоздание полосы указателя
                pointerPosition++;// сдвиг влево
                pointers[pointerPosition] = "*"; // перемещение указателя
                for (int i = 0; i < textBoxLine.TextLength; i++)
                {
                    textBoxPointer.Text += pointers[i];// вывод в текстбокс
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

        public void CreateTable()// создание таблицы состояний
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("zero", ""); dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns.Add("1", "q1");
            for (int i = 0; i < Alph.Count; i++)
            {
                dataGridView1.Rows.Add(Alph[i]);
            }
        }

        private void buttonEraseLine_Click(object sender, EventArgs e) // стереть ленту
        {
            ButtonEnterLine.Enabled = true; // разблок кнопки ввести ленту
            textBoxLine.Text = ""; // очиска ленты
            for (int i = 0; i < work.CountEmpty; i++)
            {
                textBoxLine.Text += "*";// добавление пустых ячеек (*)
            }
            textBoxPointer.Text = "";// очистка полосы указателя
            pointerPosition = work.CountEmpty - 1; //позиция указателя слева от первого элемента ленты
            LineList.Clear();// очистка листа ленты
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart(); // рестарт приложения
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var info = new InfoForm();
            info.ShowDialog();// инфо
        }

        public void UpdateLine() // апдейт ленты
        {
            textBoxLine.Text = ""; // стираем
            for (int i = 0; i < LineList.Count; i++)
            {
                textBoxLine.Text += LineList[i]; // выводим новую в соответствии с LineList 
            }
        }
        private void ButtonStep_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White; // красив в белый
                }
            }

            if (work.NextColumn == null)
            {
                work.NextColumn = "1"; // если это первый шаг то начинаем с q1
            }

            work.CurrentContentCell = LineList[pointerPosition]; //текущая клетка - значение ленты где стоит указатель снизу

            dataGridView1.Rows[Alph.IndexOf(work.CurrentContentCell)].Cells[int.Parse(work.NextColumn)].Style.BackColor = Color.GreenYellow; // красим в цвет, что мы там находимся

            try
            {

                work.CurrentContentCell = LineList[pointerPosition]; //текущая клетка - значение ленты где стоит указатель снизу
                work.Command = (string)dataGridView1[work.NextColumn, Alph.IndexOf(work.CurrentContentCell)].Value; // берем команду из ячейки таблицы
                work.SplittedCommand = work.Command.Split(' ').ToList(); // сплитим ее по пробелам

                work.NextColumn = work.SplittedCommand[0]; // 0 элемент это след колонка
                work.Direction = work.SplittedCommand[1]; // 1 элемент это направление L R или H
                work.ReplaceOnIt = work.SplittedCommand[2]; // 2 элемент это то на что заменяем

                LineList[pointerPosition] = work.ReplaceOnIt; // обновляем элемент в листе
                UpdateLine(); // обновляем на ленте
                if (work.Direction == "R") ButtonFront_Click(null, null); // сдвиг вправо
                else if (work.Direction == "L") ButtonBack_Click(null, null); // сдвиг влево
                else if (work.Direction == "H")// стоп машина
                {
                    MessageBox.Show("всё");
                    // ButtonStep.Enabled = false;
                }
            }
            catch (NullReferenceException)
            {
                string textError = "Ячейка (q" + work.NextColumn + ";" + LineList[pointerPosition] + ") не содержит команды";
                dataGridView1.Rows[Alph.IndexOf(work.CurrentContentCell)].Cells[int.Parse(work.NextColumn)].Style.BackColor = Color.Red;
                MessageBox.Show(textError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonAddColumns_Click(object sender, EventArgs e) // добавление столбца с уникальным номером
        {
            string nameNewColumn = dataGridView1.Columns[dataGridView1.Columns.Count - 1].Name;
            dataGridView1.Columns.Add((int.Parse(nameNewColumn) + 1).ToString(), "q" + (int.Parse(nameNewColumn) + 1).ToString());
        }

        private void ButtonDeleteColumns_Click(object sender, EventArgs e) // удаление столбца кроме нулевого и q1
        {
            if (dataGridView1.CurrentCell.ColumnIndex > 1)
                dataGridView1.Columns.RemoveAt(dataGridView1.CurrentCell.ColumnIndex);
        }

        private void ShowInfoOnStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowInfoOnStartToolStripMenuItem.Checked)
            {
                ShowInfoOnStartToolStripMenuItem.Checked = false;
                Settings.Default.Show = false;
                Settings.Default.Save();
            }
            else
            {
                ShowInfoOnStartToolStripMenuItem.Checked = true;
                Settings.Default.Show = true;
                Settings.Default.Save();

            }
        }
    }
}
