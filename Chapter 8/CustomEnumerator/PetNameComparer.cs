using System;
using System.Collections;

namespace CustomEnumerator
{
    //This helper class is used to sort an array of Cars by pet name
    class PetNameComparer : IComparer
    {
        //Test the pet name of each object
        int IComparer.Compare(object x, object y)
        {
            Car t1 = x as Car;
            Car t2 = y as Car;
            if (t1 != null && t2 != null)
                return String.Compare(t1.PetName, t2.PetName);
            else
                throw new ArgumentException("Parameter is not a Car!");
        }

    }
}
