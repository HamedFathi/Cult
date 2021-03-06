﻿using System.Text.RegularExpressions;
// ReSharper disable All 
namespace Cult.Persian
{
    public static class IranCodesUtils
    {
        private static readonly Regex _matchIranianMobileNumber1 = new Regex(@"^(((98)|(\+98)|(0098)|0)(9){1}[0-9]{9})+$", options: RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static readonly Regex _matchIranianMobileNumber2 = new Regex(@"^(9){1}[0-9]{9}$", options: RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static readonly Regex _matchIranianPhoneNumber = new Regex("^[2-9][0-9]{7}$", options: RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static readonly Regex _matchIranianPostalCode = new Regex(@"\b(?!(\d)\1{3})[13-9]{4}[1346-9][013-9]{5}\b", options: RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static bool IsValidIranianMobileNumber(this string mobileNumber)
        {
            return !string.IsNullOrWhiteSpace(mobileNumber) &&
                (_matchIranianMobileNumber1.IsMatch(mobileNumber) || _matchIranianMobileNumber2.IsMatch(mobileNumber));
        }
        public static bool IsValidIranianPhoneNumber(this string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(phoneNumber) && _matchIranianPhoneNumber.IsMatch(phoneNumber);
        }
        public static bool IsValidIranianPostalCode(this string postalCode)
        {
            return !string.IsNullOrWhiteSpace(postalCode) && _matchIranianPostalCode.IsMatch(postalCode);
        }
    }
}
