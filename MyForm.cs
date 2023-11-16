using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Text.RegularExpressions;

namespace Lab1_4
{
    public partial class MyForm : Form
    {
        Label lbl1, lbl2, lbl3;
        public ListBox lb1, lb2, lb3;
        Panel p;
        ComboBox cb1, cb2, cb3, cb4;
        Button bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9, bt10, bt11, bt12, bt13, bt14;
        GroupBox gb;
        TextBox tb;
        CheckBox ckb1, ckb2;
        RadioButton rb1, rb2, rb3;
        RichTextBox rtb;

        public MyForm()
        {
            this.Height = 750;
            this.Width = 945;
            this.Text = "Lab1";

            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("Файл");

            ToolStripMenuItem openMenuItem = new ToolStripMenuItem("Открыть");
            openMenuItem.Click += OpenClick;
            openMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            ToolStripMenuItem saveMenuItem = new ToolStripMenuItem("Сохранить");
            saveMenuItem.Click += SaveClick;
            saveMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Выход");
            exitMenuItem.Click += ExitClick;
            exitMenuItem.ShortcutKeys = Keys.Alt | Keys.X;

            fileMenu.DropDownItems.Add(openMenuItem);
            fileMenu.DropDownItems.Add(saveMenuItem);
            fileMenu.DropDownItems.Add(exitMenuItem);

            menuStrip.Items.Add(fileMenu);
            this.Controls.Add(menuStrip);

            cb1 = new ComboBox();
            cb1.Location = new Point(25, 75);

            cb2 = new ComboBox();
            cb2.Location = new Point(25, 75);
            cb2.BackColor = Color.White;
            cb2.Size = new Size(150, 15);
            cb2.Items.AddRange(new string[] {
                "Сортировка по...",
                "По длине (возр.)",
                "По длине (убыв.)",
                "По алфавиту (возр.)",
                "По алфавиту (убыв.)"
            });
            Controls.Add(cb2);

            cb3 = new ComboBox();
            cb3.Location = new Point(350, 75);
            cb3.BackColor = Color.White;
            cb3.Size = new Size(150, 15);
            cb3.Items.AddRange(new string[] {
                "Сортировка по...",
                "По длине (возр.)",
                "По длине (убыв.)",
                "По алфавиту (возр.)",
                "По алфавиту (убыв.)"
            });
            cb3.Text = "Сортировка по...";
            Controls.Add(cb3);

            tb = new TextBox();
            tb.Location = new Point(30, 450);
            tb.Size = new Size(175, 15);
            Controls.Add(tb);

            lbl1 = new Label();
            lbl1.Location = new Point(25, 50);
            lbl1.Size = new Size(100, 15);
            lbl1.BackColor = Color.Lavender;
            lbl1.Text = "Раздел 1";
            Controls.Add(lbl1);

            lbl2 = new Label();
            lbl2.Location = new Point(350, 50);
            lbl2.Size = new Size(100, 15);
            lbl2.BackColor = Color.Lavender;
            lbl2.Text = "Раздел 2";
            Controls.Add(lbl2);

            lbl3 = new Label();
            lbl3.Location = new Point(30, 420);
            lbl3.Size = new Size(150, 15);
            lbl3.BackColor = Color.Lavender;
            lbl3.Text = "Введите искаемое слово";
            Controls.Add(lbl3);

            lb1 = new ListBox();
            lb1.Location = new Point(25, 100);
            lb1.Size = new Size(150, 200);
            lb1.BackColor = Color.White;
            lb1.SelectionMode = SelectionMode.MultiExtended;
            Controls.Add(lb1);

            lb2 = new ListBox();
            lb2.Location = new Point(350, 100);
            lb2.Size = new Size(150, 200);
            lb2.BackColor = Color.White;
            lb1.SelectionMode = SelectionMode.MultiExtended;
            Controls.Add(lb2);

            lb3 = new ListBox();
            lb3.Location = new Point(30, 480);
            lb3.Size = new Size(175, 200);
            lb3.BackColor = Color.White;
            lb1.SelectionMode = SelectionMode.MultiExtended;
            Controls.Add(lb3);

            bt1 = new Button();
            bt1.Location = new Point(215, 100);
            bt1.Size = new Size(100, 30);
            bt1.Text = ">";
            bt1.BackColor = Color.LightGray;
            bt1.Click += btnPerenosToRightClick;
            Controls.Add(bt1);

            bt2 = new Button();
            bt2.Location = new Point(215, 150);
            bt2.Size = new Size(100, 30);
            bt2.Text = "<";
            bt2.BackColor = Color.LightGray;
            bt2.Click += btnPerenosToLeftClick;
            Controls.Add(bt2);

            bt3 = new Button();
            bt3.Location = new Point(215, 200);
            bt3.Size = new Size(100, 30);
            bt3.Text = ">>";
            bt3.BackColor = Color.LightGray;
            bt3.Click += btnPerenosAllToRightClick;
            Controls.Add(bt3);

            bt4 = new Button();
            bt4.Location = new Point(215, 250);
            bt4.Size = new Size(100, 30);
            bt4.Text = "<<";
            bt4.BackColor = Color.LightGray;
            bt4.Click += btnPerenosAllToLeftClick;
            Controls.Add(bt4);

            bt5 = new Button();
            bt5.Location = new Point(45, 320);
            bt5.Size = new Size(100, 30);
            bt5.Text = "Сортировать";
            bt5.BackColor = Color.LightGray;
            bt5.Click += Sort1;
            Controls.Add(bt5);

            bt6 = new Button();
            bt6.Location = new Point(385, 320);
            bt6.Size = new Size(100, 30);
            bt6.Text = "Сортировать";
            bt6.BackColor = Color.LightGray;
            bt6.Click += Sort2;
            Controls.Add(bt6);

            bt7 = new Button();
            bt7.Location = new Point(45, 365);
            bt7.Size = new Size(100, 30);
            bt7.Text = "Очистить>";
            bt7.BackColor = Color.LightGray;
            bt7.Click += ListBox1btnClearClick;
            Controls.Add(bt7);

            bt8 = new Button();
            bt8.Location = new Point(385, 365);
            bt8.Size = new Size(100, 30);
            bt8.Text = "Очистить";
            bt8.BackColor = Color.LightGray;
            bt8.Click += ListBox2btnClearClick;
            Controls.Add(bt8);

            bt9 = new Button();
            bt9.Location = new Point(215, 320);
            bt9.Size = new Size(100, 30);
            bt9.Text = "Добавить";
            bt9.BackColor = Color.LightGray;
            bt9.Click += btAddClikc;
            Controls.Add(bt9);

            bt10 = new Button();
            bt10.Location = new Point(215, 365);
            bt10.Size = new Size(100, 30);
            bt10.Text = "Удалить";
            bt10.BackColor = Color.LightGray;
            bt10.Click += btnDeleteClick;
            Controls.Add(bt10);

            bt11 = new Button();
            bt11.Location = new Point(390, 540);
            bt11.Size = new Size(155, 60);
            bt11.Text = "Сброс";
            bt11.BackColor = Color.LightGray;
            bt11.Click += btClearClikc;
            Controls.Add(bt11);

            bt12 = new Button();
            bt12.Location = new Point(390, 620);
            bt12.Size = new Size(155, 60);
            bt12.Text = "Выход";
            bt12.BackColor = Color.LightGray;
            bt12.Click += ExitClick;
            Controls.Add(bt12);

            bt13 = new Button();
            bt13.Location = new Point(225, 600);
            bt13.Size = new Size(100, 80);
            bt13.Text = "Поиск";
            bt13.BackColor = Color.LightGray;
            bt13.Click += btFindClikc;
            Controls.Add(bt13);

            bt14 = new Button();
            bt14.Location = new Point(820, 600);
            bt14.Size = new Size(100, 80);
            bt14.Text = "Начать";
            bt14.BackColor = Color.LightGray;
            bt14.Click += btStartClikc;
            Controls.Add(bt14);

            ckb1 = new CheckBox();
            ckb1.Location = new Point(225, 500);
            ckb1.Text = "Раздел 1";
            ckb1.BackColor = Color.Lavender;
            ckb1.Checked = true;
            Controls.Add(ckb1);

            ckb2 = new CheckBox();
            ckb2.Location = new Point(225, 530);
            ckb2.Text = "Раздел 2";
            ckb2.BackColor = Color.Lavender;
            Controls.Add(ckb2);

            rb1 = new RadioButton();
            rb1.Location = new Point(590, 600);
            rb1.Text = "Все";
            rb1.BackColor = Color.Lavender;
            rb1.Size = new Size(100, 20);
            rb1.Checked = true;
            Controls.Add(rb1);

            rb2 = new RadioButton();
            rb2.Location = new Point(590, 620);
            rb2.Size = new Size(150, 20);
            rb2.Text = "Содержащие цифры";
            rb2.BackColor = Color.Lavender;
            Controls.Add(rb2);

            rb3 = new RadioButton();
            rb3.Location = new Point(590, 640);
            rb3.Text = "Содержащие e-mail";
            rb3.Size = new Size(150, 20);
            rb3.BackColor = Color.Lavender;
            Controls.Add(rb3);

            rtb = new RichTextBox();
            rtb.Location = new Point(575, 30);
            rtb.Size = new Size(345, 545);
            Controls.Add(rtb);

            gb = new GroupBox();
            gb.Location = new Point(25, 400);
            gb.BackColor = Color.Lavender;
            gb.Size = new Size(350, 300);
            gb.Text = "Поиск";
            Controls.Add(gb);

            gb = new GroupBox();
            gb.Location = new Point(575, 580);
            gb.BackColor = Color.Lavender;
            gb.Size = new Size(350, 120);
            gb.Text = "Выбор слов";
            Controls.Add(gb);

            p = new Panel();
            p.Location = new Point(10, 25);
            p.Size = new Size(550, 680);
            p.BackColor = Color.Lavender;
            p.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(p);

            p = new Panel();
            p.Location = new Point(570, 25);
            p.Size = new Size(350, 680);
            p.BackColor = Color.Lavender;
            p.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(p);
        }

        private void OpenClick(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                rtb.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }

        private void SaveClick(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveDlg.FileName);

                writer.WriteLine(rtb.Text);

                for (int i = 0; i < lb2.Items.Count; i++)
                {
                    writer.WriteLine((string)lb2.Items[i]);
                }

                writer.Close();
            }
            saveDlg.Dispose();
        }

        private void ExitClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти?", "Уведомление о выходе", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btClearClikc(object sender, EventArgs e)
        {
            rtb.Clear();
            rb1.Checked = true;
            rb2.Checked = false;
            rb3.Checked = false;
            tb.Clear();
            lb1.Items.Clear();
            lb2.Items.Clear();
            lb3.Items.Clear();
            ckb1.Checked = true;
            ckb2.Checked = false;
            cb2.Text = "Сортировка по...";
            cb3.Text = "Сортировка по...";
        }
        private void btStartClikc(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            lb2.Items.Clear();

            lb1.BeginUpdate();

            string[] String = rtb.Text.Split(new char[] { '\n', '\t', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in String)
            {
                string Str = s.Trim();

                if (Str == " ") continue;
                if (rb1.Checked) lb1.Items.Add(Str);
                if (rb2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) lb1.Items.Add(Str);
                }
                if (rb3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) lb1.Items.Add(Str);
                }
            }

            lb1.EndUpdate();
        }
        private void btFindClikc(object sender, EventArgs e)
        {
            lb3.Items.Clear();

            string Find = tb.Text;

            if (ckb1.Checked)
            {
                foreach (string str1 in lb1.Items)
                {
                    if (str1.Contains(Find)) lb3.Items.Add(str1);
                }
            }

            if (ckb2.Checked)
            {
                foreach (string str2 in lb2.Items)
                {
                    if (str2.Contains(Find)) lb3.Items.Add(str2);
                }
            }
        }
        private void btAddClikc(object sender, EventArgs e)
        {
            NewForm AddRec = new NewForm();

            AddRec.Owner = this;
            AddRec.ShowDialog();
        }
        private void DeleteSelectedItems(ListBox listBox)
        {
            for (int i = listBox.Items.Count - 1; i >= 0; i--)
            {
                if (listBox.GetSelected(i))
                {
                    listBox.Items.RemoveAt(i);
                }
            }
        }
        private void btnDeleteClick(object sender, EventArgs e)
        {
            DeleteSelectedItems(lb1);
            DeleteSelectedItems(lb2);
        }
        private void btnPerenosToRightClick(object sender, EventArgs e)
        {
            MoveSelectedItems(lb1, lb2);
        }

        private void btnPerenosToLeftClick(object sender, EventArgs e)
        {
            MoveSelectedItems(lb2, lb1);
        }

        private void btnPerenosAllToRightClick(object sender, EventArgs e)
        {
            MoveAllItems(lb1, lb2);
        }

        private void btnPerenosAllToLeftClick(object sender, EventArgs e)
        {
            MoveAllItems(lb2, lb1);
        }

        private void MoveSelectedItems(ListBox sourceListBox, ListBox destinationListBox)
        {
            destinationListBox.Items.AddRange(sourceListBox.SelectedItems.Cast<object>().ToArray());

            foreach (object selectedItem in sourceListBox.SelectedItems.Cast<object>().ToArray())
            {
                sourceListBox.Items.Remove(selectedItem);
            }
        }

        private void MoveAllItems(ListBox sourceListBox, ListBox destinationListBox)
        {
            destinationListBox.Items.AddRange(sourceListBox.Items.Cast<object>().ToArray());
            sourceListBox.Items.Clear();
        }
        private void ListBox1btnClearClick(object sender, EventArgs e)
        {
            lb1.Items.Clear();
        }
        private void ListBox2btnClearClick(object sender, EventArgs e)
        {
            lb2.Items.Clear();
        }
        private void Sort1(object sender, EventArgs e)
        {
            int selectedIndex = cb2.SelectedIndex;

            switch (selectedIndex)
            {
                case 1:
                    lb1.Sorted = false;
                    lb1.Items.Cast<object>().OrderBy(item => item.ToString().Length).ToArray();
                    break;
                case 2:
                    lb1.Sorted = false;
                    lb1.Items.Cast<object>().OrderByDescending(item => item.ToString().Length).ToArray();
                    break;
                case 3:
                    lb1.Sorted = true;
                    break;
                case 4:
                    lb1.Sorted = true;
                    lb1.Items.Cast<object>().Reverse();
                    break;
                default:
                    break;
            }
        }
        private void Sort2(object sender, EventArgs e)
        {
            int selectedIndex = cb3.SelectedIndex;

            switch (selectedIndex)
            {
                case 1:
                    lb2.Sorted = false;
                    lb2.Items.Cast<object>().OrderBy(item => item.ToString().Length).ToArray();
                    break;
                case 2:
                    lb2.Sorted = false;
                    lb2.Items.Cast<object>().OrderByDescending(item => item.ToString().Length).ToArray();
                    break;
                case 3:
                    lb2.Sorted = true;
                    break;
                case 4:
                    lb2.Sorted = true;
                    lb2.Items.Cast<object>().Reverse();
                    break;
                default:
                    break;
            }
        }
    }
}
