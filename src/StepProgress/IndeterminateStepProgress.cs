using SAS.HierarchicalProgress.Models;

namespace SAS.HierarchicalProgress.StepProgress
{
    /// <summary>
    /// Indeterminate progress reporting
    /// </summary>
    public class IndeterminateStepProgress : IStepProgress
    {
        /// <summary>
        /// Indeterminate progress reporting
        /// </summary>
        /// <param name="step">The step associated with this progress instance</param>
        public IndeterminateStepProgress(IStepBase step)
        {
            this.Step = step;
        }

        /// <summary>
        /// The step associated with this progress instance
        /// </summary>
        public IStepBase Step { get; private set;  }
    }
}
