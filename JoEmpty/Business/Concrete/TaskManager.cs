using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        public void Add(UserTask task)
        {
            //add to database
        }

        public List<UserTask> ListAll()
        {
            //retun list from database
            return null;
        }
    }
}
