open System
open System.Windows.Forms
open System.IO
open System.Drawing


let MainForm = new Form(Width = 379, Height = 470, Text = "квадратное уравнение Form" )
let Label1ForButton = new Label(Top = 32, Left = 20, Text = "a" )
let ThisButton = new Button( Top = 75, Left = 23, Text = "посчитать" )

MainForm.Controls.Add(Label1ForButton)
MainForm.Controls.Add(ThisButton)

[<EntryPoint>]
let main argv = 
    Application.Run(MainForm)
    0