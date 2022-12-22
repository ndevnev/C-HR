using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Common
{
    public class CommonDateTimeBAL
    {
        public static int demSoNgayLamViecTrongThang(int thang, int nam)
        {
            DateTime startDate = new DateTime(nam, thang, 1);
            int totalDays = startDate.AddMonths(1).Subtract(startDate).Days;
            int songaychunhat = Enumerable.Range(1, totalDays)
                .Select(item => new DateTime(nam, thang, item))
                .Where(date => date.DayOfWeek == DayOfWeek.Sunday)
                .Count();
            int songaythubay = Enumerable.Range(1, totalDays)
                .Select(item => new DateTime(nam, thang, item))
                .Where(date => date.DayOfWeek == DayOfWeek.Saturday)
                .Count();
            int result = DateTime.DaysInMonth(nam, thang) - songaythubay - songaychunhat;
            return result;
        }
        public static int laySoNgayCuaThang(int thang, int nam)
        {
            return DateTime.DaysInMonth(nam, thang);
        }
        public static string layThuTrongTuan(int nam, int thang, int ngay)
        {
            string thu = "";
            DateTime newDate = new DateTime(nam, thang, ngay);
            switch (newDate.DayOfWeek.ToString())
            {
                case "Monday":
                    thu = "Thứ hai";
                    break;
                case "Tuesday":
                    thu = "Thứ ba";
                    break;

                case "Wednesday":
                    thu = "Thứ tư";
                    break;
                case "Thursday":
                    thu = "Thứ năm";
                    break;
                case "Friday":
                    thu = "Thứ sáu";
                    break;
                case "Saturday":
                    thu = "Thứ bảy";
                    break;
                case "Sunday":
                    thu = "Chủ nhật";
                    break;
            }
            return thu;
        }
    } 
}
