using System;
using System.Text.RegularExpressions;

namespace Bank
{
    public class BankForm
    {
        public static void Main(string[] args)
        {
            int numOfChildren,cardLimit,nomineeAge,age = 0;
            decimal salary;

            string firstName, lastName, gender, email, maritalStatus, panNumber, 
            permanentAddress, sameAddress, wantCreditCard, accountNumber, phoneNumber
            bankAccountNumber, cardNumber;

            string correspondenceAddress,addNominee,nomineeName,creditCardType,haveChildren,nomineeRelation,
            createAnotherAccount = "NA";

            bool createAccount,cardRequestAccepted,isMarried = false;
            string[] childrenNames = new string[20];

            Random rd = new Random();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Bank Account Form";

            do
            {
                Console.WriteLine("\n-----------Net Banking-----------");

                do{
                    Console.WriteLine("\nEnter your First Name: ");
                    firstName = Console.ReadLine();
                    if(!(Regex.IsMatch(firstName, @"[a-zA-Z]")))
                    {
                        Console.WriteLine("\nEnter your first name Correctly...");    
                    }
                    else
                        break;
                }while(1);
                
                do
                {
                    Console.WriteLine("\nEnter your Last Name: ");
                    lastName = Console.ReadLine();
                    if(!(Regex.IsMatch(lastName, @"[a-zA-Z]")))
                    {
                        Console.WriteLine("\nEnter your first name Correctly...");     
                    }
                    else
                        break;
                }while(1);

                do
                {
                    Console.WriteLine("\nSelect your Gender: (Male/Female/Other)");
                    gender = Console.ReadLine();
                    if(!((gender.ToUpper() == "MALE") || (gender.ToUpper() == "FEMALE") || (gender.ToUpper() == "OTHER")))
                    {
                        Console.WriteLine("\nSelect gender from the options...");
                    }
                    else
                        break;
                }while(1);

                do
                {
                    Console.WriteLine("\nEnter your Age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    if(!(Regex.IsMatch(age.ToString(),@"^1[8-9]|[2-7][0-9]|[80]$")))
                    {
                        Console.WriteLine("\nEnter Age Between 18-80 ");
                    }
                    else
                        break;
                }while(1);
                
                do
                {
                    Console.WriteLine("Enter your Email Id: ");
                    email = Console.ReadLine();
                    if(!(Regex.IsMatch(email,@"^[a-zA-Z0-9+_.-]+@(.+)+.com$")))
                    {
                        Console.WriteLine("Enter a valid email");
                    }
                }while(1);

                do
                {
                    Console.WriteLine("\nEnter your 10 digits Phone Number: ");
                    phoneNumber = Convert.ToUInt64(Console.ReadLine());
                    if(!(Regex.IsMatch(phoneNumber.ToString(),@"^[0-9]{10}$")))
                    {
                        Console.WriteLine("\nEnter a valid phone number");
                    }
                    else
                        break;
                }while(1);
                
                do
                {
                    Console.WriteLine("\nMarital Status: (Married/Unmarried/Divorcee)");
                    maritalStatus = Console.ReadLine();
                    if(maritalStatus.ToUpper() == "MARRIED" || maritalStatus.ToUpper() == "DIVORCEE")
                    {
                        isMarried = true;
                        Console.WriteLine("\nDo you have children?(Yes/No) ");
                        haveChildren = Console.ReadLine();
                        if (haveChildren == "Y" || haveChildren == "YES")
                        {
                            Console.WriteLine("\nHow many ? ");
                            numOfChildren = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nEnter Children names: ");
                            
                            for(int i=0;i<numOfChildren;i++)
                            {
                                do
                                {
                                    childrenNames[i] = Console.ReadLine();
                                    if (!(Regex.IsMatch(childrenNames[i],@"^[A-Za-z]")))
                                    {
                                        Console.WriteLine("\nEnter Name Correctly");
                                    }
                                    else
                                        break;
                                }while(1);
                            }
                        }
                    }
                    else
                    {
                        if(!(maritalStatus.ToUpper() == "UNMARRIED"))
                        {
                            Console.WriteLine("\nSelect marital status from option");
                        }
                        else
                            break;
                    }
                }while(1);
                
                bankAccountNumber = rd.Next(1000000,9999999);
                accountNumber = "00000" + bankAccountNumber.ToString();

                do
                {
                    Console.WriteLine("\nEnter your Pan number:");
                    panNumber = Console.ReadLine();

                    if(!(Regex.IsMatch(panNumber.ToString(),@"^[A-Z]{5}[0-9]{4}[A-Z]{1}$")))
                    {
                        Console.WriteLine("\nEnter Pan number Correctly");
                    }
                    else
                        break;
                }while(1);
               
                Console.WriteLine("\nAre your permanent and correspondence address same?(Yes/No) ");
                sameAddress = Console.ReadLine();
                if(sameAddress.ToUpper() == "Y" ||sameAddress.ToUpper() == "YES")
                {
                    Console.WriteLine("\nEnter Permanent Address: ");
                    permanentAddress = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nEnter Permanent Address: ");
                    permanentAddress = Console.ReadLine();
                    Console.WriteLine("\nEnter Correspondence Address: ");
                    correspondenceAddress = Console.ReadLine();
                }

                Console.WriteLine("\nWant to add Nominee Details? (Yes/No)");
                addNominee = Console.ReadLine();
                if (addNominee.ToUpper() == "Y" || addNominee.ToUpper() == "YES")
                {
                    do
                    {
                        Console.WriteLine("\nEnter Nominee Name: ");
                        nomineeName = Console.ReadLine();
                        if(!(Regex.IsMatch(nomineeName, @"[a-zA-Z]")))
                        {
                            Console.WriteLine("\nCannot be number");
                        }
                        else
                            break;
                    }while(1);

                    do
                    {
                         Console.WriteLine("\nNominee Age: ");
                        nomineeAge = int.Parse(Console.ReadLine());
                        if(!(Regex.IsMatch(nomineeAge.ToString(),@"^1[8-9]|[2-7][0-9]|[80]$")))
                        {
                            Console.WriteLine("Enter nominee age between 18-80 ");
                        }
                        else
                            break;
                    }while(1);

                    do
                    {
                        Console.WriteLine("\nRelation with nominee: ");
                        nomineeRelation = Console.ReadLine(); 
                        if(!(Regex.IsMatch(nomineeRelation, @"[A-Za-z]")))
                        {
                            Console.WriteLine("\nEnter relation with nominee correctly ");
                        }
                    }
                }
                Console.WriteLine("\nAccount Created Successfully..!");

                Console.WriteLine("\nDo you want Credit Card?(Yes/No) ");
                wantCreditCard = Console.ReadLine();
                if(wantCreditCard.ToUpper() == "Y" || wantCreditCard.ToUpper() == "YES")
                {
                    do
                    {
                        Console.WriteLine("\nEnter the salary: ");
                        salary = Convert.ToDecimal(Console.ReadLine());
                        if (salary < 0)
                        {
                            Console.WriteLine("\nSalary cannot be negative");
                        }
                        else if(salary > 0 && salary < 25000)
                        {
                            Console.WriteLine("\nYou are note eligible for credit card");
                            break;
                        }
                        else if(salary >= 25000 && salary < 50000)
                        {
                            Console.WriteLine("\nCredit Card request accepted ");
                            cardNumber = rd.Next(100000,999999);
                            cardLimit = 30000;
                            creditCardType = "Silver";
                            cardRequestAccepted = true;
                            break;
                        }
                        else if(salary >= 50000 && salary < 100000)
                        {
                            Console.WriteLine("\nCredit Card request accepted ");
                            cardNumber = rd.Next(100000,999999);
                            cardLimit = 75000;
                            creditCardType = "Gold";
                            cardRequestAccepted = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nCredit Card request accepted ");
                            cardNumber = rd.Next(100000,999999);
                            cardLimit = 200000;
                            creditCardType = "Platinum";
                            cardRequestAccepted = true;
                            break;
                        }
                    }while(1);
                }
                
                //Display Personal Details
                Console.WriteLine("\n\n--------------------------------------------");
                Console.WriteLine("                 Bank Details               ");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("\n--* Presonal Details *--");
                Console.WriteLine($"\t* Account Holder Name: {firstName} {lastName}");
                Console.WriteLine($"\t* Gender: {gender}");
                Console.WriteLine($"\t* Email Id: {email}");
                Console.WriteLine($"\t* Phone Number: {phoneNumber}");
                if (isMarried==true)
                {
                    Console.WriteLine($"\t* Marital Status: {maritalStatus}");
                    if(haveChildren.ToUpper() == "YES" || haveChildren.ToUpper() == "Y")
                    {
                        Console.WriteLine("\t* Children Names: ");
                        for(int i=0;i<numOfChildren;i++)
                        {
                            Console.WriteLine($"\t\t{i+1}. {childrenNames[i]}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"\t* Marital Status: {maritalStatus}");
                }
                if(sameAddress.ToUpper() == "YES" || sameAddress.ToUpper() == "Y")
                {
                    Console.WriteLine($"\t* Permanent Address: {permanentAddress}");

                }
                else
                {
                    Console.WriteLine($"\t* Permanent Address: {permanentAddress}");
                    Console.WriteLine($"\t* Correspondence Address: {correspondenceAddress}");
                }
                
                // Display Bank Details
                Console.WriteLine("\n\n--* Bank Account Details *--");
                Console.WriteLine($"\t* Bank Account Number: {accountNumber}");
                Console.WriteLine($"\t* Pan Number: {panNumber}");
                if (addNominee.ToUpper() == "YES" || addNominee.ToUpper() == "Y")
                {
                    Console.WriteLine($"\t* Nominee Name: {nomineeName}");
                    Console.WriteLine($"\t* Nominee Age: {nomineeAge}");
                    Console.WriteLine($"\t* Relation with nominee: {nomineeRelation}");                    
                }
                if(cardRequestAccepted == true)
                {
                    Console.WriteLine("\n--* Credit Card Details *--");
                    Console.WriteLine($"\t* Card Number(Last 6 Digits): ******{cardNumber}");
                    Console.WriteLine($"\t* Card Type: {creditCardType}");
                    Console.WriteLine($"\t* Card Limit: {cardLimit}");
                }

                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("\nCreate Another Account? ");
                createAnotherAccount = Console.ReadLine();
                if((createAnotherAccount.ToUpper() == "YES") || (createAnotherAccount.ToUpper() == "Y"))
                {
                    createAccount = true;
                }
                else
                {
                    createAccount = false;
                }

            } while (createAccount == true);
        }
    }
}