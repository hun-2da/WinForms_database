using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_database
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string State { get; set; }
        
        public static List<Contact> SampleData()
        {
            return new List<Contact>()
            {
                new Contact()
                {
                    FirstName = "Barney",
                    LastName = "Gottshall",
                    DateOfBirth = DateTime.Parse("19-Oct-1945"),
                    Phone = "885 983 8858",
                    State = "CA"
                },
                new Contact()
                {
                    FirstName = "Armando",
                    LastName = "Valdes",
                    DateOfBirth = DateTime.Parse("9-Dec-1973 "),
                    Phone = "848 553 8487",
                    State = "WA"
                },new Contact()
                {
                    FirstName = "Adam",
                    LastName = "Gauwain",
                    DateOfBirth = DateTime.Parse("3-Oct-1959"),
                    Phone = "115 999 1154",
                    State = "AK"
                },new Contact()
                {
                    FirstName = "Jeffery",
                    LastName = "Deane",
                    DateOfBirth = DateTime.Parse("16-Dec-1950"),
                    Phone = "677 602 6774",
                    State = "CA"
                },new Contact()
                {
                    FirstName = "Collin",
                    LastName = "Zeeman",
                    DateOfBirth = DateTime.Parse("10-Feb-1935"),
                    Phone = "603 303 6030",
                    State = "FL"
                },new Contact()
                {
                    FirstName = "Stewart",
                    LastName = "Kagel",
                    DateOfBirth = DateTime.Parse("20-Feb-1950"),
                    Phone = "546 607 5462",
                    State = "WA"
                },new Contact()
                {
                    FirstName = "Chance",
                    LastName = "Lard",
                    DateOfBirth = DateTime.Parse("21-Oct-1951"),
                    Phone = "278 918 2789",
                    State = "WA"
                },new Contact()
                {
                    FirstName = "Blaine",
                    LastName = "Reifsteck",
                    DateOfBirth = DateTime.Parse("18-May-1946"),
                    Phone = "715 920 7157",
                    State = "TX"
                },new Contact()
                {
                    FirstName = "Mack",
                    LastName = "Kamph",
                    DateOfBirth = DateTime.Parse("17-Sep-1977"),
                    Phone = "364 202 3644",
                    State = "TX"
                },new Contact()
                {
                    FirstName = "Ariel",
                    LastName = "Hazelgrove",
                    DateOfBirth = DateTime.Parse("23-May-1922"),
                    Phone = "165 737 1656",
                    State = "OR"
                },
            };
        }
    }
}
