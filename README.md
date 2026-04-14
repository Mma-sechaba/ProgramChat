# ProgramChat

linked my two classes and called my methods

1. Refactored Response Handling into ChatBot Class*
Removed the external ResponseManager class and moved all response logic directly into the ChatBot class by creating a private GetResponse(string input) method. Updated the StartChat() loop to call this new method instead, ensuring all chatbot functionality remains within the existing class structure as required.
