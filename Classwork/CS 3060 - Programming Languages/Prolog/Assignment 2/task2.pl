/* here you write your code for Task 2 */

2a.

deleteFirst(X, [], []).
deleteFirst(A, [H|T], T).
deleteFirst(A, [H|T], [H|Output]) :- deleteFirst(A, T, Output).
writeFile(A, List) :- write('Input file name'), read(Filename), open(Filename, write, Str), deleteFirst(A, List, Output), write(Str, Output), close(Str). 

2b. 

deleteAll(X, [], []).
deleteAll(A, [A|T], Output) :- deleteAll(A, T, Output).
deleteAll(A, [H|T], [H|Output]) :- dif(A, H), deleteAll(A, T, Output).
writeFile(A, List) :- write('Input file name'), read(Filename), open(Filename, write, Str), deleteAll(A, List, Output), write(Str, Output), close(Str). 
