using System.IO;
using System.Text.Json;

namespace ChessUI
{
    public static class CredentialManager
    {
        private static readonly string FilePath = "credentials.json";

        public static void SaveCredentials(User user)
        {
            string json = JsonSerializer.Serialize(user);
            File.WriteAllText(FilePath, json);
        }

        public static User LoadCredentials()
        {
            if (!File.Exists(FilePath))
                return null;

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<User>(json);
        }
    }
}
