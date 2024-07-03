public class array_double_1d
{
    private double[] numbers;

    public void setNumbers(double[] arr)
    {
        this.numbers = arr;
    }

    public double FindMin()
    {
        double min = this.numbers[0];

        for (int i = 1; i < this.numbers.Length; i++)
        {
            if (this.numbers[i] < min)
            {
                min = this.numbers[i];
            }
        }

        return min;
    }

    public double FindMax()
    {
        double max = this.numbers[0];

        for (int i = 1; i < this.numbers.Length; i++)
        {
            if (this.numbers[i] > max)
            {
                max = this.numbers[i];
            }
        }

        return max;
    }
}