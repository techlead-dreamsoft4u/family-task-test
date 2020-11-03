using Core.Abstractions.Repositories;
using Domain.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class TaskRepository : BaseRepository<Guid, AppTask, TaskRepository>, ITaskRepository
    {
        public TaskRepository(FamilyTaskContext context) : base(context)
        { }



        ITaskRepository IBaseRepository<Guid, AppTask, ITaskRepository>.NoTrack()
        {
            return base.NoTrack();
        }

        ITaskRepository IBaseRepository<Guid, AppTask, ITaskRepository>.Reset()
        {
            return base.Reset();
        }


    }
}
