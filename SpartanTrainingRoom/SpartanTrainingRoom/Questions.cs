using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanTrainingRoom
{
    public class Questions
    {
        public int Qnumber { get; set; }
        public string Question { get; set; }
        public string[] Choices { get; set; }
        public string Answer { get; set; }
        public int Score { get; set; }
        public QuestionType QuestionType { get; set; }
    }
    public enum QuestionType
    {
        multipleChoice,
        fillInGap,
        code
    }

    //public List<Questions> CreateQuestions()
    //{
    //    List<Questions> questions = new List<Questions>();
    //    #region Question 1
    //    Questions q1 = new Questions()
    //    {
    //        Qnumber = 1,
    //        Question = "What would be used to finish this line in C#: \nvar a = \"Alpha\"?",
    //        Choices = new string[] { "a) ;", "b) ,", "c) :", "d) ." },
    //        Answer = "Object",
    //        Score = 10,
    //        QuestionType = QuestionType.fillInGap
    //    };
    //    #endregion

    //    #region Question 2
    //    Questions q2 = new Questions()
    //    {
    //        Qnumber = 2,
    //        Question = "What type of variable is: 'p' ?",
    //        Choices = new string[] { "a) string", "b) int", "c) bool", "d) char" },
    //        Answer = "d) char",
    //        Score = 10,
    //        QuestionType = QuestionType.multipleChoice
    //    };
    //    #endregion

    //    #region Question 3
    //    Questions q3 = new Questions()
    //    {
    //        Qnumber = 3,
    //        Question = "string a = \"John\" \n string b = \"Smith\" \nstring c = a + b \nWhat is the output of c",
    //        Choices = new string[] { "a) JohnSmith", "b) John_Smith", "c) Smith_John", "d) John" },
    //        Answer = "a) JohnSmith",
    //        Score = 10,
    //        QuestionType = QuestionType.fillInGap
    //    };
    //    #endregion

    //    #region Question 4
    //    Questions q4 = new Questions()
    //    {
    //        Qnumber = 4,
    //        Question = "What Will Be The Result of the next arithmetic statement: \nint i = 5; i++",
    //        Choices = new string[] { "a) 5", "b) 6", "c) 10", "d) 25" },
    //        Answer = "b) 6",
    //        Score = 10,
    //        QuestionType = QuestionType.multipleChoice
    //    };
    //    #endregion

    //    #region Question 5
    //    Questions q5 = new Questions()
    //    {
    //        Qnumber = 5,
    //        Question = "The result printed in console for the next program is ? <br />int sum1 = 100 + 50;" +
    //        "\nint sum2 = sum1 + 250; \nConsole.WriteLine(sum2)",
    //        Choices = new string[] { "a) 250", "b) 150", "c) 400", "d) 500" },
    //        Answer = "c) 400",
    //        Score = 10,
    //        QuestionType = QuestionType.multipleChoice
    //    };
    //    #endregion

    //    #region Question 6
    //    Questions q6 = new Questions()
    //    {
    //        Qnumber = 6,
    //        Question = "The output of string z \nstring x = \"10\"" +
    //        "\nstring y = \"20\"; \nConsole.WriteLine(sum2)",
    //        Choices = new string[] { "a) 30", "b) 1020", "c) 1200", "d) 10+20" },
    //        Answer = "c) 400",
    //        Score = 10,
    //        QuestionType = QuestionType.multipleChoice
    //    };
    //    #endregion

    //    #region Question 7
    //    Questions q7 = new Questions()
    //    {
    //        Qnumber = 7,
    //        Question = "What will \\n do on the next statement: Today:\\n 20th November",
    //        Choices = new string[] { "a) Backslash", "b) New Line", "c) Backspace", "d) Tab" },
    //        Answer = "c) New line",
    //        Score = 10,
    //        QuestionType = QuestionType.multipleChoice
    //    };
    //    #endregion

    //    #region Question 8
    //    Questions q8 = new Questions()
    //    {
    //        Qnumber = 8,
    //        Question = "What does OOP stand for?",
    //        Choices = new string[] { "a) Object Operating Programming",
    //                "b) Object Oriented Process", "c) Object Oriented Programming", "d) Operating Object Process" },
    //        Answer = "c) Object Oriented Programming",
    //        Score = 10,
    //        QuestionType = QuestionType.multipleChoice
    //    };
    //    #endregion

    //    #region Question 9
    //    Questions q9 = new Questions()
    //    {
    //        Qnumber = 9,
    //        Question = "Complete the statement: A class is a " + "......... of method and variables.\n",
    //        Choices = new string[] { "a) Backslash", "b) New Line", "c) Backspace", "d) Tab" },
    //        Answer = " collection ",
    //        Score = 10,
    //        QuestionType = QuestionType.fillInGap
    //    };
    //    #endregion

    //    #region Question 10
    //    Questions q10 = new Questions()
    //    {
    //        Qnumber = 10,
    //        Question = "and it is a .......... that defines the data and behavior of a type.\n",
    //        Choices = new string[] { "a) Backslash", "b) New Line", "c) Backspace", "d) Tab" },
    //        Answer = "c) New line",
    //        Score = 10,
    //        QuestionType = QuestionType.fillInGap
    //    };
    //    #endregion
    //    questions.Add(q1);
    //    questions.Add(q2);
    //    questions.Add(q3);
    //    questions.Add(q4);
    //    questions.Add(q5);
    //    questions.Add(q6);
    //    questions.Add(q7);
    //    questions.Add(q8);
    //    questions.Add(q9);
    //    questions.Add(q10);
    //    return questions;
    //}
}
