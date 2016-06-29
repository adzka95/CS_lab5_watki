namespace lab5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.odpTaks = new System.Windows.Forms.Label();
            this.odpDelegaty = new System.Windows.Forms.Label();
            this.odpAsynch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.odpTas = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.wynikFibbo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.odpLiczbyLosowe = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symbol Newtona:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "K:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Taks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.taski);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delegaty";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.delegaty);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Async-await";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.asynch);
            // 
            // odpTaks
            // 
            this.odpTaks.AutoSize = true;
            this.odpTaks.Location = new System.Drawing.Point(143, 73);
            this.odpTaks.Name = "odpTaks";
            this.odpTaks.Size = new System.Drawing.Size(0, 13);
            this.odpTaks.TabIndex = 8;
            // 
            // odpDelegaty
            // 
            this.odpDelegaty.AutoSize = true;
            this.odpDelegaty.Location = new System.Drawing.Point(143, 103);
            this.odpDelegaty.Name = "odpDelegaty";
            this.odpDelegaty.Size = new System.Drawing.Size(0, 13);
            this.odpDelegaty.TabIndex = 9;
            // 
            // odpAsynch
            // 
            this.odpAsynch.AutoSize = true;
            this.odpAsynch.Location = new System.Drawing.Point(143, 133);
            this.odpAsynch.Name = "odpAsynch";
            this.odpAsynch.Size = new System.Drawing.Size(0, 13);
            this.odpAsynch.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Liczby Fibonacciego:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "i:";
            // 
            // odpTas
            // 
            this.odpTas.AutoSize = true;
            this.odpTas.Location = new System.Drawing.Point(143, 73);
            this.odpTas.Name = "odpTas";
            this.odpTas.Size = new System.Drawing.Size(0, 13);
            this.odpTas.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(48, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(42, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Oblicz";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.liczFibbo);
            // 
            // wynikFibbo
            // 
            this.wynikFibbo.AutoSize = true;
            this.wynikFibbo.Location = new System.Drawing.Point(143, 213);
            this.wynikFibbo.Name = "wynikFibbo";
            this.wynikFibbo.Size = new System.Drawing.Size(0, 13);
            this.wynikFibbo.TabIndex = 16;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(35, 238);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(227, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(36, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Skompresuj";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.kopresuj);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Kompresuj:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(146, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Zdekompresuj";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.dekompresuj);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "DNS:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(36, 337);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "rozwiaz";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Liczby losowe:";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(25, 508);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 24;
            this.button8.Text = "Generuj";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.liczbylosowe);
            // 
            // odpLiczbyLosowe
            // 
            this.odpLiczbyLosowe.AutoSize = true;
            this.odpLiczbyLosowe.Location = new System.Drawing.Point(143, 511);
            this.odpLiczbyLosowe.Name = "odpLiczbyLosowe";
            this.odpLiczbyLosowe.Size = new System.Drawing.Size(40, 13);
            this.odpLiczbyLosowe.TabIndex = 26;
            this.odpLiczbyLosowe.Text = "           ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 367);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(215, 117);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.klik);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.pracaWorkera);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.zmiana);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.koniecWorkera);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 543);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.odpLiczbyLosowe);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.wynikFibbo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.odpTas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.odpAsynch);
            this.Controls.Add(this.odpDelegaty);
            this.Controls.Add(this.odpTaks);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label odpTaks;
        private System.Windows.Forms.Label odpDelegaty;
        private System.Windows.Forms.Label odpAsynch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label odpTas;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label wynikFibbo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label odpLiczbyLosowe;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

