int a = 5;
int b = 6;

// compare the two numbers and display the greater number

// Method 1 is if-else statements

if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}

// Method 2 is using ternary operation
// condition ? If Block : else block 
Console.WriteLine(a>b?$"{a} is greater":$"{b} is greater");

// check if number is even or not
Console.WriteLine("Enter a number to check if the number is even or odd");
int num = int.Parse(Console.ReadLine());
// condition ? If Block : else block 
string message = num % 2 == 0 ? "Even number" : "Odd Number";
Console.WriteLine(message);

// or directly print the statement
Console.WriteLine(num % 2 == 0 ? "Even number" : "Odd Number");

// for loop
// while loop
// do-while loop
// foreach loop (arrays or list)

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" }; // Array
int i = 0;
// for loop 

Console.WriteLine("For Loop");
for ( i = 0; i < cars.Length; i++)
{
    Console.WriteLine("element: "+ cars[i]);
}

// While loop
Console.WriteLine("While Loop");
i = 0;
while (i < cars.Length)
{
    Console.WriteLine("element: "+ cars[i]);
    i++;
}

// do-while Loop
Console.WriteLine("Do-While Loop");
i = 0;
do
{
    Console.WriteLine("element: " + cars[i]);
    i++;
}while(i < cars.Length);


// For-Each Loop
Console.WriteLine("For-Each loop");
// foreach (datatype variable in array)
foreach (string element in cars)
{
    Console.WriteLine(element);
}

// int array.

//int[] array = { 1, 3, 3, 4, 5, 6, 7, 78, 8, 9 };

//// To print all the elements.
//foreach (int element in array)
//{
//    Console.WriteLine(element);
//}


int[] array = { 1, 3, 3, 4, 5, 6, 7, 78, 8, 9 };
// Print all the even elements.
// Example of ternary operators - 
// // condition ? If Block : else block 
// string message = num % 2 == 0 ? "Even number" : "Odd Number";
// use Foreach and terenay operators. 


// to print all even numbers in the array.
foreach(int element in array)
    Console.WriteLine(element%2==0? $"{element} is even": $"{element} is odd");



// 8. copy an array

int[] copy = new int[array.Length];

// Method 1
//for (i = 0; i < array.Length; i++)
//{
//    copy[i] = array[i];
//}

//foreach (int element in copy)
//{
//    Console.WriteLine(element);
//}   


// Method 2
int index = 0;
foreach(int element in array)
{
    copy[index] = element;
    index++;
}

//9. print sum of all positive numbers.

int[] array9 = { -1, 2, -3, 4, -5, 6 };
int sum = 0;
for(i=0;i< array9.Length; i++)
{
    if (array9[i]>0)
        sum = sum + array9[i];
}


Console.WriteLine("The sum: "+sum);


// 10. Reverse an array.
int[] array10 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] copy1 = new int[array10.Length];

index = array10.Length-1;// since we reverse

foreach(int element in array10)
{
    copy1[index] = element;
    index--;
}