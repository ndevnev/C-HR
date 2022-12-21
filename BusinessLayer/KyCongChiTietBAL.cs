using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class KyCongChiTietBAL
    {
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();
        public List<TB_KYCONGCHITIET> getList(int makycong)
        {
            return db.TB_KYCONGCHITIET.Where(x => x.MAKYCONG == makycong).ToList();
        }
        public void phatSinhKyCongChiTiet(int macty, int thang, int nam)
        {
            var lstNV = db.TB_NHANVIEN.ToList();
            if (lstNV.Count == 0) return;

            foreach (var item in lstNV)
            {
                List<string> listDay = new List<string>();

                for (int j = 1; j <= GetDayNumber(thang, nam); j++)
                {
                    DateTime newDate = new DateTime(nam, thang, j);

                    switch (newDate.DayOfWeek.ToString())
                    {
                        case "Sunday":
                            listDay.Add("CN");
                            break;
                        case "Saturday":
                            listDay.Add("T7");
                            break;
                        default:
                            listDay.Add("X");
                            break;
                    }
                }

                switch (listDay.Count)
                {
                    case 28:
                        listDay.Add("");
                        listDay.Add("");
                        listDay.Add("");
                        break;
                    case 29:
                        listDay.Add("");
                        listDay.Add("");
                        break;
                    case 30:
                        listDay.Add("");
                        break;
                }

                TB_KYCONGCHITIET kycongchitiet = new TB_KYCONGCHITIET();
                kycongchitiet.MANV = item.MANHANVIEN;
                kycongchitiet.HOTEN = item.HOVATEN;
                kycongchitiet.MACTY = 1;
                kycongchitiet.D1 = listDay[0];
                kycongchitiet.D2 = listDay[1];
                kycongchitiet.D3 = listDay[2];
                kycongchitiet.D4 = listDay[3];
                kycongchitiet.D5 = listDay[4];
                kycongchitiet.D6 = listDay[5];
                kycongchitiet.D7 = listDay[6];
                kycongchitiet.D8 = listDay[7];
                kycongchitiet.D9 = listDay[8];
                kycongchitiet.D10 = listDay[9];
                kycongchitiet.D11 = listDay[10];
                kycongchitiet.D12 = listDay[11];
                kycongchitiet.D13 = listDay[12];
                kycongchitiet.D14 = listDay[13];
                kycongchitiet.D15 = listDay[14];
                kycongchitiet.D16 = listDay[15];
                kycongchitiet.D17 = listDay[16];
                kycongchitiet.D18 = listDay[17];
                kycongchitiet.D19 = listDay[18];
                kycongchitiet.D20 = listDay[19];
                kycongchitiet.D21 = listDay[20];
                kycongchitiet.D22 = listDay[21];
                kycongchitiet.D23 = listDay[22];
                kycongchitiet.D24 = listDay[23];
                kycongchitiet.D25 = listDay[24];
                kycongchitiet.D26 = listDay[25];
                kycongchitiet.D27 = listDay[26];
                kycongchitiet.D28 = listDay[27];
                kycongchitiet.D29 = listDay[28];
                kycongchitiet.D30 = listDay[29];
                kycongchitiet.D31 = listDay[30];

                kycongchitiet.MAKYCONG = nam * 100 + thang;
                db.TB_KYCONGCHITIET.Add(kycongchitiet);
                try
                {
                    db.SaveChanges();
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

        }
        private int GetDayNumber(int thang, int nam)
        {
            int dayNumber = 0;
            switch (thang)
            {
                case 2:
                    dayNumber = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    dayNumber = 30;
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dayNumber = 31;
                    break;
            }

            return dayNumber;
        }
    }
}
