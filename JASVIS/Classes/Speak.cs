using System.Globalization;
using System.Runtime.Versioning;
using System.Speech.Synthesis;
using JASVIS.Interfaces;

namespace JASVIS.Classes
{
    [SupportedOSPlatform("windows")]
    public class Speak : ISpeak
    {
        private readonly SpeechSynthesizer _synthesizer;

        public Speak(SpeechSynthesizer synthesizer)
        {
            _synthesizer = synthesizer;
            _synthesizer.Volume = 100;
            _synthesizer.Rate = 0;
        }

        public void SetNewLanguage(string lang)
        {
            var culture = CultureInfo.GetCultureInfo(lang);
            var voices = _synthesizer.GetInstalledVoices(culture);

            if (voices.Count > 0)
            {
                _synthesizer.SelectVoice(voices?.FirstOrDefault()?.VoiceInfo.Name);
            }
            else
            {
                _synthesizer.SpeakAsync($"So sorry the language: {culture.Name}, doesn't exitst on the machine!");
            }
        }

        public void SetSpeakRate(int rate)
        {
            _synthesizer.Rate = rate;
        }

        public void SetSpeakVolume(int volume)
        {
            _synthesizer.Volume = volume;
        }

        public void SetVoiceGender(VoiceGender voiceGender)
        {
            _synthesizer.SelectVoiceByHints(voiceGender);
        }

        public List<Models.VoiceInfo> GetAvailableVoices()
        {
            var voices = new List<Models.VoiceInfo>();
            var installedVoices = _synthesizer.GetInstalledVoices();

            foreach (var item in installedVoices)
            {
                voices.Add(new Models.VoiceInfo()
                {
                    Id = item.VoiceInfo.Id,
                    Name = item.VoiceInfo.Name,
                    Description = item.VoiceInfo.Description,
                    CultureInfo = item.VoiceInfo.Culture,
                    VoiceAge = item.VoiceInfo.Age,
                    VoiceGender = item.VoiceInfo.Gender
                });
            }

            return voices;
        }

        public void SpeakText(string text)
        {
            _synthesizer.Speak(text);
        }
    }
}