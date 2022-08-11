using System.Speech.Synthesis;

namespace JASVIS.Interfaces
{
    public interface ISpeak
    {
        void SpeakText(string text);
        void SetSpeakRate(int rate);
        void SetSpeakVolume(int volume);
        void SetNewLanguage(string lang);
        void SetVoiceGender(VoiceGender voiceGender);
        List<Models.VoiceInfo> GetAvailableVoices();
    }
}