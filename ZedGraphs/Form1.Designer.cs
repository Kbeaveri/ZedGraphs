namespace ZedGraphs
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
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.color_choice = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_Rez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Imz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(0, 0);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(998, 592);
            this.zedGraph.TabIndex = 0;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // color_choice
            // 
            this.color_choice.AutoSize = true;
            this.color_choice.Location = new System.Drawing.Point(1029, 71);
            this.color_choice.Name = "color_choice";
            this.color_choice.Size = new System.Drawing.Size(131, 20);
            this.color_choice.TabIndex = 1;
            this.color_choice.Text = "График в цвете";
            this.color_choice.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1029, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 136);
            this.button1.TabIndex = 2;
            this.button1.Text = "Построить График";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_R
            // 
            this.textBox_R.Location = new System.Drawing.Point(1060, 115);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(100, 22);
            this.textBox_R.TabIndex = 3;
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(1060, 143);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 22);
            this.textBox_a.TabIndex = 4;
            // 
            // textBox_Rez
            // 
            this.textBox_Rez.Location = new System.Drawing.Point(1060, 171);
            this.textBox_Rez.Name = "textBox_Rez";
            this.textBox_Rez.Size = new System.Drawing.Size(100, 22);
            this.textBox_Rez.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1024, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "R = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1026, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "a = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1005, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Re z0 = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1009, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Im z0 = ";
            // 
            // textBox_Imz
            // 
            this.textBox_Imz.Location = new System.Drawing.Point(1060, 199);
            this.textBox_Imz.Name = "textBox_Imz";
            this.textBox_Imz.Size = new System.Drawing.Size(100, 22);
            this.textBox_Imz.TabIndex = 10;
            this.textBox_Imz.TextChanged += new System.EventHandler(this.textBox_Imz_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1190, 595);
            this.Controls.Add(this.textBox_Imz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Rez);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.textBox_R);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.color_choice);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.CheckBox color_choice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_Rez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Imz;
    }
}