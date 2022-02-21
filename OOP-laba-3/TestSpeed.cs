using System.Collections.Generic;
using System.Diagnostics;

namespace OOP_laba_3
{
    public class TestSpeed
    {
        private Stack<RailwayStation> stationsStack;
        private RailwayStation[] stationsArr;
        private const int SIZE = 1000000;

        public TestSpeed()
        {
            this.stationsStack = new Stack<RailwayStation>();
            this.stationsArr = new RailwayStation[SIZE];
        }

        public int GetTimeInsertStack()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < SIZE; i++)
            {
                stationsStack.Push(new RailwayStation());
            }
            timer.Stop();

            return timer.Elapsed.Milliseconds;
        }

        public int GetTimeInsertArr()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < SIZE; i++)
            {
                stationsArr[i] = new RailwayStation();
            }
            timer.Stop();

            return timer.Elapsed.Milliseconds;
        }

        public int GetTimeExtractStack()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < SIZE; i++)
            {
                RailwayStation tmp = stationsStack.Peek();
            }
            timer.Stop();

            return timer.Elapsed.Milliseconds;
        }

        public int GetTimeExtractArr()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = SIZE - 1; i >= 0; i--)
            {
                RailwayStation tmp = stationsArr[i];
            }
            timer.Stop();

            return timer.Elapsed.Milliseconds;
        }
    }
}
