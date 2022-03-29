using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    class Task
    {
        public int req { get; }
        public int dur { get; }
        public Task(int req, int dur)
        {
            this.req = req;
            this.dur = dur;
        }
        public void UpdateTimes(int[] times, bool isDiskIdle)
        {
            if (isDiskIdle)
                times[0] += dur;
            else
            {
                times[1] += times[0] + times[2] - req;
                times[0] += dur;
            }
        }
    }
    public int solution(int[,] jobs)
    {
        List<Task> list = new List<Task>();
        Task currentTask;
        // [0] : 시간경과, [1] : 작업의 대기시간, [2] : 디스크 유휴시간
        int[] times = new int[3] { 0, 0, 0 };

        for (int i = 0; i < jobs.GetLength(0); i++)
            list.Add(new Task(jobs[i, 0], jobs[i, 1]));

        var tasksAvailable = from task in list
                   where task.req <= times[0] + times[2]
                   orderby task.dur, task.req
                   select task;
        var tasksReq = from task in list
                  orderby task.req, task.dur
                  select task;

        while (list.Count != 0)
        {
            if (tasksAvailable.Count() == 0)
            {
                currentTask = tasksReq.ElementAt(0);
                times[2] += tasksReq.ElementAt(0).req - times[0];
                currentTask.UpdateTimes(times,true);
            }
            else
            {
                currentTask = tasksAvailable.ElementAt(0);
                currentTask.UpdateTimes(times,false);
            }
            list.Remove(currentTask);
        }

        return (times[0] + times[1]) / jobs.GetLength(0);
    }
}