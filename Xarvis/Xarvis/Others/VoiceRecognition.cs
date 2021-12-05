using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Xarvis.Others
{
    class VoiceRecognition
    {
        static SpeechRecognitionEngine _recognizer = null;
        static ManualResetEvent manualResetEvent = null;
        public void test()
        {
            _recognizer = new SpeechRecognitionEngine();
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("hello rafi"))); // load a "hello computer" grammar
                                                                                    // _recognizer.LoadGrammar(new DictationGrammar());
            _recognizer.SpeechRecognized += _recognizeSpeechAndMakeSureTheComputerSpeaksToYou_SpeechRecognized; // if speech is recognized, call the specified method
            _recognizer.SpeechRecognitionRejected += _recognizeSpeechAndMakeSureTheComputerSpeaksToYou_SpeechRecognitionRejected;
            _recognizer.SetInputToDefaultAudioDevice(); // set the input to the default audio device
            _recognizer.RecognizeAsync(RecognizeMode.Multiple); // recognize speech asynchronous

        }
        static void _recognizeSpeechAndMakeSureTheComputerSpeaksToYou_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "hello rafi")
            {
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                speechSynthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult); // to change VoiceGender and VoiceAge check out those links below
                speechSynthesizer.Volume = 100;  // (0 - 100)
                speechSynthesizer.Rate = 0;
                speechSynthesizer.Speak("hello rafi");
                speechSynthesizer.Dispose();
            }
            manualResetEvent.Set();
        }
        static void _recognizeSpeechAndMakeSureTheComputerSpeaksToYou_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            if (e.Result.Alternates.Count == 0)
            {
                Console.WriteLine("No candidate phrases found.");
                return;
            }
            //Console.WriteLine("Speech rejected. Did you mean:");
            Console.WriteLine("Speech rejected. Did you mean:" + e.Result.Text);
            foreach (RecognizedPhrase r in e.Result.Alternates)
            {
                Console.WriteLine("    " + r.Text);
            }
        }
    }
}



