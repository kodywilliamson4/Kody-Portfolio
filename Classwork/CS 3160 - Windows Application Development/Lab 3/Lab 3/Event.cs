//File: Event.cs
//Authors: Caudill, Connor; Williamson, Kody
//Class: CS 3160
//Instrcutor: Jadwiga Carlson
//Date: 23 March 2020
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    //Declaration of Event class
    public class Event
    {
        //Making these private variables made the code impossible, so they have been made public with private setters; best of both worlds
        public DateTime startTime { get; private set; }
        public DateTime endTime { get; private set; }
        public string eventTitle { get; private set; }
        
        //Overloaded constructor
        public Event(int Year, int Month, int Day, int startHour, int startMin, int endHour, int endMin, string Title)
        {
            //Exception block to validate that the dates are valid dates.
            if (Title == "")
                throw new System.ArgumentException("Event Title cannot be empty.");
            if (startHour < endHour)
            {
                if ((startMin > endMin) && (startHour == endHour))
                    throw new System.ArgumentException("Event ends before it starts.");
            }
            else
                throw new System.ArgumentException("Event ends before it starts.");

            //Setting of instance variables of class
            startTime = new DateTime(Year, Month, Day, startHour, startMin, 0);
            endTime = new DateTime(Year, Month, Day, endHour, endMin, 0);
            eventTitle = Title;
        }
        //Override of toString function, necessary for inclusion in listbox
        public override string ToString()
        {
            //Different formatting needed to add leading zeros for times before noon
            if (startTime.Hour < 10 && startTime.Minute > 9)
            {
                return ($"{startTime.Year}-{startTime.Month}-{startTime.Day} 0{startTime.Hour}:{startTime.Minute}");
            }
            else if (startTime.Minute == 0 && startTime.Hour < 10)
            {
                return ($"{startTime.Year}-{startTime.Month}-{startTime.Day} 0{startTime.Hour}:00");
            }
            else if (startTime.Minute == 0)
            {
                return ($"{startTime.Year}-{startTime.Month}-{startTime.Day} {startTime.Hour}:00");
            }
            else if (startTime.Hour < 10 && startTime.Minute < 10)
            {
                return ($"{startTime.Year}-{startTime.Month}-{startTime.Day} 0{startTime.Hour}:0{startTime.Minute}");
            }
            else if (startTime.Minute < 10)
            {
                return ($"{startTime.Year}-{startTime.Month}-{startTime.Day} {startTime.Hour}:0{startTime.Minute}");
            }
            else
            {
                return ($"{startTime.Year}-{startTime.Month}-{startTime.Day} {startTime.Hour}:{startTime.Minute}");
            }
        }
        //Overriden equals function
        public override bool Equals(object obj)
        {
            //Basically just sees if instance variables are the same between events
            var other = obj as Event;

            if (other == null)
                return false;
            if (other.startTime != this.startTime)
                return false;
            else if (other.endTime != this.endTime)
                return false;
            else if (other.eventTitle != this.eventTitle)
                return false;
            return true;

        }
        public override int GetHashCode()
        {
            //Simple, basic hash calculation based on random aspects of class.
            int hashCode = 12345;
            int holder = 0;
            holder = startTime.Year + startTime.Month + startTime.Day;
            return holder * hashCode;
        }
    }
}
