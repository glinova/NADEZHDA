let rec read_list n = 
    if n=0 then []
    else
    let head = System.Convert.ToInt32(System.Console.ReadLine())
    let tail = read_list (n-1)
    head::tail

let read_data=
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    read_list n

let findcount list elem =
    let rec find list elem count = function
    |[] -> count 
    |h::t -> if elem = h then find (count+1) elem t
                        else find elem t
 find 0 elem list
        



let podshet list el =
    let rec count n elem  = function
    [] -> false
    |h::t -> if 


let rec findReapeats list elem = function
    |[] -> true
    |h::t -> if h = elem  then false
             else findReapeats t elem t


let rec uniq L1 list elem = function
    |[] -> L1
    | h::t -> let l = h::L1 if (findReapeats list h) then
                                uniq l list h t
                                else uniq L1 list elem t





    //проверить след элемент из исходного, если он равен эл-ту из L1, то пропускаем

//let new_list list =
//    let rec new_list L1 list = function
//    [] -> L1
//    | h::t -> let l = h::L1
//              if ()
                


//let rec in_list_exclude list el = function
//    [] ->true
//    |h::t -> if h=el then false
//                else in_list_exclude t el t

    
    
    
    
//let prog list =
//    match list with
//    | []-> 0
//    | head::tail -> prog2 prov head tail 
