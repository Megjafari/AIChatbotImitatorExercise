namespace AIChatbotImitatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string[] responses = 
            {
                "Hello! How can I assist you today?",
                "I'm here to help! What do you need?",
                "Sure! What would you like to know?",
                "Absolutely! Feel free to ask me anything.",
                "Of course! I'm ready to assist you."
            };

            Console.WriteLine("Welcome to the AI Chatbot Imitator!");
            Console.WriteLine("Type 'exit' to quit the program.");
            while (true)
            {
                Console.Write("You: ");
                string userInput = Console.ReadLine()!;

                if (userInput.ToLower() == "exit")
                break;

                int responseIndex = random.Next(responses.Length);
                string botResponse = responses[responseIndex];

                Console.WriteLine("AI: " + botResponse);
            }

            Console.WriteLine("Thank you for using the AI Chatbot Imitator. Goodbye!");

        }
    }
}
