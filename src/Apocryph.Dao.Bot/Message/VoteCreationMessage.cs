using System.Linq;
using Serilog;

namespace Apocryph.Dao.Bot.Message
{
    public record VoteCreationMessage() : IOutboundMessage
    {
        public ulong UserId { get; init; }
        public string[] Errors { get; init; }
        public string ContractAddress { get; set; }
        public string Channel { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
 
        public string DisplayOutput()
        {
            return GetUrl();
        }
        
        public string GetUrl()
        {
            return Url;
        }

        public string GetThumbnailUrl()
        {
            return MessageResources.ProposalEventMessage_GetThumbnailUrl;
        }
    }
}