using Microsoft.ML.Data;

namespace PromptBotBlazor.Models
{
    public class TextData
    {
        [LoadColumn(0)]
        public string Text { get; set; }

        [LoadColumn(1)]
        public string Label { get; set; }
    }
}