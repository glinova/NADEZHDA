let rec read_list n = 
    if n=0 then []
    else
    let head = System.Convert.ToInt32(System.Console.ReadLine())
    let tail = read_list (n-1)
    head::tail

let read_data=
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    read_list n


//let rec write_list (list:int list)=
//    match list with 
//    |[] ->  let z=System.Console.ReadKey()
//            0
//    |h::t -> System.Console.WriteLine(h.ToString())
//             write_list t   

//let findcount list elem =
//    let rec find list elem count = function
//    |[] -> count 
//    |h::t -> if elem = h then find (count+1) elem t
//                        else find elem t
 

//let List1 (input:list<int>) =
//    let rec findReapeats list elem = function
//        |[] -> true
//        |h::t -> if h = elem  then false
//                    else findReapeats t elem t

//    let rec uniq L1 list elem = function
//        |[] -> L1
//        |h::t -> let l= h::L1 
//                 if (findReapeats list h) then
//                   uniq l list h t
//                  else uniq L1 list elem t

//let rec vivod L1 = 
//    match L1 with
//    |[] -> ()
//    |h::t -> System.Console.Write(L1.ToString)
//             vivod 
//let L1 = uniq [] input





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


let list1 (input:list<int>) =
    let rec findRepeats list elem = function
    |[] -> true
    |h::t -> if h = elem then false
                else findRepeats t elem t

let new_uniq list=   
    let rec uniq list1 input = function
    |[] -> list1 
    |h::t ->    let L1=h::list1
                if (findRepeats list h) && (findRepeats list1 h list1) then
                uniq L1 input h t
                else uniq list1 input t

let rec output (list1:int list)=
    match list1 with
    |[] -> let z=System.Console.ReadKey()
            0
    |h::then -> System.Console.WriteLine ((findRepeats )

////где-то тут вывод list1
//let rec output list1 = function
//|[] -> ()
//|h::t -> System.Console.Write(list1 h)
//        output list1 t

//let (list1:list<int>) = uniq [] input



let list2 (input:list<int>) list1 =
    let rec findCount input elem count = function
    |[] -> count 
    |h::t -> if h=elem then findCount input t (count+1)
             else findCount input t count

    findCount 0 el





[<EntryPoint>]
let main argv = read_data|>list2|>list1




