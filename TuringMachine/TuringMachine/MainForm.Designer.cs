namespace TuringMachine
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonFront = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.textBoxLine = new System.Windows.Forms.TextBox();
            this.ButtonEnterLine = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxAlph = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnterEmptyAgainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowInfoOnStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAddColumns = new System.Windows.Forms.Button();
            this.ButtonDeleteColumns = new System.Windows.Forms.Button();
            this.textBoxPointer = new System.Windows.Forms.TextBox();
            this.buttonEraseLine = new System.Windows.Forms.Button();
            this.ButtonStep = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonPause = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.DelayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.проверитьНаличиеОбновленийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonFront
            // 
            this.ButtonFront.Enabled = false;
            this.ButtonFront.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFront.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFront.Image")));
            this.ButtonFront.Location = new System.Drawing.Point(724, 29);
            this.ButtonFront.Name = "ButtonFront";
            this.ButtonFront.Size = new System.Drawing.Size(64, 46);
            this.ButtonFront.TabIndex = 1;
            this.ButtonFront.UseVisualStyleBackColor = true;
            this.ButtonFront.Click += new System.EventHandler(this.ButtonFront_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Enabled = false;
            this.ButtonBack.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBack.Image")));
            this.ButtonBack.Location = new System.Drawing.Point(12, 29);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(64, 46);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // textBoxLine
            // 
            this.textBoxLine.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLine.Location = new System.Drawing.Point(12, 82);
            this.textBoxLine.Name = "textBoxLine";
            this.textBoxLine.Size = new System.Drawing.Size(776, 38);
            this.textBoxLine.TabIndex = 3;
            this.textBoxLine.TabStop = false;
            // 
            // ButtonEnterLine
            // 
            this.ButtonEnterLine.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEnterLine.Location = new System.Drawing.Point(201, 29);
            this.ButtonEnterLine.Name = "ButtonEnterLine";
            this.ButtonEnterLine.Size = new System.Drawing.Size(78, 46);
            this.ButtonEnterLine.TabIndex = 5;
            this.ButtonEnterLine.Text = "Ввести ленту";
            this.ButtonEnterLine.UseVisualStyleBackColor = true;
            this.ButtonEnterLine.Click += new System.EventHandler(this.ButtonEnterLine_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(702, 186);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBoxAlph
            // 
            this.textBoxAlph.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAlph.Location = new System.Drawing.Point(82, 49);
            this.textBoxAlph.Name = "textBoxAlph";
            this.textBoxAlph.Size = new System.Drawing.Size(113, 26);
            this.textBoxAlph.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(82, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Алфавит:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.InfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnterEmptyAgainToolStripMenuItem,
            this.toolStripSeparator1,
            this.SaveLineToolStripMenuItem,
            this.SaveTableToolStripMenuItem,
            this.toolStripSeparator2,
            this.ShowInfoOnStartToolStripMenuItem,
            this.toolStripSeparator3,
            this.ResetToolStripMenuItem,
            this.toolStripSeparator4,
            this.проверитьНаличиеОбновленийToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // EnterEmptyAgainToolStripMenuItem
            // 
            this.EnterEmptyAgainToolStripMenuItem.Name = "EnterEmptyAgainToolStripMenuItem";
            this.EnterEmptyAgainToolStripMenuItem.Size = new System.Drawing.Size(456, 22);
            this.EnterEmptyAgainToolStripMenuItem.Text = "Указать количество пустых ячеек заново";
            this.EnterEmptyAgainToolStripMenuItem.Click += new System.EventHandler(this.EnterEmptyAgainToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(453, 6);
            // 
            // SaveLineToolStripMenuItem
            // 
            this.SaveLineToolStripMenuItem.Enabled = false;
            this.SaveLineToolStripMenuItem.Name = "SaveLineToolStripMenuItem";
            this.SaveLineToolStripMenuItem.Size = new System.Drawing.Size(456, 22);
            this.SaveLineToolStripMenuItem.Text = "Сохранить ленту";
            this.SaveLineToolStripMenuItem.Click += new System.EventHandler(this.SaveLineToolStripMenuItem_Click);
            // 
            // SaveTableToolStripMenuItem
            // 
            this.SaveTableToolStripMenuItem.Enabled = false;
            this.SaveTableToolStripMenuItem.Name = "SaveTableToolStripMenuItem";
            this.SaveTableToolStripMenuItem.Size = new System.Drawing.Size(456, 22);
            this.SaveTableToolStripMenuItem.Text = "Сохранить таблицу состояний";
            this.SaveTableToolStripMenuItem.Click += new System.EventHandler(this.SaveTableToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(453, 6);
            // 
            // ShowInfoOnStartToolStripMenuItem
            // 
            this.ShowInfoOnStartToolStripMenuItem.Checked = true;
            this.ShowInfoOnStartToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowInfoOnStartToolStripMenuItem.Name = "ShowInfoOnStartToolStripMenuItem";
            this.ShowInfoOnStartToolStripMenuItem.Size = new System.Drawing.Size(456, 22);
            this.ShowInfoOnStartToolStripMenuItem.Text = "Показывать справку при запуске";
            this.ShowInfoOnStartToolStripMenuItem.Click += new System.EventHandler(this.ShowInfoOnStartToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(453, 6);
            // 
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(456, 22);
            this.ResetToolStripMenuItem.Text = "Перезапуск";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.InfoToolStripMenuItem.Text = "Справка";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // ButtonAddColumns
            // 
            this.ButtonAddColumns.Enabled = false;
            this.ButtonAddColumns.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddColumns.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAddColumns.Image")));
            this.ButtonAddColumns.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAddColumns.Location = new System.Drawing.Point(720, 182);
            this.ButtonAddColumns.Name = "ButtonAddColumns";
            this.ButtonAddColumns.Size = new System.Drawing.Size(68, 76);
            this.ButtonAddColumns.TabIndex = 11;
            this.ButtonAddColumns.UseVisualStyleBackColor = true;
            this.ButtonAddColumns.Click += new System.EventHandler(this.ButtonAddColumns_Click);
            // 
            // ButtonDeleteColumns
            // 
            this.ButtonDeleteColumns.Enabled = false;
            this.ButtonDeleteColumns.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDeleteColumns.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteColumns.Image")));
            this.ButtonDeleteColumns.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDeleteColumns.Location = new System.Drawing.Point(720, 264);
            this.ButtonDeleteColumns.Name = "ButtonDeleteColumns";
            this.ButtonDeleteColumns.Size = new System.Drawing.Size(68, 76);
            this.ButtonDeleteColumns.TabIndex = 12;
            this.ButtonDeleteColumns.Text = "\r\n";
            this.ButtonDeleteColumns.UseVisualStyleBackColor = true;
            this.ButtonDeleteColumns.Click += new System.EventHandler(this.ButtonDeleteColumns_Click);
            // 
            // textBoxPointer
            // 
            this.textBoxPointer.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPointer.Location = new System.Drawing.Point(12, 126);
            this.textBoxPointer.Name = "textBoxPointer";
            this.textBoxPointer.ReadOnly = true;
            this.textBoxPointer.Size = new System.Drawing.Size(776, 38);
            this.textBoxPointer.TabIndex = 13;
            // 
            // buttonEraseLine
            // 
            this.buttonEraseLine.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEraseLine.Location = new System.Drawing.Point(285, 29);
            this.buttonEraseLine.Name = "buttonEraseLine";
            this.buttonEraseLine.Size = new System.Drawing.Size(92, 46);
            this.buttonEraseLine.TabIndex = 14;
            this.buttonEraseLine.Text = "Стереть ленту";
            this.buttonEraseLine.UseVisualStyleBackColor = true;
            this.buttonEraseLine.Click += new System.EventHandler(this.buttonEraseLine_Click);
            // 
            // ButtonStep
            // 
            this.ButtonStep.Enabled = false;
            this.ButtonStep.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStep.Image = ((System.Drawing.Image)(resources.GetObject("ButtonStep.Image")));
            this.ButtonStep.Location = new System.Drawing.Point(566, 29);
            this.ButtonStep.Name = "ButtonStep";
            this.ButtonStep.Size = new System.Drawing.Size(55, 46);
            this.ButtonStep.TabIndex = 15;
            this.ButtonStep.UseVisualStyleBackColor = true;
            this.ButtonStep.Click += new System.EventHandler(this.ButtonStep_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Enabled = false;
            this.ButtonStart.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("ButtonStart.Image")));
            this.ButtonStart.Location = new System.Drawing.Point(383, 29);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(55, 46);
            this.ButtonStart.TabIndex = 16;
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonPause
            // 
            this.ButtonPause.Enabled = false;
            this.ButtonPause.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPause.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPause.Image")));
            this.ButtonPause.Location = new System.Drawing.Point(444, 29);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(55, 46);
            this.ButtonPause.TabIndex = 17;
            this.ButtonPause.UseVisualStyleBackColor = true;
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Enabled = false;
            this.ButtonStop.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("ButtonStop.Image")));
            this.ButtonStop.Location = new System.Drawing.Point(505, 29);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(55, 46);
            this.ButtonStop.TabIndex = 18;
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // DelayNumericUpDown
            // 
            this.DelayNumericUpDown.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelayNumericUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.DelayNumericUpDown.Location = new System.Drawing.Point(628, 49);
            this.DelayNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.DelayNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DelayNumericUpDown.Name = "DelayNumericUpDown";
            this.DelayNumericUpDown.Size = new System.Drawing.Size(90, 26);
            this.DelayNumericUpDown.TabIndex = 19;
            this.DelayNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(625, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Задержка:";
            // 
            // проверитьНаличиеОбновленийToolStripMenuItem
            // 
            this.проверитьНаличиеОбновленийToolStripMenuItem.Enabled = false;
            this.проверитьНаличиеОбновленийToolStripMenuItem.Name = "проверитьНаличиеОбновленийToolStripMenuItem";
            this.проверитьНаличиеОбновленийToolStripMenuItem.Size = new System.Drawing.Size(456, 22);
            this.проверитьНаличиеОбновленийToolStripMenuItem.Text = "Проверить наличие обновлений";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(453, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelayNumericUpDown);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonPause);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonStep);
            this.Controls.Add(this.buttonEraseLine);
            this.Controls.Add(this.textBoxPointer);
            this.Controls.Add(this.ButtonDeleteColumns);
            this.Controls.Add(this.ButtonAddColumns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonEnterLine);
            this.Controls.Add(this.textBoxAlph);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxLine);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonFront);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Эмулятор машины Тьюринга";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonFront;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.TextBox textBoxLine;
        private System.Windows.Forms.Button ButtonEnterLine;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxAlph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.Button ButtonAddColumns;
        private System.Windows.Forms.Button ButtonDeleteColumns;
        private System.Windows.Forms.TextBox textBoxPointer;
        private System.Windows.Forms.Button buttonEraseLine;
        private System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveTableToolStripMenuItem;
        private System.Windows.Forms.Button ButtonStep;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ShowInfoOnStartToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem EnterEmptyAgainToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonPause;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.NumericUpDown DelayNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem проверитьНаличиеОбновленийToolStripMenuItem;
    }
}

