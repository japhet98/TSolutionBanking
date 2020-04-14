using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TSolutionBanking.ValidationsInput
{
  public  class Validations
    {
        public Validations()
        {

        }

       

      private bool  IsAllAlphabetic(string input)
        {
            var status = false;
            foreach (char C in input)
            {
                if (!char.IsLetter(C))
                {
                   status = false;
                }
                else
                {
                    status = true;
                }
                
            }
            return status;

        }

        private bool IsAllDouble(string input)
        {
            var str = input as string;
            // var regex =  @"/^[0 - 9] + (\.[0-9]{1,3})?$/";
            var regex = @"^((([1-9]\d{0,2},(\d{3},)*\d{3}|[1-9]\d*)(.\d{1,4})?)|(0\.\d{1,4}))$";
            /* var status = false;
             var countDot = 0;
             foreach (char C in input)
             {
                 if (C == '.')
                 {
                     countDot++;
                 }
                 if (!char.IsDigit(C)|| countDot > 1)
                 {

                     status = false;
                 }


             }
            */
            return  Regex.IsMatch(str, regex); 
        }


        public bool TextOnlyValidation(string input)
    {

        var str = input.Trim() as string;
        return str != null && IsAllAlphabetic(str);

    }
       
        public bool ValidateDouble(string input)
        {
            var str = input as string;
            return str !=null && IsAllDouble(str);

        }
        public bool ValidatePassword(string input)
        {
            var str = input as string;
            return  str != null && str.Length > 8;
        }

        public bool ValidatePhoneNumber(string input)
        {
            var str = input as string;
            return str != null;
        }

       

    }
}
