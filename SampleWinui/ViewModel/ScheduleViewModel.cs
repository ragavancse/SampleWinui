using SampleWinui.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.ViewModel
{
    public class ScheduleViewModel
    {
        public List<Schedule> Schedules=>GetSchedules().ToList();

        public List<Schedule> GetSchedules()
        {
            return new List<Schedule>()
            {
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                      new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                      new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                      new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                      new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                      new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                      new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                      new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                      new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},

                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
                new Schedule() {StartDate="01/01/2021",StartTime="9:00am",JobName="job name"},
            };

        }
    }
}
