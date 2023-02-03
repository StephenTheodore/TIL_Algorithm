using System;

public class Solution {
    public int solution(int chicken) {
        int coupon = 0;
        int service = 0;
        
        while(chicken != 0)
        {
            coupon += chicken;
            service += chicken = coupon/10;
            coupon = coupon%10;
        }
        
        return service;
    }
}