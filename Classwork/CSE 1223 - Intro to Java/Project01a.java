/*
 * Project01a.java
 * 
 * This code will take user input of two numbers and output some basic mathematic functions of the two
 * 
 * @Kody Williamson
 * @20180118
 * 
 */
package osu.cse1223;

import java.util.Scanner;

public class Project01a {

	public static void main(String[] args) {
		//Taking user inputs to find number one and two for later operations
		Scanner keyboard = new Scanner(System.in);
		System.out.print("Enter the first number: ");
		int numOne = keyboard.nextInt();
		System.out.print("Enter the second number: ");
		int numTwo = keyboard.nextInt();
		
		//Outputting simple math functions using given user inputs
		System.out.println(numOne + " + " + numTwo + " = " + (numOne + numTwo));
		System.out.println(numOne + " - " + numTwo + " = " + (numOne - numTwo));
		System.out.println(numOne + " * " + numTwo + " = " + (numOne * numTwo));
		System.out.println(numOne + " / " + numTwo + " = " + (numOne / numTwo));
		System.out.println(numOne + " % " + numTwo + " = " + (numOne % numTwo));
		
		//Finding average of the two numbers
		System.out.println("The average of your two numbers is: " + ((numOne + numTwo)/2));
		

	}

}
