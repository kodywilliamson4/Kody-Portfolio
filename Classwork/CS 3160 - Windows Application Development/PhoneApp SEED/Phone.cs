using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Lab6;

namespace PhoneApp
{
    public class Phone
    {
        /// <summary>
        /// There is one Phone object per phone number in the
        /// database.
        /// </summary>
        private string m_Name;
        private string m_PhoneNumber;
        public const string FormatError = "**";
        private static Regex whitespace;
        private static Regex valName;
        private static Regex sixDigit;
        private static Regex sixDigitDash;
        private static Regex tenDigitDash;
        private static Regex tenDigit;
        private static Regex Dashes;
        public string PhoneNumberDisplay
        {
            get
            {
                string[] splits = new string[3];
                splits = Dashes.Split(m_PhoneNumber);
                return splits[0] + "-" + splits[1] + "-" + splits[2];
            }
        }

        public Phone(string name, string phone)
        {
            // Use the properties so that data validation is done.
            Name = name;
            PhoneNumber = phone;
        }
        static Phone()
        {
            whitespace = new Regex(@"^[ \t] +|[ \t] +$");
            valName = new Regex(@"^[A-z -']+,[A-z -']+$");
            sixDigit = new Regex(@"^\d{7}$");
            sixDigitDash = new Regex(@"^\d{3}-\d{4}$");
            tenDigitDash = new Regex(@"^\d{3}-\d{3}-\d{4}$");
            tenDigit = new Regex(@"^\d{10}$");
            Dashes = new Regex(@"[-]+");
        }

        public string Name
        {
            get { return m_Name; }
            set
            {
                string name = ValidateName(value);
                if (name == FormatError)
                    throw new MyFieldException("Invalid Format", "Name", value);
                m_Name = value;
            }
        }

        public string PhoneNumber
        {
            get { return m_PhoneNumber; }
            set
            {
                string number = ValidatePhoneNumber(value);
                if (number == FormatError)
                    throw new MyFieldException("Invalid Format", "Phone Number", value);
                m_PhoneNumber = number;
            }
        }

        public override string ToString()
        {
            return m_Name;
        }

        public override bool Equals(object obj)
        {
            Phone other;
            // Make sure we're comparing two Phone objects.
            if (obj == null || !(obj is Phone))
                return false;
            // Two Phone objects are equal if the phone numbers are
            // the same.
            other = (Phone)obj;
            return m_PhoneNumber == other.PhoneNumber;
        }

        public override int GetHashCode()
        {
            // Just hash the phone number.
            return m_PhoneNumber.GetHashCode();
        }

        public static string ValidateName(string name)
        {
            string retVal;
            retVal = whitespace.Replace(name, string.Empty);
            if (valName.IsMatch(retVal))
                return retVal;
            else
                return FormatError;
        }

        public static string ValidatePhoneNumber(string number)
        {
            string retVal = "**";
            if (sixDigitDash.IsMatch(number))
            {
                retVal = Dashes.Replace(number, string.Empty);
                return retVal.Insert(0, "419");
            }
            else if (sixDigit.IsMatch(number))
            {
                retVal = number.Insert(0, "419");
                return retVal;
            }
            else if (tenDigit.IsMatch(number))
            {
                return number;
            }
            else if (tenDigitDash.IsMatch(number))
            {
                retVal = Dashes.Replace(number, string.Empty);
                return retVal;
            }
            return retVal;
        }
    }
}
