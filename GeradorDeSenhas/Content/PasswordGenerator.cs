using System.Text;

namespace GeradorDeSenhas.Content
{
    public class PasswordGenerator
    {        
        private readonly string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string numbers = "0123456789";
        private readonly string specialCharacters = "!@#$*()=?/|";
       
        private readonly Random random = new();
        private readonly StringBuilder Password = new();

        public StringBuilder GetPassword { get; set; }

        public PasswordGenerator()
        {
            GetPassword = Password;
        }

        //public StringBuilder GenerateWithNormalCharacters(decimal passwordSize)
        //{
        //    Password.Clear();
            
        //    while (passwordSize > Password.Length)
        //        Password.Append(characters[random.Next(characters.Length)]);

        //    CheckPasswordSize(passwordSize);

        //    return Password;
        //}

        public StringBuilder GenerateWithNumbersCharacters(decimal passwordSize)
        {
            Password.Clear();

            while (passwordSize > Password.Length)
            {
                Password.Append(characters[random.Next(characters.Length)]);
                Password.Append(numbers[random.Next(numbers.Length)]);
            }

            CheckPasswordSize(passwordSize);

            return Password;
        }

        //public StringBuilder GenerateWithSpecialCharacters(decimal passwordSize)
        //{
        //    Password.Clear();

        //    while (passwordSize > Password.Length)
        //    {
        //        Password.Append(characters[random.Next(characters.Length)]);
        //        Password.Append(specialCharacters[random.Next(specialCharacters.Length)]);
        //    }

        //    CheckPasswordSize(passwordSize);

        //    return Password;
        //}

        public StringBuilder GenerateWithSpecialAndNumberCharacters(decimal passwordSize)
        {
            Password.Clear();

            while (passwordSize > Password.Length)
            {
                Password.Append(characters[random.Next(characters.Length)]);
                Password.Append(numbers[random.Next(numbers.Length)]);
                Password.Append(specialCharacters[random.Next(specialCharacters.Length)]);
            }
            CheckPasswordSize(passwordSize);

            return Password;
        }

        private void CheckPasswordSize(decimal passwordSize)
        {
            while (Password.Length > passwordSize)
                Password.Length--;          
        }
    }
}

