using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceM2
{
    public class OnlineTest:IExam
    {
        public string studentName {  get; set; }
        public int totalQuestions { get; set; }
        public int correctAnswers {  get; set; }
        public int wrongAnswers {  get; set; }
        public string questionType {  get; set; }

        public OnlineTest(string studentName, int totalQuestions, int correctAnswers, int wrongAnswers, string questionType)
        {
            this.studentName = studentName;
            this.totalQuestions = totalQuestions;
            this.correctAnswers = correctAnswers;
            this.wrongAnswers = wrongAnswers;
            this.questionType = questionType;
        }

        public double calculateScore()
        {
            double totalScore = 0;
            double marksPerQuestion = 0;
            if(questionType == "MCQ")
            {
                marksPerQuestion = 2;
            }
            else if(questionType == "Coding")
            {
                marksPerQuestion = 5;
            }
            totalScore = ((correctAnswers * marksPerQuestion) - (wrongAnswers * (marksPerQuestion * 0.10)));

            return (totalScore/(totalQuestions*marksPerQuestion))*100;
        }

        public  string evaluateResult(double percentage)
        {
            if (percentage >= 85) return "Merit";
            else if (percentage >= 60 && percentage < 85) return "Pass";
            else return "Fail";
        }
    }
}
