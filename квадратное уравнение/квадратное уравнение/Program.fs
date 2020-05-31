open System
open System.Windows.Forms
open System.IO
open System.Drawing 


let MainForm = new Form(Width = 379, Height = 470, Text = "квадратное уравнение Form" )
let Label1 = new Label(Top = 32, Left = 40, Text = "a")
let Label2 = new Label(Left = 40, Top = 90, Text = "b")
//let Label3 = new Label(Left = 40, Top = 148, Text = "с")
//let textBox3 = new TextBox (Top = 174, Left = 40, Width = 70)
let textBox1 = new TextBox (Top = 60, Left = 40, Width = 70) 
let textBox2 = new TextBox (Top = 117, Left = 40, Width = 70) 
let ThisButton = new Button(Top = 330 ,Left = 135, Width = 75, Height = 23, Text = "посчитать" )
//let richtextbox = new RichTextBox (Top = 32, Left = 180, Width = 150, Height = 200)

 

MainForm.Controls.Add(Label1)
MainForm.Controls.Add(Label2)
//MainForm.Controls.Add(Label3)
MainForm.Controls.Add(textBox1)
MainForm.Controls.Add(textBox2)
//MainForm.Controls.Add(textBox3)
MainForm.Controls.Add(ThisButton)
//MainForm.Controls.Add(richtextbox)


//let discrim =  Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox2.Text)  -  4.0 * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox3.Text) 



let pr1  = 2*2
let pr _ = MessageBox.Show (Convert.ToString(pr1),"умножение")|>ignore

let _ = ThisButton.Click.Add(pr)


//let x1:double =     (Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(textBox2.Text)
 //   if discrim > 0 then 
 //   let x1 _ = MessageBox.Show ( - ( ( ( (Convert.ToDouble(textBox2.Text ) ) + sqrt discrim ) / (2.0 * (Convert.ToDouble(textBox1.Text) ) ) ) ) |> ignore

//let  x2: double = 
 //        if discrim > 0 then let x2 _ = MessageBox.Show (- ( (Convert.ToDouble(textBox2.Text ) ) ) - sqrt discrim ) / (2.0 * (Convert.ToDouble(textBox1.Text) ) )|> ignore

//let discrim = 0 then  let x1 _ = MessageBox.Show (-((System.Convert.ToInt32 (Label2.Text) / (2 * ( (System.Convert.ToInt32(Label1.Text) ) ) ) ) ) ) |> ignore 

//elif discrim < 0 then 
  //               let x1 _ = MessageBox.Show(Text = "действительных корней не существует")

//let _= ThisButton.Click.Add ( x1)  

    

[<EntryPoint>]
    let main argv = 
    Application.Run(MainForm)
    0