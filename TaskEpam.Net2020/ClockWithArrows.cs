namespace TaskEpam.Net2020
{
    class ClockWithArrows
    {
        private double hourAngle;
        private double minuteAngle;
        private double secondAngle;

        public ClockWithArrows()
        {
            hourAngle = minuteAngle = secondAngle = 0;
        }

        public ClockWithArrows(double hourAngle, double minuteAngle, double secondAngle)
        {
            this.hourAngle = hourAngle;
            this.minuteAngle = minuteAngle;
            this.secondAngle = secondAngle;
        }

        public double HourAngle
        {
            get => hourAngle;
            set
            {
                if (value >= 0 && value <= 720)
                    hourAngle = value;
            }
        }

        public double MinuteAngle
        {
            get => minuteAngle;
            set
            {
                if (value >= 0 && value <= 360)
                    minuteAngle = value;
            }
        }

        public double SecondAngle
        {
            get => secondAngle;
            set
            {
                if (value >= 0 && value <= 360)
                    secondAngle = value;
            }
        }
    }
}
