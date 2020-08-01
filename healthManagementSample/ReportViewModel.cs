using System;
using System.Collections.ObjectModel;

namespace healthManagementSample
{
    public class ReportViewModel
    {

        public ObservableCollection<CalendarModel> CalendarList { get; set; } = new ObservableCollection<CalendarModel>();

        public ReportViewModel()
        {

            CalendarList.Add(new CalendarModel { Weekday = "Fri", MonthDay = "14" });
            CalendarList.Add(new CalendarModel { Weekday = "Sat", MonthDay = "15" });
            CalendarList.Add(new CalendarModel { Weekday = "Sun", MonthDay = "16" });
            CalendarList.Add(new CalendarModel { Weekday = "Mon", MonthDay = "17" });
            CalendarList.Add(new CalendarModel { Weekday = "Tue", MonthDay = "18" });
            CalendarList.Add(new CalendarModel { Weekday = "Wed", MonthDay = "19" });
            CalendarList.Add(new CalendarModel { Weekday = "Thu", MonthDay = "20" });
            CalendarList.Add(new CalendarModel { Weekday = "Fri", MonthDay = "21" });
            CalendarList.Add(new CalendarModel { Weekday = "Sat", MonthDay = "22" });
            CalendarList.Add(new CalendarModel { Weekday = "Fri", MonthDay = "14" });
            CalendarList.Add(new CalendarModel { Weekday = "Sat", MonthDay = "15" });
            CalendarList.Add(new CalendarModel { Weekday = "Sun", MonthDay = "16" });
            CalendarList.Add(new CalendarModel { Weekday = "Mon", MonthDay = "17" });
            CalendarList.Add(new CalendarModel { Weekday = "Tue", MonthDay = "18" });
            CalendarList.Add(new CalendarModel { Weekday = "Wed", MonthDay = "19" });
            CalendarList.Add(new CalendarModel { Weekday = "Thu", MonthDay = "20" });
            CalendarList.Add(new CalendarModel { Weekday = "Fri", MonthDay = "21" });
            CalendarList.Add(new CalendarModel { Weekday = "Sat", MonthDay = "22" });

        }
    }
}
