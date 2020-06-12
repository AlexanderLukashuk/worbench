namespace workbench
{
    public class Tool
    {
        public string Type { get; set; }
        public string ToolName { get; set; }

        public static Tool operator +(Tool tool, MaterialOfTool material)
        {
            return new Tool
            {
                ToolName = $"{material.Material} {tool.Type}"
            };
        }
    }
}