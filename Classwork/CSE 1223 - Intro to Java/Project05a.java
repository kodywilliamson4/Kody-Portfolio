/*
 * Project05a.java
 *  This code will select a random number and have the user guess until the guess the correct number
 * 
 * @Kody Williamson
 * @20180215
 * 
 */

package osu.cse1223;

import java.util.Scanner;

public class Project05a {

	public static void main(String[] args) {
		
		//Initializing variables
		int guess=0;
		int tries=0;
		
		//Creating random answer between 1 and 200
		int answer=(int)(200 * Math.random()) + 1;
		
		//Creating while loop to make sure it continues until the correct user answer
		Scanner in = new Scanner(System.in);
		while(guess!=answer) {
			System.out.print("Enter a guess between 1 and 200: ");
			tries=tries+1;
			guess=in.nextInt();
			
			//Creating if statements for correct feedback
			if(guess<1||guess>200) {
				System.out.println("Your guess is out of range.  Pick a number between 1 and 200.");
			}
			
			else if(guess<answer) {
				System.out.println("Your guess was too low.  Try again.");
			}
			
			else if(guess>answer) {
				System.out.println("Your guess was too high.  Try again.");
			}
			
			else if(guess==answer) {
				System.out.println("Congratulations!  Your guess was correct!");
			}
			System.out.println();
			
		}
		
		//Outputting final statements based on number of tries
		
		if(tries==1) {
		System.out.println("I had chosen " + answer + " as the target number.");
		System.out.println("You guessed it in " + tries + " tries.");
		System.out.println("That was astounding!");
		}
		
		else if(tries<5) {
		System.out.println("I had chosen " + answer + " as the target number.");
		System.out.println("You guessed it in " + tries + " tries.");
		System.out.println("That was lucky!");
		}
		
		else if(tries<7) {
		System.out.println("I had chosen " + answer + " as the target number.");
		System.out.println("You guessed it in " + tries + " tries.");
		System.out.println("That was pretty good.");
		}
		
		else if(tries<8) {
		System.out.println("I had chosen " + answer + " as the target number.");
		System.out.println("You guessed it in " + tries + " tries.");
		System.out.println("That was not that impressive");
		}
		
		else if(tries<10) {
		System.out.println("I had chosen " + answer + " as the target number.");
		System.out.println("You guessed it in " + tries + " tries.");
		System.out.println("Are you sure this is the right game for you?");
		}
		
		else {
		System.out.println("I had chosen " + answer + " as the target number.");
		System.out.println("You guessed it in " + tries + " tries.");
		System.out.println("This just isn't your game, is it?");
		}

	}

}
