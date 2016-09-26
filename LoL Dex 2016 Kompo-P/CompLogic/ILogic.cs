using System;
using System.Collections.Generic;
using System.Data;

namespace CompLogic
{

    public interface ILogic
    {
        string[,] GetChampnames();

        string GetChampStats(int id);
    }
}
