public interface IPausable
{
    void OnPause();
    void OnResume();
    bool IsPaused { get; }
}
