// CMakeProject1.cpp : Defines the entry point for the application.
//

#include "CMakeProject1.h"

// C++ program for the coloring the
// background and text with
// different color
#include <iostream>

// Header file to change color of
// text and background
#include <windows.h>

// Driver Code
int main()
{
    // Color of the console
    HANDLE console_color;
    console_color = GetStdHandle(
        STD_OUTPUT_HANDLE);

    //// Print different colors from 1
    //// to 50 on the output screen
    //for (int P = 1; P < 50; P++) {

    //    // P is color code of the
    //    // corresponding color
    //    SetConsoleTextAttribute(console_color, P);

    //    // Print Statement
    //    
    //    cout<< endl << P << " Hello Geeks, "
    //        << "good night!!!";
    //}

    //return 0;
    // 
 
   double r = 0;
   double i = 0;
   double t = 0;
   int k = -1;
   int c = 0;

   for(int y=-10; y<=10;y++){
     for(int x=1; x<=80; x++){
       r = 0;
       i = 0;
       k = -1;

       while ( (r*r + i*i ) < 11 && (k < 112) ){
         t = r;
         r = t*2 - i*i  - 2.3 + x/24.5;
         i = 2 * t * i + y/8.5;
         k++;
       }

       c = k%16;
       SetConsoleTextAttribute(console_color, c*16);
       std::cout << c;
     }
     std::cout << std::endl;
   }
   return 0;
}