using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Assignment_4
{
    [Serializable]
    public class CustomerInfo
    {
        public XmlSerializer xmlCI = new XmlSerializer(typeof(List<CustomerInfo>));

        public string FirstName;
        public string LastName;
        public string StreetAddress;
        public string StreetAddressLine2;
        public string City;
        public string StateProvince;
        public int PostalZipCode;
        public string Phone;
        public string Email;
        public string HearAboutUs;
        public string Feedback;
        public string Suggestions;
        public string Recommend;

        public CustomerInfo()
        {
        }

        public CustomerInfo(string FirstName, string LastName, string StreetAddress, string StreetAddressLine2, string City,
            string StateProvince, int PostalZipCode, string Phone, string Email, string HearAboutUs, string Feedback, string Suggestions,
            string Recommend)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.StreetAddress = StreetAddress;
            this.StreetAddressLine2 = StreetAddressLine2;
            this.City = City;
            this.StateProvince = StateProvince;
            this.PostalZipCode = PostalZipCode;
            this.Phone = Phone;
            this.Email = Email;
            this.HearAboutUs = HearAboutUs;
            this.Feedback = Feedback;
            this.Suggestions = Suggestions;
            this.Recommend = Recommend;
        }
    }
}