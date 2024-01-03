/* here you write your code for Task 2 */

max([X],X).
max([Head|Tail], Y) :- max(Tail,X), (Head > X -> Head = Y; X = Y).