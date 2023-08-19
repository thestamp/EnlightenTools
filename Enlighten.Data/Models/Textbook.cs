﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Enlighten.Data.Models
{
    public class Textbook : IBaseGpt
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string TextbookSummary { get; set; }
        public virtual List<TextbookChapter> Chapters { get; set; }


        public string QuizSystemMessage { get; set; }
        public string QuizQuestionPrompt { get; set; }
        public string QuizAnswerPrompt { get; set; }
        public string InquireSystemMessage { get; set; }
        public string InquirePrompt { get; set; }
        public string ContentStart { get; set; }
        public string ContentEnd { get; set; }
    }
}
