let chisl n =
    let rec poisk n r =
        if (n=1) && (n%r=0) then false
        else
        if (r=n/2+1) then true
        else poisk n (r+1)
    poisk n 2


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