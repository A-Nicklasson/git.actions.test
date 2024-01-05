public class Calculator { 

    public int Addition(int a, int b) { 
        return a + b;
    }
    public float Subtract(float a, float b) {
        return a - b;
    }
    public int Multiply(int a, int b) { 
        return a * b;
    }
    public decimal Division(decimal a, decimal b) { 
        
        if (b == 0) {
            throw new ArgumentException("Kan inte vara 0.", nameof(b));
        }
        return a / b;
    }

}