using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace Assignment_4.Customer___Staff
{
    [Serializable]
    public class Staff_Info
    {

        public string UploadCoverLetterPictureBase64;

        public string UploadResumePictureBase64;

        public string FirstName;
        public string LastName;
        public string StreetAddress;
        public string StreetAddressLine2;
        public string City;
        public string StateProvince;
        public int PostalZipCode;
        public string Phone;
        public string Email;
        public string ApplyForPosition;
        public string WhenYouCanStart;
        public string YourComment;


        public Staff_Info()
        {
        }

        public Staff_Info(string FirstName, string LastName, string StreetAddress, string StreetAddressLine2, string City,
            string StateProvince, int PostalZipCode, string Phone, string Email, string ApplyForPosition, string WhenYouCanStart, string UploadCoverLetter,
            string UploadResume, string YourComment)
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
            this.ApplyForPosition = ApplyForPosition;
            this.WhenYouCanStart = WhenYouCanStart;
            this.UploadCoverLetterPictureBase64 = UploadCoverLetter;
            this.UploadResumePictureBase64 = UploadResume;
            this.YourComment = YourComment;
        }
    }
}