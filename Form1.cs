namespace colorguesser
{
    public partial class Form1 : Form
    {
        Color color;
        Random random = new Random();
        bool showResult = false;
        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            if(showResult)
            {
                Reset();
            }
            else
            {
                int r, g, b;
                try
                {
                    r = Int32.Parse(rText.Text);
                    g = Int32.Parse(gText.Text);
                    b = Int32.Parse(bText.Text);

                    if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255) throw new FormatException();
                }
                catch(FormatException)
                {
                    resultText.Text = "Invalid RGB values.";
                    return;
                }

                Color guessColor = Color.FromArgb(r, g, b);

                double diff = Math.Sqrt(Math.Pow(color.R - r, 2) + Math.Pow(color.G - g, 2) + Math.Pow(color.B - b, 2));
                double percent = 1 - (diff / Math.Sqrt(3 * Math.Pow(255, 2)));
                percent *= 100;


                guessBox.BackColor = guessColor;
                resultText.Text = "Actual color: " + ToString(color.R, color.G, color.B) + Environment.NewLine
                                + "Your guess: " + ToString(r, g, b) + Environment.NewLine + Environment.NewLine
                                + "Score: " + string.Format("{0:0.#}", percent);

                showResult = true;
                guessButton.Text = "Reset";
            }
        }

        private void Reset()
        {
            color = Color.FromArgb(255, random.Next(256), random.Next(256), random.Next(256));
            colorBox.BackColor = color;
            colorBox.Refresh();

            guessButton.Text = "Guess";
            resultText.Text = "";
            guessBox.BackColor = SystemColors.Control;

            rText.Text = "";
            gText.Text = "";
            bText.Text = "";

            showResult = false;
        }

        private string ToString(int r, int g, int b)
        {
            return "{ " + r + ", " + g + ", " + b + " }";
        }
    }
}