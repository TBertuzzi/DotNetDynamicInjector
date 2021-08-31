namespace DotNet.DynamicInjector.Models
{
    public class IoCRole
    {
        public string Name { get; set; }
        public string Dll { get; set; }
        public string Implementation { get; set; }
        public LifeTime LifeTime { get; set; }
        public int Priority { get; set; }
        public bool Active { get; set; }

        public IoCRole() =>
            Active = true;

        public IoCRole(string name, string dll, string implementation, LifeTime lifeTime, int priority) : this()
        {
            Name = name;
            Dll = dll;
            Implementation = implementation;
            LifeTime = lifeTime;
            Priority = priority;
        }
    }
}
