class Time {
    private int h, m, s;

    public Time(int h, int m, int s) { this.h = h; this.m = m; this.s = s; }
    public Time(int m, int s) : this(0, m, s) { }
    public Time(int s) : this(0, 0, s) { }
    public Time() : this(0, 0, 0) { }

    public override string ToString()
    {
        String ret = $"{s}초";
        if (m != 0) { ret = String.Format("{0}분 {1}", m, ret); }
        if (h != 0) { ret = String.Format("{0}시 {1}", h, ret); }
        return ret;
    }
}
static void Main(string[] argv)
{
    Time[] T = new Time[3];
    T[0] = new Time(6, 24, 5);
    T[1] = new Time(12, 30);
    T[2] = new Time(35);
    foreach(Time E in T) { Console.WriteLine(E.ToString()); }
}