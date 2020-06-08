let rec read_list n = 
    if n=0 then []
    else
    let head = System.Convert.ToInt32(System.Console.ReadLine())
    let tail = read_list (n-1)
    head::tail

let read_data=
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    read_list n


let unic list el =
    let rec unic1 el = function 
    [] -> false
    |h::t  -> if el = h then unic1 n el t

    //проверить след элемент из исходного, если он равен эл-ту из L1, то пропускаем

let wow_new_list list =
    let rec wow_new_list1 L1 list = function
    [] -> L1
    | h::t -> let l = h::L1
              if ()
                


let rec in_list_exclude list el = function
    [] ->true
    |h::t -> if h=el then false
                else in_list_exclude t el t




    
//let rec count list el =
//    match list with 
//    | [] -> false
//    | head::tail -> if n then 
//                         if el=h then count (n+1) el t
//                         else count n el t
//count 0 el list
    
    
    
    
//let prog list =
//    match list with
//    | []-> 0
//    | head::tail -> prog2 prov head tail 
