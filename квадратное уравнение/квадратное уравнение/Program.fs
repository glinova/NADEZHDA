﻿open System
open System.Windows.Forms
open System.IO
open System.Drawing 





let MainForm = new Form(Width = 379, Height = 470, Text = "квадратное уравнение Form" )
let Label1 = new Label(Top = 32, Left = 40, Text = "a")
let Label2 = new Label(Left = 40, Top = 90, Text = "b")
let Label3 = new Label(Left = 40, Top = 148, Text = "с")
let textBox1 = new TextBox (Top = 60, Left = 40, Width = 70) 
let textBox2 = new TextBox (Top = 117, Left = 40, Width = 70) 
let textBox3 = new TextBox (Top = 174, Left = 40, Width = 70)
let ThisButton = new Button(Top = 330 ,Left = 135, Width = 75, Height = 23, Text = "посчитать" )

 

MainForm.Controls.Add(Label1)
MainForm.Controls.Add(Label2)
MainForm.Controls.Add(Label3)

MainForm.Controls.Add(textBox1)
MainForm.Controls.Add(textBox2)
MainForm.Controls.Add(textBox3)

MainForm.Controls.Add(ThisButton)


let pr _ = 
     if ( Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox2.Text)  -  4.0 * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox3.Text) ) > 0.0 then
        MessageBox.Show( ("X1 = " + Convert.ToString( - ( ( ( (Convert.ToDouble(textBox2.Text ) ) - sqrt (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox2.Text)  -  4.0 * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox3.Text)) ) / (2.0 * (Convert.ToDouble(textBox1.Text) ) ) ) ) ) + "\nX2 = " + Convert.ToString( - ( ( ( (Convert.ToDouble(textBox2.Text ) ) + sqrt (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox2.Text)  -  4.0 * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox3.Text)) ) / (2.0 * (Convert.ToDouble(textBox1.Text) ) ) ) ) ) ) , "умножение") |>ignore
     else if ( Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox2.Text)  -  4.0 * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox3.Text) ) = 0.0 then
           MessageBox.Show( ("X = " + Convert.ToString( - ( ( ( (Convert.ToDouble(textBox2.Text ) ) ) / (2.0 * (Convert.ToDouble(textBox1.Text) ) ) ) ) ) ) , "умножение") |>ignore
           else MessageBox.Show("НЕТ КОРНЕЙ!", "умножение") |>ignore

let _ = ThisButton.Click.Add(pr)

[<EntryPoint>]
    let main argv = 
    Application.Run(MainForm)
    0