/*
 * Project07.java
 * 
 *   A program that plays the dice game high/low
 *   Used to practice breaking code up into methods. 
 * 
 * @author Kody Williamson
 * @version ENTER THE DATE HERE
 * 
 */
package osu.cse1223;
import java.util.Scanner;


public class Project07 {


	public static void main(String[] args) {
		//Bringing in keyboard
		Scanner in = new Scanner(System.in);
		
		//Initializing variables
		int cash=100;
		int d1=0;
		int d2=0;
		int total=0;
		int bet=-1;
		char guess='A';
		int winnings=0;
		
		//Creating while loop to keep the following going while bet isnt 0
		while(bet!=0 && cash!=0) {
			
			//Setting variables back to 0
			winnings=0;
		
			//Running method for finding bet
			bet=getBet(in,cash);
			
			if(bet!=0 && cash!=0) {
				//Running method for finding user choice to bet on
				guess=getHighLow(in);
				
				//Running method to determine dice roll
				d1=getRoll();
				d2=getRoll();
				total=d1+d2;
				System.out.println("Total of two dice is: " + total);
				
				//Running method to determine winnings
				winnings=determineWinnings(guess,bet,total);
				cash=cash+winnings-bet;
				System.out.println();
			}
				
			else {
				System.out.println("You have " + cash + " dollars left");
				System.out.println("Goodbye!");
			}
		}
		
	}
	
	
	// Given a Scanner and a current maximum amount of money, prompt the user for
	// an integer representing the number of dollars that they want to bet.  This
	// number must be between 0 and to maximum number of dollars.  If the user enters
	// a number that is out of bounds, display an error message and ask again.
	// Return the bet to the calling program.
	private static int getBet(Scanner inScanner, int currentPool) {
		int input=-1;
		while(input<0 || input>currentPool) {
			System.out.println("You have " + currentPool +" dollars.");
			System.out.print("Enter an amount to bet (0 to quit): ");
			input=inScanner.nextInt();
			if(input>currentPool || input<0) {
				System.out.println("Your bet MUST be between 0 and 100 dollars");
			}
		}
		
		return input;
	}
	
	// Given a Scanner, prompt the user for a single character indicating whether they
	// would like to bet High ('H'), Low ('L') or Sevens ('S').  Your code should accept
	// either capital or lowercase answers, but should display an error if the user attempts
	// to enter anything but one of these 3 values and prompt for a valid answer.
	// Return the character to the calling program.
	private static char getHighLow(Scanner inScanner) {
		char guess='A';
		while(guess!='H'&& guess!='h' && guess!='L' && guess!='l' && guess!='S' && guess!='s') {
			System.out.print("High, low or sevens (H/L/S): ");
			guess=inScanner.next().charAt(0);
			if(guess!='H'&& guess!='h' && guess!='L' && guess!='l' && guess!='S' && guess!='s') {
				System.out.println("ERROR - MUST ENTER H, L or S");
			}
		}
		
		return guess;
		
	}
	
	// Produce a random roll of a single six-sided die and return that value to the calling
	// program
	private static int getRoll() {
		int roll=(int)(6 * Math.random()) + 1;
		
		return roll;
	}
	
	// Given the choice of high, low or sevens, the player's bet and the total result of
	// the roll of the dice, determine how much the player has won.  If the player loses
	// the bet then winnings should be negative.  If the player wins, the winnings should
	// be equal to the bet if the choice is High or Low and 4 times the bet if the choice
	// was Sevens.  Return the winnings to the calling program.
	private static int determineWinnings(char highLow, int bet, int roll) {
		int winnings=0;
		if(roll==7) {
			if(highLow=='S' || highLow=='s') {
				winnings=bet*4;
				System.out.println("You won " + winnings + " dollars!");
			}
		}
		else if(roll>7) {
			if(highLow=='H' || highLow=='h') {
				winnings=bet*2;
				System.out.println("You won " + winnings + " dollars!");
			}
		}
		else if(roll<7) {
			if(highLow=='L' || highLow=='l') {
				winnings=bet*2;
				System.out.println("You won " + winnings + " dollars!");
			}
		}
		else {
			winnings=0;
			System.out.println("You lost!");
		}
		
		return winnings;
	}

}
