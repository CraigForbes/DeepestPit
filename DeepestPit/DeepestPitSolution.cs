using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepestPit
{
    public class DeepestPitSolution
    {
        public int Solution(int[] A)
        {
            if (!HasTriplet(A)) // do we even have a potential 3 points to check for a pit?
            {
                return -1;
            }

            int? P = A[0]; // Set P to first element of the array;
            int? Q = P; // so it doesnt fail if there is no initial upwards slope;
            int? R = null;

            int depth = -1;
            int greatestDepth = -1;

            // Approach I took was to find the first highest point in the array (Initial Highest point) "P"
            // and then work out the strictly decreasing lowest value. (downward slope) "Q"
            // Once we have this lowest value we start looking for strictly increaing highest point (upwards slope) "R"
            // Work out length of the slope then try and find more slopes to compare depth.
            // a few little checks for any nuances there may be also included

            for (int i = 0; i < A.Length; i++)
            {
                // i + 1 <= A.Length helps prevent error on ending downward slope
                if (i + 1 >= A.Length)
                {
                    return greatestDepth;
                }

                // check if this is the highest point on current up slope
                if (P < A[i + 1] && !R.HasValue)
                {
                    P = A[i + 1]; // set new highest point
                    Q = A[i + 1]; // set lowest point to Q so we can find the real lowest point
                    continue; // exit early so we can check next point to see if this one is still the heighest
                }

                // We now have a slopes highest starting point stored in "P", start finding the lowest point "Q "
                // start checking downwards slope
                if (Q > A[i + 1])
                {
                    Q = A[i + 1];
                    R = A[i + 1];
                    continue;
                }

                // we now have a slopes highest and lowest point, find the closing upwards slope for the pit R and work out the depth.
                if (R < A[i + 1])
                {
                    R = A[i + 1];

                    depth = CalculateDepth(P.Value, Q.Value, R.Value);
                    greatestDepth = CompareDepths(greatestDepth, depth);

                    //check if its the highest point in current slope, if there is another element in array
                    //if it is set P to value of this so we can work out next slope
                    if ((i + 2) < A.Length && !(R < A[i + 2]))
                    {
                        P = R;
                    }
                }
                else
                {
                    P = R ?? P; // set start point for new slope to bottom of previous slope
                    Q = A[i + 1]; // set lowest point of slope to top point, basically a reset
                    R = null;
                }

                if (i + 2 == A.Length) // have we checked everything, if so return greatestdepth
                {
                    return greatestDepth;
                }
            }
            return greatestDepth; // returns if nothing runs as default "-1"
        }

        public int CalculateDepth(int P, int Q, int R)
        {
            var result1 = P - Q;
            var result2 = R - Q;

            if (result1 < result2)
            {
                return result1;
            }
            else
            {
                return result2;
            }
        }

        public int CompareDepths(int greatestDepth, int depth)
        {
            if (depth > greatestDepth)
            {
                return depth;
            }

            return greatestDepth;
        }

        public bool HasTriplet(int[] A)
        {
            if (A.Length >= 3)
            {
                return true;
            }

            return false;
        }
    }
}
