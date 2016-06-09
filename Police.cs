using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police
{
    public class Police1
    {
        private string _officerName;
        private string _badgeNum;
        private double _fineAmount;

        public string OfficerName
        {
            get
            {
                return _officerName;
            }
            set
            {
                _officerName = value;
            }
        }
        public string BadgeNum
        {
            get
            {
                return _badgeNum;
            }
            set
            {
                _badgeNum = value;
            }
        }
        public double FineAmount
        {
            get
            {
                return _fineAmount;
            }
            set
            {
                _fineAmount = value;
            }
        }

    }
}
