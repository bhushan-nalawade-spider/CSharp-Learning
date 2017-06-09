using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ConsoleApplication1
{
    public class ProgramIntroduction
    {
        public void Introduction(String message)
        {
            SpeechSynthesizer speaker = new SpeechSynthesizer();
            Console.WriteLine(message);
            //speaker.Speak(message);
        }
    }
}
