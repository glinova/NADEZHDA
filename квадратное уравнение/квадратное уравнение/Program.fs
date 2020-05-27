open System
open System.Windows.Forms
open System.IO
open System.Drawing 


let MainForm = new Form(Width = 379, Height = 470, Text = "квадратное уравнение Form" )
let Label1 = new Label(Top = 32, Left = 40, Text = "a")
let Label2 = new Label(Left = 40, Top = 90, Text = "b")
let Label3 = new Label(Left = 40, Top = 148, Text = "с")
let textBox3 = new TextBox (Top = 174, Left = 40, Width = 70)
let textBox1 = new TextBox (Top = 60, Left = 40, Width = 70) 
let textBox2 = new TextBox (Top = 117, Left = 40, Width = 70) 
let ThisButton = new Button(Top = 330 ,Left = 135, Width = 75, Height = 23, Text = "посчитать" )
let richTextBox = new RichTextBox (Top = 32, Left = 180, Width = 150, Height = 200)

 


MainForm.Controls.Add(Label1)
MainForm.Controls.Add(Label2)
MainForm.Controls.Add(Label3)
MainForm.Controls.Add(textBox1)
MainForm.Controls.Add(textBox2)
MainForm.Controls.Add(textBox3)
MainForm.Controls.Add(ThisButton)
MainForm.Controls.Add(richTextBox)


let discrim = ( Convert.ToDouble(texBox2.Text) * Convert.ToDouble(texBox2.Text) ) - ( 4 * Convert.ToDouble(texBox1.Text) * Convert.ToDouble(texBox3.Text) )

let f (x1: double , x2: double) = 
    if discrim > 0 
    then let x1 _ = MessageBox.Show ( - ( ( ( (Convert.ToDouble(texBox2.Text ) ) + sqrt discrim ) / (2 * (Convert.ToDouble(texBox1.Text) ) ) ) )|> ignore
         let x2 _ = MessageBox.Show (- ( (System.Convert.ToInt32 (Label2.Text) ) ) - sqrt discrim ) / (2 * (System.Convert.ToInt32(Label1.Text) ) )|> ignore

//let discrim = 0 then  let x1 _ = MessageBox.Show (-((System.Convert.ToInt32 (Label2.Text) / (2 * ( (System.Convert.ToInt32(Label1.Text) ) ) ) ) ) ) |> ignore 

//elif discrim < 0 then 
  //               let x1 _ = MessageBox.Show(Text = "действительных корней не существует")

//let _= ThisButton.Click.Add (discrim)  

    


[<EntryPoint>]
let main argv = 
    Application.Run(MainForm)
    0