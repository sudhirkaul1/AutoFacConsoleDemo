using AutoFacDemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacDemoLibrary.BusinessLogic
{
    public class BusinessLogic : IBusinessLogic
    {
        private readonly ILogger _logger;
        private readonly IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger,IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }


        public void ProcessData()
        {
            _logger.Log("Business Process Applied");
            _dataAccess.SaveData();

        }
    }
}
