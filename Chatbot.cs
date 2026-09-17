using System;

namespace CybersecurityChatbot_Part2
{
    public class Chatbot
    {
        public string UserName { get; set; } = "";

        public string GetResponse(string input)
        {
            string message = input.ToLower();

            // General conversation
            if (message.Contains("how are you"))
            {
                return $"I'm doing well, {UserName}! I'm ready to help you stay safe online.";
            }

            if (message.Contains("hello") || message.Contains("hi"))
            {
                return $"Hello {UserName}! How can I help you with cybersecurity today?";
            }

            if (message.Contains("thank"))
            {
                return "You're welcome! Remember to stay alert and protect your personal information.";
            }

            // Purpose
            if (message.Contains("purpose") ||
                message.Contains("what do you do"))
            {
                return "My purpose is to help South African citizens understand cybersecurity risks and stay safer online.";
            }

            // What can I ask?
            if (message.Contains("what can i ask") ||
                message.Contains("what can i learn"))
            {
                return "You can ask me about phishing, passwords, safe browsing, online scams, malware, social engineering and online privacy.";
            }

            // Phishing
            if (message.Contains("phishing") ||
    message.Contains("phishing email") ||
    message.Contains("phishing message") ||
    message.Contains("fake email") ||
    message.Contains("fake message"))
            {
                return "Phishing is a scam where criminals pretend to be a trusted person or organisation to steal information. Check links carefully and never share passwords or OTPs.";
            }

            // Passwords
            if (message.Contains("password") ||
     message.Contains("passcode") ||
     message.Contains("login password"))
            {
                return "Use a long and unique password for each account. Avoid using your name, birthday or other personal information. A password manager can also help.";
            }

            // OTP
            if (message.Contains("otp") ||
                message.Contains("one time password"))
            {
                return "Never share an OTP with someone who contacts you unexpectedly. Keep your OTP private.";
            }

            // Scams
            if (message.Contains("scam") ||
    message.Contains("fraud") ||
    message.Contains("fraudulent"))
            {
                return "Be careful of messages that create urgency or ask for money, passwords, PINs or OTPs. Verify requests using official contact details.";
            }

            // Safe browsing
            if (message.Contains("safe browsing") ||
                message.Contains("browser") ||
                message.Contains("browsing"))
            {
                return "For safer browsing, use trusted websites, check the website address carefully, keep your browser updated and avoid suspicious downloads.";
            }

            // Malware
            if (message.Contains("malware") ||
                message.Contains("virus"))
            {
                return "Malware is malicious software that can damage devices or steal information. Keep your software updated and avoid downloading files from unknown sources.";
            }

            // Social engineering
            if (message.Contains("social engineering"))
            {
                return "Social engineering tricks people into revealing information or performing unsafe actions. Be cautious of pressure, urgency and suspicious requests.";
            }

            // Privacy
            if (message.Contains("privacy") ||
                message.Contains("personal information"))
            {
                return "Protect your personal information by limiting what you share online, using strong privacy settings and avoiding unknown websites and messages.";
            }

            // Public Wi-Fi
            if (message.Contains("public wi-fi") ||
                message.Contains("public wifi") ||
                message.Contains("public wireless"))
            {
                return "Avoid accessing sensitive accounts on public Wi-Fi. If you must use it, use a trusted VPN, avoid unknown networks and make sure your device is protected.";
            }

            // Identity theft
            if (message.Contains("identity theft") ||
                message.Contains("identity"))
            {
                return "Identity theft happens when criminals use your personal information without permission. Protect yourself by keeping your ID, passwords, banking details and other personal information private.";
            }

            // Ransomware
            if (message.Contains("ransomware"))
            {
                return "Ransomware is malware that can lock or encrypt your files and demand payment. Keep backups, update your software and avoid suspicious links and downloads.";
            }

            // Banking safety
            if (message.Contains("banking") ||
                message.Contains("bank account"))
            {
                return "For safer online banking, use official banking apps or websites, never share your PIN or OTP, avoid banking on public Wi-Fi and report suspicious transactions immediately.";
            }

            // Default response
            return $"I'm not sure about that, {UserName}. Try asking me about phishing, passwords, scams, safe browsing, malware, social engineering or privacy.";
        }
    }
}