using System;
using System.Text.RegularExpressions;

namespace Bank
{
    public class BankForm
    {
        public static void Main(string[] args)
        {
            int numOfChildren=0,salary,cardLimit=0,nomineeAge=0,age;
            ulong phoneNumber; 
            long bankAccountNumber, cardNumber=0;
            string firstName, lastName, gender, email, maritalStatus, haveChildren="", panNumber, permanentAddress, correspondenceAddress="None", haveSameAddress, wantCreditCard, creditCardType="NA", anotherAccount,addNominee="NA", nomineeName="", nomineeRelation="", accountNumber;
            bool createAccount = false, cardRequestAccepted=false,isMarried=false;
            string[] childrenNames = new string[20];

            Random rd = new Random();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Bank Account Form";

            do
            {
                Console.WriteLine("\n-----------Net Banking-----------");

                enterFirstName:
                Console.WriteLine("\nEnter your First Name: ");
                firstName = Console.ReadLine();
                if(!(Regex.IsMatch(firstName, @"[a-zA-Z]")))
                {
                    Console.WriteLine("\nCannot be Number..");    
                    goto enterFirstName;
                }

                enterLastName:
                Console.WriteLine("\nEnter your Last Name: ");
                lastName = Console.ReadLine();
                if(!(Regex.IsMatch(lastName, @"[a-zA-Z]")))
                {
                    Console.WriteLine("\nCannot be Number..");     
                    goto enterLastName;
                }

                selectGender:
                Console.WriteLine("\nSelect your Gender: (Male/Female/Other)");
                gender = Console.ReadLine();
                if(!((gender == "Male") || (gender == "Female") || (gender == "Other") || (gender == "male") || (gender == "female") || (gender == "other")))
                {
                    Console.WriteLine("\nSelect gender from the options.."); 
                    goto selectGender;
                }

                enterAge:
                Console.WriteLine("\nEnter your Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if(!(Regex.IsMatch(age.ToString(),@"^1[8-9]|[2-7][0-9]|[80]$")))
                {
                    Console.WriteLine("\nEnter Age Between 18-80 ");
                    goto enterAge;
                }

                enterEmail:
                Console.WriteLine("Enter your Email Id: ");
                email = Console.ReadLine();
                if(!(Regex.IsMatch(email,@"^[a-zA-Z0-9+_.-]+@(.+)+.com$")))
                {
                    Console.WriteLine("Enter a valid email");
                    goto enterEmail;
                }

                enterPhoneNumber:
                Console.WriteLine("\nEnter your 10 digits Phone Number: ");
                phoneNumber = Convert.ToUInt64(Console.ReadLine());
                if(!(Regex.IsMatch(phoneNumber.ToString(),@"^[0-9]{10}$")))
                {
                    Console.WriteLine("\nEnter a valid phone number");
                    goto enterPhoneNumber;
                }
                
                selectMaritalStatus:
                Console.WriteLine("\nMarital Status: (Married/Unmarried/Divorcee)");
                maritalStatus = Console.ReadLine();
                if(maritalStatus == "married" || maritalStatus == "Married" || maritalStatus == "divorcee" || maritalStatus == "Divorcee" || maritalStatus == "MARRIED" || maritalStatus == "DIVORCEE")
                {
                    isMarried = true;
                    Console.WriteLine("\nDo you have children?(Yes/No) ");
                    haveChildren = Console.ReadLine();
                    if (haveChildren == "Yes" || haveChildren == "yes" || haveChildren == "Y" || haveChildren == "y" || haveChildren == "YES")
                    {
                        Console.WriteLine("\nHow many ? ");
                        numOfChildren = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter Children names: ");
                        
                        for(int i=0;i<numOfChildren;i++)
                        {
                            enterChildrenNames:
                            childrenNames[i] = Console.ReadLine();
                            if (!(Regex.IsMatch(childrenNames[i],@"^[A-Za-z]")))
                            {
                                Console.WriteLine("\nEnter Name Correctly");
                                goto enterChildrenNames;
                            }
                        }
                    }
                }
                else
                {
                    if(!(maritalStatus == "unmarried" || maritalStatus == "Unmarried" || maritalStatus == "UNMARRIED"))
                    {
                        Console.WriteLine("\nSelect status from option");
                        goto selectMaritalStatus;
                    }
                }
                bankAccountNumber = rd.Next(1000000,9999999);
                accountNumber = "00000" + bankAccountNumber.ToString();

                enterPanNumber:
                Console.WriteLine("\nEnter your Pan number:");
                panNumber = Console.ReadLine();

                if(!(Regex.IsMatch(panNumber.ToString(),@"^[A-Z]{5}[0-9]{4}[A-Z]{1}$")))
                {
                    Console.WriteLine("\nEnter Pan number Correctly");
                    goto enterPanNumber;
                }
                
                Console.WriteLine("\nAre your permanent and correspondence address same?(Yes/No) ");
                haveSameAddress = Console.ReadLine();
                if(haveSameAddress == "Yes" || haveSameAddress == "yes" || haveSameAddress == "Y" || haveSameAddress == "y" || haveSameAddress == "YES")
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
                if (addNominee == "Yes" || addNominee == "yes" || addNominee == "Y" || addNominee == "y" || addNominee == "YES")
                {
                    enterNomineeName:
                    Console.WriteLine("\nEnter Nominee Name: ");
                    nomineeName = Console.ReadLine();
                    if(!(Regex.IsMatch(nomineeName, @"[a-zA-Z]")))
                    {
                        Console.WriteLine("\nCannot be number");
                        goto enterNomineeName;
                    }

                    enterNomineeAge:
                    Console.WriteLine("\nNominee Age: ");
                    nomineeAge = int.Parse(Console.ReadLine());
                    if(!(Regex.IsMatch(nomineeAge.ToString(),@"^1[8-9]|[2-7][0-9]|[80]$")))
                    {
                        Console.WriteLine("Enter nominee age between 18-80 ");
                        goto enterNomineeAge;
                    }

                    enterNomineeRelation:
                    Console.WriteLine("\nRelation with nominee: ");
                    nomineeRelation = Console.ReadLine(); 
                    if(!(Regex.IsMatch(nomineeRelation, @"[A-Za-z]")))
                    {
                        Console.WriteLine("\nEnter relation with nominee correctly ");
                        goto enterNomineeRelation;
                    }
                    
                }
                Console.WriteLine("\nAccount Created Successfully..!");
                Console.WriteLine("\nDo you want Credit Card?(Yes/No) ");
                wantCreditCard = Console.ReadLine();
                if(wantCreditCard == "Yes" || wantCreditCard == "Y" || wantCreditCard == "yes" || wantCreditCard == "y" || wantCreditCard == "YES")
                {
                    enterSalary:
                    Console.WriteLine("\nEnter the salary: ");
                    salary = Convert.ToInt32(Console.ReadLine());
                    if (salary < 0)
                    {
                        Console.WriteLine("\nSalary cannot be negative");
                        goto enterSalary;
                    }
                    else if(salary > 0 && salary < 25000)
                    {
                        Console.WriteLine("\nCredit Card request Rejected ");
                        goto showDetails;
                    }
                    else if(salary >= 25000 && salary < 50000)
                    {
                        Console.WriteLine("\nCredit Card request accepted ");
                        cardNumber = rd.Next(100000,999999);
                        cardLimit = 30000;
                        creditCardType = "Silver";
                        cardRequestAccepted = true;
                    }
                    else if(salary >= 50000 && salary < 100000)
                    {
                        Console.WriteLine("\nCredit Card request accepted ");
                        cardNumber = rd.Next(100000,999999);
                        cardLimit = 75000;
                        creditCardType = "Gold";
                        cardRequestAccepted = true;
                    }
                    else
                    {
                        Console.WriteLine("\nCredit Card request accepted ");
                        cardNumber = rd.Next(100000,999999);
                        cardLimit = 200000;
                        creditCardType = "Platinum";
                        cardRequestAccepted = true;
                    }

                }

                showDetails:
                
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
                    if(haveChildren == "Yes" || haveChildren == "yes" || haveChildren == "Y" || haveChildren == "y")
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
                if(haveSameAddress == "Yes" || haveSameAddress == "yes" || haveSameAddress == "Y" || haveSameAddress == "y")
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
                if (addNominee == "Yes" || addNominee == "yes" || addNominee == "Y" || addNominee == "y")
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
                anotherAccount = Console.ReadLine();
                if((anotherAccount == "Yes") || (anotherAccount == "Y") || (anotherAccount == "yes") || (anotherAccount == "y") || anotherAccount =="YES")
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