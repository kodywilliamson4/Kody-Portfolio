/* here you write your code for Task 3 */

hasDirectFlight(newOrleans, chicago).
hasDirectFlight(philadelphia, newOrleans).
hasDirectFlight(columbus, philadelphia).
hasDirectFlight(sanFrancisco, columbus).
hasDirectFlight(detroit, sanFrancisco).
hasDirectFlight(toledo, detroit).
hasDirectFlight(houston, sanFrancisco).

hasFlightRoute(X, Y) :- hasDirectFlight(X, Y).
hasFlightRoute(X, Y) :- hasDirectFlight(X, Z), hasFlightRoute(Z, Y).