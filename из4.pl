in_list([El|_],El).
in_list([_|T],El):-in_list(T,El).

iz4:-Deti[_,_,_,_,_],
    in_list(Deti,[Alik,_]),
    in_list(Deti,[Boris,_]),
    in_list(Deti,[Vitya,_]),
    in_list(Deti,[Lena,_]),
    in_list(Deti,[Dasha,_]),
    in_list(Deti,[_,Harkov]),
    in_list(Deti,[_,Ymani]),
    in_list(Deti,[_,Poltava]),
    in_list(Deti,[_,Slavyansk]),
    in_list(Deti,[_,Kramatorsk]),

    (
     ( in_list(Deti,[Alik,Ymani]);
       in_list(Deti,[Borya,Kramatorsk])),

       ( in_list(Deti,[Borya,Harkov]);
         in_list(Deti,[Vitya,Harkov])),

        ( in_list(Deti,[Vitya,Slavyansk]);
        in_list(Deti,[Lena,Harkov])),

        (   in_list(Deti,[Dasha,Ymani]);
        in_list(Deti,[Lena,Kramatorsk])),
    )

    in_list(Deti,[A,Harkov]),
    in_list(Deti,[B,Ymani]),
    in_list(Deti,[C,Poltava]),
    in_list(Deti,[D,Slavyansk]),
    in_list(Deti,[E,Kramatorsk]),
    write("Harkov"),write(" "),write(A),
    write("Ymani"), write(" "),write(B),
    write("Poltava"), write(" "),write(C),
    write("Slavyansk"),write(" "),write(D),
    write("Kramatorsk"),write(" "),write(E),!.


