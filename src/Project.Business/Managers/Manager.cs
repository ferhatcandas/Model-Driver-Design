using Project.Business.Services;
using System;
using System.Collections.Generic;
using System.Text;
using TStack.ADO;

namespace Project.Business.Managers
{
    public class Manager : IService
    {
        private readonly ADOManager adoManager;

        public Manager(ADOManager  adoManager)
        {
            this.adoManager = adoManager;
        }
        public void Add()
        {
           var a = adoManager.ExecuteScalar("Select top 1 Ad from kitap", TStack.ADO.Tool.CommandType.Text);
        }
    }
}
