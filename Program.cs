namespace AIChatbotImitatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string[] responses = // Sample responses to mimic an AI chatbot, Array of strings
            {
                "Hello! How can I assist you today?",
                "I'm here to help! What do you need?",
                "Sure! What would you like to know?",
                "Absolutely! Feel free to ask me anything.",
                "Of course! I'm ready to assist you."
            };

            Console.WriteLine("Welcome to the AI Chatbot Imitator!");
            Console.WriteLine("Type 'exit' to quit the program.");

            while (true)            // Infinite loop to keep the program running until the user decides to exit
            {
                Console.Write("You: ");
                string userInput = Console.ReadLine()!;

                if (userInput.ToLower() == "exit")
                break;

                int responseIndex = random.Next(responses.Length);      // Generate a random index to select a response
                string botResponse = responses[responseIndex];          // Select a random response from the array

                Console.WriteLine("AI: " + botResponse);
            }

            Console.WriteLine("Thank you for using the AI Chatbot Imitator. Goodbye!");

        }
    }
}
