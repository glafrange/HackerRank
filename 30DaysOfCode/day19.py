class Calculator(AdvancedArithmetic):
    def divisorSum(self, n):
        count = 0
        for i in range(1, n+1):
            if n % i == 0:
                count += i
        return (count)