namespace PracticeOpenClosedPrinciple.Sample3.BeforeOCP
{
    public enum MonitorType
    {
        OLED,
        LCD,
        LED
    }
    
    public enum Screen
    {
        WideScreen,
        CurvedScreen
    }

    public class ComputerMonitor
    {
        public string Name { get; set; }
        public MonitorType Type { get; set; }
        public Screen Screen { get; set; }
    }
}
