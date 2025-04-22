using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ApologySite.Models;

namespace ApologySite.Data
{
    public static class MessageStore
    {
        private static string FilePath => "messages.json";
        public static List<Message> Messages { get; set; } = new List<Message>();

        static MessageStore()
        {
            Load();
        }

        public static void Add(Message message)
        {
            Messages.Add(message);
            Save();
        }

        public static void RemoveById(int id)
        {
            var msg = Messages.Find(m => m.Id == id);
            if (msg != null)
            {
                Messages.Remove(msg);
                Save();
            }
        }

        public static void Save()
        {
            var json = JsonSerializer.Serialize(Messages, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public static void Load()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                Messages = JsonSerializer.Deserialize<List<Message>>(json) ?? new List<Message>();
            }
        }
    }
}
