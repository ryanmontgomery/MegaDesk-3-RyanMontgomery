using System;

namespace MegaDesk_3_RyanMontgomery
{
    class InvalidWidthException : Exception
    {
        public InvalidWidthException(string message)
            : base(message)
        { }
    }
    class InvalidDepthException : Exception
    {
        public InvalidDepthException(string message)
            : base(message)
        { }
    }
    class InvalidDrawersException : Exception
    {
        public InvalidDrawersException(string message)
            : base(message)
        { }
    }

    class Desk
    {
        public enum Materials { Oak, Laminate, Pine, Rosewood, Veneer }

        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        public const int MIN_DRAWERS = 0;
        public const int MAX_DRAWERS = 7;

        private int _width;
        private int _depth;
        private int _drawers;

        public int Width {
            get {
                return _width;
            }
            set {
                if (value < MIN_WIDTH)
                    throw new InvalidWidthException(String.Format("Width provided({0}) is smaller than minimum value({1}).", value, MIN_WIDTH));
                else if (value > MAX_WIDTH)
                    throw new InvalidWidthException(String.Format("Width provided({0}) is larger than maximum value({1}).", value, MAX_WIDTH));
                else
                    _width = value;
            }
        }

        public int Depth {
            get {
                return _depth;
            }
            set {
                if (value < MIN_DEPTH)
                    throw new InvalidDepthException(String.Format("Depth provided({0}) is smaller than minimum value({1}).", value, MIN_DEPTH));
                else if (value > MAX_DEPTH)
                    throw new InvalidDepthException(String.Format("Depth provided({0}) is larger than maximum value({1}).", value, MAX_DEPTH));
                else
                    _depth = value;
            }
        }

        public int Drawers {
            get {
                return _drawers;
            }
            set {
                if (value < MIN_DRAWERS)
                    throw new InvalidDrawersException(String.Format("Number of drawers provided({0}) is smaller than minimum value({1}).", value, MIN_DRAWERS));
                else if (value > MAX_DRAWERS)
                    throw new InvalidDrawersException(String.Format("Number of drawers provided({0}) is larger than maximum value({1}).", value, MAX_DRAWERS));
                else
                    _drawers = value;
            }
        }

        public Materials Material {
            get;
            set;
        }

        /// <exception cref="InvalidWidthException">Throws when outside min/max limits for width.</exception>
        /// <exception cref="InvalidDepthException">Throws when outside min/max limits for depth.</exception>
        /// <exception cref="InvalidDrawersException">Throws when outside min/max limits for drawers.</exception>
        public Desk(int width, int depth, int drawers, Materials material) {
            Width = width;
            Depth = depth;
            Drawers = drawers;
            Material = material;
        }

    }
}
