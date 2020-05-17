namespace FrontlineMaster.Entity.Logging
{
    public interface ICorrelationIdAccessor
    {
        string GetCorrelationId();
    }
}