using System.Collections.Generic;

namespace RecyclerPractice
{
    public class Question
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int NumberOfAnswers { get; set; }
    }

    public class SampleData
    {
        public static List<Question> GetQuestions()
        {
            var questions = new List<Question>();
            questions.Add(new Question() { ID = 102, Description = "1 pregunta" });
            questions.Add(new Question() { ID = 103, Description = "2 pregunta" });
            questions.Add(new Question() { ID = 104, Description = "3 pregunta" });
            questions.Add(new Question() { ID = 105, Description = "4 pregunta" });
            questions.Add(new Question() { ID = 106, Description = "5 pregunta" });
            questions.Add(new Question() { ID = 107, Description = "6 pregunta" });
            questions.Add(new Question() { ID = 108, Description = "7 pregunta" });
            questions.Add(new Question() { ID = 109, Description = "8 pregunta" });
            questions.Add(new Question() { ID = 110, Description = "9 pregunta" });
            questions.Add(new Question() { ID = 111, Description = "10 pregunta" });
            questions.Add(new Question() { ID = 112, Description = "11 pregunta" });
            questions.Add(new Question() { ID = 113, Description = "12 pregunta" });
            questions.Add(new Question() { ID = 114, Description = "13 pregunta" });
            questions.Add(new Question() { ID = 115, Description = "14 pregunta" });
            questions.Add(new Question() { ID = 115, Description = "15 pregunta" });
            questions.Add(new Question() { ID = 115, Description = "16 pregunta" });
            questions.Add(new Question() { ID = 115, Description = "17 pregunta" });
            questions.Add(new Question() { ID = 115, Description = "18 pregunta" });
            return questions;
        }
    }
}