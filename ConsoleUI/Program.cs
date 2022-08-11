using System.Speech.Synthesis;
using JASVIS.Classes;

Console.WriteLine("Weclome to the Just A Smart Voice Intelligence System!\n");

Speak synthesizer = new Speak(new SpeechSynthesizer());
synthesizer.SetSpeakRate(-2);

foreach (var voice in synthesizer.GetAvailableVoices())
{
    Console.WriteLine("Voice avaivable: ");
    Console.WriteLine($"Voice ID: {voice.Id}");
    Console.WriteLine($"Voice Name: {voice.Name}");
    Console.WriteLine($"Voice Description: {voice.Description}");
    Console.WriteLine($"Voice CultureInfo: {voice.CultureInfo}");
    Console.WriteLine($"Voice VoiceAge: {voice.VoiceAge}");
    Console.WriteLine($"Voice VoiceGender: {voice.VoiceGender}\n");
}

synthesizer.SetNewLanguage("en-US");
synthesizer.SpeakText("I love you Marishka!");

synthesizer.SetNewLanguage("en-GB");
synthesizer.SpeakText("I love you Marishka!");

Console.ReadLine();