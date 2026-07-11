namespace QuizApp
{
    public partial class Form1 : Form
    {
        // Quiz data structure (Question, Options, CorrectOption)
        private string[,] quizData = {
    {"What is the capital of France?", "Berlin", "Madrid", "Paris", "Rome", "c"},
    {"Which planet is known as the 'Red Planet'?", "Mars", "Venus", "Jupiter", "Saturn", "a"},
    {"Who wrote 'Romeo and Juliet'?", "William Shakespeare", "Jane Austen", "Charles Dickens", "Mark Twain", "a"},
    {"What is the largest ocean on Earth?", "Atlantic Ocean", "Indian Ocean", "Southern Ocean", "Pacific Ocean", "d"},
    {"What is the main ingredient in hummus?", "Chickpeas", "Tomatoes", "Onions", "Eggplant", "a"},
    {"In which year did the Titanic sink?", "1905", "1912", "1921", "1930", "b"},
    {"What is the capital of Japan?", "Seoul", "Beijing", "Tokyo", "Bangkok", "c"},
    {"Who painted the Mona Lisa?", "Vincent van Gogh", "Pablo Picasso", "Leonardo da Vinci", "Claude Monet", "c"},
    {"What is the currency of Brazil?", "Peso", "Euro", "Real", "Dollar", "c"},
    {"Which element has the chemical symbol 'O'?", "Osmium", "Oxygen", "Oganesson", "Omnium", "b"},
    {"Who is known as the 'Father of Computers'?", "Bill Gates", "Alan Turing", "Steve Jobs", "Charles Babbage", "d"},
    {"What is the largest mammal in the world?", "Elephant", "Blue Whale", "Giraffe", "Hippopotamus", "b"},
    {"Who wrote 'To Kill a Mockingbird'?", "J.K. Rowling", "George Orwell", "Harper Lee", "Ernest Hemingway", "c"},
    {"What is the capital of Canada?", "Ottawa", "Toronto", "Vancouver", "Montreal", "a"},
    {"Which gas is most abundant in the Earth's atmosphere?", "Oxygen", "Nitrogen", "Carbon Dioxide", "Helium", "b"},
    {"What is the smallest prime number?", "0", "1", "2", "3", "c"},
    {"Who discovered penicillin?", "Alexander Fleming", "Marie Curie", "Louis Pasteur", "Joseph Lister", "a"},
    {"What is the capital of Australia?", "Canberra", "Sydney", "Melbourne", "Brisbane", "a"},
    {"Which planet is known as the 'Blue Planet'?", "Neptune", "Uranus", "Earth", "Pluto", "c"},
    {"Who painted 'Starry Night'?", "Pablo Picasso", "Vincent van Gogh", "Leonardo da Vinci", "Claude Monet", "b"},
    {"What is the square root of 64?", "6", "8", "10", "12", "b"},
    {"Who is the author of '1984'?", "George Orwell", "Aldous Huxley", "Ray Bradbury", "H.G. Wells", "a"},
    {"What is the main ingredient in guacamole?", "Tomato", "Avocado", "Onion", "Cilantro", "b"},
    {"What is the longest river in the world?", "Nile", "Amazon", "Yangtze", "Mississippi", "b"},
    {"Which element has the chemical symbol 'H'?", "Hydrogen", "Helium", "Hassium", "Hafnium", "a"},
    {"In which year did Christopher Columbus first reach the Americas?", "1492", "1607", "1776", "1837", "a"},
    {"Who wrote 'The Great Gatsby'?", "F. Scott Fitzgerald", "George Orwell", "Jane Austen", "Charles Dickens", "a"},
    {"What is the smallest prime number?", "0", "1", "2", "3", "c"},
    {"Who wrote 'The Great Gatsby'?", "F. Scott Fitzgerald", "George Orwell", "Jane Austen", "Charles Dickens", "a"}
};




        private int currentQuestionIndex = 0;
        private int userScore = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeQuiz();
        }

        private void InitializeQuiz()
        {
            // Initialize the form controls, set up the first question, etc.
            lblQuestion.Text = quizData[currentQuestionIndex, 0];
            radioOptionA.Text = quizData[currentQuestionIndex, 1];
            radioOptionB.Text = quizData[currentQuestionIndex, 2];
            radioOptionC.Text = quizData[currentQuestionIndex, 3];
            radioOptionD.Text = quizData[currentQuestionIndex, 4];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Start the quiz by showing the first question
            btnStart.Enabled = false;
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            // Display the current question and options
            lblQuestion.Text = quizData[currentQuestionIndex, 0];
            radioOptionA.Text = quizData[currentQuestionIndex, 1];
            radioOptionB.Text = quizData[currentQuestionIndex, 2];
            radioOptionC.Text = quizData[currentQuestionIndex, 3];
            radioOptionD.Text = quizData[currentQuestionIndex, 4];

            // Enable radio buttons
            radioOptionA.Enabled = true;
            radioOptionB.Enabled = true;
            radioOptionC.Enabled = true;
            radioOptionD.Enabled = true;

            // Clear radio button selection
            radioOptionA.Checked = false;
            radioOptionB.Checked = false;
            radioOptionC.Checked = false;
            radioOptionD.Checked = false;

            // Show current question number
            lblQuestionNumber.Text = $"Question {currentQuestionIndex + 1}/{quizData.GetLength(0)}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Check if the user has selected an option
            if (radioOptionA.Checked || radioOptionB.Checked || radioOptionC.Checked || radioOptionD.Checked)
            {
                // Disable radio buttons
                radioOptionA.Enabled = false;
                radioOptionB.Enabled = false;
                radioOptionC.Enabled = false;
                radioOptionD.Enabled = false;

                // Check the user's answer and update the score
                CheckAnswer();

                // Move to the next question
                currentQuestionIndex++;

                // Check if there are more questions
                if (currentQuestionIndex < quizData.GetLength(0))
                {
                    ShowQuestion();
                }
                else
                {
                    // End of the quiz
                    EndQuiz();
                }
            }
            else
            {
                MessageBox.Show("Please select an option before moving to the next question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckAnswer()
        {
            // Check if the user's selected answer is correct
            string correctOption = quizData[currentQuestionIndex, 5];
            if ((radioOptionA.Checked && correctOption == "a") ||
                (radioOptionB.Checked && correctOption == "b") ||
                (radioOptionC.Checked && correctOption == "c") ||
                (radioOptionD.Checked && correctOption == "d"))
            {
                // Correct answer
                userScore++;
            }
        }

        private void EndQuiz()
        {
            // Display final score and a message based on the performance
            MessageBox.Show($"Congratulations! You scored {userScore}/{quizData.GetLength(0)}", "Quiz Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnStart.Enabled = true;
            currentQuestionIndex = 0;
            userScore = 0;
            lblQuestionNumber.Text = "Question 0/0";
            InitializeQuiz(); // Reset the quiz for the next attempt
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioOptionB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}