using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITaskService
    {
        void Add(UserTask task);
        List<UserTask> ListAll();
    }
}
