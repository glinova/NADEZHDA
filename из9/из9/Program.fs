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
