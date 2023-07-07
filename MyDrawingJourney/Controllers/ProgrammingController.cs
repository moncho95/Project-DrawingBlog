using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace MyDrawingJourney.Controllers
{
    public class ProgrammingController : Controller
    {
        public IActionResult Programming()
        {
            return View();
        }

        public IActionResult Greetings(string fName, string lName)
        {
            var message = $"Hello, {fName} {lName}!";
            return Content(message);
        }

        public IActionResult Coffee(string fName)
        {
            int n = 10;
            string some = fName;
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sb.Append(" ");
                }
                for (int j = 0; j < 3; j++)
                {
                    sb.Append("~ ");
                }

                sb.AppendLine();
            }


            for (int i = 0; i < n * 2 + 8; i++)
            {
                sb.Append("=");
            }
            sb.AppendLine();
            for (int i = 1; i <= n - 2; i++)
            {
                if (i == Math.Floor((double)n / 2))
                {
                    sb.Append("|");
                    for (int j = 0; j < (6 + 2 * n - some.Length) / 2 - n - 2; j++)
                    {
                        sb.Append("~");
                    }
                    for (int j = 0; j < n - 1; j++)
                    {
                        sb.Append(" ");
                    }
                    sb.Append(some);
                    for (int j = 0; j < (6 + 2 * n - some.Length) / 2 - n - 2; j++)
                    {
                        sb.Append("~");
                    }
                    sb.Append("|");
                    for (int j = 0; j < n - 1; j++)
                    {
                        sb.Append(" ");
                    }
                    sb.Append("|");
                    sb.AppendLine();
                    continue;
                }
                sb.Append("|");
                for (int j = 0; j < 6 + 2 * n; j++)
                {
                    sb.Append("~");
                }
                sb.Append("|");
                sb.AppendLine();

            }

            for (int i = 0; i < n * 2 + 8; i++)
            {
                sb.Append("=");
            }
            sb.AppendLine();

            for (int i = n; i > 0; i--)
            {

                for (int j = i; j < n; j++)
                {
                    sb.Append(" ");
                }
                sb.Append("\\");
                for (int j = 0; j < 6 + 2 * i; j++)
                {
                    sb.Append("@");
                }
                sb.Append("/");
                sb.AppendLine();
            }

            for (int i = 0; i < n * 2 + 8; i++)
            {
                sb.Append("-");
            }

            return Content(sb.ToString());
        }

        public IActionResult Cipher(string mesg)
        {
            char[] alphabet = new char[]
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g',
                'h', 'i', 'j', 'k', 'l', 'm', 'n',
                'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z'
            };

            string message = mesg;

            char[] secretMessage = message.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int letterPosition = Array.IndexOf(alphabet, letter);
                int newLetterPosition = letterPosition + 3;
                char letterEncoded = alphabet[newLetterPosition];
                encryptedMessage[i] = letterEncoded;

            }
            string encodedString = String.Join("", encryptedMessage);

            return Content(encodedString);
        }
    }
}
