using System.Speech.Recognition;

namespace JASVIS.Interfaces
{
    public interface ISpeechRecognize
    {
        public void Recognize(string text);
    }
}