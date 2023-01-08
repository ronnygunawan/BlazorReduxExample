using Microsoft.AspNetCore.Components;

namespace BlazorReduxExample
{
    public abstract class DisposableComponentBase : ComponentBase, IDisposable
    {
        private CancellationTokenSource? _disposalTokenSource;

        /// <summary>
        /// Gets a cancellation token that is cancelled when the component is disposed.
        /// </summary>
        protected CancellationToken DisposalToken => (_disposalTokenSource ??= new()).Token;

        public void Dispose()
        {
            if (_disposalTokenSource == null) return;

            _disposalTokenSource.Cancel();
            _disposalTokenSource.Dispose();
            _disposalTokenSource = null;
        }
    }
}
