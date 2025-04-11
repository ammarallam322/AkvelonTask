using System.Text;
using System.Text.RegularExpressions;

namespace TaskFizzBuzz
{
    public class TaskFizz
    {
      
        public int Count { get; set; }
        public string Input { get; set; }

        public string CheckFizzBuzz() {


            if (this.Input == null)
            {
                return "not valid input ! inpit cant be null ";
                  
            }
            
            if (this.Input == "")
            {
                return "not valid input ! inpit cant be empty ";
            }
            if (this.Input.Length < 7 || this.Input.Length > 100)
            {
                return $"{this.Input} is not valid ,input Length must be greater tha or equal 7 and less than or equal 100 ";
                
            }

            var matches = Regex.Matches(this.Input, @"\b[a-zA-Z0-9]+\b");
           
            string[] inputArr = matches.Cast<Match>().Select(m=>m.Value).ToArray();
          
            for (int i = 0; i < inputArr.Length; i++)
            {

                if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
                {
                    inputArr[i] = "FIZZBuzz";
                   this.Count++;
                    continue;
                }
                if ((i + 1) % 3 == 0)
                {
                    inputArr[i] = "FIZZ";
                    this.Count++;
                    continue;
                }
                if ((i + 1) % 5 == 0)
                {
                    inputArr[i] = "BUZZ";
                    this.Count++;
                    continue;
                }

            }

            //printing


            StringBuilder outputBuilder = new StringBuilder();
            foreach (var s in inputArr)
            {
                outputBuilder.Append(s + " ");
            }
            return $"{outputBuilder.ToString().TrimEnd()}"+$"\n count: {this.Count}";

        }

    }
}
