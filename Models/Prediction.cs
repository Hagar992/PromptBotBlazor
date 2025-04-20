using Microsoft.ML.Data;

namespace PromptBotBlazor.Models
{
    public class Prediction
    {
        [ColumnName("PredictedLabel")]
        public string Label { get; set; }
    }
}