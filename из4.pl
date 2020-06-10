in_list([El|_],El).
in_list([_|T],El):-in_list(T,El).

iz4:-Deti=[_,_,_,_,_],
    in_list(Deti,[alik,_]),
    in_list(Deti,[borya,_]),
    in_list(Deti,[vitya,_]),
    in_list(Deti,[lena,_]),
    in_list(Deti,[dasha,_]),
    in_list(Deti,[_,harkov]),
    in_list(Deti,[_,ymani]),
    in_list(Deti,[_,poltava]),
    in_list(Deti,[_,slavyansk]),
    in_list(Deti,[_,kramatorsk]),

    (
        ( in_list(Deti,[alik,ymani]);
          in_list(Deti,[borya,kramatorsk])),

       ( in_list(Deti,[borya,harkov]);
         in_list(Deti,[vitya,harkov])),

        ( in_list(Deti,[vitya,slavyansk]);
          in_list(Deti,[lena,sarkov])),

        (   in_list(Deti,[dasha,ymani]);
            in_list(Deti,[lena,kramatorsk]))
    ),

    in_list(Deti,[A,harkov]),
    in_list(Deti,[B,ymani]),
    in_list(Deti,[C,poltava]),
    in_list(Deti,[D,slavyansk]),
    in_list(Deti,[E,kramatorsk]),
    write("Harkov"),write(" "),write(A),nl,
    write("Ymani"), write(" "),write(B),nl,
    write("Poltava"), write(" "),write(C),nl,
    write("Slavyansk"),write(" "),write(D),nl,
    write("Kramatorsk"),write(" "),write(E),!.


