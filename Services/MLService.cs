using Microsoft.ML;
using Microsoft.ML.Data;
using PromptBotBlazor.Models;

namespace PromptBotBlazor.Services
{
    public class MLService
    {
        private readonly MLContext _mlContext;
        private ITransformer _model;
        private PredictionEngine<TextData, Prediction> _predictionEngine;

        public MLService()
        {
            _mlContext = new MLContext();
        }

        public bool TrainModel()
        {
            try
            {
                // تحميل البيانات من data.csv
                var dataPath = Path.Combine(Directory.GetCurrentDirectory(), "data.csv");
                var data = _mlContext.Data.LoadFromTextFile<TextData>(dataPath, separatorChar: ',', hasHeader: true);

                // بناء Pipeline لتحويل النصوص إلى ردود
                var pipeline = _mlContext.Transforms.Text.FeaturizeText("Features", nameof(TextData.Text))
                    .Append(_mlContext.Transforms.CopyColumns("Label", nameof(TextData.Label)))
                    .Append(_mlContext.Transforms.Text.FeaturizeText("LabelFeatures", "Label"))
                    .Append(_mlContext.Transforms.Concatenate("Features", "Features", "LabelFeatures"))
                    .Append(_mlContext.Transforms.Conversion.MapValueToKey("Label"))
                    .Append(_mlContext.MulticlassClassification.Trainers.SdcaNonCalibrated())
                    .Append(_mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel", "Label"));

                // تدريب النموذج
                _model = pipeline.Fit(data);

                // إنشاء Prediction Engine
                _predictionEngine = _mlContext.Model.CreatePredictionEngine<TextData, Prediction>(_model);

                // حفظ النموذج
                _mlContext.Model.Save(_model, data.Schema, "model.zip");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error training model: {ex.Message}");
                return false;
            }
        }

        public string Predict(string text)
        {
            if (_model == null || _predictionEngine == null)
            {
                if (!File.Exists("model.zip"))
                    return "Model not trained. Please train the model first.";
                try
                {
                    var dataPath = Path.Combine(Directory.GetCurrentDirectory(), "data.csv");
                    var data = _mlContext.Data.LoadFromTextFile<TextData>(dataPath, separatorChar: ',', hasHeader: true);
                    _model = _mlContext.Model.Load("model.zip", out var schema);
                    _predictionEngine = _mlContext.Model.CreatePredictionEngine<TextData, Prediction>(_model);
                }
                catch (Exception ex)
                {
                    return $"Error loading model: {ex.Message}";
                }
            }

            var input = new TextData { Text = text };
            var prediction = _predictionEngine.Predict(input);
            return prediction.Label;
        }

        public bool IsModelReady()
        {
            if (_model == null || _predictionEngine == null)
            {
                if (!File.Exists("model.zip"))
                    return false;
                try
                {
                    var dataPath = Path.Combine(Directory.GetCurrentDirectory(), "data.csv");
                    var data = _mlContext.Data.LoadFromTextFile<TextData>(dataPath, separatorChar: ',', hasHeader: true);
                    _model = _mlContext.Model.Load("model.zip", out var schema);
                    _predictionEngine = _mlContext.Model.CreatePredictionEngine<TextData, Prediction>(_model);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error checking model readiness: {ex.Message}");
                    return false;
                }
            }
            return true;
        }
    }
}