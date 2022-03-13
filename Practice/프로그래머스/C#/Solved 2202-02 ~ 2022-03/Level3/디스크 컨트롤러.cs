/*
◆ 문제 설명
하드디스크는 한 번에 하나의 작업만 수행할 수 있습니다.
디스크 컨트롤러를 구현하는 방법은 여러 가지가 있으나 가장 일반적인 방법은 요청이 들어온 순서대로 처리하는 것입니다.

주어진 작업들에 대하여 작업의 요청부터 종료까지 걸린 시간의 평균을 가장 줄이는 방법으로 처리하면 평균이 얼마가 되는지 구하세요.
(단, 소수점 이하의 수는 버립니다)

◆ 매개변수
  jobs : 각 작업에 대해 [작업이 요청되는 시점, 작업의 소요시간]을 담은 2차원 배열 

◆ 제한사항
  jobs의 길이는 1 이상 500 이하입니다.
  jobs의 각 행은 하나의 작업에 대한 [작업이 요청되는 시점, 작업의 소요시간] 입니다.
  각 작업에 대해 작업이 요청되는 시간은 0 이상 1,000 이하입니다.
  각 작업에 대해 작업의 소요시간은 1 이상 1,000 이하입니다.
  하드디스크가 작업을 수행하고 있지 않을 때에는 먼저 요청이 들어온 작업부터 처리합니다.
*/

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

        var tasksAvailable = from task in list              //List<>.Sort()와 람다식으로 풀다가 쿼리를 사용하여 푸는 것으로 변경
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