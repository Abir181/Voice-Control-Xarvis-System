using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xarvis.Forms;
using Xarvis.Others;

namespace Xarvis
{
    public partial class Voice_System : Form
    {
        VoiceRecognition vc;
        static string com1="app list";
        static string com2 = "searh google";
        static string com3 = "search youtube";
        static string com4 = "";
        static string command = "";
        
        public string MyProperty { get; set; }
        static SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        static ManualResetEvent manualResetEvent = null;
        private int voice;
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public Voice_System()
        {
            InitializeComponent();
            vc = new VoiceRecognition();
            this.richVoiceText.Hide();
            speechSynthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult); // to change VoiceGender and VoiceAge check out those links below
            speechSynthesizer.Volume = 100;  // (0 - 100)
            speechSynthesizer.Rate = -1;
        }

        private void btnEnableVoice_Click(object sender, EventArgs e)
        {
            if (voice == 0)
            {
                
                this.btnEnableVoice.Text = "Enabled";
                this.btnEnableVoice.BackColor = Color.Green;
                this.richVoiceText.Show();
                this.sayIntruction();
                voice++;
            }
            else
            {
                this.btnEnableVoice.Hide();
                this.richVoiceText.Hide();
                speechSynthesizer.Speak("Voice Command DeActivated");
                this.btnEnableVoice.Text = "Disabled";
                this.btnEnableVoice.BackColor = Color.Red;
                
                voice = 0;
               _recognizer.Dispose();
                this.btnEnableVoice.Show();
            }
            
        }
        public void sayIntruction()
        {
            this.btnEnableVoice.Hide();
            speechSynthesizer.Speak("Voice Command Activated");
            this.richVoiceText.Text = "1.Search";
            this.btnEnableVoice.Show();
            this.searchEngine(1);
        }
     
        public void yes_no(string com)
        {
            command = com;
            
        }

        public void searchEngine(int i)
        {
            
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("google search"))); 
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("play music")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("app list")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("folder")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("wifi")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("performance")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("task manager")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("about")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("volume")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("bluetooth")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("panel")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("uninstall")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("setting")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("recycle")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("yes")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("browse")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("who are you")));
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("zarvis")));
            if (i == 1)
            {
                _recognizer.SetInputToDefaultAudioDevice(); // set the input to the default audio device

                _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
            //Thread.Sleep(TimeSpan.FromSeconds(2));
            
            _recognizer.SpeechRecognized+= _recognizeSpeechAndMakeSureTheComputerSpeaksToYou_SpeechRecognized; // if speech is recognized, call the specified method
            _recognizer.SpeechRecognitionRejected += _recognizeSpeechAndMakeSureTheComputerSpeaksToYou_SpeechRecognitionRejected;
            
            // recognize speech asynchronous
        }

        void _recognizeSpeechAndMakeSureTheComputerSpeaksToYou_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
           
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult); // to change VoiceGender and VoiceAge check out those links below
            speechSynthesizer.Volume = 100;  // (0 - 100)
            speechSynthesizer.Rate = 0;
            this.switch_flow(e.Result.Text);
            
            _recognizer.RecognizeAsyncStop();
            Thread.Sleep(2000);
            _recognizer.RecognizeAsync();

        }
        public void _recognizeSpeechAndMakeSureTheComputerSpeaksToYou_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            
            if (e.Result.Alternates.Count == 0)
            {
                this.richVoiceText.Text = "No";
            }
            else
            {
                this.richVoiceText.Text = "Speech rejected. Did you mean:" + e.Result.Text;
                this.switch_flow(e.Result.Text);
                _recognizer.RecognizeAsyncStop();
                Thread.Sleep(2000);
                _recognizer.RecognizeAsync();
                //this.searchEngine(0);
                //this.yes_no(e.Result.Text);
            }
            
        }
        private void switch_flow(string text)
        {
            //speechSynthesizer.Speak(text);
            switch (text)
            {
                case "google search":
                    Process.Start("http://www.google.com");
                    break;
                case "play music":
                    Process.Start("https://www.youtube.com/watch?v=zns53qYaQIo&list=RDzns53qYaQIo&start_radio=1");
                    break;
                case "app list":
                    Applist a = new Applist();
                    a.Show();
                    break;
                case "folder":
                    Process.Start("explorer.exe");
                    break;
                case "performance":
                    Process.Start("perfmon");
                    break;
                case "wifi":
                    Process.Start("ms-settings:network-wifi");
                    break;
                case "task manager":
                    Process.Start("taskmgr.exe");
                    break;
                case "browse":
                    Process.Start("http://www.google.com");
                    break;
                case "setting":
                    Process.Start("ms-settings:wifi");
                    break;
                case "bluetooth":
                    Process.Start("ms-settings:bluetooth");
                    break;
                case "volume":
                    Process.Start("control", "mmsys.cpl");
                    break;
                case "about":
                    Process.Start("ms-settings:about");
                    break;
                case "uninstall":
                    Process.Start("control", "appwiz.cpl");
                    break;
                case "recycle":
                    Process.Start("explorer.exe", "shell:RecycleBinFolder");
                    break;
                case "panel":
                    Process.Start("control");
                    break;
                case "who are you":
                    speechSynthesizer.Speak("My name is jarvis");
                    speechSynthesizer.Speak("Hello Developer");
                    break;
                case "zarvis":
                    speechSynthesizer.Speak("hmmmmmmmm I'm listening");
                    break;
                case "yes":
                    speechSynthesizer.Speak("yes");
                    break;
                default:
                    speechSynthesizer.Speak("command not found");
                    break;
            }
        }
        private void Voice_System_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richVoiceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" Folder ");

        }

        private void label1_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" Panel ");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" About ");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" Bluetooth ");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" Play Music ");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" Uninstall ");

        }

        private void label13_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" Recycle ");

        }

        private void label6_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" Setting ");

        }

        private void label8_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" Wifi ");

        }

        private void label9_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" Volume ");

        }

        private void label10_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" Task Manager ");

        }

        private void label11_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" performance  ");

        }

        private void label4_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" Browse ");
        }

        private void label14_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Speak(" Hey My name is zarvis ");
            speechSynthesizer.Speak(" In this module you can see some word in both side ");
            speechSynthesizer.Speak(" Every word is a command for execution the specific program");

            speechSynthesizer.Speak(" Click for the pronunciation");
            speechSynthesizer.Speak(" And Enable the voice command mode please click on the button one time");
        }
    }
}
