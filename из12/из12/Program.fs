let rec read_list n = 
    if n=0 then []
    else
    let head = System.Convert.ToInt32(System.Console.ReadLine())
    let tail = read_list (n-1)
    head::tail

let read_data=
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    read_list n

    
let rec list =
    match list with
    | [] -> 0
    | head::tail -> 

    
    
    
    
let prog list =
    match list with
    | []-> 0
    | head::tail -> prog2 prov head tail 
