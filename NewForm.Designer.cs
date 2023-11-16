namespace Lab1_4
{
    partial class NewForm
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
        GroupBox gp;
        RadioButton rb1, rb2;
        Label lb;
        TextBox tb;
        Button bt1, bt2;
        private NewForm newForm;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 200);
            this.Text = "NewForm";

            rb1 = new RadioButton();
            rb1.Location = new Point(20, 30);
            rb1.Text = "Раздел 1";
            rb1.Size = new Size(100, 20);
            Controls.Add(rb1);

            rb2 = new RadioButton();
            rb2.Location = new Point(20, 60);
            rb2.Size = new Size(150, 20);
            rb2.Text = "Раздел 2";
            Controls.Add(rb2);

            lb = new Label();
            lb.Text = "Введите текст";
            lb.Location = new Point(20, 110);
            lb.Size = new Size(150, 20);
            Controls.Add(lb);

            tb = new TextBox();
            tb.Location = new Point(20, 130);
            tb.Size = new Size(220, 15);
            Controls.Add(tb);

            bt1 = new Button();
            bt1.Location = new Point(20, 160);
            bt1.Size = new Size(100, 30);
            bt1.Text = "Добавить";
            bt1.BackColor = Color.LightGray;
            bt1.Click += btnAddClick;
            Controls.Add(bt1);

            bt2 = new Button();
            bt2.Location = new Point(140, 160);
            bt2.Size = new Size(100, 30);
            bt2.Text = "Отмена";
            bt2.BackColor = Color.LightGray;
            bt2.Click += btnCloseClick;
            Controls.Add(bt2);

            gp = new GroupBox();
            gp.Text = "Добавить в";
            gp.Size = new Size(235, 95);
            gp.Location = new Point(5, 5);
            Controls.Add(gp);
        }
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddClick(object sender, EventArgs e)
        {
            MyForm Main = this.Owner as MyForm;

            if (tb.Text != "")
            {
                if (this.rb1.Checked == true)
                Main.lb1.Items.Add(this.tb.Text);
                else Main.lb2.Items.Add(this.tb.Text);

                this.Close();
            }
        }
        #endregion
    }   
}