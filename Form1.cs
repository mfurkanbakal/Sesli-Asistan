using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;
namespace Sesli_Asistan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PromptBuilder okuyucu = new PromptBuilder();
        SpeechSynthesizer konuşma_sentez = new SpeechSynthesizer();
        SpeechRecognitionEngine konuşma_motoru = new SpeechRecognitionEngine();
        bool listening = false;

       
        private void Konuşma_motoru_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string alınan_ses = e.Result.Text;
            
            
            if(alınan_ses=="asistan")
            {
                okuyucu.ClearContent();
                okuyucu.AppendText("I am listening");
                konuşma_sentez.Speak(okuyucu);
                listening = true;

                label1.BackColor = Color.Red;
             
            }

            if (alınan_ses == "stop listening")
            {
                okuyucu.ClearContent();
                okuyucu.AppendText("Okey I stop listening");
                konuşma_sentez.Speak(okuyucu);
                listening = false;
            }
           
            if (alınan_ses =="google" && listening==true)
            {
                okuyucu.ClearContent();
                okuyucu.AppendText("Tamam");
                konuşma_sentez.Speak(okuyucu);
                System.Diagnostics.Process.Start("C:/Program Files/Google/Chrome/Application/chrome.exe");
                okuyucu.ClearContent();
                okuyucu.AppendText("I am opening the google chrome");
                konuşma_sentez.Speak(okuyucu);
            }
            
            if(alınan_ses == "open youtube" && listening == true)
            {
                okuyucu.ClearContent();
                okuyucu.AppendText("Tamam");
                konuşma_sentez.Speak(okuyucu);
                System.Diagnostics.Process.Start("https://www.youtube.com/");
                okuyucu.ClearContent();
                okuyucu.AppendText("I am opening the youtube");
                konuşma_sentez.Speak(okuyucu);

            }
            if (alınan_ses == "open moodle" && listening == true)
            {
                okuyucu.ClearContent();
                okuyucu.AppendText("Tamam");
                konuşma_sentez.Speak(okuyucu);
                System.Diagnostics.Process.Start("https://moodle.atilim.edu.tr/");
  

                okuyucu.ClearContent();
                okuyucu.AppendText("I am opening the moodle");
                konuşma_sentez.Speak(okuyucu);

            }

            if (alınan_ses == "open gmail" && listening == true)
            {  okuyucu.ClearContent();
                 okuyucu.AppendText("Tamam");
                   konuşma_sentez.Speak(okuyucu);
                System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/?tab=rm&ogbl#inbox");
                okuyucu.ClearContent();
                okuyucu.AppendText("I am opening the gmail");
                konuşma_sentez.Speak(okuyucu);

            }

            if (alınan_ses == "open hotmail" && listening == true)
            {
                okuyucu.ClearContent();
                okuyucu.AppendText("Tamam");
                konuşma_sentez.Speak(okuyucu);
                System.Diagnostics.Process.Start("https://outlook.live.com/owa/");
                okuyucu.ClearContent();
                okuyucu.AppendText("I am opening the hotmail");
                konuşma_sentez.Speak(okuyucu);

            }
           
            if (alınan_ses== "exit" && listening == true)
            {
                okuyucu.ClearContent();
                okuyucu.AppendText("Bye Bye");
                konuşma_sentez.Speak(okuyucu);
                Application.Exit();
            }

            if (alınan_ses == "open dev c" && listening == true)
            {
                okuyucu.ClearContent();
                okuyucu.AppendText("Tamam");
                konuşma_sentez.Speak(okuyucu);
                System.Diagnostics.Process.Start("C:/Program Files (x86)/Dev-Cpp/devcpp.exe");
               

                okuyucu.ClearContent();
                okuyucu.AppendText("I am opening the dev c");
                konuşma_sentez.Speak(okuyucu);
            }
            if (alınan_ses == "open discord" && listening == true)
            {
                okuyucu.ClearContent();
                okuyucu.AppendText("Tamam");
                konuşma_sentez.Speak(okuyucu);
                System.Diagnostics.Process.Start("C:/Users/MFB44/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Discord Inc/Discord.lnk");
                okuyucu.ClearContent();
                okuyucu.AppendText("I am opening the discord");
                konuşma_sentez.Speak(okuyucu);
                

            }
            if (alınan_ses == "open translate" && listening == true)
            {
                okuyucu.ClearContent();
                okuyucu.AppendText("Tamam");
                konuşma_sentez.Speak(okuyucu);
                System.Diagnostics.Process.Start("https://translate.google.com/");
               
                okuyucu.ClearContent();
                okuyucu.AppendText("I am opening the google translate");
                konuşma_sentez.Speak(okuyucu);

            }
            if (alınan_ses == "today weather" && listening == true)
            {
                okuyucu.ClearContent();
                okuyucu.AppendText("Today the weather is like this");
                konuşma_sentez.Speak(okuyucu);
                System.Diagnostics.Process.Start("https://www.google.com/search?q=hava+durumu&oq=hava+&aqs=chrome.0.69i59i131i433j0i131i433j69i57j0i131i433l2j69i60l3.2825j1j7&sourceid=chrome&ie=UTF-8");

            }
            if (alınan_ses == "open blender" && listening == true)
            {
                okuyucu.ClearContent();
                okuyucu.AppendText("Tamam");
                konuşma_sentez.Speak(okuyucu);
                System.Diagnostics.Process.Start("C:/Program Files/Blender Foundation/Blender 2.92/blender.exe");
                okuyucu.ClearContent();
                okuyucu.AppendText("I am opening the blender");
                konuşma_sentez.Speak(okuyucu);                
            }




        }
        private void Form1_Load(object sender, EventArgs e)
        {
             
            okuyucu.ClearContent();
            okuyucu.AppendText("Hello I am your assistant if you want to me something before you should say asistan");
            konuşma_sentez.Speak(okuyucu);
            konuşma_motoru.SetInputToDefaultAudioDevice();
            Choices işlemler = new Choices("open blender","asistan","today weather", "open translate","open discord", "exit", "open gmail", "open hotmail", "open dev c",  "open moodle","google", "open youtube", "stop listening");
            GrammarBuilder gramer_yapıcı = new GrammarBuilder(işlemler);
            gramer_yapıcı.Culture = System.Globalization.CultureInfo.GetCultureInfoByIetfLanguageTag("en-US");

            Grammar gramer = new Grammar(gramer_yapıcı);
            konuşma_motoru.LoadGrammar(gramer);
            konuşma_motoru.SpeechRecognized += Konuşma_motoru_SpeechRecognized; ;
            konuşma_motoru.RecognizeAsync(RecognizeMode.Multiple);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }
    }
}
