using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todolist
{
   public static class Validation
    {

      
        public static bool IsNotEmpty(TextBox[] values)
        {
            try
            {
                foreach (var value in values)
                {
                    if (value.Text.Equals(""))
                    {
                        //if empty display an error msg
                        MessageBox.Show("Field must not be empty", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return false;
                    }
                    else
                    {

                        //else do not display -- continue..

                    }
                }

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return true;

        }


        // Validation for Email
        public static bool IsValidEmail(TextBox value)
        {
            string emailPattern = "^[^@\\s]+@[^@\\s]+(\\.[^@\\s]+)+$";
            if (!Regex.IsMatch( value.Text , emailPattern))
            {
                MessageBox.Show("Email must be a valid email address", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

            
           
        }


        // Validation for AlphaNumeric Value
        public static bool IsValidInput(TextBox value)
        {
            string alphanum = "^[A-Za-z0-9_-]*$";
            if (!Regex.IsMatch(value.Text, alphanum))
            {
                MessageBox.Show("Letters and numbers only", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
