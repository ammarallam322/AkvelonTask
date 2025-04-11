
using System.Text;
using TaskFizzBuzz;
using Xunit;




namespace TaskFizzBuzzTests
{
    public class TaskFizzTests
    {

        //ref from Task class
        TaskFizz task;
        public TaskFizzTests()
        {
            this.task = new TaskFizz();
        }
        //case 1 lenth < 7
        [Fact]
        public void CheckFizzBuzz_Lessthan7_NotValid()
        {
            //arrange
            task.Input= "abc";

            //act
            string result = task.CheckFizzBuzz();

            //assert
            Assert.Equal($"{task.Input} is not valid ,input Length must be greater tha or equal 7 and less than or equal 100 ", result.ToString());

        }


        //case 2 lenth > 100
        [Fact]
        public void CheckFizzBuzz_Greaterthan100_NotValid()
        {
            //arrange
            task.Input = "abc 1 2 3 4 5 6 7 8 9 f " +
                "abc 1 2 3 4 5 6 7 8 9 f" +
                "abc 1 2 3 4 5 6 7 8 9 f" +
                "abc 1 2 3 4 5 6 7 8 9 f" +
                "abc 1 2 3 4 5 6 7 8 9 f" +
                "abc 1 2 3 4 5 6 7 8 9 f" +
                "abc 1 2 3 4 5 6 7 8 9 f" +
                "abc 1 2 3 4 5 6 7 8 9 f" +
                "abc 1 2 3 4 5 6 7 8 9 f" +
                "abc 1 2 3 4 5 6 7 8 9 f" +
                "abc 1 2 3 4 5 6 7 8 9 f" +
                "abc 1 2 3 4 5 6 7 8 9 f" +
                "abc 1 2 3 4 5 6 7 8 9 f" +
                "abc 1 2 3 4 5 6 7 8 9 f";

            //act
            string result = task.CheckFizzBuzz();

            //assert
            Assert.Equal($"{task.Input} is not valid ,input Length must be greater tha or equal 7 and less than or equal 100 ", result.ToString());

        }


        
        //case 3 length = 0
        [Fact]
        public void CheckFizzBuzz_LengthEqualZero_NotValid()
        {
            //arrange
            task.Input = "";

            //act
            string result = task.CheckFizzBuzz();

            //assert
            Assert.Equal("not valid input ! inpit cant be empty ", result.ToString());

        }

        

        //case 4 input string has 10 words
        [Fact]
        public void CheckFizzBuzz_InputWordsEqual10_CountEqual5()
        {
            //arrange
            task.Input = "abc1 abc2 abc3 abc4 abc5 abc6 abc7 abc8 abc9 anc10";

            //act
            string result = task.CheckFizzBuzz();

            //assert
            Assert.Equal($"abc1 abc2 FIZZ abc4 BUZZ FIZZ abc7 abc8 FIZZ BUZZ"+"\n5", result.ToString());

        }
        
        //case 5 input string has 17 words
        [Fact]
        public void CheckFizzBuzz_InputWordsEqual17_CountEqual7()
        {
            //arrange
            task.Input = "abc1 abc2 abc3 abc4 abc5 abc6 abc7 abc8 abc9 anc10 abc11 abc12 abc13 abc14 abc15 abc16 abc17";

            //act
            string result = task.CheckFizzBuzz();

            //assert
            Assert.Equal("abc1 abc2 FIZZ abc4 BUZZ FIZZ abc7 abc8 FIZZ BUZZ abc11 FIZZ abc13 abc14 FIZZBuzz abc16 abc17" + "\n7", result.ToString());

        }


        //case6 ignore symbols and whitespaces

        [Fact]
        public  void CheckFizzBuzz_InputWordsContainswhitespaceAndSymbols_()
        {
            //arrange
            task.Input = "abc1 abc2 @@@ abc3     # abc4 abc5 &^$";
            //ac
            string result = task.CheckFizzBuzz();
            //assert
            Assert.Equal("abc1 abc2 FIZZ abc4 BUZZ"+"\n2",result.ToString());


        }

    }
}
