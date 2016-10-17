using System.Collections.Generic;

namespace PartyInvites.Models.Repository {
    public class MemoryRepository: IRepository  {
        private List<GuestResponse> responses = new List<GuestResponse>();

        public IEnumerable<GuestResponse> GetAllResponses() {
            return responses;
        }

        public void AddResponse(GuestResponse response) {
            responses.Add(response);
        }
    }
}