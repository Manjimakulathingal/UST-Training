using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    internal class membercar
    {
        private long _id;

        private Member _member;

        private Car _car;

        private string _carRegistrationNumber;

        private string _carColor;

        public long Id

        {

            get { return _id; }

            set { _id = value; }

        }

        public Member member

        {

            get { return _member; }

            set { _member = value; }

        }

        public Car Car

        {

            get { return _car; }

            set { _car = value; }

        }

        public string CarRegistrationNumber

        {

            get { return _carRegistrationNumber; }

            set

            {

                _carRegistrationNumber = value;

            }

        }

        public string CarColor

        {

            get { return _carColor; }

            set

            {

                _carColor = value;

            }

        }

        public static void FindMember(long id)

        {

            
    }

    }

}
    

