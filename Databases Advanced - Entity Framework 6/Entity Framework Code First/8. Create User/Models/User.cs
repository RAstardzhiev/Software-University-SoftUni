namespace _8.Create_User.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class User
    {
        private const string NegativeIdExceptionMessage = "Id cannot be less than 1!";
        private const string UsernameExceptionMessage = "Username must be with length between 4 and 30 symbols!";
        private const string PasswordMissesLowerCaseExceptionMessage = "Password must contain at least 1 Lowercase letter!";
        private const string PasswordMissesUpperCaseExceptionMessage = "Password must contain at least 1 Uppercase letter!";
        private const string PasswordMissesDigitExceptionMessage = "Password must contain at least 1 Digit!";
        private const string PasswordMissesSpecialSymbolExceptionMessage = "Password must contain at least 1 of the following symbols: (!, @, #, $, %, ^, &, *, (, ), _, +, <, >, ?)";
        private const string ProfilePictureTooLargeExceptionMessage = "Profile picture allowed size is maximum 1MB";
        private const string AgeWrongValueExceptionMessage = "Wrong Age! Age must be in range[1, 120]";
        private readonly string EmailForbiddenSymbolsExceptionMessage = $@"Forbidden symbols in the email! Please enter email format<user>@<host> where: {Environment.NewLine}
            \t o <user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them (they cannot appear at the beginning or at the end of the sequence). {Environment.NewLine}
            \t o<host> is a sequence of at least two words, separated by dots '.' (dots cannot appear at the beginning or at the end of the sequence).";

        private const int ProfilePictureMaxSizeInBytes = 1 * 1024 * 1024;
        private const string EmailValidationRegexPattern = @"^[A-Za-z0-9]+[\w-.]*[A-Za-z0-9]+@[A-Za-z0-9-\.]+\.([A-Za-z0-9-\.])+$";
        private readonly char[] PasswordSpecialStymbols =  { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '<', '>', '?' };

        private int id;
        private string password;
        private string email;
        private string profilePicturePath;
        private byte age;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User(string username, string password, string email)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.RegisteredOn = DateTime.Now;
        }

        public int Id { get; private set; }

        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(50)]
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.ValidatePasswordRequirements(value);
                this.password = value;
            }
        }

        [Required]
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (!Regex.IsMatch(value, EmailValidationRegexPattern))
                {
                    if (value.IndexOf('@') == 1 && (char.IsDigit(value[0]) || char.IsLetter(value[0])))
                    {
                        return;
                    }

                    throw new ArgumentException(EmailForbiddenSymbolsExceptionMessage);
                }

                this.email = value;
            }
        }

        public string ProfilePicturePath
        {
            get
            {
                return this.profilePicturePath;
            }

            set
            {
                if (new FileInfo(value).Length > ProfilePictureMaxSizeInBytes)
                {
                    throw new InvalidOperationException(ProfilePictureTooLargeExceptionMessage);
                }

                this.profilePicturePath = value;
            }
        }

        public DateTime RegisteredOn { get; private set; }

        public DateTime LastTimeLoggedIn { get; set; }

        public byte Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value <= 0 || value > 120)
                {
                    throw new ArgumentException(AgeWrongValueExceptionMessage);
                }

                this.age = value;
            }
        }

        public bool IsDeleted { get; set; }

        private void ValidatePasswordRequirements(string password)
        {
            var missesLowerCase = true;
            var missesUpperCase = true;
            var missesDigit = true;
            var missesSpecialSymbol = true;

            foreach (var ch in password.ToCharArray())
            {
                if (char.IsLower(ch))
                {
                    missesLowerCase = false;
                }
                else if (char.IsUpper(ch))
                {
                    missesUpperCase = false;
                }
                else if (char.IsDigit(ch))
                {
                    missesDigit = false;
                }
                else if (PasswordSpecialStymbols.Contains(ch))
                {
                    missesSpecialSymbol = false;
                }
            }

            if (missesLowerCase)
            {
                throw new ArgumentException(PasswordMissesLowerCaseExceptionMessage);
            }
            else if (missesUpperCase)
            {
                throw new ArgumentException(PasswordMissesUpperCaseExceptionMessage);
            }
            else if (missesDigit)
            {
                throw new ArgumentException(PasswordMissesDigitExceptionMessage);
            }
            else if (missesSpecialSymbol)
            {
                throw new ArgumentException(PasswordMissesSpecialSymbolExceptionMessage);
            }
        }
    }
}
