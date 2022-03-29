using System;
using System.Collections.Generic;

public class Solution
{
        class UserInfo
        {
            public int userCode;
            public List<string> reporters;
            public bool getBanned;
            public int countReported;
            public UserInfo(int userCode)
            {
                this.userCode = userCode;
                this.reporters = new List<string>();
                this.getBanned = false;
                this.countReported = 0;
            }
        }
    public int[] solution(string[] id_list, string[] report, int k)
    {
            int[] countMailSent = new int[id_list.Length];
            Dictionary<String, UserInfo> listUser = new Dictionary<string, UserInfo>();
            string[] splitStrings;

            //초기화
            for (int i = 0; i < id_list.Length; i++ )
            {
                listUser.Add(id_list[i], new UserInfo(i));
            }
            //신고 횟수
            for (int i = 0; i < report.Length; i++ )
            {
                splitStrings = report[i].Split(' ');
                if (!listUser[splitStrings[1]].reporters.Contains(splitStrings[0]))
                {
                    listUser[splitStrings[1]].reporters.Add(splitStrings[0]);
                    listUser[splitStrings[1]].countReported++;
                    if (listUser[splitStrings[1]].countReported == k)
                        listUser[splitStrings[1]].getBanned = true;
                }
            }
            //메일 발송 횟수
            for (int i = 0; i < id_list.Length; i++)
            {
                if (!listUser[id_list[i]].getBanned)
                    continue;
                splitStrings = listUser[id_list[i]].reporters.ToArray();
                for (int j = 0; j < splitStrings.Length; j++)
                {
                    countMailSent[listUser[splitStrings[j]].userCode]++;
                }
            }
            return countMailSent;
    }
}