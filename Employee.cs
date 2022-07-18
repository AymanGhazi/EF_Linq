using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice;

public class Employee
{
    public int ID { get; internal set; }
    public string Name { get; internal set; }
    public decimal Salary { get;internal set; }


    public override bool Equals(object obj)
    {


        if (obj is Employee R)
        {
            if (R == null) return false;
            if (this.GetType() != R.GetType()) return false;
            if (Object.ReferenceEquals(this, R)) return true;
            return (ID == R.ID) && (Name == R.Name) && (Salary == R.Salary);
        }

        return false;

    }

    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        throw new System.NotImplementedException();
        return base.GetHashCode();
    }


    public override string ToString()

        => $"ID : {ID} , Name {Name} , Salary {Salary}";



}
