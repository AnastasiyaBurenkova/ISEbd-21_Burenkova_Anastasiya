using System;
using System.Runtime.Serialization;

namespace WindowsFormsApplication18
{
    [Serializable]
    internal class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException():
            base ("На парковке есть такая машина")
        { }
    }
}