using System.Collections.Generic;

namespace PartyInvites.Models.Repository {

    public interface IRepository {
        IEnumerable<GuestResponse> GetAllResponses();

        void AddResponse(GuestResponse response);
    }
}
