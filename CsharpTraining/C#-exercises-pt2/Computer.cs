namespace CsharpTraining;

class Computer
{
    String gpu;
    String cpu;
    int ram;
    String system;
    String monitor;
    public static int computersCount;

    public Computer(String gpu, String cpu, int ram, String system, String monitor)
    {
        this.gpu = gpu;
        this.cpu = cpu;
        this.ram = ram;
        this.system = system;
        this.monitor = monitor;
        computersCount++;
    }

    public Computer(String gpu, String cpu, int ram, String system)
    {
        this.gpu = gpu;
        this.cpu = cpu;
        this.ram = ram;
        this.system = system;
        computersCount++;
    }
}