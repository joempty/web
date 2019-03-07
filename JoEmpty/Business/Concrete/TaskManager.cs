using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        public void Add(Task task)
        {
            //add to database
        }

        public List<Task> ListAll()
        {
            //retun list from database
            return null;
        }
    }
}
