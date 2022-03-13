import java.util.*;

class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        List<Integer> Lost = new ArrayList();
        List<Integer> Reserve = new ArrayList();
        List<Integer> Dupl = new ArrayList<Integer>();
        int answer=0;
        for(int i = 0; i < lost.length; i++)
        {
            Lost.add(lost[i]);
        }
        for(int i = 0; i< reserve.length; i++)
        {
            Reserve.add(reserve[i]);
        }
        
        for(int v1 : Lost)
        {
            for(int v2 : Reserve)
            {
                if(v1==v2)
                {
                    Dupl.add(v1);
                    break;
                }
            }
        }
        for(int v : Dupl)
        {
            Lost.remove(Integer.valueOf(v));
            Reserve.remove(Integer.valueOf(v));
        }
        for(int i=0; i<Lost.size(); i++)
        {
            for(int v : Reserve)
            {
                if(v==Lost.get(i)-1 || v==Lost.get(i)+1)
                {
                    Reserve.remove(Integer.valueOf(v));   
                    answer++;
                    break;
                }
            }
        }
        
        return n - (Lost.size() - answer);
    }
}