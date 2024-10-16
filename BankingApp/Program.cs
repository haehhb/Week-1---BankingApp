/*
 * Classname:BankingApp
 * Information: Logical Operators demo
 * Version: 1
 * Author: Habiba Ehab
 * Date: October 2024 
 */

//Call the BankingApp meathod to begin Application 
using System.Diagnostics.CodeAnalysis;

BuildBankingApp();

void BuildBankingApp()
{
    //Initialize variable 
    //Note theres no value assigned to the variable
    int choice;
    double accountBalance = 1000.00;
    double depositAmount;
    double withdrawalAmount;


    //The code displayed on the main screen
    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1-Deopsit or withdraw funds");
    Console.WriteLine("2-View current account information");
    Console.WriteLine("Please choose an option (1-2)");



    //Read choice from the main menu 
    //Explicitly typecast the string input 
    //Convert to integer so we can use it within if statements later 

    choice = Convert.ToInt32(Console.ReadLine());

    // The "||" in the loop represents OR
    //This is an example of a logical operation 
    if (choice == 1 || choice == 2)
    {
        Console.WriteLine("Please choose an option");
        Console.WriteLine("=======================");
        Console.WriteLine("1-Deopsit or withdraw funds");
        Console.WriteLine("2-View current account information");
        Console.WriteLine("Please choose an option (1-2)");

        choice = Convert.ToInt32(Console.ReadLine());
    

        if(choice==1)
        {
            Console.WriteLine("How much do you want to deposit?");
            Console.WriteLine("Enter amount including pence using a decimal point");
            //Typically a curreny is is input as a decimal
            depositAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The original balance was {0}", accountBalance);
            //This reads as account balance= account balance + deposit amount 
            //This is an example of an assignment operator 
            accountBalance += depositAmount;
            Console.WriteLine("The new balance is now {0}", accountBalance);
        }


        if(choice==2)
        {
            Console.WriteLine("How much do you want to withdraw from account?");
            Console.WriteLine("Enter amount using decimal point");
            withdrawalAmount = Convert.ToDouble(Console.ReadLine());
            accountBalance -= withdrawalAmount;
            Console.WriteLine("The new Balance for account is {0}", accountBalance);
      
        }


    }
    else
    {
        //Invalid number selected add comment for the user 
        Console.WriteLine("Please choose a vaalif option between 1-2");
    }



}