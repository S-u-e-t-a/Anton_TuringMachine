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
            this.ButtonFront = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.textBoxLine = new System.Windows.Forms.TextBox();
            this.ButtonEnterLine = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxAlph = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAddColumns = new System.Windows.Forms.Button();
            this.ButtonDeleteColumns = new System.Windows.Forms.Button();
            this.textBoxPointer = new System.Windows.Forms.TextBox();
            this.buttonEraseLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonFront
            // 
            this.ButtonFront.Enabled = false;
            this.ButtonFront.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFront.Location = new System.Drawing.Point(710, 29);
            this.ButtonFront.Name = "ButtonFront";
            this.ButtonFront.Size = new System.Drawing.Size(78, 46);
            this.ButtonFront.TabIndex = 1;
            this.ButtonFront.Text = "Вперед";
            this.ButtonFront.UseVisualStyleBackColor = true;
            this.ButtonFront.Click += new System.EventHandler(this.ButtonFront_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Enabled = false;
            this.ButtonBack.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(12, 29);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(78, 46);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Назад";
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
            this.textBoxLine.Text = "**********";
            // 
            // ButtonEnterLine
            // 
            this.ButtonEnterLine.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEnterLine.Location = new System.Drawing.Point(218, 30);
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
            this.dataGridView1.Size = new System.Drawing.Size(656, 186);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBoxAlph
            // 
            this.textBoxAlph.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAlph.Location = new System.Drawing.Point(99, 50);
            this.textBoxAlph.Name = "textBoxAlph";
            this.textBoxAlph.Size = new System.Drawing.Size(113, 26);
            this.textBoxAlph.TabIndex = 8;
            this.textBoxAlph.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Алфавит:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // ButtonAddColumns
            // 
            this.ButtonAddColumns.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddColumns.Location = new System.Drawing.Point(674, 170);
            this.ButtonAddColumns.Name = "ButtonAddColumns";
            this.ButtonAddColumns.Size = new System.Drawing.Size(114, 46);
            this.ButtonAddColumns.TabIndex = 11;
            this.ButtonAddColumns.Text = "Добавить столбец";
            this.ButtonAddColumns.UseVisualStyleBackColor = true;
            this.ButtonAddColumns.Click += new System.EventHandler(this.ButtonAddColumns_Click);
            // 
            // ButtonDeleteColumns
            // 
            this.ButtonDeleteColumns.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDeleteColumns.Location = new System.Drawing.Point(674, 222);
            this.ButtonDeleteColumns.Name = "ButtonDeleteColumns";
            this.ButtonDeleteColumns.Size = new System.Drawing.Size(114, 46);
            this.ButtonDeleteColumns.TabIndex = 12;
            this.ButtonDeleteColumns.Text = "Удалить столбец";
            this.ButtonDeleteColumns.UseVisualStyleBackColor = true;
            // 
            // textBoxPointer
            // 
            this.textBoxPointer.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPointer.Location = new System.Drawing.Point(12, 126);
            this.textBoxPointer.Name = "textBoxPointer";
            this.textBoxPointer.Size = new System.Drawing.Size(776, 38);
            this.textBoxPointer.TabIndex = 13;
            // 
            // buttonEraseLine
            // 
            this.buttonEraseLine.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEraseLine.Location = new System.Drawing.Point(302, 30);
            this.buttonEraseLine.Name = "buttonEraseLine";
            this.buttonEraseLine.Size = new System.Drawing.Size(92, 46);
            this.buttonEraseLine.TabIndex = 14;
            this.buttonEraseLine.Text = "Стереть ленту";
            this.buttonEraseLine.UseVisualStyleBackColor = true;
            this.buttonEraseLine.Click += new System.EventHandler(this.buttonEraseLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Машина Тьюринга";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button ButtonAddColumns;
        private System.Windows.Forms.Button ButtonDeleteColumns;
        private System.Windows.Forms.TextBox textBoxPointer;
        private System.Windows.Forms.Button buttonEraseLine;
    }
}

