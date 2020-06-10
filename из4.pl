in_list([El|_],El).
in_list([_|T],El):-in_list(T,El).

iz4:-Deti[_,_,_,_,_],
    in_list(Deti,[Alik,_]),
    in_list(Deti,[Boris,_]),
    in_list(Deti,[Vitya,_]),
    in_list(Deti,[Lena,_]),
    in_list(Deti,[Dasha,_])

