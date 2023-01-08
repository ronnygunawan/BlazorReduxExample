using RG.Redux;

namespace BlazorReduxExample.Stores;

public record CurrentCountStore() : Store<int>(initialState: 0)
{
    public void Increment() => State++;
}

public record SingletonCurrentCountStore() : CurrentCountStore;