using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			 DateTime today = DateTime.Now;
        
        		 DateTime referenceDate = new DateTime(1900, 1, 1);
        
        		 int daysDifference = (today - referenceDate).Days;
        
        		 int weekday = (daysDifference % 7);
  
        		 string day = "";
        
        		 switch (weekday)
        		 {
            			case 0: 
             				day = "Monday";
            			break;
			    	case 1: 
			     		day = "Tuesday";
			     	break;
			    	case 2: 
			     		day = "Wednesday";
			    	break;
			    	case 3: 
			     		day = "Thursday";
			      	break;
			    	case 4: 
			     		day = "Friday";
			     	break;
			    	case 5:
			     		day = "Saturday";
			     	break;
			    	case 6:
			     		day = "Sunday";
			     	break;
			    	default: 
			    		day = "Unknown";
			    	break;
        		}
        
         		Console.WriteLine("Today's weekday is: " + day);
		}
	}
}
