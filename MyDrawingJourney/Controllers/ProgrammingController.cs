using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using MyDrawingJourney.Hubs;
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

        public IActionResult Stack(string str)
        {
            Stack<char> s = new Stack<char>();
            //we push all char in stack.
            foreach (char ch in str)
            {
                s.Push(ch);
            }
            //here we clear all char present in str.
            str = "";
            //as stack is LIFO DS we push_back all char and our string is reverse now.
            while (s.Count != 0)
            {
                str += s.Peek();
                s.Pop();
            }

            ViewBag.Message = "The revered message is: " + str;
            
            return View("Programming");
        }

        public IActionResult Arrays()
        {
            int[][] jagged_arr =
                {
                    new int[] {1, 2, 3, 4},
                    new int[] {11, 34, 67},
                    new int[] {89, 23},
                    new int[] {0, 45, 78, 53, 99}
                };
            var str = new StringBuilder();
            for (int j = 0;  j< jagged_arr.Length; j++) {
                for (int i = 0; i < jagged_arr[j].Length; i++)
                {
                    str.Append(jagged_arr[j][i].ToString() + " ");
                }
                str.AppendLine();
            }
            return Content(str.ToString());
        }

        public IActionResult Dictionary(string str)
        {
            string text =

        "Mary had a little lamb " +

        "little Lamb, little Lamb, " +

        "Mary had a Little lamb, " +

        "whose fleece were white as snow.";
            string[] tokens =

           text.Split(' ', '.', ',', '-', '?', '!');



            IDictionary<string, int> words =

                new SortedDictionary<string, int>();



            foreach (string word in tokens)

            {

                if (!string.IsNullOrEmpty(word.Trim()))

                {

                    int count;

                    if (!words.TryGetValue(word, out count))

                    {

                        count = 0;

                    }

                    words[word] = count + 1;

                }

            }
            return Content(words[str].ToString());

        }

        public IActionResult PopularNames(string str)
        {
            LinkedList<String> my_list = new LinkedList<String>();

            my_list.AddLast("Aleksanar");
            my_list.AddLast("Georgi");
            my_list.AddLast("Martin");
            my_list.AddLast("Dimitar");
            my_list.AddLast("Viktor");
            my_list.AddLast("Ivan");
            my_list.AddLast("Boris");
            my_list.AddLast("Nikola");
            my_list.AddLast("Stoyan");
            var result = new StringBuilder();
            if (my_list.Contains(str) == true)
            {
                result.AppendLine("You guessed! Name Found...!!");
            }
            else
            {
                result.AppendLine("Try again! Name Not found...");
            }

            return Content(result.ToString());
        }

        public IActionResult FunctProgramming(string numone, string op, string numtwo)
        {
            double result = 0;
            Func<int[], double> add = (numbers) =>
            {
                result = numbers[0] + numbers[1];
                return result;
            };
            Func<int[], double> multiply = (numbers) =>
            {
                result = numbers[0] * numbers[1];
                return result;
            };
            Func<int[], double> subtract = (numbers) =>
            {
                result = numbers[0] - numbers[1];
                return result;
            };
            Func<int[], double> divide = (numbers) =>
            {
                result = numbers[0] / numbers[1];
                return result;
            };

            int[] numbers = new int[]
            {
                int.Parse(numone),
                int.Parse(numtwo)
            };
            string command = op;
            
                if (command == "+")
                {
                    add(numbers);
                }
                if (command == "*")
                {
                    multiply(numbers);
                }
                if (command == "-")
                {
                    subtract(numbers);
                }
                if (command == "/")
                {
                    divide(numbers);
                }

            return Content(result.ToString());

            }

        public IActionResult ActionResult(int op)
        {
            switch (op)
            {
                case 0:
                    return StatusCode(404);
                case 1:
                    return Ok();
                case 2:
                    return BadRequest();
                case 3:
                    return NotFound();
                case 4:
                    return RedirectToAction("Home", "Blog");
                case 5:
                    return Content("This is Content Action Result!");
                default:
                    return View();
            }
           
        }
    }
}
