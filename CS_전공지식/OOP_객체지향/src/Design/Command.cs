namespace DesignPattern
{
    //Base class for the commands
    //This class should always look like this to make it more general, so no constructors, parameters, etc!!!
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }

    
}