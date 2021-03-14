using System;

namespace BinaryComparer {
    public struct Difference {
        public int Position { get; init; }
        public int LengthLeft { get; init; }
        public int LengthRight { get; init; }
        public int ShortestLength => Math.Min(LengthLeft, LengthRight);
    }
}
