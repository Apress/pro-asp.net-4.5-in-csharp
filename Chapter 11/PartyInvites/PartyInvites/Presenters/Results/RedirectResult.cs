
namespace PartyInvites.Presenters.Results {
    public class RedirectResult : IResult {
        private string url;

        public RedirectResult(string urlValue) {
            url = urlValue;
        }

        public string Url {
            get {
                return url;
            }
        }
    }
}