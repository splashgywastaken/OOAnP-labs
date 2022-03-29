namespace Lab3.Main.Interface
{
    internal interface ICommand
    {
        string Execute();
        string Undo();
    }
}
