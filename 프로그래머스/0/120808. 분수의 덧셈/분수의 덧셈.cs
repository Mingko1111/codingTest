using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        // 공통 분모를 구함
        int lcm = denom1 * denom2 / GCD(denom1, denom2);
        
        // 분자 계산
        int sumNumer = numer1 * (lcm / denom1) + numer2 * (lcm / denom2);
        int sumDenom = lcm;
        
        // 기약 분수로 만들기 위해 최대공약수 계산
        int gcd = GCD(sumNumer, sumDenom);
        
        return new int[] { sumNumer / gcd, sumDenom / gcd };
    }
    
    // 최대공약수(GCD) 계산 (유클리드 호제법)
    private int GCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
