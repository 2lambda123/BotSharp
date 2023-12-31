namespace BotSharp.Abstraction.Knowledges.Settings;

public class KnowledgeBaseSettings
{
    public string VectorDb { get; set; }
    public string TextEmbedding { get; set; }
    public string TextCompletion { get; set; }
    public string Pdf2TextConverter { get; set; }
}
