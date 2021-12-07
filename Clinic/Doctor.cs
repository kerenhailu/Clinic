using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    internal class Doctor : Worker ,IComparable
    {
        public int numPatients;
        public int yearOfBirth;
        public Doctor(string name, string lname, string job, int numPatients, int yearOfBirth) : base(name, lname, job)
        {
            this.numPatients = numPatients;
            this.yearOfBirth = yearOfBirth;
        }

        public int CompareTo(object? obj)
        {
            Doctor p = (Doctor)obj;
            if (this.numPatients < p.numPatients)
                return -1;
            if (this.numPatients > p.numPatients)
                return 1;
            return 0;
        }
    }
}
