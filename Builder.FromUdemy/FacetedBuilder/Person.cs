using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FromUdemy.FacetedBuilder
{
    public class Person
    {
        //we are going to have one facet for address
        public string StreetAddress, Postcode, City;

        //and one for employment
        public string CompanyName, Position;

        public int AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }
}
