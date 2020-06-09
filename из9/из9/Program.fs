let chisl n =
    let rec poisk n r =
        if (n=1) && (n%r=0) then false
        else
        if (r=n/2+1) then true
        else poisk n (r+1)
    poisk n 2



