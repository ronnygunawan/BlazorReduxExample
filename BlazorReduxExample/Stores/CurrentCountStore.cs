using RG.Redux;

namespace BlazorReduxExample.Stores;

public interface ICurrentCountEvent : IEvent { }
public record CurrentCountIncremented : ICurrentCountEvent;

public record CurrentCountStore() : Store<int, ICurrentCountEvent>(
    reducer: (state, action) => action switch
    {
        CurrentCountIncremented => state + 1,
        _ => state
    },
    initialValue: 0
)
{
    private static readonly CurrentCountIncremented _incremented = new();
    
    public void Increment() => Dispatch(_incremented);
}

public record SingletonCurrentCountStore : CurrentCountStore;