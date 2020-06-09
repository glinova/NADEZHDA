let prost n =
    let rec poisk n r =
        if (n=1) then false
        else
        if (r=n/2+1) then true
        else
        if (n%r=0) then false 
        else poisk n (r+1)
    poisk n 2

let rec razl chislo =
    let rec razlb chislo delitel pred now =
        if (delitel>chislo && chislo <> 1) then -1
            else
                if(prost chislo) then
                    if (chislo = pred) then now
                        else 
                            now+1
                else 
                    if (chislo=1) then now
                        else 
                            if(prost delitel = true && chislo%delitel=0) then
                                if (delitel=pred) then razlb (chislo/delitel) delitel pred (now)
                                    else
                                        razlb (chislo/delitel) delitel delitel (now+1)
                            else 
                                razlb chislo (delitel+1) delitel now
    razlb chislo 2 1 0



let rec perebor chislo vsegochis now =
    if (now = vsegochis) then chislo;
        else 
            let uniq = razl chislo
            if (uniq = vsegochis) then perebor (chislo+ 1) vsegochis (now+1)
                else 
                    perebor (chislo+1) vsegochis 0
            
[<EntryPoint>]
let main argv =
    let rec output chislo now=
        if(now=0) then ()
        else
        System.Console.Write(chislo-now)
        System.Console.Write(" ")
        output chislo (now-1)
    
    let count = System.Convert.ToInt32(System.Console.ReadLine());
    let result = perebor 2 count 0
    
    output result count
    System.Console.WriteLine()
    0