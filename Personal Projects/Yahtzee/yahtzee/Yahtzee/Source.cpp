#include <cstdlib>
#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

void diceRoll(int oneD, int twoD, int threeD, int fourD, int fiveD);

int main()
{
	string str;

	cout << "Press enter to start a new game";
	cin >> str;
	if (str == "Hello " )
	{


	}
}


class die
{
	public:
		int value;
};

class dice
{
	public:
		die one;
		die two;
		die three;
		die four;
		die five;
};

class ScoreCard
{
public:
	int ones;
	int twos;
	int threes;
	int fours;
	int fives;
	int sixes;
	int threekind;
	int fourkind;
	int fullhouse;
	int smallstr;
	int largestr;
	int yahtzee;
	int chance;
	int rollNum;

	//Constructor
	ScoreCard()
	{
		ones = -1;
		twos = -1;
		threes = -1;
		fours = -1;
		fives = -1;
		sixes = -1;
		threekind = -1;
		fourkind = -1;
		fullhouse = -1;
		smallstr = -1;
		largestr = -1;
		yahtzee = -1;
		chance = -1;
		rollNum = -1;
	}
};

class Game
{
	public:
		ScoreCard score;
		dice dice;

		//Constructor
		Game()
		{

		}

		Game play()
		{
			while (score.rollNum < 12)
			{
				diceRoll(dice.one.value, dice.two.value, dice.three.value, dice.four.value, dice.five.value);
				scoreChoice(score, dice);
			}
		}
	
};


void diceRoll(int oneD, int twoD, int threeD, int fourD, int fiveD)
{

	oneD = rand() % 6 + 1;
	twoD = rand() % 6 + 1;
	threeD = rand() % 6 + 1;
	fourD = rand() % 6 + 1;
	fiveD = rand() % 6 + 1;

	cout << "Dice 1 is: " << oneD << endl;
	cout << "Dice 2 is: " << twoD << endl;
	cout << "Dice 3 is: " << threeD << endl;
	cout << "Dice 4 is: " << fourD << endl;
	cout << "Dice 5 is: " << fiveD << endl;
};

void scoreChoice(ScoreCard score, dice dice)
{
	bool check = false;
	int input = 0;
	int num = 0;
	int array[5] = { dice.one.value, dice.two.value, dice.three.value, dice.four.value, dice.five.value };
	int n = sizeof(array) / sizeof(array[0]);
	sort(array, array + n);
	int row = 0;
	while (check = false)
	{
		cout << "1. Ones score: ";
		if (score.ones != -1)
		{
			cout << score.ones;
		}
		cout << endl;
		cout << "2. Twos score: ";
		if (score.twos != -1)
		{
			cout << score.twos;
		}
		cout << endl;
		cout << "3. Threes score: ";
		if (score.threes != -1)
		{
			cout << score.threes;
		}
		cout << endl;
		cout << "4. Fours score: ";
		if (score.fours != -1)
		{
			cout << score.fours;
		}
		cout << endl;
		cout << "5. Fives score: ";
		if (score.fives != -1)
		{
			cout << score.fives;
		}
		cout << endl;
		cout << "6. Sixes score: ";
		if (score.sixes != -1)
		{
			cout << score.sixes;
		}
		cout << endl;
		cout << "7. Three of a Kind score: ";
		if (score.threekind != -1)
		{
			cout << score.threekind;
		}
		cout << endl;
		cout << "8. Four of a Kind score: ";
		if (score.fourkind != -1)
		{
			cout << score.fourkind;
		}
		cout << endl;
		cout << "9. Full House score: ";
		if (score.fourkind != -1)
		{
			cout << score.fullhouse;
		}
		cout << endl;
		cout << "10. Small Straight score: ";
		if (score.smallstr != -1)
		{
			cout << score.smallstr;
		}
		cout << endl;
		cout << "11. Large Straight score: ";
		if (score.largestr != -1)
		{
			cout << score.largestr;
		}
		cout << endl;
		cout << "12. Yahtzee score: ";
		if (score.yahtzee != -1)
		{
			cout << score.yahtzee;
		}
		cout << endl;
		cout << "13. Chance score: ";
		if (score.chance != -1)
		{
			cout << score.chance;
		}
		cout << endl;

		//Prompting user
		cout << "Select which category number you want this score to go into:" << endl;
		cin >> input;
		check = true;

		//Checking input and scoring

		//Ones
		if (input = 1)
		{
			if (score.ones != -1)
			{
				if (dice.one.value == 1)
				{
					num = num + 1;
				}
				if (dice.two.value == 1)
				{
					num = num + 1;
				}
				if (dice.three.value == 1)
				{
					num = num + 1;
				}
				if (dice.four.value == 1)
				{
					num = num + 1;
				}
				if (dice.five.value == 1)
				{
					num = num + 1;
				}
				score.ones = num;
			}
			else {
				check = false;
			}
		}

		//Twos
		else if (input = 2)
		{
			if (score.twos != -1)
			{
				if (dice.one.value == 2)
				{
					num = num + 2;
				}
				if (dice.two.value == 2)
				{
					num = num + 2;
				}
				if (dice.three.value == 2)
				{
					num = num + 2;
				}
				if (dice.four.value == 2)
				{
					num = num + 2;
				}
				if (dice.five.value == 2)
				{
					num = num + 2;
				}
				score.twos = num;
			}
			else {
				check = false;
			}
		}

		//Threes
		else if (input = 3)
		{
			if (score.threes != -1)
			{
				if (dice.one.value == 3)
				{
					num = num + 3;
				}
				if (dice.two.value == 3)
				{
					num = num + 3;
				}
				if (dice.three.value == 3)
				{
					num = num + 3;
				}
				if (dice.four.value == 3)
				{
					num = num + 3;
				}
				if (dice.five.value == 3)
				{
					num = num + 3;
				}
				score.threes = num;
			}
			else {
				check = false;
			}
		}

		//Fours
		else if (input = 4)
		{
			if (score.fours != -1)
			{
				if (dice.one.value == 4)
				{
					num = num + 4;
				}
				if (dice.two.value == 4)
				{
					num = num + 4;
				}
				if (dice.three.value == 4)
				{
					num = num + 4;
				}
				if (dice.four.value == 4)
				{
					num = num + 4;
				}
				if (dice.five.value == 4)
				{
					num = num + 4;
				}
				score.fours = num;
			}
			else {
				check = false;
			}
		}

		//Fives
		else if (input = 5)
		{
			if (score.fives != -1)
			{
				if (dice.one.value == 5)
				{
					num = num + 5;
				}
				if (dice.two.value == 5)
				{
					num = num + 5;
				}
				if (dice.three.value == 5)
				{
					num = num + 5;
				}
				if (dice.four.value == 5)
				{
					num = num + 5;
				}
				if (dice.five.value == 5)
				{
					num = num + 5;
				}
				score.fives = num;
			}
			else {
				check = false;
			}
		}

		//Sixes
		else if (input = 6)
		{
			if (score.sixes != -1)
			{
				if (dice.one.value == 6)
				{
					num = num + 6;
				}
				if (dice.two.value == 6)
				{
					num = num + 6;
				}
				if (dice.three.value == 6)
				{
					num = num + 6;
				}
				if (dice.four.value == 6)
				{
					num = num + 6;
				}
				if (dice.five.value == 6)
				{
					num = num + 6;
				}
				score.sixes = num;
			}
			else {
				check = false;
			}
		}

		//Three of a kind
		else if (input = 7)
		{
			if (score.threekind != -1)
			{
				score.threekind = 0;
				for (int i = 0; i < 5; i++)
				{
					if (array[i] = 1)
					{
						row = row + 1;
					}
				}
				if (row >= 3)
				{
					score.threekind = dice.one.value + dice.two.value + dice.three.value + dice.four.value + dice.five.value;
				}
				row = 0;

				for (int i = 0; i < 5; i++)
				{
					if (array[i] = 2)
					{
						row = row + 1;
					}
				}
				if (row >= 3)
				{
					score.threekind = dice.one.value + dice.two.value + dice.three.value + dice.four.value + dice.five.value;
				}
				row = 0;

				for (int i = 0; i < 5; i++)
				{
					if (array[i] = 3)
					{
						row = row + 1;
					}
				}
				if (row >= 3)
				{
					score.threekind = dice.one.value + dice.two.value + dice.three.value + dice.four.value + dice.five.value;
				}
				row = 0;

				for (int i = 0; i < 5; i++)
				{
					if (array[i] = 4)
					{
						row = row + 1;
					}
				}
				if (row >= 3)
				{
					score.threekind = dice.one.value + dice.two.value + dice.three.value + dice.four.value + dice.five.value;
				}
				row = 0;

				for (int i = 0; i < 5; i++)
				{
					if (array[i] = 5)
					{
						row = row + 1;
					}
				}
				if (row >= 3)
				{
					score.threekind = dice.one.value + dice.two.value + dice.three.value + dice.four.value + dice.five.value;
				}
				row = 0;

				for (int i = 0; i < 5; i++)
				{
					if (array[i] = 6)
					{
						row = row + 1;
					}
				}
				if (row >= 3)
				{
					score.threekind = dice.one.value + dice.two.value + dice.three.value + dice.four.value + dice.five.value;
				}
				row = 0;
			}
			else {
				check = false;
			}
		}

		//Four of a kind
		else if (input = 8)
		{
			if (score.fourkind != -1)
			{
				score.fourkind = 0;
				for (int i = 0; i < 5; i++)
				{
					if (array[i] = 1)
					{
						row = row + 1;
					}
				}
				if (row >= 4)
				{
					score.fourkind = dice.one.value + dice.two.value + dice.three.value + dice.four.value + dice.five.value;
				}
				row = 0;

				for (int i = 0; i < 5; i++)
				{
					if (array[i] = 2)
					{
						row = row + 1;
					}
				}
				if (row >= 4)
				{
					score.fourkind = dice.one.value + dice.two.value + dice.three.value + dice.four.value + dice.five.value;
				}
				row = 0;

				for (int i = 0; i < 5; i++)
				{
					if (array[i] = 3)
					{
						row = row + 1;
					}
				}
				if (row >= 4)
				{
					score.fourkind = dice.one.value + dice.two.value + dice.three.value + dice.four.value + dice.five.value;
				}
				row = 0;

				for (int i = 0; i < 5; i++)
				{
					if (array[i] = 4)
					{
						row = row + 1;
					}
				}
				if (row >= 4)
				{
					score.fourkind = dice.one.value + dice.two.value + dice.three.value + dice.four.value + dice.five.value;
				}
				row = 0;

				for (int i = 0; i < 5; i++)
				{
					if (array[i] = 5)
					{
						row = row + 1;
					}
				}
				if (row >= 4)
				{
					score.fourkind = dice.one.value + dice.two.value + dice.three.value + dice.four.value + dice.five.value;
				}
				row = 0;

				for (int i = 0; i < 5; i++)
				{
					if (array[i] = 6)
					{
						row = row + 1;
					}
				}
				if (row >= 4)
				{
					score.fourkind = dice.one.value + dice.two.value + dice.three.value + dice.four.value + dice.five.value;
				}
				row = 0;
			}
			else {
				check = false;
			}
		}

		//Full House
		else if (input = 9)
		{
			if (score.fullhouse != -1)
			{
				score.fullhouse = 0;
				if ( ((array[0] == array[1] == array[2]) && (array[3] == array[4]) ) || ((array[0] == array[1]) && (array[2] == array[3] == array[4])))
				{
					score.fullhouse = 25;
				}

			}
			else {
				check = false;
			}
		}

		//Small straight
		else if (input = 9)
		{
			if (score.smallstr != -1)
			{
				score.smallstr = 0;
				if (  ((array[0] + 3) == (array[1] +2) == (array[2] + 1) == (array [3]) || ()  )
				{
					score.fullhouse = 25;
				}

			}
			else {
				check = false;
			}
		}

	}
}