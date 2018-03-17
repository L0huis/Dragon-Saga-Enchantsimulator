// Tester.cpp : Defines the entry point for the console application.
//
#include "stdafx.h"

#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include <stdio.h>

using namespace std;

double pW[] =
{
	0.95, 0.95, 0.95, 0.3, 0.27, 0.24, 0.21, 0.18, 0.15, 0.12, 0.09, 0.06, 0.03, 0.03, 0.01, 0.007, 0.004, 0.002, 0.0018, 0.0017
};
double pA[] =
{
	0.95, 0.95, 0.95, 0.5, 0.4, 0.3, 0.25, 0.2, 0.18, 0.16, 0.14, 0.12, 0.1, 0.05, 0.03, 0.009, 0.008, 0.004, 0.0035, 0.0034
};

void printProbabilities(int weap)
{
	for (int i = 0; i < 20; i++)
	{
		printf("%2d -> %2d : %5.2lf%c\n", i, i + 1, weap ? pW[i] * 100 : pA[i] * 100, '%');
	}
}

double enchant(int isWeap, int from, int to, double chance, double percentage)
{
	double expected = 0;
	for (int i = from; i < to; i++)
	{
		expected += isWeap ? 1 / (chance + pW[i] * (percentage + 1)) : 1 / (chance + pA[i] * (percentage + 1)) + 1;
	}
	return expected;
}

void enchantCall(int isWeap = 1, int from = 0, int to = 20, double chance = 0, double percentage = 0)
{
	if (from < 15 && to < 15)
	{
		cout << "Expected IS needed: " << enchant(isWeap, from, to, chance, percentage) << endl;
	}
	else if (from >= 15 && to >= 15)
	{
		cout << "Expected RIS needed: " << enchant(isWeap, from, to, chance, percentage) << endl;
	}
	else
	{
		cout << "Expected IS needed: " << enchant(isWeap, from, 15, chance, percentage) << endl;
		cout << "Expected RIS needed: " << enchant(isWeap, 15, to, chance, percentage) << endl;
	}
}


int main(int argc, char *argv[])
{
	//argv:	.exe isWeap from to chance isEW

	int isWeap = 1;
	int from;
	int to;
	int isEW;
	double chance;

	cout << "Weapon:" << endl;
	printProbabilities(1);
	cout << "\nArmor:" << endl;
	printProbabilities(0);
	cout << endl;

	if (argc < 5)
	{
		cout << "Not nough arguments" << endl;
		return 0;
	}

	from = stoi(argv[2]);
	to = stoi(argv[3]);
	chance = stod(argv[4]);
	isEW = argc == 6 ? 1 : 0;

	int invalid = 0;
	do
	{

		if (*argv[1] == 'w')
		{
			isWeap = 1;
		}
		else if (*argv[1] == 'a')
		{
			isWeap = 0;
		}
		else
		{
			cout << "Invalid first argument\nShould be 'w' or 'a'" << endl;
			cout << "Will use 'w' instead" << endl;
		}

		if (from < 0 || from > 19)
		{
			cout << "Cannot enchant from level " << from << "!" << endl;
			invalid = 1;
		}
		else if (to < 0 || to > 20)
		{
			cout << "Cannot enchant to level " << to << "!" << endl;
			invalid = 1;
		}
		else if (to < from)
		{
			cout << "Cannot enchant to a lower level!" << endl;
			invalid = 1;
		}
		else if (chance < 0 || chance > 1)
		{
			cout << "Invalid chance increase!" << endl;
			invalid = 1;
		}

	} while (invalid);

	cout << (isWeap ? "Weapon: " : "Armor: ") << " From: " << from << " To: " << to << " Chance increase: " << chance << " isEW: " << isEW << endl;
	enchantCall(isWeap, from, to, chance, isEW ? 0.2 : 0);
	return 0;
}
