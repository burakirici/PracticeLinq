Description
This application is a C# console application that performs various operations. The application prints the numbers in a list by categorizing them into various categories and also calculates the squares of the numbers.

Features
Even Numbers: Filters even numbers in a list and prints them.
Odd Numbers: Filters odd numbers in a list and prints them.
Negative Numbers: Filters negative numbers in a list and prints them.
Positive Numbers: Filters positive numbers in a list and prints them.
Numbers in a Specified Range: Filters numbers greater than 15 and less than 22 and prints them.
Squares: Calculates the square of each number in a list and prints them.
Usage
To run this application:

Open the project in Visual Studio or any other C# IDE.
Run the program.
Code Descriptions:
Even Numbers: Even numbers are filtered using randomNumbers.Where(num => num % 2 == 0).
Odd Numbers: Use randomNumbers.Where(num => num % 2 != 0) to filter out odd numbers.

Negative Numbers: Use randomNumbers.Where(num => num < 0) to filter out negative numbers.

Positive Numbers: Use randomNumbers.Where(num => num > 0) to filter out positive numbers.

Numbers in Range: Use randomNumbers.Where(num => num > 15 && num < 22) to filter out numbers within a certain range.

Squared Numbers: Use numbers.Select(num => num * num) to calculate the squares of numbers.
