namespace SAS.HierarchicalProgress.Models
{
    /// <summary>
    /// Interface outlining a class instance for a step
    /// </summary>
    /// <typeparam name="T">Return type of ExecuteAsync</typeparam>
    public interface IStep<T> : IStepBase
    {
        /// <summary>
        /// Execute the step associated with this class
        /// </summary>
        /// <param name="progress">Reporter for step progression</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Type as provided by T</returns>
        public Task<T> ExecuteAsync(IProgress<IStepProgress> progress, CancellationToken cancellationToken = default);
    }
}
