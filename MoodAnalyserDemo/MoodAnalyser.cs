using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
          this.message = message;
        }
        /// <summary>
        /// parameterized Constructor.
        /// </summary>
        /// <paran name="message"></paran>
        public string AnalyseMood()
        {
            if (this.message.Contains("sad"))
            {
                return "SAD";

            }
            else
            {
                return "HAPPY";

            }
  
        }
    }
}
