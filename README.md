# ProgramChat

linked my two classes and called my methods

1. Refactored Response Handling into ChatBot Class*
Removed the external ResponseManager class and moved all response logic directly into the ChatBot class by creating a private GetResponse(string input) method. Updated the StartChat() loop to call this new method instead, ensuring all chatbot functionality remains within the existing class structure as required.

2. Implemented Keyword-Based Response Logic*
Added multiple conditional checks inside the GetResponse() method to detect keywords such as "password", "phishing", "malware", "virus", and "wifi". Each keyword now returns a specific cybersecurity tip, improving the chatbot’s ability to provide meaningful and context-aware responses.
