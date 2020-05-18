open System
open System.Windows.Forms
open System.IO
open System.Drawing

let label1 = new System.Windows.Forms.Label()
let richTextBox1 = new System.Windows.Forms.RichTextBox()
let button1 = new System.Windows.Forms.Button()
let textBox1 = new System.Windows.Forms.TextBox()
let textBox2 = new System.Windows.Forms.TextBox()
let textBox3 = new System.Windows.Forms.TextBox()
let label2 = new System.Windows.Forms.Label()
let label3 = new System.Windows.Forms.Label()
let SuspendLayout()
            // 
            // label1
            // 
    let label1.AutoSize = true
    let label1.Location = new System.Drawing.Point(37, 54)
    let label1.Name = "label1"
    let label1.Size = new System.Drawing.Size(13, 13)
    let label1.TabIndex = 0
    let label1.Text = "a"
            // 
            // richTextBox1
            // 
    let richTextBox1.Location = new System.Drawing.Point(201, 51);
    let richTextBox1.Name = "richTextBox1";
    let richTextBox1.Size = new System.Drawing.Size(150, 205);
    let richTextBox1.TabIndex = 1;
    let richTextBox1.Text = "";
            // 
            // button1
            // 
            let button1.Location = new System.Drawing.Point(142, 330);
            let button1.Name = "button1";
            let button1.Size = new System.Drawing.Size(75, 23);
            let button1.TabIndex = 2;
            let button1.Text = "посчитать";
            let button1.UseVisualStyleBackColor = true;
            let button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            let textBox1.Location = new System.Drawing.Point(28, 85);
            let textBox1.Name = "textBox1";
            let textBox1.Size = new System.Drawing.Size(32, 20);
            let textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            let textBox2.Location = new System.Drawing.Point(91, 85);
            let textBox2.Name = "textBox2";
            let textBox2.Size = new System.Drawing.Size(33, 20);
            let textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            let textBox3.Location = new System.Drawing.Point(152, 85);
            let textBox3.Name = "textBox3";
            let textBox3.Size = new System.Drawing.Size(33, 20);
            let textBox3.TabIndex = 5;
            // 
            // label2
            // 
            let label2.AutoSize = true;
            let label2.Location = new System.Drawing.Point(99, 54);
            let label2.Name = "label2";
            let label2.Size = new System.Drawing.Size(13, 13);
            let label2.TabIndex = 6;
            let label2.Text = "b";
            // 
            // label3
            // 
            let label3.AutoSize = true;
            let label3.Location = new System.Drawing.Point(162, 54);
            let label3.Name = "label3";
            let label3.Size = new System.Drawing.Size(13, 13);
            let label3.TabIndex = 7;
            let label3.Text = "c";
            // 
            // Form1
            // 
            let AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            let AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            let ClientSize = new System.Drawing.Size(363, 432);
            let Controls.Add(this.label3);
            let Controls.Add(this.label2);
            let Controls.Add(this.textBox3);
            let Controls.Add(this.textBox2);
            let Controls.Add(this.textBox1);
            let Controls.Add(this.button1);
            let Controls.Add(this.richTextBox1);
            let Controls.Add(this.label1);
            let Name = "Form1";
            let Text = "Form1";
            let ResumeLayout(false);
            let PerformLayout();