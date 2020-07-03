namespace TaskEpam.Net2020
{
    class ClockAdapter:IClockAdapter
    {
        private ClockWithArrows clockWithArrows;
        private const int VALUE_BOUNDARY_HOUR = 24;
        private const int VALUE_BOUNDARY_MINUTE_SECOND = 60;
        private const int HOUR_DEGREE = 30;
        private const int MINUTE_SECOND_DEGREE = 6;
        
        public ClockAdapter(ClockWithArrows clockWithArrows)
        {
            this.clockWithArrows = clockWithArrows;
        }

        public void SetHourAngle(double hourAngle)
        {
            clockWithArrows.HourAngle = hourAngle;
        }

        public void SetMinuteAngle(double minuteAngle)
        {
            clockWithArrows.MinuteAngle = minuteAngle;
        }

        public void SetSecondAngle(double secondAngle)
        {
            clockWithArrows.SecondAngle = secondAngle;
        }

        public string ShowDigitalTime()
        {
            int hours = (int)clockWithArrows.HourAngle / HOUR_DEGREE;
            int minutes = (int)clockWithArrows.MinuteAngle / MINUTE_SECOND_DEGREE;
            int seconds = (int)clockWithArrows.SecondAngle / MINUTE_SECOND_DEGREE;
            return string.Format("{0:00}:{1:00}:{2:00}", ((hours < VALUE_BOUNDARY_HOUR) ? hours : 0), ((minutes < VALUE_BOUNDARY_MINUTE_SECOND) ? minutes : 0), ((seconds < VALUE_BOUNDARY_MINUTE_SECOND) ? seconds : 0));
        }
    }
}
