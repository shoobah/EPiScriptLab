using EPiServer.Core;

namespace EPiScriptLab.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
