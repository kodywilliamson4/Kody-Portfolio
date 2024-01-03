/*
 * Project04a.java
 *  This code will take a user input for a type of dragon and the users answer will face off a random computer answer to see who wins
 * 
 * @Kody Williamson
 * @20180209
 * 
 */

package osu.cse1223;

import java.util.Scanner;

public class Project04a {

	public static void main(String[] args) {
		
		//Initializing variables to determine overall winner
		int gameNum=0;
		int uWin=0;
		int cWin=0;
		int tie=0;
		
		//Creating loop that stops after one side wins twice
		while(uWin!=2 && cWin!=2) {
		//Initializing integer for later use and determining random integer for computer choice
		int comp=(int)(3 * Math.random()) + 1;
		int user=0;
		
		//Increasing game count by one
		gameNum=gameNum+1;
		
		
		//Taking user input for their type of dragon
		Scanner in = new Scanner(System.in);
		System.out.print("Please select one of your dragons [Fire/Plant/Water]: ");
		String dragon = in.nextLine();
		dragon=dragon.toLowerCase();
		
		//Determining which dragon was chosen
		if(dragon.equals("w")||dragon.equals("water")) {
			dragon = "Water";
			user=3;
			System.out.println("You chose: " + dragon + " dragon");
		}
		else if(dragon.equals("f")||dragon.equals("fire")) {
			dragon = "Fire";
			user=1;
			System.out.println("You chose: " + dragon + " dragon");
		}
		else if(dragon.equals("p")||dragon.equals("plant")) {
			dragon = "Plant";
			user=2;
			System.out.println("You chose: " + dragon + " dragon");
		}
		else {
			System.out.println("You don't have a " + dragon + " dragon, so you choose no dragons.");
		}

		//Outputting the computer's choice of a dragon
		if(comp==1) {
			System.out.println("I chose: Fire dragon");
		}
		else if(comp==2) {
			System.out.println("I chose: Plant dragon");
		}
		else {
			System.out.println("I chose: Water dragon");
		}
		
		//Outputting the winner of the battle
		if(user==1 && comp==1) {
			System.out.println("A Tie!");
			tie=tie+1;
		}
		else if(user==1 && comp==2) {
			System.out.println("Fire defeats Plant - you win!");
			uWin=uWin+1;
		}
		else if(user==1 && comp==3) {
			System.out.println("Water defeats Fire - you lose!");
			cWin=cWin+1;
		}
		else if(user==2 && comp==1) {
			System.out.println("Fire defeats Plant - you lose!");
			cWin=cWin+1;
		}
		else if(user==2 && comp==2) {
			System.out.println("A Tie!");
			tie=tie+1;
		}
		else if(user==2 && comp==3) {
			System.out.println("Plant defeats Water - you win!");
			uWin=uWin+1;
		}
		else if(user==3 && comp==1) {
			System.out.println("Water defeats Fire - you win!");
			uWin=uWin+1;
		}
		else if(user==3 && comp==2) {
			System.out.println("Plant defeats Water - you lose!");
			cWin=cWin+1;
		}
		else if(user==3 && comp==3) {
			System.out.println("A Tie!");
			tie=tie+1;
		}
		else if(user==0) {
			System.out.println("You lose by default");
			cWin=cWin+1;
		}
	}
		System.out.println();
		System.out.println("Out of " + gameNum + " matches you won " + uWin + ", I won " + cWin + ", and we tied " + tie + ".");
		if(uWin==2) {
			System.out.println("Congratulations - You win the tournament!");
		}
		else if(cWin==2) {
			System.out.println("Sorry - You lost the tournament!");
		}
	}

}
