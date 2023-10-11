namespace LibSystem
{
    partial class Librarian
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBook = new System.Windows.Forms.Button();
            this.listBooks = new System.Windows.Forms.ListBox();
            this.editBook = new System.Windows.Forms.Button();
            this.delBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addReader = new System.Windows.Forms.Button();
            this.editReader = new System.Windows.Forms.Button();
            this.delReader = new System.Windows.Forms.Button();
            this.listReaders = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listBooks);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 493);
            this.panel1.TabIndex = 1;
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(3, 3);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(284, 75);
            this.addBook.TabIndex = 1;
            this.addBook.Text = "Добавить";
            this.addBook.UseVisualStyleBackColor = true;
            // 
            // listBooks
            // 
            this.listBooks.FormattingEnabled = true;
            this.listBooks.ItemHeight = 16;
            this.listBooks.Location = new System.Drawing.Point(3, 3);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(302, 372);
            this.listBooks.TabIndex = 0;
            // 
            // editBook
            // 
            this.editBook.Location = new System.Drawing.Point(3, 84);
            this.editBook.Name = "editBook";
            this.editBook.Size = new System.Drawing.Size(284, 75);
            this.editBook.TabIndex = 2;
            this.editBook.Text = "Изменить";
            this.editBook.UseVisualStyleBackColor = true;
            // 
            // delBook
            // 
            this.delBook.Location = new System.Drawing.Point(3, 165);
            this.delBook.Name = "delBook";
            this.delBook.Size = new System.Drawing.Size(284, 75);
            this.delBook.TabIndex = 3;
            this.delBook.Text = "Удалить";
            this.delBook.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Изменяемая книга";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(404, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 93);
            this.button4.TabIndex = 5;
            this.button4.Text = "Применить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 22);
            this.textBox1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 102);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addBook);
            this.panel3.Controls.Add(this.editBook);
            this.panel3.Controls.Add(this.delBook);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(311, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 391);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.listReaders);
            this.panel4.Location = new System.Drawing.Point(641, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(620, 493);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.addReader);
            this.panel5.Controls.Add(this.editReader);
            this.panel5.Controls.Add(this.delReader);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(311, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(309, 391);
            this.panel5.TabIndex = 8;
            // 
            // addReader
            // 
            this.addReader.Location = new System.Drawing.Point(3, 3);
            this.addReader.Name = "addReader";
            this.addReader.Size = new System.Drawing.Size(284, 75);
            this.addReader.TabIndex = 1;
            this.addReader.Text = "Добавить";
            this.addReader.UseVisualStyleBackColor = true;
            // 
            // editReader
            // 
            this.editReader.Location = new System.Drawing.Point(3, 84);
            this.editReader.Name = "editReader";
            this.editReader.Size = new System.Drawing.Size(284, 75);
            this.editReader.TabIndex = 2;
            this.editReader.Text = "Изменить";
            this.editReader.UseVisualStyleBackColor = true;
            // 
            // delReader
            // 
            this.delReader.Location = new System.Drawing.Point(3, 165);
            this.delReader.Name = "delReader";
            this.delReader.Size = new System.Drawing.Size(284, 75);
            this.delReader.TabIndex = 3;
            this.delReader.Text = "Удалить";
            this.delReader.UseVisualStyleBackColor = true;
            // 
            // listReaders
            // 
            this.listReaders.FormattingEnabled = true;
            this.listReaders.ItemHeight = 16;
            this.listReaders.Location = new System.Drawing.Point(3, 3);
            this.listReaders.Name = "listReaders";
            this.listReaders.Size = new System.Drawing.Size(302, 372);
            this.listReaders.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 22);
            this.textBox2.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(314, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(303, 96);
            this.button8.TabIndex = 5;
            this.button8.Text = "Применить";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 391);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(620, 102);
            this.panel6.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Изменяемый читатель";
            // 
            // Librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 564);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Librarian";
            this.Text = "Librarian";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delBook;
        private System.Windows.Forms.Button editBook;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.ListBox listBooks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button addReader;
        private System.Windows.Forms.Button editReader;
        private System.Windows.Forms.Button delReader;
        private System.Windows.Forms.ListBox listReaders;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox2;
    }
}