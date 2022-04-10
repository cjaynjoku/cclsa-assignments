using System.Collections;

namespace WorkersSort
{
    public class WorkerComparerDescending : IComparer
    {
        public int Compare(object x, object y)
        {
            Worker workerA = (Worker)x;
            Worker workerB = (Worker)y;

            if (workerA.Wages < workerB.Wages)
            {
                return 1;
            }
            else if (workerA.Wages > workerB.Wages)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
}
