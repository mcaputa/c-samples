namespace FabricMethodPattern
{
    public class MiniCooper : IAuto
    {
        public MiniCooper(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void TurnOn()
        {
            throw new System.NotImplementedException();
        }

        public void TurnOff()
        {
            throw new System.NotImplementedException();
        }
    }
}