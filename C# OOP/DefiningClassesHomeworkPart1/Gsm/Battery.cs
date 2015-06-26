namespace Gsm
{
    using System;

    public class Battery
    {
        private BatteryType model;
        private double hoursIdle;
        private double hoursTalk;

        public Battery()
        {

        }
        public Battery(BatteryType batteryModel)
        {
            this.Model = batteryModel;
        }
        public Battery(BatteryType batteryModel, double batteryHoursIdle, double batteryHoursTalk)
            : this(batteryModel)
        {
            this.HoursIdle = batteryHoursIdle;
            this.HoursTalk = batteryHoursTalk;
        }

        public BatteryType Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 600)
                {
                    throw new ArgumentOutOfRangeException("Invalid hours idle(should be greater than 600)");
                }
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 500)
                {
                    throw new ArgumentOutOfRangeException("Invalid hours idle(should be greater than 500)");
                }
                this.hoursTalk = value;
            }
        }
    }
}