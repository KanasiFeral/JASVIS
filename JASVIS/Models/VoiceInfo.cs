using System.Globalization;
using System.Speech.Synthesis;

namespace JASVIS.Models
{
    public class VoiceInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CultureInfo CultureInfo { get; set; }
        public VoiceGender VoiceGender { get; set; }
        public VoiceAge VoiceAge { get; set; }
    }
}