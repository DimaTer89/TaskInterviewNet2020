﻿namespace ClockLibrary
{
    public interface IClockAdapter
    {
        string ShowDigitalTime();
        void SetHourAngle(double hourAngle);
        void SetMinuteAngle(double minuteAngle);
        void SetSecondAngle(double secondAngle);
    }
}
