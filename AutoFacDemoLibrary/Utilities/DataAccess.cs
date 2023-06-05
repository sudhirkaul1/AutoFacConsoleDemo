using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacDemoLibrary.Utilities;

public class DataAccess : IDataAccess
{
    public void SaveData()
    {
        Console.WriteLine("Data Saved");
    }
}
