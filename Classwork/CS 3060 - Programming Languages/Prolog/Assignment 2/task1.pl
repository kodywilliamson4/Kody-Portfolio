/* here you write your code for Task 1 */
hasDirectFlight(newOrleans, chicago).
hasDirectFlight(philadelphia, newOrleans).
hasDirectFlight(columbus, philadelphia).
hasDirectFlight(sanFrancisco, columbus).
hasDirectFlight(detroit, sanFrancisco).
hasDirectFlight(toledo, detroit).
hasDirectFlight(houston, sanFrancisco).

hasFlightRoute(X, Y) :- hasDirectFlight(X, Y).
hasFlightRoute(X, Y) :- hasDirectFlight(X, Z), hasFlightRoute(Z, Y).

findFlightRoute(X, Y) :- hasDirectFlight(X, Y), write(X), write(->), write(Y).
findFlightRoute(X, Y) :- write(X), write(->), hasDirectFlight(X, Z), findFlightRoute(Z, Y).
