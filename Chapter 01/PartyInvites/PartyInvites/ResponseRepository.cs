using System.Collections.Generic;

namespace PartyInvites {
    public class ResponseRepository {
        private static ResponseRepository repository = new ResponseRepository();
        private List<GuestResponse> responses = new List<GuestResponse>();

        public static ResponseRepository GetRepository() {
            return repository;
        }

        public IEnumerable<GuestResponse> GetAllResponses() {
            return responses;
        }

        public void AddResponse(GuestResponse response) {
            responses.Add(response);
        }
    }
}