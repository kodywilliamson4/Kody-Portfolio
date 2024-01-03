
/**
 * Project09.java
 *
 *   A program that converts binary numbers into decimal numbers.
 *   Used to practice breaking code up into methods.
 *
 *   @author Kody Williamson
 *   @version 20180322
 */
package osu.cse1223;
import java.util.Scanner;

public class Project09 {

    public static void main(String[] args) {
    	//Bringing in keyboard
        Scanner in = new Scanner(System.in);
        
        //Declaring variables
        int decVal=0;
        String userIn="starter";
        
        //Creating while loop to keep performing until a blank line is entered
        while(!userIn.equals("")) {
        	userIn=promptForBinary(in);
        	if(!userIn.equals("")) {
        		decVal=binaryToDecimal(userIn);
        		System.out.println("The binary value " + userIn + " is " + decVal + " in decimal (base 10).");
        		System.out.println("");
        	} 
        }
    }

    /**
     * Given a Scanner as input, prompt the user to enter a binary value. Use
     * the function checkForBinaryValue below to make sure that the value
     * entered is actually a binary value and not junk. Then return the value
     * entered by the user as an String to the calling method.
     *
     * @param input
     *            A scanner to take user input from
     * @return a String representing a binary value read from the user
     */
    public static String promptForBinary(Scanner input) {
        String userIn="oops";
        if(input.equals("oops")) {
        	System.out.print("Enter a binary value (empty line to quit): ");
        	userIn=input.nextLine();
        	if(!checkForBinaryValue(userIn)) {
        		userIn="oops";
        		System.out.println("ERROR - invalid binary value");
        		System.out.println("");
        	}
        }
        else if(input.equals("")) {
        	System.out.println("Goodbye");
        	userIn="";
        }
        return userIn;
    }

    /**
     * Given a String as input, return true if the String represents a valid
     * binary value (i.e. contains only the digits 1 and 0). Returns false if
     * the String does not represent a binary value.
     *
     * @param value
     *            A String value that may contain a binary value
     * @return true if the String value contains a binary value, false otherwise
     */
    public static boolean checkForBinaryValue(String value) {
    	boolean answer=true;
        int length=value.length();
        int i=0;
        char ref='a';
        while(i<length) {
        	ref=value.charAt(i);
        	if(ref!='0' && ref!='1') {
        		answer=false;
        	}
        	i++;
        }
        return answer;
    }

    /**
     * Given a binary value, return an int value that is the base 10
     * representation of that value. Your implementation must use the algorithm
     * described in the Project 9 write-up. Other algorithms will receive no
     * credit.
     *
     * @param value
     *            A String containing a binary value to convert to integer
     * @return The base 10 integer value of that binary in the String
     */
    public static int binaryToDecimal(String value) {
    	//Getting numbers set up to perform function
        int j=value.length()-1;
        int decVal=0;
        int currentNum=0;
        char currentChar='a';
        double powRef=0.0;
        
        //Creating while loop to circle through each character in the string
        while(j>=0) {
        	//Getting current character and the binary value of that character
        	currentChar=value.charAt(j);
        	currentNum=Character.getNumericValue(currentChar);
        	//Converting from binary to decimal and adding to total
        	powRef=j;
        	decVal=(int) (decVal+Math.pow(2.0, powRef)*currentNum);
        	
        	j++;
        }
        return decVal;
    }
}
