using System;
using System.ComponentModel.DataAnnotations;

namespace Cult.Persian
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter)]
    public sealed class ShouldContainOnlyPersianNumbersAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (string.IsNullOrWhiteSpace(value as string))
            {
                return true; // returning false, makes this field required.
            }
            return value.ToString().ContainsOnlyPersianNumbers();
        }
    }
}