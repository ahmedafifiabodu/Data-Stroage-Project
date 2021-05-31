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
        [NonSerialized]
        private Bitmap UploadCoverLetterPicture;

        [NonSerialized]
        private Bitmap UploadResumePicture;

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

        //[XmlElementAttribute("UploadCoverLetter")]
        public byte[] UploadCoverLetterImage
        {
            get
            {
                if (UploadCoverLetterPicture != null)
                {
                    TypeConverter BitmapConverter =
                         TypeDescriptor.GetConverter(UploadCoverLetterPicture.GetType());
                    return (byte[])
                         BitmapConverter.ConvertTo(UploadCoverLetterPicture, typeof(byte[]));
                }
                else
                    return null;
            }

            set
            {
                if (value != null && value.Length !=0)
                    UploadCoverLetterPicture = new Bitmap(new MemoryStream(value));
                else
                    UploadCoverLetterPicture = new Bitmap(1, 1);
            }
        }

        //[XmlElementAttribute("UploadResume")]
        public byte[] UploadResumeImage
        {
            get
            {
                if (UploadResumePicture != null)
                {
                    TypeConverter BitmapConverter =
                         TypeDescriptor.GetConverter(UploadResumePicture.GetType());
                    return (byte[])
                         BitmapConverter.ConvertTo(UploadResumePicture, typeof(byte[]));
                }
                else
                    return null;
            }

            set
            {
                if (value != null && value.Length != 0)
                    UploadResumePicture = new Bitmap(new MemoryStream(value));
                else
                    UploadResumePicture = new Bitmap(1, 1);
            }
        }

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
            this.UploadCoverLetterImage = Convert.FromBase64String(UploadCoverLetter);
            this.UploadResumeImage = Convert.FromBase64String(UploadResume);
            this.YourComment = YourComment;
        }
    }
}