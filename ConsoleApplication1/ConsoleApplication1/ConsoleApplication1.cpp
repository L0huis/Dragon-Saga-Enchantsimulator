// application.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <math.h>
#include <ctime>
#define SIZE 268435455
//Max Size:  268435455

void quickSort(int left, int right);
void bubbleSort();

int arr[SIZE];
double mana = 1;

int main()
{
  for (int i = 0; i < 46; i++)
  {
    mana -= 0.05;
    std::cout << "Step:" << i + 1 << "\tMana:" << mana << "\n";
  }
  std::cin >> mana;
}
//int main()
//{
//  int value;
//  std::clock_t start;
//  double duration;
//  srand(time(nullptr));
//
//
//  for (int i = 0; i < SIZE; i++)
//  {
//    arr[i] = rand();
//    std::cout << arr[i] << "\n";
//  }
//  std::cout << "Filled Array\n";
//  std::cout << "Doing Quicksort\n";
//
//  start = std::clock();
//  quickSort(0, SIZE - 1);
//  duration = (std::clock() - start) / (double)CLOCKS_PER_SEC;
//  std::cout << "Done!\n" << "Duration: " << duration << "s\n";
//
//
//
//  for (int i = 0; i < SIZE; i++)
//  {
//    arr[i] = rand();
//    //std::cout << arr[i] << "\n";
//  }
//  std::cout << "Filled Array\n";
//  std::cout << "Doing Bubblesort\n";
//
//  start = std::clock();
//  bubbleSort();
//  duration = (std::clock() - start) / (double)CLOCKS_PER_SEC;
//  std::cout << "Done!\n" << "Duration: " << duration << "s\n";
//  for (int i = 0; i < SIZE; i++)
//  {
//    std::cout << arr[i] << "\n";
//  }
//
//  std::cin >> value;
//}

void quickSort(int left, int right)
{

  int i = left, j = right;
  int tmp;
  int pivot = arr[(left + right) / 2];

  /* partition */

  while (i <= j)
  {
    while (arr[i] < pivot)
    {
      i++;
    }

    while (arr[j] > pivot)
    {
      j--;
    }

    if (i <= j)
    {
      tmp = arr[i];
      arr[i] = arr[j];
      arr[j] = tmp;
      i++;
      j--;
    }
  };



  /* recursion */

  if (left < j)
  {
    quickSort(left, j);
  }

  if (i < right)
  {
    quickSort(i, right);
  }
}

void bubbleSort()
{
  int sortet;
  do
  {
    sortet = 1;
    for (int i = 1; i < SIZE; i++)
    {
      if (arr[i + 1] < arr[i])
      {
        int temp = arr[i + 1];
        arr[i + 1] = arr[i];
        arr[i] = temp;
        sortet = 0;
      }
    }
  } while (!sortet);
}
