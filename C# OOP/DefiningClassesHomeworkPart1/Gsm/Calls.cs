using System;
namespace Gsm
{
    public class Calls
    {
        private DateTime dateAndTime;
        private string dialledPhoneNumber;
        private int duration;

        public Calls()
        {

        }
        public Calls(DateTime callDateAndTime, string callDialledPhoneNumber, int callDuration)
        {
            this.dateAndTime = callDateAndTime;
            this.dialledPhoneNumber = callDialledPhoneNumber;
            this.duration = callDuration;
        }
        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            private set
            {
                this.dateAndTime = value;
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }
            set
            {
                this.dialledPhoneNumber = value;
            }
        }
        public int Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            return "Date and time: "+ DateAndTime + "\r\nDialled phone number: " + DialledPhoneNumber + "\r\nDuration in seconds: " + Duration;
        }
    }
}
