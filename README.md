# ProgramChat

linked my two classes and called my methods

1. Refactored Response Handling into ChatBot Class*
Removed the external ResponseManager class and moved all response logic directly into the ChatBot class by creating a private GetResponse(string input) method. Updated the StartChat() loop to call this new method instead, ensuring all chatbot functionality remains within the existing class structure as required.

2. Implemented Keyword-Based Response Logic*
Added multiple conditional checks inside the GetResponse() method to detect keywords such as "password", "phishing", "malware", "virus", and "wifi". Each keyword now returns a specific cybersecurity tip, improving the chatbot’s ability to provide meaningful and context-aware responses.

Added Quiz Feature with Method Integration*
Created a new private method StartQuiz() inside the ChatBot class to provide an interactive quiz. Integrated this feature into the main chat loop by detecting the "quiz" command and calling the method. Included answer validation, score tracking, and feedback messages using existing UI helper methods.

. Implemented Chat History Tracking and Display*
Added a List<string> field to store user inputs during runtime. Updated the chat loop to save each user input into the list and implemented a "history" command that displays all previous user queries. This enhances usability and demonstrates data storage within the application.

Added File-Based Chat Logging System*
Integrated file handling using System.IO to log all conversations. Modified the chat loop to write both user inputs and bot responses to a chatlog.txt file using File.AppendAllText(). This ensures persistent storage of interactions for later review.

 Enhanced User Experience and Audio Feedback*
Improved the user interface by adding a help command that lists available commands and enhancing the welcome message with usage guidance. Extended the AudioManager class by adding a PlaySuccess() method and called it within the quiz feature to provide audio feedback for correct answers.






