using System;

namespace LoggingKata
{
    internal class GeoCordinate
    {
        public GeoCordinate()
        {
        }

        public object Latitude { get; internal set; }
        public object Longuitude { get; internal set; }

        internal double GetDistanceTo(object corB)
        {
            throw new NotImplementedException();
        }
    }
}