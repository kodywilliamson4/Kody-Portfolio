/* here you write your code for Task 1 */
male(kody).
male(john).
male(drew).
male(benny).
male(brutus).
female(jody).
female(kylee).
female(lindsay).
female(lily).
female(mia).
dog(lily).
dog(brutus).
dog(mia).
dog(benny).
human(kody).
human(john).
human(jody).
human(kylee).
human(lindsay).
human(drew).
parent(lindsay, benny).
parent(kody, benny).
parent(kylee, mia).
parent(drew, mia).
parent(jody, lily).
parent(john, lily).
parent(jody, brutus).
parent(john, brutus).
parent(john, kody).
parent(jody, kody).
parent(john, kylee).
parent(jody, kylee).

%This checks if X is a child of Y, with both being human.
isHumanChild(X, Y) :- parent(Y, X), human(X), human(Y).
%This checks if X is a human, male dog owner
isMaleDogOwner(X) :- male(X), dog(Y), parent(X, Y), human(X).
%This checks if X is a human female who has a kid with a dog.
isDogGrandmother(X) :- female(X), human(Y), dog(Z), parent(X, Y), parent(Y, Z).
%This checks that X and Y share a parent.
shareParent(X, Y) :- parent(Z, X), parent(Z, Y).
