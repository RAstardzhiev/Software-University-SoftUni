namespace _15.Drawing_tool
{
    using System.Text;

    public class CorDraw
    {
        private double width;
        private double height;

        public CorDraw(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public string Draw()
        {
            var sb = new StringBuilder();
            sb.Append('|');
            sb.Append(new string('-', (int)this.width));
            sb.AppendLine("|");

            for (int i = (int)this.height - 2; i > 0; i--)
            {
                sb.Append('|');
                sb.Append(new string(' ', (int)this.width));
                sb.AppendLine("|");
            }

            sb.Append('|');
            sb.Append(new string('-', (int)this.width));
            sb.AppendLine("|");

            return sb.ToString();
        }
    }
}
