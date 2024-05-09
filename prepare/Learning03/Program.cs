public class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {
        this.top = 1;
        this.bottom = 1;
    }

    public Fraction(int top)
    {
        this.top = top;
        this.bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }

    public int GetTop()
    {
        return this.top;
    }

    public void SetTop(int top)
    {
        this.top = top;
    }

    public int GetBottom()
    {
        return this.bottom;