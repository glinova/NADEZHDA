let rec read_list n = 
    if n=0 then []
    else
    let head = System.Convert.ToInt32(System.Console.ReadLine())
    let tail = read_list (n-1)
    head::tail

let read_data=
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    read_list n

let findcount list el =
    let rec count list el =
        match list with 
    |   [] -> false
    |   h::t -> if list element then 
                            if elem=h then count (n+1) el t
                            else count n el t
count 0 elem count








let podshet list el =
    let rec count n elem  = function
    [] -> false
    |h::t -> if 





let rec uniq L1 list elem = function
    |[] -> L1
    | h::t -> let l = h::L1 if (findReapeats list h) then
                            uniq l list h t
                            else uniq L1 list elem t





let rec findReapeats list elem = function
    |[] -> true
    |h::t -> if h = elem  then false
             else findReapeats t elem t




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
