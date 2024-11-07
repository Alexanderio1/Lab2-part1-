using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Password
    {
        public string value;
        public Password(string value="default")
        {
            this.value = value;
        }
        public string Value
        {
            set { this.value = value; }
            get { return value; }
            
        }

        public static Password operator -(Password pass, char item)
        {

            pass.value = pass.value.Substring(0, pass.value.Length - 1)+item;
            return pass;
        }

        public static bool operator >(Password pass1, Password pass2)
        {
            return pass1.value.Length > pass2.value.Length;
        }

        public static bool operator <(Password pass1, Password pass2)
        {
            return pass1.value.Length < pass2.value.Length;
        }

        public static bool operator !=(Password pass1, Password pass2)
        {
            return !pass1.value.SequenceEqual(pass2.value);
        }

        public static bool operator ==(Password pass1, Password pass2)
        {
            return pass1.value.SequenceEqual(pass2.value);
        }

        public static Password operator ++(Password pass)
        {
            Password passDef = new Password();
            pass.value=passDef.value;
            return pass;
        }

        public static bool operator true(Password pass)
        {
            return (pass.value.Length>6 && pass.value.Any(char.IsDigit) && pass.value.Any(char.IsLetter));
        }

        public static bool operator false(Password pass)
        {
            return !(pass.value.Length > 6 && pass.value.Any(char.IsDigit) && pass.value.Any(char.IsLetter));
        }

    }

   
}
