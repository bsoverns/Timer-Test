using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace time_test
{
    class Program
    {
        static void Main(string[] args)
        {                    
            string run = "Y";
            string test = "N";
            DateTime time;
            //DateTime startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 22, 34, 0);
            DateTime startTime = new DateTime(2022, 10, 06, 19, 09, 00);  //2022-10-06 19:09:00.000
            DateTime endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 22, 36, 0);
            while (test == "N")
            {
                while (run == "Y")
                {
                    time = DateTime.Now;
                    TimeSpan ts = time - startTime;
                    int days = Math.Abs(ts.Days);

                    //if ((time.Hour >= 11 && time.Minute >= 40) && (time.Hour <= 11 && time.Minute <= 40))                    
                    if ((time >= startTime) && (time <=endTime))                    
                    { 
                        Console.WriteLine("");
                        Console.WriteLine("Criteria met.");                        
                        Console.WriteLine(time.ToString());
                        Console.WriteLine(startTime.ToString());
                        Console.WriteLine(time.Hour.ToString() + ":" + time.Minute.ToString() + " - Current Time");
                        Console.WriteLine(startTime.Hour.ToString() + ":" + startTime.Minute.ToString() + " - Start Time");
                        Console.WriteLine("This is a test: " + days.ToString());
                    }

                    //if (time.Hour >= 10)
                    else
                    {                     
                        //run = "N";
                        Console.WriteLine("");
                        Console.WriteLine("Criteria not met.");
                        Console.WriteLine(time.ToString());
                        Console.WriteLine(startTime.ToString());
                        Console.WriteLine(time.Hour.ToString() + ":" + time.Minute.ToString() + " - Current Time");
                        //Console.WriteLine(startTime.Hour.ToString() + ":" + startTime.Minute.ToString() + " - Start Time");
                        Console.WriteLine("This is a test: " + days.ToString());
                        //Thread.Sleep(1000000);
                    }


                    //Thread.Sleep(1000);
                    Thread.Sleep(60000);
                }
            }
                        
        }        
    }
}



/*
var timezone = StringHelper.Coalesce(x.OrganizationSite.TimeZone, x.Organization?.TimeZone); //Pacific
var currentDateTime = DateTime.UtcNow; //2022-10-12 17:05:38.500	

if (x.PatientClass.PatientClassName.Equals("Emergency") || x.PatientClass.PatientClassName.Equals("Outpatient"))
{
	return 0;
}

if (!x.DischargeDateTime.HasValue)
{
	if (!string.IsNullOrWhiteSpace(timezone))
	{
		var timeZoneInfo = TZConvert.GetTimeZoneInfo(timezone);
		currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(currentDateTime, timeZoneInfo); //2022-10-12 10:05:38.500 -07:00
	}
	return (x.AdmitDateTime?.Date == currentDateTime.Date ? 0 : //2022-10-06 19:09:00.000
			//Convert.ToInt32(Math.Truncate((currentDateTime - x.AdmitDateTime.Value).TotalDays))
			TimeSpan ts = currentDateTime-x.AdmitDateTime;
			int days = Math.Abs(ts.Days);
			); //Should be 6  

						
}

else //Not reached
{
	return (x.AdmitDateTime?.Date == x.DischargeDateTime?.Date ? 0 :
			Convert.ToInt32(Math.Truncate((x.DischargeDateTime.Value - x.AdmitDateTime.Value).TotalDays)));
}       Convert.ToInt32(Math.Truncate((x.DischargeDateTime.Value - x.AdmitDateTime.Value).TotalDays)));
}
*/