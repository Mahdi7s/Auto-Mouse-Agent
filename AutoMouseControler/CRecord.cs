using System;
using System.Collections.Generic;
using System.Drawing;

namespace AutoMouseControler
{
    public enum EVENTS { CLICK, RIGHT_CLICK, DOUBLE_CLICK }

    [Serializable]
    public class CRecord
    {
        public CRecord()
        {
            Points = new List<Point>();
            Seconds = new List<int>();
            Events = new List<EVENTS>();
        }

        public List<Point> Points { get; set; }
        public List<int> Seconds { get; set; }
        public List<EVENTS> Events { get; set; }
        public int Count { get { return Points.Count; } }
    }
}
