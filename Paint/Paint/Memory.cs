namespace Paint
{
    public class Memory
    {
        public List<Action> actions = new List<Action>();

        public void AddAction(int id)
            => actions.Add(new UndoDraw(id));
        public void AddAction(Color color)
            => actions.Add(new UndoColor(color));

        public void Undo()
        {
            if (actions.Count == 0) return;

            for (int i = Form1.GetLayer().layer.Count; i > actions.Last().index; i--)
            {
                if (actions.Last() is UndoDraw)
                    Form1.layer[Form1.current.start].layer.RemoveAt(i-1);
                else if (actions.Last() is UndoColor)
                    Form1.pen.Color = actions.Last().color;
            }
            actions.Remove(actions.Last());
        }
    }

    public class UndoDraw : Action
    {
        public UndoDraw(int index)
        {
            this.index = index;
        }
    }

    public class UndoColor : Action
    {
        public UndoColor(Color color)
        {
            this.color = color;
        }
    }

    public class Action
    {
        public int index;
        public Color color;
    }
}