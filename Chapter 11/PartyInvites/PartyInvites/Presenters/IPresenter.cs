using PartyInvites.Presenters;
using PartyInvites.Presenters.Results;

namespace PartyInvites.Presenters {
    public interface IPresenter<T> {

        IResult GetResult();

        IResult GetResult(T requestData);
    }
}
