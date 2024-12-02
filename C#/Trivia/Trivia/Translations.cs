using System.Collections.Generic;

namespace Trivia;

public class Translations
{
    // Define translations
    public static Dictionary<string, Dictionary<string, string>> Texts = new Dictionary<string, Dictionary<string, string>>
    {
        { "en", new Dictionary<string, string>
            {
                { "Greeting", "Hello!" },
                { "Farewell", "Goodbye!" }
            }
        },
        { "fr", new Dictionary<string, string>
            {
                { "Greeting", "Bonjour!" },
                { "Farewell", "Au revoir!" }
            }
        },
        { "es", new Dictionary<string, string>
            {
                { "Greeting", "¡Hola!" },
                { "Farewell", "¡Adiós!" }
            }
        }
    };
}