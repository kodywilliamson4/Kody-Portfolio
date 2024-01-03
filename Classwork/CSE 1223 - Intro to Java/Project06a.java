package osu.cse1223;

import java.util.Scanner;

public class Project06a {

	public static void main(String[] args) {
		
		//Bringing in scanner
		Scanner in = new Scanner(System.in);
		
		//Creating string for user input
		String card = "1";
		
		//Creating integers for checking card
		int digit=0;
		int i=0;
		int length=0;
		char lastDig='a';
		int sum=0;
		int checkDig=0;
		int checkDigCal=0;
		
		
		//While loop to keep checking until blank line
		while(!card.equals("")) {
			
			//Getting user input
			System.out.print("Enter a credit card number (enter a blank line to quit):");
			card = in.nextLine();
		
			//Chaning variables for use later
			length=card.length();
			i=0;
		
			//Case 1: Correct number of digits
			if(length==16) {
				
				sum=0;
				
				//While loop for dermining each digit individually
				while(i<length) {
					lastDig=card.charAt(i);
					digit=Character.getNumericValue(lastDig);
					
					//If branch to separate the digits to be doubled, regular digits, and the check digit
					if(i==15) {
						checkDig=digit;
					}
					else if(i%2==0) {
						if(digit*2>=10) {
							sum=sum+((digit*2)%10+1);
						}
						else {
							sum=sum+digit*2;
						}
					}
					else {
						sum=sum+digit;
					}
					i=i+1;
				}
				
				//Outputting what check digit should be
				checkDigCal=10-sum%10;
				System.out.println("Check digit should be: " + checkDigCal);
				System.out.println("Check digit is:" + checkDig);
				
				//Outputting whether check digit is correct or not
				if(checkDig==checkDigCal) {
					System.out.println("Number is valid");
				}
				else {
					System.out.println("Number is not valid");
				}
				
			}
		
			//Case 2: End loop
			else if(card.equals("")) {
				System.out.println("Goodbye!");
			}
			
			//Case 3:Wrong amount of digits
			else {
				System.out.println("ERROR! Number MUST have exactly 16 digits");
			}
			System.out.println();
		}

	}

}
