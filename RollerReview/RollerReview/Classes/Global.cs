using RollerReview.Forms;
using RollerReview.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollerReview.MyClasses
{
    public class Global
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public static bool CheckPassword(string password, string hash)
        {
            return HashPassword(password) == hash;
        }

        public static void FormDirect(Form currentForm, Form gotoForm)
        {
            currentForm.Hide();
            gotoForm.ShowDialog();
            currentForm.Close();
        }

        public static void Logout(Form currentForm)
        {
            UserData = null;

            if(ReviewPage._chosencoaster !=  null)
            {
                ReviewPage._chosencoaster = null;
            }

            FormDirect(currentForm, new MainForm());
        }

        public static int Random(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static User UserData { get; set; }
    }
}
