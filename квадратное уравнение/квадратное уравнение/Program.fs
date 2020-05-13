open System
open System.Windows.Forms

let form = new Form()
form.Visible <- true
form.Text <- "F# Forms"

let label = new Label()
label.Text <- "F# Labels"

form.Controls.Add(label)

[<STAThread>]
Application.Run(form)

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
