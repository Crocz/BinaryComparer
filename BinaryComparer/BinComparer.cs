using System;
using System.Collections.Generic;

namespace BinaryComparer {
    public class BinComparer {
        public List<Difference> GetDifference(IList<byte> left, IList<byte> right) {
            List<Difference> retval = new List<Difference>();
            for(int i = 0; i < left.Count; ++i) {
                if(left[i] != right[i]) {
                    var shortestDifference = GetShortestDifference(left, right, i);
                    retval.Add(shortestDifference);
                    i += shortestDifference.ShortestLength;
                }
                
            }
            return retval;
        }

        private Difference GetShortestDifference(IList<byte> left, IList<byte> right, int startIndex) {
            throw new NotImplementedException();
        }
    }
}
