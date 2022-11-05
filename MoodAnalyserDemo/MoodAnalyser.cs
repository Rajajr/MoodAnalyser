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
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "SAD";

                }
                else
                {
                    return "HAPPY";

                }

            }
            catch
            {
                return "HAPPY";

            }

        }
    }
}
