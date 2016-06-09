using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Cars
    {
        private string _make;
        private string _model;
        private string _color;
        private string _plateNum;
        private int _minPurchased;
        private double _minParked;

        public Cars(string make, string model, string color, string plateNum)
        {
            this._make = make;
            this._model = model;
            this._color = color;
            this._plateNum = plateNum;
        }


        public Cars()
        {
    
        }

        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public string PlateNum
        {
            get
            {
                return _plateNum;
            }
            set
            {
                _plateNum = value;
            }
        }
        public int MinPurchased
        {
            get
            {
                return _minPurchased;
            }
            set
            {
                _minPurchased = value;
            }
        }
        public double MinParked
        {
            get
            {
                return _minParked;
            }
            set
            {
                _minParked = value;
            }
        }

    }

}
