namespace CSharp10;
class MultyThreading {

    public CancellationTokenSource CancellationTokenSource;

    public MultyThreading(CancellationTokenSource cancellationTokenSource) {
        CancellationTokenSource = cancellationTokenSource;
    }

    public void RandomGenerator() {
        Task.Run(() => {
            while (true) {
                if (CancellationTokenSource.IsCancellationRequested) break;
                Console.WriteLine((char)new Random().Next(0, 256));
            }
        }, CancellationTokenSource.Token);
    }

}
