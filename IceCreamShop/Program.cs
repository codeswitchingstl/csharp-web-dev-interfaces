﻿using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;


            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name' field.
            FlavorComparer comparer = new FlavorComparer();
            availableFlavors.Sort(comparer);

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            ConeComparer compareCones = new ConeComparer();
            availableCones.Sort(compareCones);
            foreach (Cone c in availableCones)
            {
                Console.WriteLine(c);
            }

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}
