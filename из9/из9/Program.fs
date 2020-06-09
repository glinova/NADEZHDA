let chisl n =
    let rec r n k =
if ((n=1) && (n % k=0))then false
else
if (k=n/2+1) then true
else r n (k+1)
    r n 2