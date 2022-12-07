using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_Final
{
    public class Car
    {
        //Create enumerator and populate with makes
        public enum MAKE { Subaru, Toyota, Honda, Nissan }

        //Fields
        MAKE _make;
        string _model;
        int _year;
        bool _hasGPS;
        bool _hasBackUpCam;
        int _mileage;

        //Constructor takes all fields
        public Car(MAKE make, string model, int year, bool hasGPS, bool hasBackUpCam, int mileage)
        {
            _make = make;
            _model = model;
            _year = year;
            _hasGPS = hasGPS;
            _hasBackUpCam = hasBackUpCam;
            _mileage = mileage;
        }

        //Properties all with get and set
        internal MAKE Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public bool HasGPS { get => _hasGPS; set => _hasGPS = value; }
        public bool HasBackUpCam { get => _hasBackUpCam; set => _hasBackUpCam = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }
    }
}
