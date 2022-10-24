using System;

namespace Takvim_14_kasım
{
    class Program
    {
        static void Main(string[] args)
        {   //Defining Zeller's Algorithm for find the days of the week.
            string dayofweek(double dayofthemonth,double month,double yearofcentury,double zerobasedcentury)  
            { double dayofweek;
                 dayofweek= (dayofthemonth + Math.Floor(((13 * (month + 1)) / 5)) + yearofcentury + Math.Floor(yearofcentury / 4) + Math.Floor(zerobasedcentury / 4) + (5 * zerobasedcentury)) % 7;
                
                if (dayofweek == 0)
                {
                    return "Saturday";
                }
                else if (dayofweek == 1)
                {
                    return "Sunday";
                }
                else if (dayofweek == 2)
                {
                    return "Monday";
                }
                else if (dayofweek == 3)
                {
                    return "Tuesday";
                }
                else if (dayofweek == 4)
                {
                    return "Wednesday";
                }
                else if (dayofweek == 5)
                {
                    return "Thursday";
                }
                else
                {
                    return "Friday";
                }                                
            }
            //Defining the necessary variables and months.
            bool Day1InputControl=true, Month1InputControl=true, Year1InputControl=true, Day2InputControl=true, Month2InputControl=true, Year2InputControl=true,control2015_1= true,control2015_2 = true ;
            int Day1=0, Month1=32, Year1=0, Day2=0, Month2=32, Year2=0;
            string Day1Input, Month1Input, UpperMonth1Input="", Year1Input, Day2Input , Month2Input , UpperMonth2Input="", Year2Input,N_input;
            bool whilecontrol1 = true;
            bool whilecontrol2  = true;
            bool whilecontrol3 = true;
            int January = 31;                  
            int March = 31;
            int April = 30;
            int May = 31;
            int June = 30;
            int July = 31;
            int August = 31;
            int September = 30;
            int October = 31;
            int November = 30;
            int December = 31;                       
            int January_DayCount = 31;
            int February_DayCount = 59;
            int March_DayCount = 90;
            int April_DayCount = 120;
            int May_DayCount = 151;
            int June_DayCount = 181;
            int July_DayCount = 212;
            int August_DayCount = 243;
            int September_DayCount = 273;
            int October_DayCount = 304;
            int November_DayCount = 334;
            int December_DayCount = 365;
            int Month2DayCount=0;
            int Month1DayCount=0;
            int n=0;
            Console.WriteLine("****CALENDER CALCULATOR****\n");
            //Taking first date,assigning month variables and controlling them.If inputs are wrong write a error message to the terminal.
            while (whilecontrol1)
            {
                Day1InputControl = true;
                Month1InputControl = true;
                Year1InputControl = true;
                control2015_1 = true;
                Console.WriteLine("Please enter day1: ");
                Day1Input = Console.ReadLine();
                if(!(int.TryParse(Day1Input, out Day1))|| Day1 <= 0 || Day1 > 31)
                {
                    Day1InputControl = false;
                }
                Console.WriteLine("Please enter month1: ");
                Month1Input = Console.ReadLine();
                UpperMonth1Input = Month1Input.ToUpper();
                if(!((string.Equals(UpperMonth1Input, "JANUARY")) ||
                      (string.Equals(UpperMonth1Input, "FEBRUARY")) ||
                      (string.Equals(UpperMonth1Input, "MARCH")) ||
                      (string.Equals(UpperMonth1Input, "APRIL")) ||
                      (string.Equals(UpperMonth1Input, "MAY")) ||
                      (string.Equals(UpperMonth1Input, "JUNE")) ||
                      (string.Equals(UpperMonth1Input, "JULY")) ||
                      (string.Equals(UpperMonth1Input, "AUGUST")) ||
                      (string.Equals(UpperMonth1Input, "SEPTEMBER")) ||
                      (string.Equals(UpperMonth1Input, "OCTOBER")) ||
                      (string.Equals(UpperMonth1Input, "NOVEMBER")) ||
                      (string.Equals(UpperMonth1Input, "DECEMBER")))
                      )
                {
                    Month1InputControl = false;                   
                }
                Console.WriteLine("Please enter year1: ");
                Year1Input = Console.ReadLine();
                Console.Clear();

                if (!(int.TryParse(Year1Input, out Year1)))
                {
                    Year1InputControl = false;                    
                }               
                if (string.Equals(UpperMonth1Input, "JANUARY"))
                {
                    Month1DayCount = January_DayCount;
                    Month1 = January;
                }
                if (string.Equals(UpperMonth1Input, "FEBRUARY"))
                {
                    Month1DayCount = February_DayCount;
                    if (Year1 % 4 == 0)
                    {
                        Month1 = 29;
                    }
                    else
                    {
                        Month1 = 28;
                    }
                    
                }
                if (string.Equals(UpperMonth1Input, "MARCH"))
                {
                    Month1DayCount = March_DayCount;
                    Month1 = March;
                }
                if (string.Equals(UpperMonth1Input, "APRIL"))
                {
                    Month1DayCount = April_DayCount;
                    Month1 = April;
                }
                if (string.Equals(UpperMonth1Input, "MAY"))
                {
                    Month1DayCount = May_DayCount;
                    Month1 = May;
                }
                if (string.Equals(UpperMonth1Input, "JUNE"))
                {
                    Month1DayCount = June_DayCount;
                    Month1 = June;
                }
                if (string.Equals(UpperMonth1Input, "JULY"))
                {
                    Month1DayCount = July_DayCount;
                    Month1 = July;
                }
                if (string.Equals(UpperMonth1Input, "AUGUST"))
                {
                    Month1DayCount = August_DayCount;
                    Month1 = August;
                }
                if (string.Equals(UpperMonth1Input, "SEPTEMBER"))
                {
                    Month1DayCount = September_DayCount;
                    Month1 = September;
                }
                if (string.Equals(UpperMonth1Input, "OCTOBER"))
                {
                    Month1DayCount = October_DayCount;
                    Month1 = October;
                }
                if (string.Equals(UpperMonth1Input, "NOVEMBER"))
                {
                    Month1DayCount = November_DayCount;
                    Month1 = November;
                }
                if (string.Equals(UpperMonth1Input, "DECEMBER"))
                {
                    Month1DayCount = December_DayCount;
                    Month1 = December;
                }
               
                if ((Day1InputControl == false || (Month1 < Day1)) && Month1InputControl && Year1InputControl)
                {
                    Day1InputControl = false;
                    
                    Console.WriteLine("Day is wrong!");                    
                }
                else if ((Day1InputControl == false || (Month1 < Day1)) && Month1InputControl == false && Year1InputControl)
                {
                    Day1InputControl = false;
                   
                    Console.WriteLine("Day is wrong!");
                    Console.WriteLine("Month is wrong!");                   
                }
                else if ((Day1InputControl == false || (Month1 < Day1)) && Month1InputControl == false && Year1InputControl == false)
                {
                    Day1InputControl = false;
                    
                    Console.WriteLine("Day is wrong!");
                    Console.WriteLine("Month is wrong!");
                    Console.WriteLine("Year is wrong!");                  
                }
                else if (Day1InputControl && Month1InputControl == false && Year1InputControl)
                {
                   
                    Console.WriteLine("Month is wrong!");                   
                }
                else if (Day1InputControl && Month1InputControl == false && Year1InputControl == false)
                {
                   
                    Console.WriteLine("Month is wrong!");
                    Console.WriteLine("Year is wrong!");                    
                }
                else if ((Day1InputControl == false || (Month1 < Day1)) && Month1InputControl && Year1InputControl == false)
                {
                    Day1InputControl = false;
                   
                    Console.WriteLine("Day is wrong!");
                    Console.WriteLine("Year is wrong!");                    
                }
                else if (Day1InputControl && Month1InputControl && Year1InputControl == false)
                {
                   
                    Console.WriteLine("Year is wrong!");                    
                }
                if (Year1 < 2015 && (int.TryParse(Year1Input, out Year1)))
                {
                    Console.WriteLine("The date must be after 01.01.2015");
                    control2015_1 = false;
                }

                if (Day1InputControl && Month1InputControl && Year1InputControl&& control2015_1)
                {
                    whilecontrol1 = false;
                }
                Console.WriteLine("Please try again\n");
            }
            Console.Clear();
            //Taking second date,assigning month variables and controlling them.If inputs are wrong write a error message to the terminal.
            while (whilecontrol2)
                

            {
                Day2InputControl = true;
                Month2InputControl = true;
                Year2InputControl = true;
                control2015_2 = true;
                Console.WriteLine("Please enter day2: ");
                Day2Input = Console.ReadLine();
                if (!(int.TryParse(Day2Input, out Day2))|| Month2 < Day2||Day2<=0||Day2>31)
                {
                    Day2InputControl = false;
                }
                Console.WriteLine("Please enter month2: ");
                Month2Input = Console.ReadLine();
                UpperMonth2Input = Month2Input.ToUpper();
                if (!((string.Equals(UpperMonth2Input, "JANUARY")) ||
                      (string.Equals(UpperMonth2Input, "FEBRUARY")) ||
                      (string.Equals(UpperMonth2Input, "MARCH")) ||
                      (string.Equals(UpperMonth2Input, "APRIL")) ||
                      (string.Equals(UpperMonth2Input, "MAY")) ||
                      (string.Equals(UpperMonth2Input, "JUNE")) ||
                      (string.Equals(UpperMonth2Input, "JULY")) ||
                      (string.Equals(UpperMonth2Input, "AUGUST")) || 
                      (string.Equals(UpperMonth2Input, "SEPTEMBER")) ||
                      (string.Equals(UpperMonth2Input, "OCTOBER")) ||
                      (string.Equals(UpperMonth2Input, "NOVEMBER")) ||
                      (string.Equals(UpperMonth2Input, "DECEMBER")))
                      )
                {
                    Month2InputControl = false;                  
                }
                Console.WriteLine("Please enter year2: ");
                Year2Input = Console.ReadLine();
                Console.Clear();
               
                if (!(int.TryParse(Year2Input, out Year2)))
                {
                    Year2InputControl = false;
                }               
                if (string.Equals(UpperMonth2Input, "JANUARY"))
                {
                    Month2DayCount = January_DayCount;
                    Month2 = January;
                }
                if (string.Equals(UpperMonth2Input, "FEBRUARY"))
                {
                    Month2DayCount = February_DayCount;
                    if (Year2 % 4 == 0)
                    {
                        Month1 = 29;
                    }
                    else
                    {
                        Month1 = 28;
                    }

                }
                if (string.Equals(UpperMonth2Input, "MARCH"))
                {
                    Month2DayCount = March_DayCount;
                    Month2 = March;
                }
                if (string.Equals(UpperMonth2Input, "APRIL"))
                {
                    Month2DayCount = April_DayCount;
                    Month2 = April;
                }
                if (string.Equals(UpperMonth2Input, "MAY"))
                {
                    Month2DayCount = May_DayCount;
                    Month2 = May;
                }
                if (string.Equals(UpperMonth2Input, "JUNE"))
                {
                    Month2DayCount = June_DayCount;
                    Month2 = June;
                }
                if (string.Equals(UpperMonth2Input, "JULY"))
                {
                    Month2DayCount = July_DayCount;
                    Month2 = July;
                }
                if (string.Equals(UpperMonth2Input, "AUGUST"))
                {
                    Month2DayCount = August_DayCount;
                    Month2 = August;
                }
                if (string.Equals(UpperMonth2Input, "SEPTEMBER"))
                {
                    Month2DayCount = September_DayCount;
                    Month2 = September;
                }
                if (string.Equals(UpperMonth2Input, "OCTOBER"))
                {
                    Month2DayCount = October_DayCount;
                    Month2 = October;
                }
                if (string.Equals(UpperMonth2Input, "NOVEMBER"))
                {
                    Month2DayCount = November_DayCount;
                    Month2 = November;
                }
                if (string.Equals(UpperMonth2Input, "DECEMBER"))
                {
                    Month2DayCount = December_DayCount;
                    Month2 = December;
                }
                
                if ((Day2InputControl == false || (Month2 < Day2)) && Month2InputControl && Year2InputControl)
                {
                    Day2InputControl = false;

                    Console.WriteLine("Day Is Wrong!");                    
                }
                else if ((Day2InputControl == false || (Month2 < Day2)) && Month2InputControl == false && Year2InputControl)
                {
                    Day2InputControl = false;
                    Console.WriteLine("Day Is Wrong!");
                    Console.WriteLine("Month Is Wrong!");                    
                }
                else if ((Day2InputControl == false || (Month2 < Day2)) && Month2InputControl == false && Year2InputControl == false)
                {
                    Day2InputControl = false;
                    Console.WriteLine("Day Is Wrong!");
                    Console.WriteLine("Month Is Wrong!");
                    Console.WriteLine("Year Is Wrong!");                    
                }
                else if (Day2InputControl && Month2InputControl == false && Year2InputControl)
                {
                    Console.WriteLine("Month Is Wrong!");                   
                }
                else if (Day2InputControl && Month2InputControl == false && Year2InputControl == false)
                {
                    Console.WriteLine("Month Is Wrong!");
                    Console.WriteLine("Year Is Wrong!");                  
                }
                else if ((Day2InputControl == false || (Month2 < Day2)) && Month2InputControl && Year2InputControl == false)
                {
                    Day2InputControl = false;
                    Console.WriteLine("Day Is Wrong!");
                    Console.WriteLine("Year Is Wrong!");                   
                }
                else if (Day2InputControl && Month2InputControl && Year2InputControl == false)
                {
                    Console.WriteLine("Year Is Wrong!");                   
                }
                if (Year2 < 2015 && (int.TryParse(Year2Input, out Year2)))
                {
                    Console.WriteLine("The date must be after 01.01.2015");
                    control2015_2 = false;
                }
                if (Day2InputControl && Month2InputControl && Year2InputControl&&control2015_2)
                {
                    whilecontrol2 = false;
                }
                Console.WriteLine("Please try again\n");
            }
            Console.Clear();
            //Taking increment number and control the number,If number is not positive and not integer write a error message to the terminal.
            while (whilecontrol3)
            {
                whilecontrol3 = true;
                Console.WriteLine("Please enter the increment:");
                N_input = Console.ReadLine();
                if (!(int.TryParse(N_input, out n))||n<=0)
                {   
                    Console.WriteLine("n must be a integer and positive");
 
                }
                else
                {
                    whilecontrol3 = false;
                }
            }
            Console.Clear(); 
            //If second date before than first date,swap the value of variables
                
                if ((Year1 > Year2) || ((Year1 == Year2) && (Month1DayCount > Month2DayCount)) || ((Year1 == Year2) && (Month1DayCount == Month2DayCount) && (Day1 > Day2)))
                {
                    int temp;
                    temp = Year1;
                    Year1 = Year2;
                    Year2 = temp;
                    temp = Month1;
                    Month1 = Month2;
                    Month2 = temp;
                    temp = Day1;
                    Day1 = Day2;
                    Day2 = temp;
                    temp = Month1DayCount;
                    Month1DayCount = Month2DayCount;
                    Month2DayCount = temp;
                    
            }
                //Finding how many year is 366 days for the calculate the dates day difference.
            int sum=0;
            int fakeyear1 = Year1;
            int fakeyear2 = Year2;
            if (fakeyear1 % 4 == 0)
            {
                sum++;
            }

            for (int a=0; a < Year2 - Year1; a++)
            {               
                fakeyear1 += 1;                
                if ((fakeyear1 % 4==0))
                {
                    sum++;
                }                               
            }
            //Finding total days and defining season variables.
            int totaldays = (Year2 - Year1) * 365 + (Month2DayCount - Month1DayCount) + (Day2-Month2) + (Month1-Day1)+sum;
            int Year1daycount = Month1DayCount+Day1-Month1;       
            bool wintercontrol = true;
            bool springcontrol = true;
            bool summercontrol = true;
            bool fallcontrol = true;     
            //Using for loop for writing days to the screen.
            for (int i= Month1DayCount; i<Month1DayCount+totaldays; i+=n)
            {   //If the date is exceed the second date,break the loop.
                if (Year1==Year2 && Year1daycount>Month2DayCount+Day2-Month2-n)
                {                   
                    break;
                }
                Year1daycount+=n;                                                
                if (Year1daycount > 0 && Year1daycount <= January_DayCount)
                {
                    
                    
                    Console.WriteLine(Year1daycount + " January "+ Year1 +" "+ dayofweek(Year1daycount,13,(Year1-1)%100,Math.Floor(Convert.ToDouble(Year1-1) / 100)));

                }
                
                if (Year1daycount > January_DayCount && Year1daycount <= February_DayCount)
                {
                    
                    Console.WriteLine(Year1daycount-January_DayCount + " February " + Year1 + " " + dayofweek(Year1daycount - January_DayCount, 14, (Year1 - 1) % 100, Math.Floor(Convert.ToDouble(Year1 - 1) / 100)));

                }
                
                if (Year1daycount > February_DayCount && Year1daycount <= March_DayCount)
                {
                    
                    while (springcontrol)
                    {
                        Console.WriteLine("\n***SPRING***\n");
                        springcontrol = false;
                    }
                    
                    Console.WriteLine(Year1daycount - February_DayCount + " March " + Year1 + " " + dayofweek(Year1daycount - February_DayCount, 3, (Year1) % 100, Math.Floor(Convert.ToDouble(Year1) / 100)));

                }
               
                
                if (Year1daycount > March_DayCount && Year1daycount <= April_DayCount)
                {
                    
                    Console.WriteLine(Year1daycount - March_DayCount + " April " + Year1 + " " + dayofweek(Year1daycount - March_DayCount, 4, (Year1) % 100, Math.Floor(Convert.ToDouble(Year1) / 100)));

                }
               
                if (Year1daycount > April_DayCount && Year1daycount <= May_DayCount)
                {
                    
                    Console.WriteLine(Year1daycount - April_DayCount + " May " + Year1 + " " + dayofweek(Year1daycount - April_DayCount, 5, (Year1) % 100, Math.Floor(Convert.ToDouble(Year1 ) / 100)));

                }                
                if (Year1daycount > May_DayCount && Year1daycount <= June_DayCount)
                {
                    
                    while (summercontrol)
                    {
                        Console.WriteLine("\n***SUMMER***\n");
                        summercontrol = false;
                    }
                    
                    Console.WriteLine(Year1daycount - May_DayCount + " June " + Year1 + " " + dayofweek(Year1daycount - May_DayCount, 6, (Year1) % 100, Math.Floor(Convert.ToDouble(Year1) / 100)));

                }                
                if (Year1daycount > June_DayCount && Year1daycount <= July_DayCount)
                {
                    
                    
                    Console.WriteLine(Year1daycount-June_DayCount + " July " + Year1 + " " + dayofweek(Year1daycount - June_DayCount, 7, (Year1) % 100, Math.Floor(Convert.ToDouble(Year1) / 100)));

                }               
                if (Year1daycount > July_DayCount && Year1daycount <= August_DayCount)
                {
                    
                    Console.WriteLine(Year1daycount - July_DayCount + " August " + Year1 + " " + dayofweek(Year1daycount - July_DayCount, 8, (Year1) % 100, Math.Floor(Convert.ToDouble(Year1) / 100)));

                }                
                if (Year1daycount > August_DayCount && Year1daycount <= September_DayCount)
                {                  
                    while (fallcontrol)
                    {
                        Console.WriteLine("\n***FALL***\n");
                        fallcontrol = false;
                    }
                    
                    Console.WriteLine(Year1daycount - August_DayCount + " September " + Year1 + " " + dayofweek(Year1daycount - August_DayCount, 9, (Year1) % 100, Math.Floor(Convert.ToDouble(Year1) / 100)));

                }               
                if (Year1daycount > September_DayCount && Year1daycount <= October_DayCount)
                {
                    
                    Console.WriteLine(Year1daycount - September_DayCount + " October " + Year1 + " " + dayofweek(Year1daycount - September_DayCount, 10, (Year1) % 100, Math.Floor(Convert.ToDouble(Year1) / 100)));

                }              
                if (Year1daycount > October_DayCount && Year1daycount <= November_DayCount)
                {
                    
                    Console.WriteLine(Year1daycount - October_DayCount + " November " + Year1 + " " + dayofweek(Year1daycount - October_DayCount, 11, (Year1) % 100, Math.Floor(Convert.ToDouble(Year1) / 100)));

                }               
                if (Year1daycount > November_DayCount && Year1daycount <= December_DayCount)
                {

                    
                    while (wintercontrol)
                    {
                        Console.WriteLine("\n***WINTER***\n");
                        wintercontrol = false;
                    }
                    
                    Console.WriteLine(Year1daycount - November_DayCount + " December " + Year1 + " " + dayofweek(Year1daycount - November_DayCount, 12, (Year1) % 100, Math.Floor(Convert.ToDouble(Year1) / 100)));

                }
                //Defining year and month values also defining operations for the fix the day increment while we get to the next year.
                
                if (!(Year1 % 4 == 0) && Year1daycount >= 365)
                {      
                    Year1daycount = Year1daycount-365-n;
                    if(Year1daycount==-n)
                    {
                        Year1daycount += n;
                       
                    }
                    if(n!=1)
                    {
                        i -= n;
                    }
                    
                    Year1++;
                    wintercontrol = true;
                    springcontrol = true;
                    summercontrol = true;
                    fallcontrol = true;                   
                }
                else if (Year1 % 4 == 0 && Year1daycount >= 366)
                {
                    Year1daycount = Year1daycount - 366-n;
                    if (Year1daycount == -n)
                    {
                        Year1daycount += n;                      
                    }
                    if (n != 1)
                    {
                        i -= n;
                    }
                    Year1++;
                    wintercontrol = true;
                    springcontrol = true;
                    summercontrol = true;
                    fallcontrol = true;                    
                }
                if (Year1 % 4 == 0)
                {
                    January_DayCount = 31;
                    February_DayCount = 60;
                    March_DayCount = 91;
                    April_DayCount = 121;
                    May_DayCount = 152;
                    June_DayCount = 182;
                    July_DayCount = 213;
                    August_DayCount = 244;
                    September_DayCount = 274;
                    October_DayCount = 305;
                    November_DayCount = 335;
                    December_DayCount = 366;
                }
                else
                {
                    January_DayCount = 31;
                    February_DayCount = 59;
                    March_DayCount = 90;
                    April_DayCount = 120;
                    May_DayCount = 151;
                    June_DayCount = 181;
                    July_DayCount = 212;
                    August_DayCount = 243;
                    September_DayCount = 273;
                    October_DayCount = 304;
                    November_DayCount = 334;
                    December_DayCount = 365;
                }
                
               
            }
            Console.ReadLine();

        }
    }
}
